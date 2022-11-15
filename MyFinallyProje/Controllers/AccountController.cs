using Business.ViewModels;
using DAL.Identity;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using System.IO;
using System.Threading.Tasks;
using static Utilities.Helpers.Enums;

namespace MyFinallyProje.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;

        public AccountController(
            UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<AppUser> signInManager,
            IWebHostEnvironment env
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _env = env;
        }

        #region Register
        [HttpGet(nameof(Register))]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost(nameof(Register))]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (User.Identity.IsAuthenticated)
            {
                return Json("Ok");
            }

            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            AppUser appUser = new AppUser();

            appUser.Firstname = registerVM.Firstname;
            appUser.Lastname = registerVM.Firstname;
            appUser.Email = registerVM.Email;
            appUser.UserName = registerVM.Username;

            var result = await _userManager.CreateAsync(appUser, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }


            var roleResult = await _userManager.AddToRoleAsync(appUser, Rollar.Admin.ToString());

            if (!roleResult.Succeeded)
            {
                foreach (var item in roleResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }


            var message = new MimeMessage();


            message.From.Add(new MailboxAddress("Event Menegment System", "ayselabilovaa12@gmail.com"));

            message.To.Add(new MailboxAddress(appUser.FullName, appUser.Email));
            message.Subject = "Confirm Email";

            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader(Path.Combine(_env.WebRootPath, "Templates", "Confirm.html")))
            {
                emailbody = streamReader.ReadToEnd();
            }

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
            var link = Url.Action(nameof(VerifyEmail), "Account", new { userId = appUser.Id, token = code }, Request.Scheme, Request.Host.ToString());

            emailbody = emailbody.Replace("{{fullname}}", $"{appUser.FullName}").Replace("{{code}}", $"{link}");

            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();


            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("ayselabilovaa12@gmail.com", "zzrwnzlbuzqglzmn\r\n");
            smtp.Send(message);

            smtp.Disconnect(true);

            return RedirectToAction("Index", controllerName: "Home");
        }

        #endregion

        #region Logout
        public async Task<ActionResult> Logout()
        {
            //zzrwnzlbuzqglzmn

            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
            }

            return RedirectToAction("Index", controllerName: "Home");
        }

        #endregion

        #region Login
        [HttpGet(nameof(Login))]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost(nameof(Login))]
        public async Task<IActionResult> Login(LoginVM loginVm)
        {
            if (User.Identity.IsAuthenticated)
            {
                return Json("Ok");
            }

            if (!ModelState.IsValid)
            {
                return View(loginVm);
            }

            AppUser appUser = await _userManager.FindByNameAsync(loginVm.Username);

            if (appUser is null)
            {
                ModelState.AddModelError("", "Username not found!");
                return View(loginVm);
            }

            var result = await _signInManager.PasswordSignInAsync(appUser, loginVm.Password, loginVm.RememberMe, true);

            if (result.IsNotAllowed)
            {
                ModelState.AddModelError("", "Please confirm your account!");
                return View(loginVm);
            }

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Your profile has been locked!\nPlease try later!");
                return View(loginVm);
            }

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username not found!");
                return View(loginVm);
            }

            if (await _userManager.IsInRoleAsync(appUser, Rollar.SuperAdmin.ToString()))
            {
                return RedirectToAction("Index", controllerName: "Dashboard", new { area = "Admin" });
            }


            return RedirectToAction("Index", controllerName: "Home");
        }
        #endregion

        #region Create Roll

        //public async Task<IActionResult> CreateRole()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
        //    return Ok();
        //
        //}
        #endregion

        #region Email Confirm
        public async Task<IActionResult> VerifyEmail(string userId, string token)
        {
            if (userId == null || token == null) return BadRequest();

            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user is null) return BadRequest();


            await _userManager.ConfirmEmailAsync(user, token);

            await _signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Forgot Password
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM forgotPasswordVM)
        {
            if (!ModelState.IsValid) return View(forgotPasswordVM);

            var user = await _userManager.FindByEmailAsync(forgotPasswordVM.Email);

            if (user is null)
            {
                ModelState.AddModelError("", "This email hasn't been registrated");
                return View(forgotPasswordVM);
            }

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Event Menegment System", "ayselabilovaa12@gmail.com"));

            message.To.Add(new MailboxAddress(user.FullName, user.Email));
            message.Subject = "Reset Password";

            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader(Path.Combine(_env.WebRootPath, "Templates", "Reset.html")))
            {
                emailbody = streamReader.ReadToEnd();
            }

            string forgotpasswordtoken = await _userManager.GeneratePasswordResetTokenAsync(user);
            string url = Url.Action(nameof(ResetPassword), "Account", new { email = user.Email, Id = user.Id, token = forgotpasswordtoken, }, Request.Scheme);

            emailbody = emailbody.Replace("{{fullname}}", $"{user.FullName}").Replace("{{code}}", $"{url}");

            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();

            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("ayselabilovaa12@gmail.com", "zzrwnzlbuzqglzmn\r\n");
            smtp.Send(message);
            smtp.Disconnect(true);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Reset Password
        [HttpGet]
        public IActionResult ResetPassword(string email, string token)
        {
            var resetPasswordModel = new ResetPasswordVM { Email = email, Token = token };
            return View(resetPasswordModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        {
            if (!ModelState.IsValid) return View(resetPasswordVM);

            var user = await _userManager.FindByEmailAsync(resetPasswordVM.Email);

            if (user is null) return NotFound();

            IdentityResult result = await _userManager.ResetPasswordAsync(user, resetPasswordVM.Token, resetPasswordVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(resetPasswordVM);

            }


            return RedirectToAction(nameof(Login));

        }
        #endregion
    }
}
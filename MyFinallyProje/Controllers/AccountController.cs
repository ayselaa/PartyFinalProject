using Business.ViewModels;
using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using static Utilities.Helpers.Enums;

namespace MyFinallyProje.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager <AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;


        public AccountController(
            UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager; 
        }


        [HttpGet (nameof(Register))]
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
            return RedirectToAction("Index", controllerName: "Home");
            return Json(registerVM);
            return View();

            
        }


        public async Task<ActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
            }

            return RedirectToAction("Index", controllerName: "Home");
        }


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
            return Json(loginVm);
            return View();
        }



        //public async Task<IActionResult> CreateRole()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });


        //    return Ok();

        //}







    }
}

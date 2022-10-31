using Business.ViewModels;
using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LayoutService(IHttpContextAccessor httpContextAccessor,
                             AppDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }


        public List<BasketVM> GetBasket()
        {
            string basket = _httpContextAccessor.HttpContext.Request.Cookies["basket"];
            List<BasketVM> basketVMs = new List<BasketVM>();
            if (basket != null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                if (basketVMs.Count >0)
                {
                    foreach (BasketVM basketVM in basketVMs)
                    {
                        basketVM.Title = _context.Products.FirstOrDefault(p => p.Id == basketVM.Id).Title;
                        basketVM.ProductImage = _context.ProductImages.Include(p => p.Image).FirstOrDefault(x => x.ProductId == basketVM.Id);
                        basketVM.Price = _context.Products.FirstOrDefault(p => p.Id == basketVM.Id).Price;

                    }
                }

                
            }

            return basketVMs;
        }
    }
}
using DAL.Identity;
using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet <HomeBox> HomeBoxs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceDetail> ServiceDetails { get; set; }
        public DbSet<Image> Images{ get; set; }
        public DbSet<ServiceImage> ServiceImages { get; set; }
        public DbSet<BlogImage> BlogImages{ get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail>  ProductDetails { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamDetail> TeamDetails { get; set; }
        public DbSet<TeamImage> TeamImages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public  DbSet<Reservation> Reservations { get; set; }
    }
}

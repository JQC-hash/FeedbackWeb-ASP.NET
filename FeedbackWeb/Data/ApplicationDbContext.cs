using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FeedbackWeb.Models;

namespace FeedbackWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<DemoIdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FeedbackWeb.Models.Feedback> Feedback { get; set; }
    }
}

using Content_Managment_System.Infrastructure.Context;
using Content_Managment_System.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Content_Managment_System.Infrastructure.Seeding
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =new ProjectContext(serviceProvider.GetRequiredService<DbContextOptions<ProjectContext>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }
                context.Pages.AddRange(
                    new Page
                    {
                        Title = "Home",
                        Slug="home",
                        Content="home Page",
                        Sorting=0,
                    },
                    new Page
                    {
                        Title = "About Us",
                        Slug = "about-us",
                        Content = "about us page",
                        Sorting = 100,
                    },
                    new Page
                    {
                        Title = "Services",
                        Slug = "services",
                        Content = "services page",
                        Sorting = 100,
                    },
                    new Page
                    {
                        Title = "Contact",
                        Slug = "contact",
                        Content = "contact page",
                        Sorting = 100,
                    }
                    );
                context.SaveChanges();
            }

        }
    }
}

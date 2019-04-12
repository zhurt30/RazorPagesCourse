using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace RazorPagesCourse.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesCourseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesCourseContext>>()))
            {
                // Look for any Courses.
                if (context.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Course.AddRange(
                    new Course
                    {
                        Number = "1-W-3",
                        Title = "PHP",
                        Date = DateTime.Parse("2019-2-12"),
                        Semester = "2019-W",
                        Description = "nan",
                        Credits = 3.2m

                    },

                    new Course
                    {
                        Number = "1-W-4",
                        Title = "jsp",
                        Date = DateTime.Parse("2019-2-12"),
                        Semester = "2019-W",
                        Description = "nan",
                        Credits = 2.2m
                    },
                    new Course
                    {
                        Number = "1-W-4",
                        Title = "web design",
                        Date = DateTime.Parse("2019-2-12"),
                        Semester = "2019-W",
                        Description = "nan",
                        Credits = 2.2m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
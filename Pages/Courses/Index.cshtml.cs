using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCourse.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesCourse.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCourse.Models.RazorPagesCourseContext _context;

        public IndexModel(RazorPagesCourse.Models.RazorPagesCourseContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Semester { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CourseSemester { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Course
                                            orderby m.Semester
                                            select m.Semester;

            var courses = from m in _context.Course
                          select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                courses = courses.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CourseSemester))
            {
                courses = courses.Where(x => x.Semester == CourseSemester);
            }
            Semester = new SelectList(await genreQuery.Distinct().ToListAsync());
            Course = await courses.ToListAsync();
        }
    }
}

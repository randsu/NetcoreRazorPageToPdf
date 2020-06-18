using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace NetcoreRazorPageToPdf.Web.Pages
{
    public class PdfModel : PageModel
    {
        public IEnumerable<(string name, string address)> Persons { get; set; }

        public IActionResult OnGet()
        {
            Persons = new List<(string name, string address)>()
            {
                ("Richard", "Gata 1"),
                ("Kenny", "Tomten 5"),
                ("Sølve", "Orreplassen 12"),
                ("Brynje", "Campen 76"),
                ("Pandy", "Bakken 2a"),
            }.AsEnumerable();

            return new RazorPageAsPdf(this);       // we don't need page path because it can be determined by current route
        }
    }
}
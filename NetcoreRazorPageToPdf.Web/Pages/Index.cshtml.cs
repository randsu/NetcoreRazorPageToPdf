using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NetcoreRazorPageToPdf.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<(string name, string address)> Persons { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Persons = new List<(string name, string address)>()
            {
                ("Richard", "Gata 1"),
                ("Kenny", "Tomten 5"),
                ("Sølve", "Orreplassen 12"),
                ("Brynje", "Campen 76"),
                ("Pandy", "Bakken 2a"),
            }.AsEnumerable();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicatieBasketbal.Models.DBModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ApplicatieBasketbal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public List<Speler> spelers { get; set; }
        public void OnGet()
        {
            Speler speler = new Speler();
            spelers = speler.GetSpelers();
        }
    }
}
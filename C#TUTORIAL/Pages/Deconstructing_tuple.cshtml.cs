using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Deconstructing_tuple : PageModel
    {
        private readonly ILogger<Deconstructing_tuple> _logger;

        public Deconstructing_tuple(ILogger<Deconstructing_tuple> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

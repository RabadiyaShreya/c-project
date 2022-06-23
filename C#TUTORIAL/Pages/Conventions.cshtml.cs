using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Conventions : PageModel
    {
        private readonly ILogger<Conventions> _logger;

        public Conventions(ILogger<Conventions> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Handling : PageModel
    {
        private readonly ILogger<Handling> _logger;

        public Handling(ILogger<Handling> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

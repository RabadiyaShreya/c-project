using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Error_Overview : PageModel
    {
        private readonly ILogger<Error_Overview> _logger;

        public Error_Overview(ILogger<Error_Overview> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

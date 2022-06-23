using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class type_overview : PageModel
    {
        private readonly ILogger<type_overview> _logger;

        public type_overview(ILogger<type_overview> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

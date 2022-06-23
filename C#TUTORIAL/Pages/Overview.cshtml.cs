using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Overview : PageModel
    {
        private readonly ILogger<Overview> _logger;

        public Overview(ILogger<Overview> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

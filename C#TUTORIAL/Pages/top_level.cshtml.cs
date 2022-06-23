using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class top_level : PageModel
    {
        private readonly ILogger<top_level> _logger;

        public top_level(ILogger<top_level> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

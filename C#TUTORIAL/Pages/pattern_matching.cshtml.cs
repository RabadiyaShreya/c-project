using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class pattern_matching : PageModel
    {
        private readonly ILogger<pattern_matching> _logger;

        public pattern_matching(ILogger<pattern_matching> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

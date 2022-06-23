using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Records_learn : PageModel
    {
        private readonly ILogger<Records_learn> _logger;

        public Records_learn(ILogger<Records_learn> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

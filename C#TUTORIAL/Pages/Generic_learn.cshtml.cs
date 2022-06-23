using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Generic_learn : PageModel
    {
        private readonly ILogger<Generic_learn> _logger;

        public Generic_learn(ILogger<Generic_learn> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

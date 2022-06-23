using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Interface_learn : PageModel
    {
        private readonly ILogger<Interface_learn> _logger;

        public Interface_learn(ILogger<Interface_learn> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class login : PageModel
    {
        private readonly ILogger<login> _logger;

        public login(ILogger<login> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

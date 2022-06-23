using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Main_method : PageModel
    {
        private readonly ILogger<Main_method> _logger;

        public Main_method(ILogger<Main_method> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

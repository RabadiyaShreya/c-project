using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Exception : PageModel
    {
        private readonly ILogger<Exception> _logger;

        public Exception(ILogger<Exception> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

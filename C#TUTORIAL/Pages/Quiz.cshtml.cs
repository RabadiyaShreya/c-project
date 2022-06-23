using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Quiz : PageModel
    {
        private readonly ILogger<Quiz> _logger;

        public Quiz(ILogger<Quiz> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Identifier : PageModel
    {
        private readonly ILogger<Identifier> _logger;

        public Identifier(ILogger<Identifier> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class type_namespace : PageModel
    {
        private readonly ILogger<type_namespace> _logger;

        public type_namespace(ILogger<type_namespace> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

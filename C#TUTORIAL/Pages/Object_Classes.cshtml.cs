using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class Object_Classes : PageModel
    {
        private readonly ILogger<Object_Classes> _logger;

        public Object_Classes(ILogger<Object_Classes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

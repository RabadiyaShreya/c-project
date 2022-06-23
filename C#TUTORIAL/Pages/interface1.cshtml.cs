using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C_TUTORIAL.Pages
{
    public class interface1 : PageModel
    {
        private readonly ILogger<interface1> _logger;

        public interface1(ILogger<interface1> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

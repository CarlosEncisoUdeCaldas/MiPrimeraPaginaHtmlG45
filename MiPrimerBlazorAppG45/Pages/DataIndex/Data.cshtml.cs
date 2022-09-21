using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiPrimerBlazorAppG45.Pages
{
    public class DataModel : PageModel
    {
        private readonly ILogger<DataModel> _logger;

        public DataModel(ILogger<DataModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

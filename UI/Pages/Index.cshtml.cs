using Advice_API_Library.Models;
using Advice_API_Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IApiProcessor apiProcessor;
        public Advice AdviceModel { get; set; }

        public IndexModel(IApiProcessor _apiProcessor) => apiProcessor = _apiProcessor;

        public async Task OnGetAsync() => await GetAdvice();

        public async Task OnPostAsync() => await GetAdvice();

        public async Task GetAdvice()
        {
            AdviceModel = await apiProcessor.LoadAdvice();
        }
    }
}
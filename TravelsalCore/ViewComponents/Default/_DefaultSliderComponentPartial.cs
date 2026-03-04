using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponents.Default
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}

using ElonIsVeryRich.Data;
using ElonIsVeryRich.Logic;
using ElonIsVeryRich.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Html;

namespace ElonIsVeryRich.UI.Pages
{
    public class IndexModel : PageModel
    {
        private AppManager appManager  = new();
        public int TotalCost { get; set; }
        public HtmlString TotalCostElement { get; set; }
        public List<LaunchModel> Launches { get; set; }

        public async Task OnGet()
        {
            Launches = await appManager.GetAllLaunches();
        }

        public async Task OnGetCalculate()
        {
            await OnGet();

            TotalCost = await appManager.CalculateTotalPrice();

            TotalCostElement = new HtmlString($"<h3>Total Cost: {TotalCost}</h3>");
        }
    }
}
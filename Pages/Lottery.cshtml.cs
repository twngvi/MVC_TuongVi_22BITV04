using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MVC_Week1.Pages
{
    public class LotteryModel : PageModel
    {
        public List<int> LotteryNumbers { get; set; } = new List<int>();

        public void OnGet()
        {
            var rnd = new Random();
            LotteryNumbers = Enumerable.Range(1, 46)
                .OrderBy(x => rnd.Next())
                .Take(6)
                .OrderBy(x => x)
                .ToList();
        }
    }
}
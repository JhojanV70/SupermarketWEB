using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using Microsoft.AspNetCore.Authorization;

namespace SupermarketWEB.Pages.Details
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;
        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }
        public IList<Detail> Details { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Details != null)
            {
                Details = await _context.Details.ToListAsync();
            }
        }
    }
}

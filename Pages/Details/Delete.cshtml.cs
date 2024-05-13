using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Details
{
    public class DeleteModel : PageModel
    {
        private readonly SupermarketContext _context;

        public DeleteModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Detail Detail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Details == null)
            {
                return NotFound();
            }

            var Detail = await _context.Details.FirstOrDefaultAsync(m => m.Id == id);

            if (Detail == null)
            {
                return NotFound();
            }
            else
            {
                Detail = Detail;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Details == null)
            {
                return NotFound();
            }
            var Detail = await _context.Details.FindAsync(id);

            if (Detail != null)
            {
                Detail = Detail;
                _context.Details.Remove(Detail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

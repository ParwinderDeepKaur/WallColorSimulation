using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SetColorLibrary.Data;
using SetColorLibrary.Interface;
using SetColorLibrary.Models;

namespace ColorSet.Pages.Admin.wallColor
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly IWallColor _color;

        public DeleteModel(IWallColor color)
        {
            _color = color;
        }

        [BindProperty]
        public SetColorLibrary.Models.wallColor wallColor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            wallColor = await _color.GetWallColorById(id.Value);

            if (wallColor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            wallColor = await _color.GetWallColorById(id.Value);

            if (wallColor != null)
            {
                
                await _color.DeleteAsysn(wallColor);
            }

            return RedirectToPage("./Index");
        }
    }
}

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

namespace ColorSet.Pages.Admin.floorColor
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly IFloorColor _color;

        public DeleteModel(IFloorColor color)
        {
            _color = color;
        }

        [BindProperty]
        public SetColorLibrary.Models.floorColor floorColor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            floorColor = await _color.GetFloorColorById(id.Value);

            if (floorColor == null)
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

            floorColor = await _color.GetFloorColorById(id.Value);

            if (floorColor != null)
            {
                
                await _color.DeleteAsysn(floorColor);
            }

            return RedirectToPage("./Index");
        }
    }
}

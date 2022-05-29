using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SetColorLibrary.Data;
using SetColorLibrary.Interface;
using SetColorLibrary.Models;

namespace ColorSet.Pages.Admin.floorColor
{
    public class EditModel : PageModel
    {
        private readonly IFloorColor _color;

        public EditModel(IFloorColor color)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

          

            try
            {
                await _color.UpdateAsync(floorColor);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_color.floorColorExists(floorColor.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

    }
}

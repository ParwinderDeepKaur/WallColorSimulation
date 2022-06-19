using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SetColorLibrary.Data;
using SetColorLibrary.Interface;
using SetColorLibrary.Models;

namespace ColorSet.Pages.Admin.floorColor
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly IFloorColor _color;

        public CreateModel(IFloorColor color)
        {
            _color = color;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SetColorLibrary.Models.floorColor floorColor { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            await _color.CreateAsync(floorColor);

            return RedirectToPage("./Index");
        }
    }
}

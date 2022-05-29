using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SetColorLibrary.Data;
using SetColorLibrary.Interface;
using SetColorLibrary.Models;

namespace ColorSet.Pages.Admin.wallColor
{
    public class DetailsModel : PageModel
    {
        private readonly IWallColor _color;

        public DetailsModel(IWallColor color)
        {
            _color = color;
        }

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
    }
}

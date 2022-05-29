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
    public class IndexModel : PageModel
    {
        private readonly IWallColor _color;

        public IndexModel(IWallColor color)
        {
            _color = color;
        }

        public IList<SetColorLibrary.Models.wallColor> wallColor { get;set; }

        public async Task OnGetAsync()
        {
            wallColor = await _color.GetWallColorList();
        }
    }
}

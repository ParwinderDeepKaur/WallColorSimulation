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
    public class IndexModel : PageModel
    {
        private readonly IFloorColor _color;

        public IndexModel(IFloorColor color)
        {
            _color = color;
        }

        public IList<SetColorLibrary.Models.floorColor> floorColor { get;set; }

        public async Task OnGetAsync()
        {
            floorColor = await _color.GetFloorColorList();
        }
    }
}

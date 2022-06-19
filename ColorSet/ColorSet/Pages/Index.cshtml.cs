using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SetColorLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSet.Pages
{
    public class IndexModel : PageModel
    {
       
        private readonly IWallColor _color;
        private readonly IFloorColor _floorColor;

        public IndexModel(IWallColor color, IFloorColor floorColor)
        {
            _color = color;
            _floorColor = floorColor;
        }

       
        public async void OnGet()
        {

            ViewData["wallColor"] = _color.GetWallColorList();
            ViewData["floorColor"] = _floorColor.GetFloorColorList();
            

        }

        
    }
}

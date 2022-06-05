using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using SetColorLibrary.Data;
using SetColorLibrary.Models;
using SetColorLibrary.Interface;

namespace SetColorLibrary.Service
{
    public class wallColorService: IWallColor
    {
        private readonly ApplicationDbContext _context;

        public wallColorService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// get wall color list
        /// </summary>
        /// <returns></returns>
        public async Task<IList<wallColor>> GetWallColorList()
        {

           var color = await _context.WallColors.ToListAsync();

            return color;
        }


        public SelectList GetWallDDL()
        {

            var list = new SelectList(_context.WallColors, "Id", "Color");

            return list;
        }



        /// <summary>
        /// get wall color by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<wallColor> GetWallColorById(int id)
        {
            return await _context.WallColors.FirstOrDefaultAsync(m => m.Id == id);
   
        }

      


        /// <summary>
        /// create wall color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public async Task<bool> CreateAsync(wallColor color)
        {
            _context.WallColors.Add(color);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(wallColor color)
        {
            _context.Attach(color).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// delete record
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public async Task<bool>  DeleteAsysn(wallColor color)
        {
            _context.WallColors.Remove(color);
            await _context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// record exist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool wallColorExists(int id)
        {
            return _context.WallColors.Any(e => e.Id == id);
        }

    }
}

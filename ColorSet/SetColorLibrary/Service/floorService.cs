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
    public class floorService: IFloorColor
    {
        private readonly ApplicationDbContext _context;

        public floorService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// get floor color list
        /// </summary>
        /// <returns></returns>
        public async Task<IList<floorColor>> GetFloorColorList()
        {

           var color = await _context.floorColors.ToListAsync();

            return color;
        }

       

        /// <summary>
        /// get floor color by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<floorColor> GetFloorColorById(int id)
        {
            return await _context.floorColors.FirstOrDefaultAsync(m => m.Id == id);
   
        }

      


        /// <summary>
        /// create floor color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public async Task<bool> CreateAsync(floorColor color)
        {
            _context.floorColors.Add(color);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(floorColor color)
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
        public async Task<bool>  DeleteAsysn(floorColor color)
        {
            _context.floorColors.Remove(color);
            await _context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// record exist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool floorColorExists(int id)
        {
            return _context.floorColors.Any(e => e.Id == id);
        }

    }
}

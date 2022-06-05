using Microsoft.AspNetCore.Mvc.Rendering;
using SetColorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetColorLibrary.Interface
{
   public interface IFloorColor
    {
        /// <summary>
        /// get floor color list
        /// </summary>
        /// <returns></returns>
         Task<IList<floorColor>> GetFloorColorList();




        /// <summary>
        /// get record by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         Task<floorColor> GetFloorColorById(int id);

        /// <summary>
        /// ddl list
        /// </summary>
        /// <returns></returns>
        SelectList GetFloorDDL();

        /// <summary>
        /// create record
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        Task<bool> CreateAsync(floorColor color);

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(floorColor color);

        /// <summary>
        /// delete record
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        Task<bool> DeleteAsysn(floorColor color);

        /// <summary>
        /// record exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool floorColorExists(int id);



    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using SetColorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetColorLibrary.Interface
{
   public interface IWallColor
    {
        /// <summary>
        /// get wall color list
        /// </summary>
        /// <returns></returns>
         Task<IList<wallColor>> GetWallColorList();

        /// <summary>
        /// ddl list
        /// </summary>
        /// <returns></returns>
        SelectList GetWallDDL();


        /// <summary>
        /// get record by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         Task<wallColor> GetWallColorById(int id);

        /// <summary>
        /// create record
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        Task<bool> CreateAsync(wallColor color);

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(wallColor color);

        /// <summary>
        /// delete record
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        Task<bool> DeleteAsysn(wallColor color);

        /// <summary>
        /// record exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool wallColorExists(int id);



    }
}

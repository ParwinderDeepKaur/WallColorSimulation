using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetColorLibrary.Models
{
   public class wallColor
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        [Required]
        [Display(Name = "Color")]
        public string Color { get; set; }


    }
}

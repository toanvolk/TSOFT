using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity.Models
{
    public class User : BaseModel
    {
        [Key]
        [StringLength(50)]
        public  string UserID { get; set; }
        [StringLength(250)]
        public  string UserName { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

    }
}

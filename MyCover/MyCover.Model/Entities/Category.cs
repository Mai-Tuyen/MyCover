using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCover.Model.Entities
{
    public class Category
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}

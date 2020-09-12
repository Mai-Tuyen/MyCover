using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCover.Model.Entities
{
    public class Role
    {
        public int ID { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

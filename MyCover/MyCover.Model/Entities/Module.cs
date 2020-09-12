using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCover.Model.Entities
{
    public class Module
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string ControllerName { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string ActionName { get; set; }
    }
}

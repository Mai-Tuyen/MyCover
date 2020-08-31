using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCover.Model.Entities
{
    public class User
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        [StringLength(50)]
        public string DisplayName { get; set; }

        public string AvartarLink { get; set; }
        
        [StringLength(30)]
        public string Role { get; set; }
        
        public bool Status { get; set; }
    }
}

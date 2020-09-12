using System;
using System.Collections.Generic;
using System.Text;

namespace MyCover.Model.Entities
{
    public class UserToken
    {
        public int ID { get; set; }
        public string AccountToken { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}

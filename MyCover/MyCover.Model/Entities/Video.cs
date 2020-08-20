using System;
using System.Collections.Generic;
using System.Text;

namespace MyCover.Model.Entities
{
    public class Video
    {
        public int ID { get; set; }

        public string VideoName { get; set; }

        public int CreateBy { get; set; }

        public DateTime CreateAt { get; set; }

        public bool Status { get; set; }

        public string LinkVideo { get; set; }

        public string Description { get; set; }

        public int CategoryID { get; set; }

        public bool IsDelete { get; set; }

        public string SlugUrl { get; set; }

        public string SeoDescription { get; set; }

        public string SeoKeyword { get; set; }

        public string SeoTitle { get; set; }

        public int ViewCount { get; set; }

        public string Tag { get; set; }
    }
}

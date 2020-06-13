using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace intellore_system_test.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public int? PostId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string content { get; set; }
        public string Status { get; set; }
        public DateTime Add_time { get; set; }
        public DateTime Modify_time { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Todo
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime DeadLine { get; set; }
        public String Memo { get; set; }
    }
}

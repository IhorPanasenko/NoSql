using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime WhenWasWrote { get; set; }

        public string Author { get; set; }

    }
}

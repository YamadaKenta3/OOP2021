using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models
{
    //エンティティクラス
    public class Author
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public String Gender { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}


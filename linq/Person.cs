using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
        public List<Tech> Programing { get; set; }
    }
    public class Tech
    {
        public string Tecnology { get; set; } 
    }
}


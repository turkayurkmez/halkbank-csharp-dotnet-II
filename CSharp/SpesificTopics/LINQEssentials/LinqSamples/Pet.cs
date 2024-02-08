using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSamples
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Human
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int PetId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class GenericPoint<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }

        public void Reset()
        {
            X = default(T);
            Y = default(T);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicKeyword
{
    public class DynamicClass
    {
        public dynamic Property { get; set; }

        public dynamic GetSomething(dynamic someParameter)
        {
            dynamic output = new Random();

            return output;
        }


    }
}

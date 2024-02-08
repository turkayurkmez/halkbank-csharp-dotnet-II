using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDynamic
{
    public interface IFormBagContainer
    {
        dynamic FormBag { get; set; }
    }
}

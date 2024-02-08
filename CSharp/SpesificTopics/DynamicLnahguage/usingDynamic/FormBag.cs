using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDynamic
{
    public class FormBag : DynamicObject
    {
        private Dictionary<string, object> properties = new Dictionary<string, object>();
        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            return properties.TryAdd(binder.Name, value);
        }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            return properties.TryGetValue(binder.Name, out result);

        }


    }


}

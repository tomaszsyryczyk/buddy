using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buddy.Infra
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Inject : System.Attribute
    {
        
    }
}

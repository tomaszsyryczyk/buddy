using System;

namespace Buddy.Infra
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Inject : System.Attribute
    {
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildGame.Object
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
    public class PropertyObjectAttribute : Attribute
    { }
}

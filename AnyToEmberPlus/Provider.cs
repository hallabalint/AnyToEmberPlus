using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmberPlusProviderClassLib.EmberHelpers;

namespace AnyToEmberPlus
{
    internal abstract class Provider
    {
        protected EmberNode Node;
        protected string identifier;
        Provider(EmberNode node)
        {
            Node = node;
        }

        string ToString() { return identifier; }
    }
}

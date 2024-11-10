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
        protected Dictionary<string, Object> properties;
        Provider(EmberNode node)
        {
            Node = node;
        }

        abstract public string ToString();

        abstract public void Run();

        abstract public void Dispose();

        abstract public void Stop();

        public Dictionary<string, Object> getProperties()
        {
            return properties;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmberPlusProviderClassLib;
using EmberPlusProviderClassLib.EmberHelpers;

namespace AnyToEmberPlus
{
    public abstract class Provider
    {
        protected EmberNode Node;
        public bool state = false;
        protected string identifier;
        public string Identifier
        {
            get { return this.ToString(); }
        }
        public Dictionary<string, string> Properties { get; set; }
        public Provider(EmberNode node)
        {
            Node = node;
        }

        abstract public string ToString();

        abstract public void Run();

        abstract public void Dispose();

        abstract public void Stop();


    }
}

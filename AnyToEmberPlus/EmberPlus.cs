using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmberPlusProviderClassLib;
using EmberPlusProviderClassLib.EmberHelpers;
using EmberPlusProviderClassLib.Model;

namespace AnyToEmberPlus
{
    internal class EmberPlus
    {
        EmberPlusProvider _emberTree;
        int _nodeNumber;
        public EmberPlus(int port) {
            _emberTree = new EmberPlusProvider(
        9000,
        "AnyToEmber+",
        "AnyToEmber+");

            _emberTree.CreateIdentityNode(
                1,
                "Client1",
                "AnyToEmber",
                "hbj.hu",
                "v1.0.0");

            // General utility node
        }

        public EmberNode getNewEmberNode(string name) => _emberTree.AddChildNode(_nodeNumber++, name);

        
    }
}

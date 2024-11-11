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
    public class EmberPlus
    {
        public static EmberPlusProvider EmberTree;
        int _nodeNumber = 2;
        public EmberPlus(int port) {
            EmberTree = new EmberPlusProvider(
        9000,
        "AnyToEmber+",
        "AnyToEmber+");

            EmberTree.CreateIdentityNode(
                1,
                "Client1",
                "AnyToEmber",
                "hbj.hu",
                "v1.0.0");

            // General utility node
        }

        public EmberNode getNewEmberNode(string name) => EmberTree.AddChildNode(_nodeNumber++, name);

        public static void AddStringToNode(EmberNode node, int id, bool writeable, string name, string value)
        {
            node.AddStringParameter(id, name, EmberTree, writeable,value);
        }

        
    }
}

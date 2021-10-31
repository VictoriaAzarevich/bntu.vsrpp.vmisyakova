using System.Collections.Generic;
using System.Xml.Linq;

namespace bntu.vsrpp.vmisyakova.Core
{
    class XMLNode
    {
        public XElement Node { get; set; }
        public IEnumerable<XElement> ChildNodes { get; set; }

        public XMLNode(XElement node, IEnumerable<XElement> childNode)
        {
            Node = node;
            ChildNodes = childNode;
        }
    }
}

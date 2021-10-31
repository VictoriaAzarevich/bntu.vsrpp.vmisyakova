using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace bntu.vsrpp.vmisyakova.Core
{
    public class XMLReader
    {
        private readonly List<XMLNode> xmlNodes;

        public XMLReader()
        {
            xmlNodes = new List<XMLNode>();
        }

        public void ReadXML(string path)
        {
            xmlNodes.Clear();
            XDocument xmlDocument = XDocument.Load(path);

            foreach (XElement rootNode in xmlDocument.Elements())
            {
                foreach (XElement node in rootNode.Elements())
                {
                    xmlNodes.Add(new XMLNode(node, node.Elements()));
                }
            }
        }

        public int GetCountNode()
        {
            return xmlNodes.Count;
        }

        private List<string> GetChildNodeNames()
        {
            List<string> childNodeNames = new();

            foreach (XMLNode xmlNode in xmlNodes)
            {
                foreach (XElement childNode in xmlNode.ChildNodes)
                {
                    if (xmlNodes.All(x => x.ChildNodes.Any(x => x.Name.ToString().Equals(childNode.Name.ToString()))))
                    {
                        childNodeNames.Add(childNode.Name.ToString());
                    }
                }
            }

            return childNodeNames.Distinct().ToList();
        }

        public List<string> GetStringTypeChildNodes()
        {
            List<string> stringTypeChildNodes = new();

            foreach (string childNodeName in GetChildNodeNames())
            {
                foreach (XMLNode xmlNode in xmlNodes)
                {
                    if (!Int32.TryParse(xmlNode.ChildNodes.ToList().Find(x => x.Name == childNodeName).Value, out int temp))
                    {
                        stringTypeChildNodes.Add(childNodeName);
                    }
                }
            }

            return stringTypeChildNodes.Distinct().ToList();
        }

        public List<string> GetNumericTypeChildNodes()
        {
            List<string> numericTypeChildNodes = new();

            foreach (string childNodeName in GetChildNodeNames())
            {
                foreach (XMLNode xmlNode in xmlNodes)
                {
                    if (Int32.TryParse(xmlNode.ChildNodes.ToList().Find(x => x.Name == childNodeName).Value, out int temp))
                    {
                        numericTypeChildNodes.Add(childNodeName);
                    }
                }
            }

            return numericTypeChildNodes.Distinct().ToList();
        }

        private List<int> GetIntValues(string childNode)
        {
            List<int> values = new();

            foreach (XMLNode xmlNode in xmlNodes)
            {
                if (Int32.TryParse(xmlNode.ChildNodes.ToList().Find(x => x.Name == childNode).Value, out int temp))
                {
                    values.Add(temp);
                }
            }

            return values;
        }

        private List<string> GetStringValues(string childNode)
        {
            List<string> values = new();

            foreach (XMLNode xmlNode in xmlNodes)
            {
                if (!Int32.TryParse(xmlNode.ChildNodes.ToList().Find(x => x.Name == childNode).Value, out int temp))
                {
                    values.Add(xmlNode.ChildNodes.ToList().Find(x => x.Name == childNode).Value);
                }
            }

            return values;
        }

        public int GetMaxLength(string childNode)
        {
            return GetStringValues(childNode).OrderByDescending(s => s.Length).First().Length;
        }

        public int GetMinLength(string childNode)
        {
            return GetStringValues(childNode).OrderBy(s => s.Length).First().Length;
        }

        public double GetAverageLength(string childNode)
        {
            return GetStringValues(childNode).Average(x => x.Length);
        }

        public int GetMaxValue(string childNode)
        {
            return GetIntValues(childNode).Max();
        }

        public int GetMinValue(string childNode)
        {
            return GetIntValues(childNode).Min();
        }

        public double GetAverageValue(string childNode)
        {
            return GetIntValues(childNode).Average();
        }
    }
}

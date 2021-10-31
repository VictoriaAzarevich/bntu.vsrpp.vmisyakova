using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace bntu.vsrpp.vmisyakova.Core
{
    public class XMLEditor
    {
        public void CreateNewXMLDoc(string path)
        {
            XDocument xmlDocument = XDocument.Load(path);
            foreach (XElement rootNode in xmlDocument.Elements())
            {
                foreach (XElement node in rootNode.Elements())
                {
                    foreach (string nameChildNode in GetChildNodeNames(xmlDocument))
                    {
                        if (node.Elements().ToList().Find(x => x.Name.ToString().Equals(nameChildNode)) == null)
                        {
                            XElement childNode = Cheched(nameChildNode, path);
                            if (Int32.TryParse(childNode.Value, out int temp))
                            {
                                node.Add(new XElement(childNode.Name, 0));
                            }
                            else
                            {
                                node.Add(new XElement(childNode.Name, "N/A"));
                            }
                        }
                    }
                    if (node.Elements().ToList().Find(x => x.Name.ToString().Equals("FIO")) != null || node.Elements().ToList().Find(x => x.Name.ToString().Equals("FullName")) != null)
                    {
                        XElement xEl = node.Elements().ToList().Find(x => x.Name.ToString().Equals("FIO") || x.Name.ToString().Equals("FullName"));
                        var str = xEl.Value.ToString().Split(' ');
                        xEl.Remove();
                        node.Add(
                            new XElement("FirstName", str[0]),
                            new XElement("LastName", str[1]),
                            new XElement("Surname", str[2])
                            );
                    }
                }
            }
            xmlDocument.Save(path.Remove(path.Length - 4) + "_output.xml");
        }

        private XElement Cheched(string name, string path)
        {
            XDocument xmlDocument = XDocument.Load(path);
            foreach (XElement rootNode in xmlDocument.Elements())
            {
                foreach (XElement node in rootNode.Elements())
                {
                    XElement childNode = node.Elements().ToList().Find(x => x.Name.ToString().Equals(name));
                    if (childNode != null)
                    {
                        return childNode;
                    }
                }
            }
            return null;
        }

        private List<string> GetChildNodeNames(XDocument xDocument)
        {
            List<string> childNodeNames = new();

            foreach (XElement rootNode in xDocument.Elements())
            {
                foreach (XElement node in rootNode.Elements())
                {
                    foreach (XElement childNode in node.Elements())
                    {
                        if ((!childNodeNames.Contains(childNode.Name.ToString())) && !childNode.Name.ToString().Equals("FIO") && !childNode.Name.ToString().Equals("FullName") 
                            && !childNode.Name.ToString().Equals("LastName") && !childNode.Name.ToString().Equals("FirstName") && !childNode.Name.ToString().Equals("Surname"))
                        {
                            childNodeNames.Add(childNode.Name.ToString());
                        }
                    }
                }
            }

            return childNodeNames;
        }
    }
}

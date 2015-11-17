using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

/*
 * Author: John Marnon
 * CreationDate: 7/14/14
 * LastEditDate: 11/17/15
 * Notes:
 * This class is design for saving data stored in common classes for easy reloading
 * It was copied to the IGVC project on 1/27/15
 */

namespace IGVC_2016.DataIO
{
    public class SaveFile
    {
        string filename;
        byte state = 0;

        public SaveFile(string filename)
        {
            this.filename = filename + ".xml";
        }

        XmlDocument xml = null;

        public void BeginRead()
        {
            if(state == 0)
            {
                //try
                {
                    if (!System.IO.File.Exists(filename))
                    {
                        System.IO.File.Create(filename);
                    }
                    xml = new XmlDocument();
                    try
                    {
                        xml.Load(filename);
                    }catch(Exception)
                    {
                        StreamWriter sw = new StreamWriter(filename);
                        sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                        sw.WriteLine("<RootNode>");
                        sw.WriteLine("</RootNode>");
                        sw.Close();
                        xml.Load(filename);
                    }
                    state = 1;
                }
                //catch (Exception) { }
            }
            else
                throw new Exception("SaveFile is currently being used");
        }

        public T Read<T>(string itemName)
        {
            if (state == 1)
            {
                foreach (XmlNode node in xml.FirstChild.ChildNodes)
                    if (node.Name == itemName)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        return (T)serializer.Deserialize(new StringReader(node.InnerXml));
                    }
                return default(T);
            }
            else
                throw new Exception("Must call BeginRead first");
        }

        public T Read<T>(string itemName, T defaultValue)
        {
            if (state == 1)
            {
                foreach (XmlNode node in xml.FirstChild.ChildNodes)
                    if (node.Name == itemPath + itemName)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        return (T)serializer.Deserialize(new StringReader(node.InnerXml));
                    }
                return defaultValue;
            }
            else
                throw new Exception("Must call BeginRead first");
        }

        public void EndRead()
        {
            if (state == 1)
            {
                state = 0;
                xml = null;
            }
            else
                throw new Exception("Must call BeginRead first");
        }

        public void BeginWrite()
        {
            if (state == 0)
            {
                xml = new XmlDocument();
                XmlNode rootNode = xml.CreateElement("rootNode");
                xml.AppendChild(rootNode);
                state = 2;
            }
            else
                throw new Exception("SaveFile is currently being used");
        }

        public string itemPath = "";

        public void Write<T>(string itemName, T data)
        {
            if (state == 2)
            {
                XmlNode newNode = xml.CreateElement(itemPath + itemName);
                MemoryStream mem = new MemoryStream();
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(mem, data);
                byte[] buffer = mem.ToArray();
                string str = "";
                for(int i = 23; i < buffer.Length; i++)
                    str += (char)buffer[i];
                newNode.InnerXml = str;
                xml.FirstChild.AppendChild(newNode);
            }
            else
                throw new Exception("Must call BeginWrite first");
        }

        public void EndWrite()
        {
            if (state == 2)
            {
                xml.Save(filename);
                state = 0;
            }
            else
                throw new Exception("Must call BeginWrite first");
        }
    }
}
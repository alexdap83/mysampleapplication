using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SampleApplication
{
    [XmlRoot("XMLData", Namespace = "", IsNullable = true)]
    public class XMLData
    {
        [XmlIgnore]
        public string FileName { get; set; }

        public static T Load<T>(string fileName) where T : XMLData, new()
        {
            if (File.Exists(fileName))
            {
                using (Stream s = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    try
                    {
                        var xmlSerializer = new XmlSerializer(typeof (T));
                        var obj = (T) xmlSerializer.Deserialize(s);
                        obj.FileName = fileName;
                        return obj;
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
            var t = new T {FileName = fileName};
            t.Save();
            return t;
        }

        public void Save()
        {
            using (Stream s = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var xmlSerializer = new XmlSerializer(GetType());
                xmlSerializer.Serialize(s, this);
            }
        }
    }
}
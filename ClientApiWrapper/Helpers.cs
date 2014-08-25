using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ClientApiWrapper
{
    public class Helpers
    {
        public static T FromXmlNode<T>(XNode element)
        {
            return FromXmlString<T>(GetInnerXml(element));
        }

        public static string GetInnerXml(XNode element)
        {
            var reader = element.CreateReader();
            reader.MoveToContent();
            return reader.ReadOuterXml();
        }

        public static T FromXmlString<T>(string xmlString)
        {
            try
            {
                var reader = new StringReader(xmlString);
                var serializer = new XmlSerializer(typeof (T));
                var instance = (T) serializer.Deserialize(reader);

                return instance;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("XML Serialization error (line - column) {0} - inner exception {1}", ex.Message, ex.InnerException), ex);
            }
        }
    }
}

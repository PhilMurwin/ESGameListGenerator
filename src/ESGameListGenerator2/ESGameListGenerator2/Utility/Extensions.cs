using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ESGameListGenerator2.Utility
{
    public static class Extensions
    {
        public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions)
        {
            if (extensions == null)
            {
                throw new ArgumentNullException("extensions");
            }

            IEnumerable<FileInfo> files = dir.EnumerateFiles();
            var fileInfoList = files.Where(f => extensions.Contains(f.Extension));

            return fileInfoList;
        }

        public static string GetXMLString<T>(this T model)
        {
            var xml = "";

            //Create our own namespaces for the output
            var xmlNS = new XmlSerializerNamespaces();
            xmlNS.Add("", "");

            var xmlSettings = new XmlWriterSettings();
            xmlSettings.IndentChars = "\t";
            xmlSettings.Indent = true;

            using (var sw = new Utf8StringWriter())
            {
                using (XmlWriter xw = XmlWriter.Create(sw, xmlSettings))
                {
                    var serializer = new XmlSerializer(model.GetType());
                    serializer.Serialize(xw, model, xmlNS);
                    xml = sw.ToString();
                }
            }

            return xml;
        }
    }
}

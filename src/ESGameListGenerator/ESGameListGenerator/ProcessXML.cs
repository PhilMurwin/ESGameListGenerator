using System.IO;
using System.Xml.Serialization;

namespace ESGameListGenerator2
{
    public static class ProcessXML
    {
        public static string SaveModelToXML<T>( T model )
        {
            var xml = "";

            //Create our own namespaces for the output
            var xmlNS = new XmlSerializerNamespaces();
            xmlNS.Add( "", "" );

            var serializer = new XmlSerializer( model.GetType() );

            using ( var textWriter = new StringWriter() )
            {
                serializer.Serialize( textWriter, model, xmlNS );
                xml = textWriter.ToString();
            }

            return xml;
        }

        public static T ParseXMLToModel<T>( FileInfo file )
        {
            T model = default( T );

            var serializer = new XmlSerializer( typeof( T ) );

            var reader = new StreamReader( file.FullName );
            model = (T)serializer.Deserialize( reader );

            reader.Close();

            return model;
        }
    }
}

using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ESGameListGenerator
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

        public static T ParseXMLToModel<T>( string xml )
        {
            T model = default( T );

            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes( xml );
            MemoryStream stream = new MemoryStream( byteArray );

            var serializer = new XmlSerializer( typeof( T ) );
            model = (T)serializer.Deserialize( stream );

            return model;
        }
    }
}

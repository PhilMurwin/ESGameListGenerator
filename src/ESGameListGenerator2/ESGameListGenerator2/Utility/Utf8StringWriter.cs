using System.Text;

namespace ESGameListGenerator2.Utility
{
    public sealed class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}

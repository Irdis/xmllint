using System.Xml;
using System.Text;

using var input = Console.OpenStandardInput();
using var output = Console.OpenStandardOutput();
using var writer = new XmlTextWriter(output, new UTF8Encoding(
        encoderShouldEmitUTF8Identifier: false
));
var document = new XmlDocument();

document.Load(input);
writer.Formatting = Formatting.Indented;

document.WriteContentTo(writer);

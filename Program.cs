using System.Xml;
using System.Text;

using var input = Console.OpenStandardInput();
using var output = Console.OpenStandardOutput();
using var writer = new XmlTextWriter(output, Encoding.Unicode);
var document = new XmlDocument();

document.Load(input);
writer.Formatting = Formatting.Indented;

document.WriteContentTo(writer);

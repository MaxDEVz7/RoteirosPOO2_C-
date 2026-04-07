using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
class Program
{
    static void Main()
    {
        XmlSerializer serializerXml = new XmlSerializer(typeof(ListaAlunos));

        using (StreamReader reader = new StreamReader("alunos.xml"))
        {
            ListaAlunos alunos = (ListaAlunos)serializerXml.Deserialize(reader);

            foreach (var a in alunos.Alunos)
            {
                Console.WriteLine(a.Nome);
                Console.WriteLine(a.Curso);
            }
        }
    }
}

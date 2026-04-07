using System.IO;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;
class Livros
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        var livro = new Livros
        {
            Titulo = "Testando livro",
            Autor = "EU",
            Ano = 1955
        };

        string json = JsonConvert.SerializeObject(livro, Newtonsoft.Json.Formatting.Indented);


        Console.WriteLine(json);

    }
}
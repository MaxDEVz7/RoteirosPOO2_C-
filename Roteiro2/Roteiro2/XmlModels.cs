using System;
using System.Xml.Serialization;


using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot("alunos")]
public class ListaAlunos
{
    [XmlElement("aluno")]
    public List<Aluno> Alunos { get; set; }
}
public class Aluno
{
    [XmlElement("nome")]
    public string Nome { get; set; }

    [XmlElement("curso")]
    public string Curso { get; set; }
}



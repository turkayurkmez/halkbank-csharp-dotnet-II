// See https://aka.ms/new-console-template for more information
using Serialization;
using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");
/*
 * 1. Binary Serialization
 * 2. XML Serialization
 * 3. Json Serialization
 */
var documents = new DocumentService().GetDocuments();
var jsonSerialize = JsonSerializer.Serialize(documents);

XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Document>));
//using FileStream fileStream = new FileStream("serialize.xml", FileMode.CreateNew);

//xmlSerializer.Serialize(fileStream, documents);

var deserializedDocuements = JsonSerializer.Deserialize<List<Document>>(jsonSerialize);

deserializedDocuements.ForEach(d => Console.WriteLine(d.Name));

Console.WriteLine(jsonSerialize);


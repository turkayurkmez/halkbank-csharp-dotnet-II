// See https://aka.ms/new-console-template for more information
using Constructors;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
Report report = new Report("a.xml");
Console.WriteLine(report.Format);

report.Format = FormatType.Word;

//SqlDataAdapter adapter = new SqlDataAdapter()
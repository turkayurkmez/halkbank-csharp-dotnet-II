// See https://aka.ms/new-console-template for more information
using AbstractionAndInterface;

Console.WriteLine("Hello, World!");
ExcelDocument excelDocument = new ExcelDocument();
WordDocument wordDocument = new WordDocument();
PDFDocument pdfDocument = new PDFDocument();

PrintDocument printer = new PrintDocument();
printer.Print(excelDocument);
printer.Print(wordDocument);


//printer.Print(pdfDocument);
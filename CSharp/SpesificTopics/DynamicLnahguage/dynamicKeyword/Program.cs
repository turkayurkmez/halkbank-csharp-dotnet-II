// See https://aka.ms/new-console-template for more information
using dynamicKeyword;

Console.WriteLine("Hello, World!");

dynamic value = "test";
Console.WriteLine(value.ToUpper());

value = new Random();
Console.WriteLine(value.Next(1, 10));

dynamic instance = Activator.CreateInstance(typeof(Sample));
//string stringValue = (string)instance.GetType().InvokeMember("Word",
//                                                      System.Reflection.BindingFlags.GetProperty,
//                                                      null,
//                                                      instance,
//                                                      null
//                                                      );

var stringValue = instance.Word;

Console.WriteLine(stringValue);
dynamic dynamicObject = new DynamicClass();
Console.WriteLine(dynamicObject.GetSomething(5).Next(1, 10));


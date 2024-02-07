// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Queue<string> mails = new Queue<string>();
mails.Enqueue("a@b.com");
mails.Enqueue("b@b.com");
mails.Enqueue("c@b.com");

while (mails.Count > 0)
{
    string mail = mails.Dequeue();
    Console.WriteLine(mail);
}

Console.WriteLine($"mails koleksiyonunda {mails.Count} eleman var!");

Stack<string> stack = new Stack<string>();
stack.Push("a");
stack.Push("b");
stack.Push("c");
Console.WriteLine($"Çıkarılacak ilk eleman: {stack.Peek()} ");
while (stack.Count > 0)
{
    string item = stack.Pop();
    Console.WriteLine(item);
}


Console.WriteLine($"stack koleksiyonunda {stack.Count} eleman var!");

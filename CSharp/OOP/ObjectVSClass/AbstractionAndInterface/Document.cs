using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{

    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public string Owner { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }

        public void Copy(string from, string to) { }

        public void Move(string from, string to) { }

        public abstract void Load();
        public abstract void Save();


        public virtual void ChangeTitle(string title)
        {
            Title = title;
        }



    }

    public class ExcelDocument : Document, IPrintable
    {


        public override void Load()
        {
            Console.WriteLine($"{GetType().Name} yükleniyor");
        }

        public void Print()
        {
            Console.WriteLine($"{GetType().Name} çıktı alınıyor");

        }

        public override void Save()
        {
            Console.WriteLine($"{GetType().Name} kaydediliyor");

        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load()
        {
            Console.WriteLine($"{GetType().Name} yükleniyor");
        }

        public void Print()
        {
            Console.WriteLine("Word çıktısı alınıyor");
        }

        public override void Save()
        {
            Console.WriteLine($"{GetType().Name} kaydediliyor");

        }
    }

    public class PDFDocument : Document
    {
        public override void Load()
        {
            Console.WriteLine($"{GetType().Name} yükleniyor");
        }

        public override void Save()
        {
            Console.WriteLine($"{GetType().Name} kaydediliyor");

        }
    }

    public class PrintDocument
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }
}

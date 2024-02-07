// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;
using System.Collections.Specialized;

Console.WriteLine("Hello, World!");
ObservableCollection<string> folders = new ObservableCollection<string>();
folders.CollectionChanged += Folders_CollectionChanged;


folders.Add("Documents");
folders.Add("Images");
folders.Add("repos");

folders.Move(2, 0);
folders[0] = "Repos";



folders.Clear();

void Folders_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    switch (e.Action)
    {
        case NotifyCollectionChangedAction.Add:
            if (e.NewItems.Count > 0)
            {
                Console.WriteLine(e.NewItems[0] + " eklendi....");
            }
            break;
        case NotifyCollectionChangedAction.Remove:
            break;
        case NotifyCollectionChangedAction.Replace:
            Console.WriteLine("Değişti!");
            var collection = (ObservableCollection<string>)sender;
            Console.WriteLine($"{e.OldStartingIndex} indexindeki değer, {collection[e.NewStartingIndex]} olarak değişti");
            break;
        case NotifyCollectionChangedAction.Move:
            Console.WriteLine($"{e.OldStartingIndex} indexi {e.NewStartingIndex} olarak değişti");
            break;
        case NotifyCollectionChangedAction.Reset:
            Console.WriteLine("koleksiyon resetlendi");
            break;
        default:
            break;
    }
}
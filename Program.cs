using FileHelper;

var fileHelper = new Helper(@"C:\Users\student\Desktop\ListaProdotti.csv");

var list = fileHelper.ReadAll();

Console.WriteLine("*********************");

foreach (var list in list)
{
    Console.WriteLine($"idProdotto: {list.id} - nome: {list.nome} - magazzino: {list.magazzino}");
}

Console.WriteLine("*********************");

Console.WriteLine("Inserisci id prodotto");
var id = Console.ReadLine();
Console.WriteLine("Inserisci il nome prodotto");
var nome = Console.ReadLine();
Console.WriteLine("Inserisci quantità magazzino");
var magazzino = Console.ReadLine();


var listsNew = new list();
listsNew.id = id;
listsNew.nome = nome;
listsNew.magazzino = magazzino;


fileHelper.AddContact(contactnew);

list = fileHelper.ReadAll();


Console.WriteLine("*********************");

foreach (var list in list)
{
    Console.WriteLine($"id: {list.id} - nome: {list.nome} - quantità presente: {list.magazzino}");
}

Console.WriteLine("*********************");


Console.ReadLine();
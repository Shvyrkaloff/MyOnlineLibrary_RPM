// See https://aka.ms/new-console-template for more information

using DummyLib.Entities;
using DummyLib;

using (var context = new MyOnlineLibraryContext())
{
    var test = context.Users.ToList();
}

Console.WriteLine("Hello, World!");

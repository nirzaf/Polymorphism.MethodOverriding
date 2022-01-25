// See https://aka.ms/new-console-template for more information
Console.WriteLine("Polymorphism using method overriding (Dynamic Polymorphism)");

var mp = new MobilePhone();

mp.Typing();

var sm = new SmartPhone();

sm.Typing();

MobilePhone mpNew = new SmartPhone();

mpNew.Typing();

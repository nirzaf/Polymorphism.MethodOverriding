// See https://aka.ms/new-console-template for more information
Console.WriteLine("Polymorphism using method overriding (Dynamic Polymorphism)");

MobilePhone mp = new MobilePhone();

mp.Typing();

SmartPhone sm = new SmartPhone();

sm.Typing();

MobilePhone mpNew = new SmartPhone();

mpNew.Typing();

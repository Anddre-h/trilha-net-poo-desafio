using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("123456", "Tijolão", "12121212", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Iphone iphone = new Iphone("55617", "13", "3434343434", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
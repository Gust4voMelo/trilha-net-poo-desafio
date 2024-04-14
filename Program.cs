using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("1234-5678", "XR", "1234567890", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\nSmartphone Nokia: ");
Smartphone nokia = new Nokia("8765-4321", "Tijolão", "0987654321", 1000);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da cobrinha");
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine($"Número do Nokia: {nokia.Numero}");
nokia.InstalarAplicativo("WhatsApp");
nokia.Numero = "987654321";
Console.WriteLine($"Número do Nokia: {nokia.Numero}");

Console.WriteLine("=".PadRight(50, '='));

Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine($"Número do Iphone: {iphone.Numero}");
iphone.InstalarAplicativo("Instagram");
iphone.Numero = "123456789";
Console.WriteLine($"Número do Iphone: {iphone.Numero}");
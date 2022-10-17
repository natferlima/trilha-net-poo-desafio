using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("987654322", "Modelo1", "1111111111", 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");


Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("976543218", "Modelo2", "2222222222", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

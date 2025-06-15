using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("123456789", "Iphone 14", "123456789", 64);

Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", 64);

Console.WriteLine("Operações no Iphone: ");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Spotify");
iphone.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("Facebook Messenger");
Console.WriteLine("Aplicativos instalados no Iphone: " + iphone.AplicativosInstalados.Count);

Console.WriteLine("Operações no Nokia: ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");
nokia.InstalarAplicativo("Spotify");
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Facebook Messenger");
Console.WriteLine("Aplicativos instalados no Nokia: " + nokia.AplicativosInstalados.Count);
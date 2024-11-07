using DesafioPOO.Models;

Nokia nokia = new Nokia("(11)91111-1111", "Nokia A1", "fduioasjfdiosajio", 2);
Iphone iphone = new Iphone("(11)92222-2222", "Iphone 2", "324532908kfdsçal", 1);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.ReadKey();

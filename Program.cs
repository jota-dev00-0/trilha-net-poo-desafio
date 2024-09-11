using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("111", "n1", "11113222" , 8);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Telegram");

Console.WriteLine("___________________");
Console.WriteLine();

Iphone i9 = new Iphone("222", "i9", "333333333" , 16);
i9.Ligar();
i9.ReceberLigacao();
i9.InstalarAplicativo("WhatsApp");


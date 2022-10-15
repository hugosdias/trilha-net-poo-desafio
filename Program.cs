using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("9999-6415", "13 PRO", "5468761685681681", 128);
Nokia nokia = new Nokia("99456-1234", "N95", "65465135156", 64);

Console.WriteLine("Smartphone iPhone:");
iphone.InstalarAplicativo("WhatsApp");
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine();

Console.WriteLine("Smartphone Nokia:");
nokia.InstalarAplicativo("Facebook");
nokia.Ligar();
iphone.ReceberLigacao();



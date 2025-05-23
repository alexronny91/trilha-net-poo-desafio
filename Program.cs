using DesafioPOO.Models;

Iphone iphone1 = new Iphone("11999999999", "Iphone 16", "imei123", 256);
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");

Nokia nokia1 = new Nokia("11988888888", "Nokia G21", "imei321", 128);
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Facebook");

using DesafioPOO.Models;

Console.WriteLine("Celular Nokia: ");
Nokia nokia = new Nokia("2199999999","Tijolão","91919191919",64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatzapp");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone: ");
Iphone iphone = new Iphone("22888888888", "15 Pro Max Plus Delux optimus Prime","7773777737",128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Google Fotos");
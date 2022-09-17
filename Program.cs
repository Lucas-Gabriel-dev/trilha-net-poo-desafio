using DesafioPOO.Models;

Console.WriteLine("Celular nokia");
Smartphone nokia = new Nokia(numero: "91919191", modelo: "Nokia", imei: "192312", memoria: 4);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
nokia.InfoCelular();

Console.WriteLine($"\n");

Console.WriteLine("Celular iphone");
Smartphone iphone = new Iphone(numero: "454516", modelo: "Iphone X", imei: "151619", memoria: 8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.InfoCelular();

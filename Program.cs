using DesafioPOO.Models;

// Implementado para realizar testes


Console.WriteLine("Smartphone Nokia");

Nokia n1 = new Nokia("8256324853", "N95","a526a66e3656", 64);


n1.Ligar();

//n1.Modelo como private
//n1.IMEI como private
//n1.Memoria como private

n1.ReceberLigacao();
n1.InstalarAplicativo("Telegram");



Console.WriteLine("Smartphone Iphone");

Iphone i1 = new Iphone("545632159", "13ProMax", "2e5yt54r214", 128);

i1.Ligar();

//i1.Modelo como private
//i1.IMEI ocmo private
//i1.Memoria como private

i1.ReceberLigacao();
i1.InstalarAplicativo("WhatsApp");

using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("123456", "modelo 01", "111111", 64);
nokia.Ligar();
Console.WriteLine("Celular Nokia ligado");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Candy Crush");

Console.WriteLine("\n");
Console.WriteLine("###########");
Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "654321", modelo: "modelo 02", imei: "222222", memoria: 128);
iphone.Ligar();
Console.WriteLine("Celular Iphone ligado");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Sudoku");
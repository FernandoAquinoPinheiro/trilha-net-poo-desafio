using DesafioPOO.Models;

Nokia n1 = new Nokia("11 99999-0000","n15","n8888",64);
Iphone i1 = new Iphone("11 98888-1111","15 pro max","22222",128);

Console.WriteLine($"Nokia numero {n1.Numero}");
n1.Ligar();
n1.InstalarAplicativo("Revolution");
Console.WriteLine("\n");
Console.WriteLine($"Nokia numero {i1.Numero}");
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagran");
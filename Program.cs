const string kioscoName = "Kiosco Austral";

Console.Write("Ingrese el nombre del cajero: ");
String cajeroName = Console.ReadLine();

Console.WriteLine($"-----{kioscoName}-----");
Console.WriteLine($"Cajero a cargo: {cajeroName}");
Console.WriteLine($"Bienvenido, {cajeroName}, caja abierta");

Console.Write("Ingrese el nombre del producto: ");
string productName = Console.ReadLine();

Console.Write("Ingrese el precio del producto");
decimal productPrice = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Su producto es {productName} y su precio ${productPrice}");

Console.ReadKey();
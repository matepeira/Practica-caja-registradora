const string kioscoName = "Kiosco Austral";

Console.Write("Ingrese el nombre del cajero: ");
String cajeroName = Console.ReadLine();

Console.WriteLine($"-----{kioscoName}-----");
Console.WriteLine($"Cajero a cargo: {cajeroName}");
Console.WriteLine($"Bienvenido, {cajeroName}, caja abierta");

int choice;
decimal totalVenta = 0;
int productCant = 0;

do
{
    Console.WriteLine("\nQue desea hacer?");
    Console.WriteLine("1- Cargar un poducto");
    Console.WriteLine("2- Cerrar la venta");
    Console.WriteLine("Eleccion 1 o 2: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Ingrese el nombre del producto: ");
            string productName = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Su producto es {productName} y su precio ${productPrice}");
            totalVenta += productPrice;
            productCant++;
            break;

        case 2:
            Console.WriteLine("\nLa venta ha sido cerrada, cantidades y precio final: ");
            Console.WriteLine($"Cantidad de productos: {productCant}");
            Console.WriteLine($"Monto total: {totalVenta}");
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
} while (choice != 2);
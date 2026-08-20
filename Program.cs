const string kioscoName = "Kiosco Austral";

Console.Write("Ingrese el nombre del cajero: ");
String cajeroName = Console.ReadLine();

Console.WriteLine($"-----{kioscoName}-----");
Console.WriteLine($"Cajero a cargo: {cajeroName}");
Console.WriteLine($"Bienvenido, {cajeroName}, caja abierta");

int choice;
decimal totalVenta = 0;
int productCant = 0;
const decimal discount_10 = 0.10m;
const decimal discount_5 = 0.05m;

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
            if (totalVenta > 50000)
            {
                Console.WriteLine($"Subtotal: {totalVenta}");
                Console.WriteLine($"Descuento aplicado(10%): {totalVenta * discount_10}");
                Console.WriteLine($"Monto a pagar: {totalVenta - totalVenta * discount_10}");
            }
            else if (totalVenta > 20000)
            {
                Console.WriteLine($"Subtotal: {totalVenta}");
                Console.WriteLine($"Descuento aplicado(5%): {totalVenta * discount_5}");
                Console.WriteLine($"Monto a pagar: {totalVenta - totalVenta * discount_5}");
            }
            else
            {
                Console.WriteLine($"Subtotal: {totalVenta}");
                Console.WriteLine($"Descuento aplicado: 0");
                Console.WriteLine($"Monto a pagar: {totalVenta}");
            }
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
} while (choice != 2);
Console.ReadKey();
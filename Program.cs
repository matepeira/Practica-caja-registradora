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
const decimal discount_cash = 0.10m;
const decimal surcharge_credit = 0.15m;

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
            Console.WriteLine($"Cantidad de productos: {productCant}");
           
            decimal montoConDescuento = totalVenta;
            decimal descuentoMontoAplicado = 0;

            if (totalVenta > 50000)
            {
                Console.WriteLine($"Subtotal: {totalVenta}");
                descuentoMontoAplicado = totalVenta * discount_10;
                Console.WriteLine($"Descuento aplicado(10%): {descuentoMontoAplicado}");
                montoConDescuento = totalVenta - descuentoMontoAplicado;
                Console.WriteLine($"Monto a pagar: {montoConDescuento}");
            }
            else if (totalVenta > 20000)
            {
                Console.WriteLine($"Subtotal: {totalVenta}");
                descuentoMontoAplicado = totalVenta * discount_5;
                Console.WriteLine($"Descuento aplicado(5%): {descuentoMontoAplicado}");
                montoConDescuento = totalVenta - descuentoMontoAplicado;
                Console.WriteLine($"Monto a pagar: {montoConDescuento}");
            }
            else
            {
                Console.WriteLine($"Subtotal: {totalVenta}");
                Console.WriteLine($"Descuento aplicado: 0");
                Console.WriteLine($"Monto a pagar: {montoConDescuento}");
            }

            int payment;
            decimal paymentDiscount = 0;
            decimal finalCost = 0;

            do
            {
                Console.WriteLine("\nElija un metodo de pago");
                Console.WriteLine("1- Efectivo, 10% de descuento");
                Console.WriteLine("2- Debito, sin modificaciones");
                Console.WriteLine("3- Credito, 15% de recargo");
                Console.WriteLine("opcion 1,2 o 3");
                payment = int.Parse(Console.ReadLine());

                switch (payment)
                {
                    case 1:
                        Console.WriteLine("\nLa venta ha sido cerrada, cantidades y precio final: ");
                        Console.WriteLine($"Subtotal: {montoConDescuento}");
                        paymentDiscount = montoConDescuento * discount_cash;
                        Console.WriteLine($"Descuento aplicado(10%): {paymentDiscount}");
                        finalCost = montoConDescuento - paymentDiscount;
                        Console.WriteLine($"Monto a pagar: {finalCost}");
                        break;

                    case 2:
                        Console.WriteLine("\nLa venta ha sido cerrada, cantidades y precio final: ");
                        Console.WriteLine($"Monto a pagar: {montoConDescuento}");
                        break;

                    case 3:
                        Console.WriteLine("\nLa venta ha sido cerrada, cantidades y precio final: ");
                        Console.WriteLine($"Subtotal: {montoConDescuento}");
                        paymentDiscount = montoConDescuento * surcharge_credit;
                        Console.WriteLine($"Recargo(15%): {paymentDiscount}");
                        finalCost = montoConDescuento + paymentDiscount;
                        Console.WriteLine($"Monto a pagar: {finalCost}");
                        break;
                    default:
                        Console.WriteLine("Opción de pago inválida. Intente de nuevo.");
                        break;
                }
            } while (payment < 1 || payment > 3);
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
} while (choice != 2);
Console.ReadKey();
const string kioscoName = "Kiosco Austral";

Console.Write("Ingrese el nombre del cajero: ");
String cajeroName = Console.ReadLine();

Console.WriteLine($"-----{kioscoName}-----");
Console.WriteLine($"Cajero a cargo: {cajeroName}");
Console.WriteLine($"Bienvenido, {cajeroName}, caja abierta");

int choice;
decimal totalSell = 0;
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
   
    while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
    {
        Console.Write("Error. Opción inválida. Por favor, ingrese 1 o 2: ");
    }

    switch (choice)
    {
        case 1:
            Console.Write("Ingrese el nombre del producto: ");
            string productName = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Su producto es {productName} y su precio ${productPrice}");
            totalSell += productPrice;
            productCant++;
            break;

        case 2:

            decimal discountAmountApplied = 0;

            if (totalSell > 50000)
            {
                discountAmountApplied = totalSell * discount_10;
            }
            else if (totalSell > 20000)
            {
                discountAmountApplied = totalSell * discount_5;
            }

            decimal discountedAmount = totalSell - discountAmountApplied;

            int payment;
            decimal paymentDiscount = 0;
            decimal paymentSurcharge = 0;

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
                        paymentDiscount = discountedAmount * discount_cash;
                        break;

                    case 2:
                        break;

                    case 3:
                        paymentSurcharge = discountedAmount * surcharge_credit;
                        break;

                    default:
                        Console.WriteLine("Opción de pago inválida. Intente de nuevo.");
                        break;
                }
            } while (payment < 1 || payment > 3);

            decimal totalDisccount = discountAmountApplied + paymentDiscount;
            decimal totalRecharge = paymentSurcharge;
            decimal finalCost = totalSell - totalDisccount + totalRecharge;

            Console.WriteLine();
            for (int i = 0; i < 35; i++) Console.Write("-");
            Console.WriteLine();

            Console.WriteLine($"         {kioscoName}");

            for (int i = 0; i < 35; i++) Console.Write("-");
            Console.WriteLine();

            Console.WriteLine($"Cajero: {cajeroName}");
            Console.WriteLine($"Productos: {productCant}");
            Console.WriteLine($"Subtotal: {totalSell}");
            Console.WriteLine($"Descuento: {totalDisccount}");
            Console.WriteLine($"Recargo: {totalRecharge}");

            for (int i = 0; i < 35; i++) Console.Write("-");
            Console.WriteLine();

            Console.WriteLine($"TOTAL: {finalCost}");

            for (int i = 0; i < 35; i++) Console.Write("-");
            break;


    }
} while (choice != 2);
Console.ReadKey();
int tipoCliente;
double montoBase;
int metodoPago;
string cupon;
string codigo;
int antifraude;
double descuento = 1;
double recargo = 1;
Console.WriteLine("Sistema de facturación");
Console.WriteLine("Ingrese el tipo de cliente");
Console.WriteLine("1. Estudiante");
Console.WriteLine("2. Docente");
Console.WriteLine("3. Administrativo");
Console.WriteLine("4. Externo");
tipoCliente = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el monto base a pagar");
montoBase = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el metodo de pago");
Console.WriteLine("1. Efectivo");
Console.WriteLine("2. Tarjeta");
Console.WriteLine("3. Transferencia");
metodoPago  = int.Parse(Console.ReadLine());
Console.WriteLine("Reporte antifraude");
Console.WriteLine("1. Ninguno");
Console.WriteLine("2. Cupon invalido o repetido");
Console.WriteLine("3. Pagos rechazados multiples");
antifraude = int.Parse(Console.ReadLine());
Console.WriteLine("¿Posee cupon? S/N");
cupon = Console.ReadLine();

switch (metodoPago)
{
    case 1:
        descuento = 1.10;
        break;

    case 2:
        descuento = 1.07;
        break;

    case 3:
        descuento = 1;
        break;

    default:
        Console.WriteLine("Metodo de pago no válido");
        break;
}

if (cupon == "S" || cupon == "s")
{
    Console.WriteLine("Ingrese el codigo del cupon");
    codigo = Console.ReadLine();
    if (codigo.Contains("U") || codigo.Contains("2"))
    {
        Console.WriteLine("Codigo no válido");
    }
    else
    {
        descuento = 1.15;
    }
}

switch(antifraude)
{
    case 1:

    break;

    case 2:
        descuento = 1;
        recargo = 1.10;
        Console.WriteLine("Se le asigno recargo\n");
    break;

    case 3:
        descuento = 1;
        recargo = 1.10;
        Console.WriteLine("Se le asigno recargo\n");
    break;

    default:
        Console.WriteLine("Antifraude no válido");
    break;
}

switch(tipoCliente)
{
    case 1:
        Console.WriteLine($"Su pago por ser estudiante es de: {(montoBase / descuento) * recargo}");
        break;

    case 2:
        Console.WriteLine($"Su pago por ser docente es de: {montoBase * recargo}");
        break;

    case 3:
        if(recargo == 1)
        {
            descuento = 1.15;
        }
        Console.WriteLine($"Su pago por ser administrativo es de: {(montoBase / descuento) * recargo}");
    break;

    case 4:
        if (cupon == "s" || cupon == "S")
        {
            descuento = 1.15;
            Console.WriteLine($"Precio por canje de codigo: {montoBase/descuento}");
        }
        Console.WriteLine($"Por ser externo su pago es normal: {montoBase}");
    break;

    default:
        Console.WriteLine("No existe ese tipo de cliente");
    break;
}
int tipoCliente;
double montoBase;
int metodoPago;
string cupon;
string codigo;
int antifraude;
double descuento;
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
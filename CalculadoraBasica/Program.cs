//Primer valor pedido
double valor1;
Console.WriteLine("Escribí tu primer numero: ");
valor1 = Convert.ToDouble(Console.ReadLine());
Console.Clear();

//Operacion
string operacion;
Console.WriteLine("Escribí la operacion (símbolo) que deseás: ");
operacion = Convert.ToString(Console.ReadLine());
Console.Clear();

//Segundo valor pedido
double valor2;
Console.WriteLine("Escribí tu segundo numero: ");
valor2 = Convert.ToDouble(Console.ReadLine());
Console.Clear();

//Condicionales
if (operacion == "+")
{
    Console.WriteLine("El resultado de tu suma es: " + (valor1 + valor2));
}
else if (operacion == "-")
{
    Console.WriteLine("El resultado de tu resta es: " + (valor1 - valor2));
}
else if (operacion == "/")
{
    Console.WriteLine("El resultado de tu división es: " + (valor1 / valor2));
}
else
{
    Console.WriteLine("El resultado de tu multiplicación es: " + (valor1 * valor2));
};

//Resultado string

Console.ReadKey();
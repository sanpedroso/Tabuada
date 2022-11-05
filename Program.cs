int resultado = 0;
int valor = 0;
Console.WriteLine("Tabuada do numero..");
int v = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ate qual numero deseja multiplicar:");
int r = Convert.ToInt16(Console.ReadLine());
while (resultado  <= r)
{
    valor = v * resultado;
    Console.WriteLine(valor);
    resultado++ ;
}
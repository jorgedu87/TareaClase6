Console.Clear();
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
//Console.WriteLine($"el numero generado es {numeroSecreto}");


int contador = 0;
int numeroIngresado;
do
{
    contador++;
    Console.WriteLine("Ingrese un numero del 1 al 20");
    numeroIngresado = int.Parse(Console.ReadLine());
    if (numeroIngresado == numeroSecreto) { break; }

    if (numeroIngresado > numeroSecreto)
    { Console.WriteLine("el numero ingresado es mayor al numero secreto"); }
    else
    { Console.WriteLine("el numero ingresado es menor al numero secreto"); }

}
while (numeroIngresado != numeroSecreto);
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}. Lo has logrado en {contador} intentos");



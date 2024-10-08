int numero = 0;
int contador = 0;
int soma = 0;
// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}");
//     contador++;
// }

do
{
    Console.WriteLine("Digite um numero");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;

} while (numero!=0);

Console.WriteLine($"O Total dos numeros é {soma}");
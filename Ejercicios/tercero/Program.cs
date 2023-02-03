List<int> lista = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un entero");
    var num = Convert.ToInt32(Console.ReadLine());
    lista.Insert(i,num);
}

var pares = 0;
var impares = 0;

foreach(var num in lista) {
    if (num % 2 == 0){
        pares += num;
    } else {
        impares += num;
    }
}

Console.WriteLine("Pares: " + pares + "\nImpares: " + impares);

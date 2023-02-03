List<int> lista = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un entero");
    var num = Convert.ToInt32(Console.ReadLine());
    lista.Insert(i,num);
}

int mayor = lista[0];
int menor = lista[0];

foreach(var num in lista) {

    if (num >= mayor){
        mayor = num;
    }
    if (num <= menor){
        menor = num;
    }
}

Console.WriteLine("Mayor: " + mayor + "\nMenor: " + menor);


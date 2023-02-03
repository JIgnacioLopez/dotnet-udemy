using System.Collections;

// Estructura de datos compleja de implementar
// coleccion indexada, la indexacion funciona 
//como un diccionario
// Metodo de busqueda muy rapido con una 
// performance muy alta

Hashtable hashtable = new Hashtable();

// Añadir valores (key , value)
hashtable.Add("Juan", 1.22);
hashtable.Add("Pedro", "aa");
hashtable.Add("Seba", 9);

// Recorrer hashtable

foreach(DictionaryEntry item in hashtable) {
    Console.WriteLine(item.Value + " " + item.Key);
}

// Obtener valor del hashtable
// Ingresa una key y devuelve el valor correspondiente
var valor = hashtable["Juan"];

// Buscar
if (hashtable.ContainsKey("Seba")){
    Console.WriteLine("Hola seba");
}

if (hashtable.ContainsValue("aa")) {

}

// Eliminar
hashtable.Remove("Pedro");

// limpiar
hashtable.Clear();

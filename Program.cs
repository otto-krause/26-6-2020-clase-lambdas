using System;
using System.Linq;
using System.Collections.Generic;

namespace _26_6_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 7, 8, 9, 5, 6 };
            //{x perteneciente a numeros / x<4} -> {1,2,3}
            List<int> menoresQue4 = numeros.Where(x => x < 4).ToList();

            foreach (int numero in menoresQue4)
            {
                Console.WriteLine(numero);
            }

            //Solo en List
            menoresQue4.ForEach(numero => Console.WriteLine(numero));


            //Where: Sirve para filtrar elementos | Lista
            
            //ForEach: Sirve para recorrer una lista, realizando una accion | No devuelve valor, causa efecto
            //gatos.ForEach(gato => gato.comer());

            int cuantosMenoresA4Hay = menoresQue4.Count;

            //Count: Sirve para contar elementos bajo una condicion | Devuelve un numero
            int cuantosMenoresA4HayVersion2 = numeros.Count(x => x < 4);

            Console.WriteLine("Menores a 4: " + cuantosMenoresA4HayVersion2);


            bool result = numeros.All(x => x < 4);
            Console.WriteLine("Todos son menores a 4? " + result);

            result = numeros.All(x => x < 10);
            Console.WriteLine("Todos son menores a 4? " + result);

            // numeros.OrderBy(x => x)
            // .ToList()
            // .ForEach(numero => Console.WriteLine(numero));

            // numeros.OrderByDescending(x => x)
            // .ToList()
            // .ForEach(numero => Console.WriteLine(numero));

            List<Persona> personas = new List<Persona>{ new Persona(13, "Juan"), new Persona(42, "maria"), new Persona(18, "Ariel") };

            //Muestra las personas ordenadas por edad
            Console.WriteLine("Ordenados por edad:");
            personas.OrderByDescending(persona => persona.Edad)
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre));

            //Muestra solo los mayores de edad
            Console.WriteLine("Mayores de edad:");
            personas.Where(persona => persona.Edad >= 18)
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre));

            //Muestra las personas ordenadas por nombre
            Console.WriteLine("Ordenados por nombre:");
            personas.OrderBy(persona => persona.Nombre)
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre));

            //OrderBy: Ordena segun un criterio | devuelve una lista ordenada
            

            result = numeros.Any(x => x < 4);
            Console.WriteLine("Alguno es menor a 4? " + result);


            //Proyeccion o Transformacion:
            List<int> numeros2 = numeros.Select(numero => numero + 1).ToList();
            numeros2.ForEach(numero => Console.WriteLine(numero));

            Console.WriteLine("Lista de edades: ");
            personas.Select(persona => persona.Edad)
            .ToList()
            .ForEach(edad => Console.WriteLine(edad));

            double promedio = personas.Sum(persona => persona.Edad) / ((double)personas.Count);
            Console.WriteLine("El promedio de edad es: " + promedio);

            
            promedio = personas.Average(persona => persona.Edad);
            Console.WriteLine("El promedio de edad es: " + promedio);

            ///////////////
            int mayorEdad = personas.Max(persona => persona.Edad);
            Console.WriteLine("La mayor edad es: " + mayorEdad);

            int menorEdad = personas.Min(persona => persona.Edad);
            Console.WriteLine("La menor edad es: " + menorEdad);

            //Max y min: DEVUELVEN UN NUMERO

            string nombreMayorEdad = personas.OrderByDescending(p => p.Edad).First().Nombre;
            Console.WriteLine("El nombre de la persona mayor es " + nombreMayorEdad);


            //First: Devuelve el primer elemento que cumple una condicion | Devuelve un objeto dentro de la lista
        }
    }
}

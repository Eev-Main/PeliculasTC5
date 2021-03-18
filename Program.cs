using System;
using System.Collections.Generic;

namespace Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombresDePelicula = new List<string>();
            nombresDePelicula.Add("Toy Story");
            nombresDePelicula.Add("Avengers");
            nombresDePelicula.Add("Bicentennial Man");
            nombresDePelicula.Add("BeetleJuice");
            nombresDePelicula.Add("Silenc of the Lambs");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Aladdin");
            nombresDePelicula.Add("Aladdin");

            HashSet<string> nombresDePeliculaSet = new HashSet<string>();
            nombresDePeliculaSet.Add("Toy Story");
            nombresDePeliculaSet.Add("Avengers");
            nombresDePeliculaSet.Add("Bicentennial Man");
            nombresDePeliculaSet.Add("BeetleJuice");
            nombresDePeliculaSet.Add("Silenc of the Lambs");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Aladdin");
            nombresDePeliculaSet.Add("Aladdin");

            Console.WriteLine("Cant. de peliculas en nombreDePeliculas: " + nombresDePelicula.Count);
            Console.WriteLine("Cant. de peliculas en nombreDePeliculasSet: " + nombresDePeliculaSet.Count);

            HashSet<Pelicula> peliculaSet = new HashSet<Pelicula>();
            peliculaSet.Add(new Pelicula("bad Boys", 1995));
            peliculaSet.Add(new Pelicula("bad Boys", 1983));
            peliculaSet.Add(new Pelicula("Aladdin", 2019));
            peliculaSet.Add(new Pelicula("Aladdin", 2019)); 
            //son objetos distintos incluso si tienen los mismos datos
            peliculaSet.Add(new Pelicula("Aladdin", 1992));

            Console.WriteLine("Cant. de peliculas en nombreDePeliculasSet: " + peliculaSet.Count); //output= 5

            //map -> Java
            //dictionary -> C# python
            //object -> Javascript

            Dictionary<string, string> nombresDePeliculasFavoritas = new Dictionary<string, string>();
            nombresDePeliculasFavoritas.Add("Pablo", "Titanic");
            nombresDePeliculasFavoritas.Add("Esteban", "The Fast and the Furious: Toky Drift");
            nombresDePeliculasFavoritas.Add("octavio", "Barbie in the 12 dancing princesses");

            string NombrePeliculaFavoritaPablo = nombresDePeliculasFavoritas.GetValueOrDefault("Pablo");
            Console.WriteLine("nombre de la pelicula favorita de pablo: " + NombrePeliculaFavoritaPablo);

            string NombrePeliculaFavoritaRamiro = nombresDePeliculasFavoritas.GetValueOrDefault("Ramiro");
            Console.WriteLine("nombre de la pelicula favorita de Ramiro: " + NombrePeliculaFavoritaRamiro); //null

            NombrePeliculaFavoritaRamiro = nombresDePeliculasFavoritas.GetValueOrDefault("Ramiro", "(ninguna)");
            Console.WriteLine("nombre de la pelicula favorita de Ramiro: " + NombrePeliculaFavoritaRamiro); //ninguna

            nombresDePeliculasFavoritas.Add("Ramiro", "Shrek");

            NombrePeliculaFavoritaRamiro = nombresDePeliculasFavoritas.GetValueOrDefault("Ramiro", "(ninguna)");
            Console.WriteLine("nombre de la pelicula favorita de Ramiro: " + NombrePeliculaFavoritaRamiro); //Shrek

            //uso real de obtner valores de un Dictionary
            //out -> se decñara una nueva variable donde se recibira el resultado (el valor de "salida")
            if (nombresDePeliculasFavoritas.TryGetValue("Maria", out string nombresDePeliculasFavoritaMaria))
            {
                //en caso de que si tenga un valor el dictionary, se entra a este else
                Console.WriteLine("nombrePeliculaFavoritaMaria " + nombresDePeliculasFavoritaMaria);
            }
            else
            {
                Console.WriteLine("Maria no tiene pelicula favorita");
            }

            //lista
            Console.WriteLine("-------------------");
            Console.WriteLine("Lista");
            for (int i = 0; i < nombresDePelicula.Count; i++)
            {
                Console.WriteLine(nombresDePelicula[i]);
            }

            //HashSet
            Console.WriteLine("-------------------");
            Console.WriteLine("set");
            //foreach : elemento in conjunto
            foreach (string nombrePelicula in nombresDePeliculaSet)
            {
                Console.WriteLine(nombrePelicula);
            }

            //Dictionary
            Console.WriteLine("-------------------");
            Console.WriteLine("Dictionary");
            foreach (var Key in nombresDePeliculasFavoritas.Keys)
            {
                Console.WriteLine(Key);
            }
            foreach (var value in nombresDePeliculasFavoritas.Values)
            {
                Console.WriteLine(value);
            }
            foreach (var Key in nombresDePeliculasFavoritas.Keys)
            {
                Console.WriteLine(Key + ":" + nombresDePeliculasFavoritas.GetValueOrDefault(Key));
            }

        }
    }
}

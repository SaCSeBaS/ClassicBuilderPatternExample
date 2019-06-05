using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeCancion = 1;

            // MATERIAL DISCOGRAFICO
            String nombre;
            Double precio;
            int stock;

            // AUTOR
            Autor autor;
            String nombreArtista;
            String descripcionArtista;

            // GENERO
            Genero genero;
            String descripcionGenero;

            // TIPO MATERIAL DISCOGRAFICO
            String nombreMaterialDiscografico;

            // CANCIONES
            List<Cancion> canciones = new List<Cancion>();
            Cancion cancion;
            String nombreCancion;
            int duracionSegundos;

            char respuesta;

            // MATERIAL DISCOGRAFICO
            Console.Write("Ingrese el nombre del nuevo material: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el precio del nuevo material: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el stock del nuevo material: ");
            stock = Convert.ToInt32(Console.ReadLine());

            // AUTOR
            Console.Write("Ingrese el nombre del artista: ");
            nombreArtista = Console.ReadLine();
            Console.Write("Ingrese descripcion del artista: ");
            descripcionArtista = Console.ReadLine();
            autor = new Autor(nombreArtista, descripcionArtista);

            // GENERO
            Console.Write("Ingrese el nombre del genero: ");
            descripcionGenero = Console.ReadLine();
            genero = new Genero(descripcionGenero);

            do
            {
                // CANCIONES
                Console.WriteLine("\nCancion " + numeroDeCancion.ToString());
                Console.Write("Ingrese el nombre de la canción: ");
                nombreCancion = Console.ReadLine();
                Console.Write("Ingrese la duracion de la cancion en segundos: ");
                duracionSegundos = Convert.ToInt32(Console.ReadLine());

                cancion = new Cancion(nombreCancion, duracionSegundos);
                canciones.Add(cancion);

                numeroDeCancion++;

                Console.Write("Desea seguir agregando canciones? (S/N): ");
                respuesta = Console.ReadKey().KeyChar;
                Console.ReadKey();

            } while (respuesta == 'S');

            // BUILDER MATERIAL DISCOGRAFICO
            MaterialDiscograficoBuilder materialDiscograficoBuilder;
            Director director = new Director();

            Console.Write("Ingrese DISCO (D) O VINILO (V): ");
            respuesta = Console.ReadKey().KeyChar;

            Console.Clear();

            if(respuesta == 'D')
            {
                materialDiscograficoBuilder = new DiscoCompactoBuilder();
            }
            else
            {
                materialDiscograficoBuilder = new ViniloBuilder();
            }

            
            director.Construir(materialDiscograficoBuilder, nombre, precio, stock, genero, autor, canciones);

            // MOSTRAR DATOS
            Console.WriteLine(materialDiscograficoBuilder.MaterialDiscografico.reportarDatos());

            Console.ReadKey();
        }
    }
}


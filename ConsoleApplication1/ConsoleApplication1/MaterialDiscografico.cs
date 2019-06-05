using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MaterialDiscografico
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Double precio;

        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        private String TipoMaterialDiscografico;


        private Genero genero;

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        private Autor autor;

        public Autor Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        private List<Cancion> canciones;

        public List<Cancion> Canciones
        {
            get { return canciones; }
            set { canciones = value; }
        }

        public MaterialDiscografico(String tipoMaterialDiscografico)
        {
            TipoMaterialDiscografico = tipoMaterialDiscografico;
        }

        public String datosCanciones()
        {
            int numeroDeCancion = 1;
            String datos = "\nCANCIONES";

            foreach (Cancion cancion in canciones)
            {
                datos +=
                    "\nNº " + numeroDeCancion.ToString() +
                    "\nNombre: " + cancion.NombreCancion +
                    "\nDuracion: " + cancion.DuracionSegundos.ToString() + " segundos";

                numeroDeCancion++;
            }

            return datos;
        }

        public String reportarDatos()
        {
            return "REPORTE DE MATERIAL" +
                   "\nNombre: " + nombre +
                   "\nPrecio: " + precio +
                   "\nStock: " + stock +
                   "\n--------------------" +
                   "\nAUTOR" +
                   "\nNombre: " + autor.NombreArtista +
                   "\nDescripcion: " + autor.DescripcionArtista +
                   "\n--------------------" +
                   "\nGENERO" +
                   "\nNombre: " + genero.DescripcionGenero +
                   "\n--------------------" +
                   "\nTIPO DE MATERIAL DISCOGRAFICO" +
                   "\nNombre: " + TipoMaterialDiscografico +
                   datosCanciones();
        }

    }
}

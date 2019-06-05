using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Director
    {
        public void Construir(MaterialDiscograficoBuilder materialDiscograficoBuilder, String nombre, Double precio, int stock, Genero genero, Autor autor, List<Cancion> canciones)
        {
            materialDiscograficoBuilder.BuildNombre(nombre);
            materialDiscograficoBuilder.BuildPrecio(precio);
            materialDiscograficoBuilder.BuildStock(stock);
            materialDiscograficoBuilder.BuildGenero(genero);
            materialDiscograficoBuilder.BuildAutor(autor);
            materialDiscograficoBuilder.BuildCanciones(canciones);
        }
    }
}

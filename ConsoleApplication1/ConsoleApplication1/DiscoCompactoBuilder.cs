using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DiscoCompactoBuilder : MaterialDiscograficoBuilder
    {
        public DiscoCompactoBuilder()
        {
            materialDiscografico = new MaterialDiscografico("Disco Compacto");
        }

        public override void BuildNombre(String nombre)
        {
            materialDiscografico.Nombre = nombre;
        }

        public override void BuildPrecio(Double precio)
        {
            materialDiscografico.Precio = precio;
        }

        public override void BuildStock(int stock)
        {
            materialDiscografico.Stock = stock;
        }

        public override void BuildGenero(Genero genero)
        {
            materialDiscografico.Genero = genero;
        }

        public override void BuildAutor(Autor autor)
        {
            materialDiscografico.Autor = autor;
        }

        public override void BuildCanciones(List<Cancion> canciones)
        {
            materialDiscografico.Canciones = canciones;
        }
    }

}

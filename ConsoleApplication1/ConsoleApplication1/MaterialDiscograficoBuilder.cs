using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class MaterialDiscograficoBuilder
    {
        protected MaterialDiscografico materialDiscografico;

        public MaterialDiscografico MaterialDiscografico
        {
            get { return materialDiscografico; }
        }

        public abstract void BuildNombre(String nombre);
        public abstract void BuildPrecio(Double precio);
        public abstract void BuildStock(int stock);
        public abstract void BuildGenero(Genero genero);
        public abstract void BuildAutor(Autor autor);
        public abstract void BuildCanciones(List<Cancion> canciones);
    }
}

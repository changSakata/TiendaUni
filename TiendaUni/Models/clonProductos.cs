using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaUni.Models
{
    public class clonProductos
    {

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public string urlFoto { get; set; }
        public Nullable<float> Descuento { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<float> Precio_Unitario { get; set; }
        public List<string> listaFotos { get; set; }
    }
}
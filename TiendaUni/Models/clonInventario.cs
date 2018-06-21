using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaUni.Models
{
    public class clonInventario
    {
        public int Idinventario { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public float Precio_Unitario { get; set; }
        public Nullable<float> Descuento { get; set; }

    }
}
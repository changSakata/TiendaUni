//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaUni.BaseDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cotizacion_Producto
    {
        public int IdCotizacion_Producto { get; set; }
        public int IdProducto { get; set; }
        public int IdCotizacion { get; set; }
    
        public virtual Cotizacion Cotizacion { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaUni.BaseDatos;
using TiendaUni.Models;

namespace TiendaUni.Controllers
{
    public class HomeController : Controller
    {
        private NANGINFANJEN_DataBaseEntities conexionBaseDatos = new NANGINFANJEN_DataBaseEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ObtenerTodo()
        {

            var CategoriaProducto = (from item in conexionBaseDatos.Categorias
                                     select new clonCategoria
                                     {
                                         IdCategoria = item.IdCategoria,
                                         Nombre = item.Nombre,
                                         Descripcion = item.Descripcion
                                         
                                     }
                            ).ToList();


            var Productos = (from item in conexionBaseDatos.Productoes
                             select item);

            List<clonProductos> listaFinalProducto = new List<clonProductos>();
            foreach (var item in Productos)
            {
                clonProductos nuevo = new clonProductos();
                nuevo.IdCategoria = item.IdCategoria;
                nuevo.Nombre = item.Nombre;
                nuevo.Descripcion = item.Descripcion;
                nuevo.urlFoto = item.urlFoto;
                nuevo.IdProducto = item.IdProducto;
                nuevo.Descuento = item.Descuento;
                nuevo.Precio_Unitario = item.Presio;
                nuevo.Cantidad = item.Cantidad;
                nuevo.listaFotos = Splitear(item.urlFoto);


                listaFinalProducto.Add(nuevo);

            }

          
            

            return Json(new { CategoriaProducto, listaFinalProducto },JsonRequestBehavior.AllowGet);
        }


        private List<string> Splitear(string texto)
        {
            List<string> lista = (texto != null && texto.Length > 5)
                                     ? (texto).Split('&').ToList()
                                     : new List<string>();
            return lista;

        }


    }

}
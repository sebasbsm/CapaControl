using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControl
{
    public class NProducto
    {
		public static string Insertar(int code, string nombre, int precio, string tipo)
		{

			DProducto dProd = new DProducto();
			dProd.Codigo = code;
			dProd.Nombre = nombre;
			dProd.Precio = precio;
			dProd.Tipo = tipo;
			return dProd.Insertar(dProd);
		}


		public static string Modificar(int code, string nombre, int precio, string tipo)
		{
			DProducto dProd = new DProducto();
			dProd.Codigo = code;
			dProd.Nombre = nombre;
			dProd.Precio = precio;
			dProd.Tipo = tipo;
			return dProd.Modificar(dProd);
		}

		public static string Eliminar(int idProducto)
		{
			DProducto dProd = new DProducto();
			dProd.TextoBuscar = textBuscar;
			return dProd.ConsultarNombre(dProd);
		}
	}
}

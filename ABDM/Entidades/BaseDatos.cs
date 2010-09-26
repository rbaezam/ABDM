using System;
namespace ABDM
{
	public class BaseDatos
	{
		public BaseDatos ()
		{
		}
		
		public string Nombre { get; set; }
		public string Usuario { get; set; }
		public string Contraseña { get; set; }
		public string Descripcion { get; set; }
		public Conexion Conexion { get; set; }
	}
}


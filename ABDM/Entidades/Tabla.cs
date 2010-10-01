using System;
namespace ABDM
{
	public class Tabla
	{
		public Tabla ()
		{
		}
		
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public TipoTabla Tipo { get; set; }
		public FormatoRegistro Formato { get; set; } // row_format
		public int MinimoFilas { get; set; } // Min Rows
		public int MaximoFilas { get; set; } // Max Rows
		public int ValorAutoincremento { get; set; } // Auto Increment Value
		public int PromedioLongitudFila { get; set; } // Avarage Row Length
		public bool SumaChequeo { get; set; } // Check Sum
		public bool RetrasarEscrituraLlaves { get; set; } // Delay Key Write
		public bool EmpaquetarLlaves { get; set; } // Pack Keys
		public bool Temporal { get; set; } // Temporary
		public ConjuntoCaracteres Conjunto { get; set; } // Character Set
		public Colacion Colacion { get; set; } // Collation
		public string DirectorioDatos { get; set; } // Data Directory
		public string DirectorioIndice { get; set; } // Index Directory
		public MetodoInsercion MetodoInsercion { get; set; } // Insert Method
	}
}


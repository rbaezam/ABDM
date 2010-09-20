using System;
using Gtk;

namespace ABDM
{
	class Principal
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			VenPrincipal venPrincipal = new VenPrincipal ();
			venPrincipal.Show ();
			Application.Run ();
		}
	}
}


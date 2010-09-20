using System;
using Gtk;

using ABDM.Ayuda;

public partial class VenPrincipal : Gtk.Window
{
	public VenPrincipal () : base(Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected virtual void OnAcercaDeActionActivated (object sender, System.EventArgs e)
	{
		DlgAcercaDe dlgAcercaDe = new DlgAcercaDe();
		dlgAcercaDe.Show();
	}
	
	
}


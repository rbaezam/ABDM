using System;
using Pango;

namespace ABDM.Ayuda
{
	public partial class DlgAcercaDe : Gtk.Dialog
	{
		protected virtual void OnFrameEvent (object o, Gtk.FrameEventArgs args)
		{
		}
		
		
		public DlgAcercaDe ()
		{
			this.Build ();
			
			FontDescription fd = Style.FontDescription.Copy();
			fd.Size = (fd.Size*30) / 10;
			lblTitulo1.ModifyFont(fd);

		}
		protected virtual void OnBtnAceptarClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		
	}
}


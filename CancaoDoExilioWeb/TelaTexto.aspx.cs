using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CancaoDoExilio;

namespace CancaoDoExilioWeb
{
	public partial class TelaTexto : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            Texto.Text = Program.GerarPrimeiraEstrofe(new Terra(),true);
            Texto.Text += Program.GerarSegundaEstrofe(new Terra(),true);
            Texto.Text += Program.GerarTerceiraEstrofe(new Terra(),true);
            Texto.Text += Program.GerarQuartaEstrofe(new Terra(),true);
            Texto.Text += Program.GerarQuintaEstrofe(new Terra(),true);

            Texto.Style.Add(HtmlTextWriterStyle.FontFamily,"Courier");
            Texto.Style.Add(HtmlTextWriterStyle.FontWeight,"bold");

        }
	}
}
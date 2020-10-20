using System;
using pruebaAPI.Clases;
using System.Web.UI;

namespace pruebaAPI.Forms
{
    public partial class OuputJson : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conexion file = new Conexion();
            Tuple<string, string> response = file.Get();

            this.salida.InnerText = response.Item1;
        }
    }
}
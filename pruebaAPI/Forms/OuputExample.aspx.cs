using pruebaAPI.Clases;
using System;
using System.Web.UI;

namespace pruebaAPI.Forms
{
    public partial class OuputExample : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conexion file = new Conexion();
            Tuple<string, string> response = file.Get();
            this.printTable.InnerHtml = response.Item2;
        }
    }
}
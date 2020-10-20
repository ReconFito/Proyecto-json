using System;
using System.Web.UI;
using pruebaAPI.Clases;

namespace pruebaAPI
{
    public partial class JsonFormat : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conexion file = new Conexion();
            Tuple<string, string> response = file.Get();
            this.salida.InnerText = response.Item1;
            this.printTable.InnerHtml = response.Item2;
        }
    }
}
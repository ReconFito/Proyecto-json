using pruebaAPI.Clases;
using System;


namespace pruebaAPI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected async void Respuesta(object sender, EventArgs e)
        {
            Coneccion api = new Coneccion();
            var respuesta = await api.Get();
            string json = respuesta[2].ToString();

            this.salida.InnerText = json;
        }
    }
}
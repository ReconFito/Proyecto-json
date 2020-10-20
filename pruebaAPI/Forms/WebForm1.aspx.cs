using pruebaAPI.Clases;
using System;
using System.Threading.Tasks;

namespace pruebaAPI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Conexion api;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ApiResponse(object sender, EventArgs e)
        {
            // Espera al resultado de la llamada a API.
            var response = ConectionStart();

            // Nombre de la API.
            //string userApiName = this.txtnameApi.Value;
            //string apiName = (string.IsNullOrEmpty(userApiName)) ? "Countries Information" : userApiName;
            //this.apiName.InnerHtml = $"&nbsp;&#91{apiName}&#93";

            // Texto de salida.
            this.salida.InnerText = response.Item1;
        }
        protected void JsonExample(object sender, EventArgs e)
        {
            // Espera al resultado de la llamada a API.
            var response = ConectionStart();

            // Nombre de la API a conectarse.
            //string apiName = this.txtnameApi.Value;
            //this.apiName.InnerHtml = $"&nbsp;&#91{apiName}&#93";

            // Imprimir los datos solicitados a la API por defecto.
            this.printTable.InnerHtml = response.Item2;

        }

        Tuple<string, string> ConectionStart()
        {
            api = new Conexion();
            var response = api.Get();

            return response;
        }

    }
}
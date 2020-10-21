using System;
using Newtonsoft.Json;
using System.IO;


namespace pruebaAPI.Clases
{
    public class Conexion
    {
        public string path;
        public string fronteras { get; set; }

        public Conexion()
        {
            // Validar valor de entrada del usuario.
            this.path = @"C:\Users\Emanuel\Desktop\III_Cuatrimestre\Programacion_V\FormatoJSON\pruebaAPI\pruebaAPI\Clases\json.txt";
            this.fronteras = "";
        }

        /// <summary>
        /// Leer el contenido del archivo .json
        /// </summary>
        /// <returns>Texto en json con formato.</returns>
        public Tuple<string, string> Get()
        {
            string jsonFile = File.ReadAllText(path);

            var infoCountries = JsonConvert.DeserializeObject<CountryInformation[]>(jsonFile);
            var json = JsonConvert.SerializeObject(infoCountries, Formatting.Indented);

            string card = GetCountriesInfo(infoCountries);
            var countriesJson = Tuple.Create(json, CountryCardStructure(card));

            return countriesJson;
        }

        /// <summary>
        /// Tomar datos de la API.
        /// </summary>
        /// <param name="_countries"></param>
        /// <returns>Cadena de texto que contiene formato HTML</returns>
        public string GetCountriesInfo(CountryInformation[] _countries)
        {
            string bordes = "";
            string simbolo = "";
            string nombre = "";
            string codigo = "";
            foreach (var countries in _countries) // Itera a travez de clases.
            {
                bordes = "";
                simbolo = "";
                nombre = "";
                codigo = "";
                this.fronteras += "<tr>" +
                                    $"<td class='align-middle'>{countries.name}</td>" +
                                    $"<td class='align-middle'>{countries.capital}</td>";
                foreach (var frontera in countries.borders)
                {
                    bordes += frontera + "<br/>";
                }
                foreach (var moneda in countries.currencies)
                {
                    nombre += moneda.name + "<br/>";
                    codigo += moneda.code + "<br/>";
                    simbolo += moneda.symbol + "<br/>";
                }
                this.fronteras += $"<td class='align-middle'>{bordes}</td>" +
                    $"<td class='align-middle'>{codigo}</td>" +
                    $"<td class='align-middle'>{nombre}</td>" +
                    $"<td class='align-middle'>{simbolo}</td>";
                this.fronteras += "</tr>";
            }
            return fronteras;
        }

        /// <summary>
        /// Este método se encarga de crear la estructura HTML
        /// necesaria para imprimir los datos.
        /// </summary>
        /// <returns>Cadena con formato HTML</returns> 
        public string CountryCardStructure(string _fronteras)
        {
            string card = "<table class='table table-bordered'>" +
                                "<thead class='bg-dark shadow'>" +
                                    "<tr class='text-white'>" +
                                        "<th class='align-middle' rowspan='2'>Nombre</th>" +
                                        "<th class='align-middle' rowspan='2'>Capital</th>" +
                                        "<th class='align-middle' rowspan='2'>Fronteras</th>" +
                                        "<th class='text-center' colspan='3'>Tipo de moneda</th>" +
                                    "</tr>" +
                                    "<tr class='text-white'>" +
                                        "<th class='text-center'>Código</th>" +
                                        "<th class='text-center'>Nombre</th>" +
                                        "<th class='text-center'>Simbolo</th>" +
                                    "</tr>" +
                                "</thead>" +
                                "<tbody>" +
                                    $"{_fronteras}" +
                                "</tbody>" +
                        "</table>";
            return card;
        }
    }
}
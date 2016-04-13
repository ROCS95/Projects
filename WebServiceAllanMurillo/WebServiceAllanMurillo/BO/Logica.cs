using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WebServiceAllanMurillo.WSBanco;

namespace WebServiceAllanMurillo.BO
{
    public class Logica
    {
        public Decimal TipoCambio { get; set; }

        public Decimal ToColones(Decimal dolares)
        {
            return Math.Round(Decimal.Multiply(dolares, TipoCambio),2);
        }

        public Decimal ToDolares(Decimal colones)
        {
            return Math.Round(Decimal.Divide(colones, TipoCambio),2);
        }

        public void ConsultarTipoCambio()
        {
            try
            {
                wsIndicadoresEconomicosSoapClient ws = new wsIndicadoresEconomicosSoapClient("wsIndicadoresEconomicosSoap");
                string resultado = ws.ObtenerIndicadoresEconomicosXML("318", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString(), "Allan Murillo", "N");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(resultado);
                XmlNodeList elemList = doc.GetElementsByTagName("NUM_VALOR");
                foreach (XmlNode item in elemList)
                {
                    Console.WriteLine(item.InnerText);
                    NumberFormatInfo nfi = new CultureInfo("es-cr", false).NumberFormat;
                    nfi.NumberDecimalSeparator = ".";
                    TipoCambio = Decimal.Parse(item.InnerText, nfi);
                }
            }
            catch (Exception)
            {
                throw new Exception("El servicio del BCCR no esta disponible\n");
            }
        }

    }
}

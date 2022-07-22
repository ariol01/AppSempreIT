using System;
using System.Globalization;

namespace AppSempreIT.Models.Helpers
{
    public static class ConverterDataParaCulturaBrasileira
    {
        public static DateTime Executar(DateTime data)
        {
            CultureInfo idioma = new CultureInfo("pt-BR");
            var dateTime = Convert.ToDateTime(data.ToString("D",idioma));
            return dateTime;
        }
    }
}

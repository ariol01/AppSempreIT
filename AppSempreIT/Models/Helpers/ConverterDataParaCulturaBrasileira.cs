using System;
using System.Globalization;

namespace AppSempreIT.Models.Helpers
{
    public static class ConverterDataParaCulturaBrasileira
    {
        public static string Executar(string data)
        {
            var dateTime = Convert.ToDateTime(data);
            return dateTime.ToLongDateString();
        }
    }
}

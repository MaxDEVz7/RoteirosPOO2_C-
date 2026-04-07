namespace MinhaBiblioteca
{
    public class Calculadora
    {

        public double converterCelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public double converterMetrosParaKilometros(double metros)
        {
            return metros / 1000;
        }

        public double converterReaisParaDolares(double reais, double taxaCambio)
        {
            return reais / taxaCambio;
        }

        public double converterHorasParaMinutos(double horas) // Meu metodo de conversão de horas para minutos para utilização da dll 
        {
            return horas * 60;
        } 
    }
}
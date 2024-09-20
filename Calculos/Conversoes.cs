namespace Calculos
{
	/// <summary>
    /// Conversão de temperaturas.
    /// </summary>
	/// <summary>
	/// Tipo de conversão de temperatura a executar.
	/// </summary>
	
	public enum ConversaoTemperatura
		{
			Nulo = 0,
			CelsiusFahrenheit,
			FahrenheitCelsius
		}		
		
		/// <summary>
		/// Operação soma.
		/// </summary>
		/// <returns>Retorna a soma de dois números.</returns>
	internal static class Conversoes
	{
    /// <param name="conversao">A conversão a efetuar.</param>
    /// <param name="temperatura">A temperatua a converter.</param>
    /// <returns>Retorna o resultado da conversão da temperatura.</returns>

		public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
		{
			if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
			{
				return (temperatura * 1.8000 + 32);
			}
			else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
			{
				return ((temperatura - 32) / 1.8000);
			}

			return -1;
		}
	
		
	}
	
}
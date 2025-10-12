namespace Bank.Domain
{
    /// <summary>
    /// Implementación concreta de tarjeta de crédito tipo MoneyBack.
    /// Representa un producto específico en el patrón Factory, ofreciendo beneficios de devolución de dinero.
    /// </summary>
    public class MoneyBack : ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta MoneyBack.
        /// </summary>
        /// <returns>El string "MoneyBack" identificando este tipo de tarjeta.</returns>
        public string GetCardType()
        {
            return "MoneyBack";
        }
        
        /// <summary>
        /// Obtiene el límite de crédito para tarjetas MoneyBack.
        /// </summary>
        /// <returns>Límite de crédito de $15,000.</returns>
        public int GetCreditLimit()
        {
            return 15000;
        }
        
        /// <summary>
        /// Obtiene el cargo anual para tarjetas MoneyBack.
        /// </summary>
        /// <returns>Cargo anual de $500.</returns>
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
namespace Bank.Domain
{
    /// <summary>
    /// Implementación concreta de tarjeta de crédito tipo Platinum Plus.
    /// Representa un producto premium en el patrón Factory, ofreciendo el mayor límite de crédito y beneficios exclusivos.
    /// </summary>
    public class Platinum : ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta Platinum Plus.
        /// </summary>
        /// <returns>El string "Platinum Plus" identificando este tipo de tarjeta premium.</returns>
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        
        /// <summary>
        /// Obtiene el límite de crédito para tarjetas Platinum Plus.
        /// </summary>
        /// <returns>Límite de crédito de $35,000.</returns>
        public int GetCreditLimit()
        {
            return 35000;
        }
        
        /// <summary>
        /// Obtiene el cargo anual para tarjetas Platinum Plus.
        /// </summary>
        /// <returns>Cargo anual de $2,000.</returns>
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
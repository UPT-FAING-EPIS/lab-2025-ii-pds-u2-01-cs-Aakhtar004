namespace Bank.Domain
{
    /// <summary>
    /// Implementación concreta de tarjeta de crédito tipo Titanium Edge.
    /// Representa un producto de gama media-alta en el patrón Factory, ofreciendo características avanzadas y durabilidad.
    /// </summary>
    public class Titanium : ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta Titanium Edge.
        /// </summary>
        /// <returns>El string "Titanium Edge" identificando este tipo de tarjeta de alta gama.</returns>
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        
        /// <summary>
        /// Obtiene el límite de crédito para tarjetas Titanium Edge.
        /// </summary>
        /// <returns>Límite de crédito de $25,000.</returns>
        public int GetCreditLimit()
        {
            return 25000;
        }
        
        /// <summary>
        /// Obtiene el cargo anual para tarjetas Titanium Edge.
        /// </summary>
        /// <returns>Cargo anual de $1,500.</returns>
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
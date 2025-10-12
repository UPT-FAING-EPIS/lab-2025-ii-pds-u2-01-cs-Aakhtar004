namespace Bank.Domain
{
    /// <summary>
    /// Interfaz que define el contrato para las tarjetas de crédito del sistema bancario.
    /// Implementa el patrón Product en el contexto de los patrones Factory y Factory Method.
    /// </summary>
    public interface ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta de crédito.
        /// </summary>
        /// <returns>El nombre del tipo de tarjeta como string.</returns>
        string GetCardType();
        
        /// <summary>
        /// Obtiene el límite de crédito disponible para la tarjeta.
        /// </summary>
        /// <returns>El límite de crédito como valor entero.</returns>
        int GetCreditLimit();
        
        /// <summary>
        /// Obtiene el cargo anual asociado a la tarjeta de crédito.
        /// </summary>
        /// <returns>El cargo anual como valor entero.</returns>
        int GetAnnualCharge();
    }
}
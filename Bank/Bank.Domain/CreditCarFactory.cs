namespace Bank.Domain
{
    /// <summary>
    /// Implementación del patrón Factory para la creación centralizada de tarjetas de crédito.
    /// Esta clase encapsula la lógica de instanciación de productos concretos basándose en el tipo solicitado.
    /// </summary>
    public class CreditCardFactory
    {
        /// <summary>
        /// Método estático que crea instancias de tarjetas de crédito basado en el tipo especificado.
        /// Implementa el patrón Factory proporcionando una interfaz común para la creación de objetos.
        /// </summary>
        /// <param name="cardType">El tipo de tarjeta de crédito a crear. Valores válidos: "MoneyBack", "Titanium", "Platinum".</param>
        /// <returns>Una instancia de ICreditCard del tipo especificado, o null si el tipo no es reconocido.</returns>
        /// <example>
        /// <code>
        /// ICreditCard card = CreditCardFactory.GetCreditCard("MoneyBack");
        /// </code>
        /// </example>
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard? cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails; 
        }
    }
}
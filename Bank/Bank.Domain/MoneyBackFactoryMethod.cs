namespace Bank.Domain
{
    /// <summary>
    /// Implementación concreta del Factory Method para crear tarjetas MoneyBack.
    /// Especializa el proceso de creación para productos MoneyBack específicos.
    /// </summary>
    public class MoneyBackFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Implementa el Factory Method para crear instancias de tarjetas MoneyBack.
        /// </summary>
        /// <returns>Una nueva instancia de MoneyBack.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}
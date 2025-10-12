namespace Bank.Domain
{
    /// <summary>
    /// Implementación concreta del Factory Method para crear tarjetas Titanium Edge.
    /// Especializa el proceso de creación para productos Titanium de gama media-alta.
    /// </summary>
    public class TitaniumFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Implementa el Factory Method para crear instancias de tarjetas Titanium Edge.
        /// </summary>
        /// <returns>Una nueva instancia de Titanium.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}
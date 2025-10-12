namespace Bank.Domain
{
    /// <summary>
    /// Implementación concreta del Factory Method para crear tarjetas Platinum Plus.
    /// Especializa el proceso de creación para productos Platinum de alta gama.
    /// </summary>
    public class PlatinumFactoryMethod: CreditCardFactoryMethod
    {
        /// <summary>
        /// Implementa el Factory Method para crear instancias de tarjetas Platinum Plus.
        /// </summary>
        /// <returns>Una nueva instancia de Platinum.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}
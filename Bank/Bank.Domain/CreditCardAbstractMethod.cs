namespace Bank.Domain
{
    /// <summary>
    /// Clase abstracta que implementa el patrón Factory Method para la creación de tarjetas de crédito.
    /// Define la estructura del algoritmo de creación, delegando la instanciación específica a las subclases.
    /// </summary>
    public abstract class CreditCardFactoryMethod
    {
        /// <summary>
        /// Método abstracto que debe ser implementado por las clases derivadas para crear productos específicos.
        /// Este es el "Factory Method" que cada subclase debe personalizar según el tipo de tarjeta.
        /// </summary>
        /// <returns>Una instancia concreta de ICreditCard.</returns>
        protected abstract ICreditCard MakeProduct();
        
        /// <summary>
        /// Método público que utiliza el Factory Method para crear y retornar productos.
        /// La responsabilidad principal del Creator no es crear productos, sino contener lógica de negocio central
        /// que depende de los objetos Product retornados por el factory method.
        /// </summary>
        /// <returns>Una instancia de ICreditCard creada por el método factory específico de la subclase.</returns>
        /// <example>
        /// <code>
        /// CreditCardFactoryMethod factory = new MoneyBackFactoryMethod();
        /// ICreditCard card = factory.CreateProduct();
        /// </code>
        /// </example>
        public ICreditCard CreateProduct()
        {
            // Llama al MakeProduct que creará y retornará el objeto apropiado
            ICreditCard creditCard = this.MakeProduct();
            // Retorna el objeto al cliente
            return creditCard;
        }
    }
}
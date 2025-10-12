using Bank.Domain;
using NUnit.Framework;

namespace Bank.Domain.Tests
{
    /// <summary>
    /// Clase de pruebas para validar la funcionalidad de los patrones Factory y Factory Method
    /// en la creación de tarjetas de crédito.
    /// </summary>
    public class CreditCardTests
    {
        /// <summary>
        /// Prueba que valida la creación de tarjeta MoneyBack usando el patrón Factory.
        /// </summary>
        [Test]
        public void GivenCreditTypeSelected_WhenRequestCreditCard_ThenNewValidCreditCard()
        {
            // Arrange
            string cardType = "MoneyBack";
            
            // Act
            ICreditCard? cardDetails = CreditCardFactory.GetCreditCard(cardType);
            
            // Assert
            Assert.IsNotNull(cardDetails);
            Assert.IsNotEmpty(cardDetails.GetCardType());
            Assert.GreaterOrEqual(cardDetails.GetCreditLimit(), 0);
            Assert.GreaterOrEqual(cardDetails.GetAnnualCharge(), 0);
        }

        /// <summary>
        /// Prueba que valida la creación de tarjeta MoneyBack usando el patrón Factory Method.
        /// </summary>
        [Test]
        public void GivenCreditTypeMoneyBackChoosen_WhenRequestCreditCard_ThenNewValidCreditCard()
        {
            // Arrange & Act
            ICreditCard creditCard = new MoneyBackFactoryMethod().CreateProduct();
            
            // Assert
            Assert.IsNotNull(creditCard);
            Assert.IsNotEmpty(creditCard.GetCardType());
            Assert.AreEqual("MoneyBack", creditCard.GetCardType());
            Assert.AreEqual(15000, creditCard.GetCreditLimit());
            Assert.AreEqual(500, creditCard.GetAnnualCharge());
        }

        /// <summary>
        /// Prueba que valida la creación de tarjeta Platinum usando el patrón Factory Method.
        /// </summary>
        [Test]
        public void GivenCreditTypePlatinumChoosen_WhenRequestCreditCard_ThenNewValidCreditCard()
        {
            // Arrange & Act
            ICreditCard creditCard = new PlatinumFactoryMethod().CreateProduct();
            
            // Assert
            Assert.IsNotNull(creditCard);
            Assert.IsNotEmpty(creditCard.GetCardType());
            Assert.AreEqual("Platinum Plus", creditCard.GetCardType());
            Assert.AreEqual(35000, creditCard.GetCreditLimit());
            Assert.AreEqual(2000, creditCard.GetAnnualCharge());
        }

        /// <summary>
        /// Prueba que valida la creación de tarjeta Titanium usando el patrón Factory Method.
        /// </summary>
        [Test]
        public void GivenCreditTypeTitaniumChoosen_WhenRequestCreditCard_ThenNewValidCreditCard()
        {
            // Arrange & Act
            ICreditCard creditCard = new TitaniumFactoryMethod().CreateProduct();
            
            // Assert
            Assert.IsNotNull(creditCard);
            Assert.IsNotEmpty(creditCard.GetCardType());
            Assert.AreEqual("Titanium Edge", creditCard.GetCardType());
            Assert.AreEqual(25000, creditCard.GetCreditLimit());
            Assert.AreEqual(1500, creditCard.GetAnnualCharge());
        }

        /// <summary>
        /// Prueba que valida todos los tipos de tarjetas usando el patrón Factory.
        /// </summary>
        [Test]
        public void GivenAllCreditTypes_WhenRequestCreditCard_ThenNewValidCreditCards()
        {
            // Test MoneyBack
            ICreditCard? moneyBack = CreditCardFactory.GetCreditCard("MoneyBack");
            Assert.IsNotNull(moneyBack);
            Assert.AreEqual("MoneyBack", moneyBack.GetCardType());

            // Test Titanium
            ICreditCard? titanium = CreditCardFactory.GetCreditCard("Titanium");
            Assert.IsNotNull(titanium);
            Assert.AreEqual("Titanium Edge", titanium.GetCardType());

            // Test Platinum
            ICreditCard? platinum = CreditCardFactory.GetCreditCard("Platinum");
            Assert.IsNotNull(platinum);
            Assert.AreEqual("Platinum Plus", platinum.GetCardType());
        }
    }
}
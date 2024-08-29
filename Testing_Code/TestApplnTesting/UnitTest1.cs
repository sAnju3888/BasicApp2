

using CustOrdLib;

namespace TestApplnTesting
    {
    public class Tests
        {

        [Test]
        public void When_Premium_Expect_10PercentDiscount()
            {
            //Arrange
            Customer premiumCustomer = new Customer
                {
                CustomerId = 1,
                CustomerName = "George",
                CustomerType = CustomerType.Premium
                };

            Order order = new Order
                {
                OrderId = 1,
                ProductId = 212,
                ProductQuantity = 1,
                Amount = 150

                };
            CustomerOrder c = new CustomerOrder();

            //Act
            c.ApplyDiscount(premiumCustomer, order);

            //Assert
            Assert.AreEqual(order.Amount, 135);

            }
        }
    }
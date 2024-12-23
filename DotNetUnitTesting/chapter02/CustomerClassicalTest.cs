using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DotNetUnitTesting.chapter02
{
    public class CustomerClassicalTest
    {
        [Fact]
        public void Purchase_succeeds_when_enough_inventory()
        {
            //Arrange
            var store = new Store();
            store.AddInventory(Product.Shampoo, 10);
            var customer = new Customer();

            //Act
            bool success = customer.Purchase(store, Product.Shampoo, 5);

            //Assert
            Assert.True(success);
            Assert.Equal(5, store.GetInventory(Product.Shampoo));

        }

        [Fact]
        public void Purchase_file_when_not_enough_inventory()
        {
            //Arrange
            var store = new Store();
            store.AddInventory(Product.Shampoo, 10);
            var customer = new Customer();

            //Act
            bool succes = customer.Purchase(store, Product.Shampoo, 15);

            //Assert
            Assert.False(succes);
            Assert.Equal(10, store.GetInventory(Product.Shampoo));

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using One.Controllers;
using One.Data;
using One.Models;

namespace OneUnitTest.Controllers
{
    public class CoffeesControllerTests
    {
        [Fact]
        public void Create()
        {
            // Arrange
            var faqs = new List<Coffee>
            {
                new Coffee {Id = 1, Name = "Columbia", Price = 17, Weight = "12 oz", Description = "Coffeeee", RoastLevel = "Medium", Taste = "Sweet", Img = "columbia.png", RoastDate = new DateTime(2020, 9, 20)},
                new Coffee {Id = 2, Name = "Kenya", Price = 15, Weight = "12 oz", Description = "Coffeeee", RoastLevel = "Medium", Taste = "Sweet", Img = "columbia.png", RoastDate = new DateTime(2020, 9, 20)},
            };
        }
    }
}
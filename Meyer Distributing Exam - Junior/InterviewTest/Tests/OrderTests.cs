using InterviewTest.Orders; 
using NUnit.Framework; 
﻿using System;

using System.Collections.Generic; 

namespace InterviewTest.UnitTests
{
    [TestFixture]
    public class OrderTests
    {
        private OrderRepository _orderRepository;

        [SetUp]
        public void Setup()
        {
            _orderRepository = new OrderRepository();
        }

        [Test]
        public void GetAllOrders()
        {
            //Arrange
            Order testOrder = new Order("Order Invoice #1", null);

            //adding the order to the repo
            _orderRepository.Add(testOrder);

            //ACT
            List<IOrder> orders = _orderRepository.Get();

            //ASSERT
            Assert.AreEqual(1, orders.Count);
            Assert.Contains(testOrder, orders);
        }

        [Test]
        public void AddOrderInRepo()
        {
            //Arrange
            Order order = new Order("Order Invoice #1", null);

            //ACT
            _orderRepository.Add(order);

            //ASSERT
            List<IOrder> orders = _orderRepository.Get();
            Assert.Contains(order, orders);
        }
    }
}

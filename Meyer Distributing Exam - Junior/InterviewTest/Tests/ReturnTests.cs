using InterviewTest.Returns; 
using InterviewTest.Orders; 
using NUnit.Framework; 
using System.Collections.Generic; 
﻿using System;

namespace InterviewTest.UnitTests
{
    [TestFixture]
    public class ReturnTests
    {
        private ReturnRepository _returnRepository;

        [SetUp]
        public void Setup()
        {
            _returnRepository = new ReturnRepository();
        }

        [Test]
        public void GetAllReturns()
        {
            // Arrange
            Order testOrder = new Order("Order Invoice #1", null);
            Return returnTestOrder = new Return("Return #1", testOrder);

            //adding the return to the repo
            _returnRepository.Add(returnTestOrder);

            //ACT
            List<IReturn> returns = _returnRepository.Get();

            //ASSERT
            Assert.AreEqual(1, returns.Count);
            Assert.Contains(returnTestOrder, returns);
        }

        [Test]
        public void AddReturnInRepo()
        {
            //Arrange
            Order order = new Order("Order Invoice #1", null);
            Return returnTestOrder = new Return("Return #1", order);

            //ACT
            _returnRepository.Add(returnTestOrder);

            //ASSERT
            List<IReturn> returns = _returnRepository.Get();
            Assert.Contains(returnTestOrder, returns);
        }
    }
}

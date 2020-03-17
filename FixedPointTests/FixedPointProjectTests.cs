using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cuni.Arithmetics.FixedPoint;

namespace FixedPointTests
{
    [TestClass]
    public class FixedPointProjectTests
    {
        //Q8_24 tests

        //Add tests 
        [TestMethod]
        public void AddQ8_24TestBothSmallAndPositive()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(1);
            Fixed<Q8_24> b = new Fixed<Q8_24>(2);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("3",r.ToString());
        }

        [TestMethod]
        public void AddQ8_24TestBothSmallOnePositiveOneNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(1);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-2);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("-1", r.ToString());
        }

        [TestMethod]
        public void AddQ8_24TestBothSmallBothNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-2);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("-3", r.ToString());
        }

        [TestMethod]
        public void AddQ8_24TestUsingBiggerNumberBothPositive()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(1);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("1", r.ToString());
        }

        [TestMethod]
        public void AddQ8_24TestUsingBiggerNumberOnePositiveOneNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("-1", r.ToString());
        }

        [TestMethod]
        public void AddQ8_24TestUsingBiggerNumberBothNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(-256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("-1", r.ToString());
        }

        //Substract
        [TestMethod]
        public void SubstractQ8_24TestBothSmallAndPositive()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(2);
            Fixed<Q8_24> b = new Fixed<Q8_24>(1);
            Fixed<Q8_24> r = a.Substract(b);
            Assert.AreEqual("1", r.ToString());
        }

        [TestMethod]
        public void SubstractQ8_24TestBothSmallOnePositiveOneNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(1);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-2);
            Fixed<Q8_24> r = a.Substract(b);
            Assert.AreEqual("3", r.ToString());
        }

        [TestMethod]
        public void SubstractQ8_24TestBothSmallBothNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-2);
            Fixed<Q8_24> r = a.Substract(b);
            Assert.AreEqual("1", r.ToString());
        }

        [TestMethod]
        public void SubstractQ8_24TestUsingBiggerNumberBothPositive()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(1);
            Fixed<Q8_24> r = a.Substract(b);
            Assert.AreEqual("-1", r.ToString());
        }

        [TestMethod]
        public void SubstractQ8_24TestUsingBiggerNumberOnePositiveOneNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("-1", r.ToString());
        }

        [TestMethod]
        public void SubstractQ8_24TestUsingBiggerNumberBothNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(-256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("-1", r.ToString());
        }

        //Multiply

        [TestMethod]
        public void MultiplyQ8_24TestBothSmallAndPositive()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(2);
            Fixed<Q8_24> b = new Fixed<Q8_24>(2);
            Fixed<Q8_24> r = a.Multiply(b);
            Assert.AreEqual("4", r.ToString());
        }

        [TestMethod]
        public void MultiplyQ8_24TestBothSmallOnePositiveOneNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(1);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-2);
            Fixed<Q8_24> r = a.Multiply(b);
            Assert.AreEqual("-2", r.ToString());
        }

        [TestMethod]
        public void MultiplyQ8_24TestBothSmallBothNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-2);
            Fixed<Q8_24> r = a.Multiply(b);
            Assert.AreEqual("2", r.ToString());
        }

        [TestMethod]
        public void MultiplyQ8_24TestUsingBiggerNumberBothPositive()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(2);
            Fixed<Q8_24> r = a.Multiply(b);
            Assert.AreEqual("0", r.ToString());
        }

        [TestMethod]
        public void MultiplyQ8_24TestUsingBiggerNumberOnePositiveOneNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("-1", r.ToString());
        }

        [TestMethod]
        public void MultiplyQ8_24TestUsingBiggerNumberBothNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(-256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> r = a.Add(b);
            Assert.AreEqual("-1", r.ToString());
        }

        //Division

        [TestMethod]
        public void DivideQ8_24TestBothSmallAndPositive()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(2);
            Fixed<Q8_24> b = new Fixed<Q8_24>(4);
            Fixed<Q8_24> r = a.Divide(b);
            Assert.AreEqual("0.5", r.ToString());
        }

        [TestMethod]
        public void DivideQ8_24TestBothSmallOnePositiveOneNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(1);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-2);
            Fixed<Q8_24> r = a.Divide(b);
            Assert.AreEqual("-0.5", r.ToString());
        }

        [TestMethod]
        public void DivideQ8_24TestBothSmallBothNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-2);
            Fixed<Q8_24> r = a.Divide(b);
            Assert.AreEqual("0.5", r.ToString());
        }

        [TestMethod]
        public void DivideQ8_24TestUsingBiggerNumberBothPositive()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(2);
            Fixed<Q8_24> r = a.Divide(b);
            Assert.AreEqual("0", r.ToString());
        }

        [TestMethod]
        public void DivideQ8_24TestUsingBiggerNumberOnePositiveOneNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(-256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(2);
            Fixed<Q8_24> r = a.Divide(b);
            Assert.AreEqual("0", r.ToString());
        }

        [TestMethod]
        public void DivideQ8_24TestUsingBiggerNumberBothNegative()
        {
            Fixed<Q8_24> a = new Fixed<Q8_24>(-256);
            Fixed<Q8_24> b = new Fixed<Q8_24>(-1);
            Fixed<Q8_24> r = a.Divide(b);
            Assert.AreEqual("0", r.ToString());
        }

        //Q24_8 tests
        //Add tests
        [TestMethod]
        public void AddQ24_8TestBothSmallAndPositive()
        {
            Fixed<Q24_8> a = new Fixed<Q24_8>(1);
            Fixed<Q24_8> b = new Fixed<Q24_8>(2);
            Fixed<Q24_8> r = a.Add(b);
            Assert.AreEqual("3", r.ToString());
        }

        //Q16_16 tests
        //Add tests
        [TestMethod]
        public void AddQ16_16TestBothSmallAndPositive()
        {
            Fixed<Q16_16> a = new Fixed<Q16_16>(1);
            Fixed<Q16_16> b = new Fixed<Q16_16>(2);
            Fixed<Q16_16> r = a.Add(b);
            Assert.AreEqual("3", r.ToString());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab2;
using System.Collections.Generic;

namespace UnitTestLab2ex2
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void AddValue_ShouldAddValueToVector()
        {
            
            var vector = new Vector();
            double valueToAdd = 5.0;

            vector.AddValue(valueToAdd);
            List<double> result = vector.ReturnValue();

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(valueToAdd, result[0]);
        }

        [TestMethod]
        public void OperatorPlus_ShouldCombineVectors()
        {
            
            var vector1 = new Vector();
            vector1.AddValue(1.0);
            vector1.AddValue(2.0);

            var vector2 = new Vector();
            vector2.AddValue(3.0);
            vector2.AddValue(4.0);

            Vector result = vector1 + vector2;

            List<double> expected = new List<double> { 1.0, 2.0, 3.0, 4.0 };
            CollectionAssert.AreEqual(expected, result.ReturnValue());
        }

        [TestMethod]
        public void OperatorGreaterThan_ShouldReturnTrueForLargerVector()
        {
            
            var vector1 = new Vector();
            vector1.AddValue(1.0);
            vector1.AddValue(2.0);

            var vector2 = new Vector();
            vector2.AddValue(3.0);

            bool result = vector1 > vector2;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void OperatorLessThan_ShouldReturnTrueForSmallerVector()
        {
            var vector1 = new Vector();
            vector1.AddValue(1.0);

            var vector2 = new Vector();
            vector2.AddValue(3.0);
            vector2.AddValue(4.0);

            bool result = vector1 < vector2;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void OperatorEqual_ShouldReturnTrueForEqualVectors()
        {
            var vector1 = new Vector();
            vector1.AddValue(1.0);
            vector1.AddValue(2.0);

            var vector2 = new Vector();
            vector2.AddValue(1.0);
            vector2.AddValue(2.0);

            bool result = vector1 == vector2;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void OperatorNotEqual_ShouldReturnTrueForDifferentVectors()
        {
            var vector1 = new Vector();
            vector1.AddValue(1.0);
            vector1.AddValue(2.0);

            var vector2 = new Vector();
            vector2.AddValue(3.0);
            vector2.AddValue(4.0);

            bool result = vector1 != vector2;

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void OperatorMultiply_ShouldMultiplyVectorByScalar()
        {
            var vector = new Vector();
            vector.AddValue(1.0);
            vector.AddValue(2.0);
            double scalar = 2.0;

            Vector result = vector * scalar;

            List<double> expected = new List<double> { 2.0, 4.0 };
            CollectionAssert.AreEqual(expected, result.ReturnValue());
        }

        [TestMethod]
        public void Delete_ShouldRemoveNegativeValues()
        {
            var vector = new Vector();
            vector.AddValue(1.0);
            vector.AddValue(-2.0);
            vector.AddValue(3.0);
            vector.AddValue(-4.0);

            Vector result = Vector.Delete(vector);

            List<double> expected = new List<double> { 1.0, 3.0 };
            CollectionAssert.AreEqual(expected, result.ReturnValue());
        }
    }

}

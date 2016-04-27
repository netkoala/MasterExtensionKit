﻿using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	[TestClass]
	public class IsLessThanOrEqualExtensionsTests
	{
		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_ZERO.IsLessThanOrEqual(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INT_ZERO.IsLessThanOrEqual(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_ZERO.IsLessThanOrEqual(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.INT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_ZERO.IsLessThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_ZERO.IsLessThanOrEqual(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_ZERO.IsLessThanOrEqual(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_POSITIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_ZERO.IsLessThanOrEqual(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_ZERO.IsLessThanOrEqual(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_ZERO.IsLessThanOrEqual(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_POSITIVE_TWO));
		}
	}
}
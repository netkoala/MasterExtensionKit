﻿using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class ToEnumExtensionsUnitTest
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Converter_ToEnum_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Converter_ToEnum_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void String_Converter_ToEnum_IgnoreErrors_Administrator_Valid()
		{
			var expectedResult = TestEnumData.UserType.ADMINISTRATOR;
			var actualResult = "Administrator".ToEnum<TestEnumData.UserType>();
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void String_Converter_ToEnum_IncludeErrors_Administrator_Valid()
		{
			var expectedResult = TestEnumData.UserType.ADMINISTRATOR;
			var actualResult = "Administrator".ToEnum<TestEnumData.UserType>(false);
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void String_Converter_ToEnum_IgnoreErrors_User_Invalid()
		{
			var expectedResult = TestEnumData.UserType.NONE;
			var actualResult = "User".ToEnum<TestEnumData.UserType>();
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		[ExpectedException(typeof(EnumNotFoundFromStringException), "No enum value was found with value: User")]
		public void String_Converter_ToEnum_IncludeErrors_User_Invalid()
		{
			var expectedResult = TestEnumData.UserType.NONE;
			var actualResult = "User".ToEnum<TestEnumData.UserType>(false);
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
﻿using System;
using MasterExtensionKit.Core.Enums.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Enums.Functions
{
	[TestClass]
	public class EnumGuidExtensionsUnitTests
	{
		private const string STRING_GUID = "9EF4F4BE-69E2-4C43-98DD-9531CC721621";
		private readonly Guid _pureGuid = Guid.Parse(STRING_GUID);

		[TestMethod]
		public void EnumGuid_GetGuid_Matches()
		{
			Assert.AreEqual(_pureGuid, TestEnumData.GuidEnum.HasGuid.GetGuid());
		}

		[TestMethod]
		public void EnumGuid_GetEnum_Matches()
		{
			var myEnum = TestEnumData.GuidEnum.EmptyGuid;
			var actualResult = myEnum.GetEnumValue(_pureGuid);
			Assert.AreEqual(TestEnumData.GuidEnum.HasGuid, actualResult);
		}
	}
}
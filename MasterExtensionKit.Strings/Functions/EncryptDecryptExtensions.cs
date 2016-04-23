﻿using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace MasterExtensionKit.Strings.Functions
{
	public static class EncryptDecryptExtensions
	{
		/// <summary>
		///     Encrypts the given string using the provided key
		/// </summary>
		/// <param name="stringToEncrypt"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		public static string Encrypt(this string stringToEncrypt, string key)
		{
			if (string.IsNullOrWhiteSpace(stringToEncrypt))
			{
				throw new ArgumentException("An empty string value cannot be encrypted.");
			}

			if (string.IsNullOrWhiteSpace(key))
			{
				throw new ArgumentException("Cannot encrypt using an empty key. Please supply an encryption key.");
			}

			var cspp = new CspParameters {KeyContainerName = key};

			var rsa = new RSACryptoServiceProvider(cspp) {PersistKeyInCsp = true};

			var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(stringToEncrypt), true);

			return BitConverter.ToString(bytes);
		}

		/// <summary>
		///     Decrypts the given string using the provided key
		/// </summary>
		/// <param name="stringToDecrypt"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		public static string Decrypt(this string stringToDecrypt, string key)
		{
			string result = null;

			if (string.IsNullOrEmpty(stringToDecrypt))
			{
				throw new ArgumentException("An empty string value cannot be decrypted.");
			}

			if (string.IsNullOrEmpty(key))
			{
				throw new ArgumentException("Cannot decrypt using an empty key. Please supply a decryption key.");
			}

			try
			{
				var cspp = new CspParameters {KeyContainerName = key};

				var rsa = new RSACryptoServiceProvider(cspp) {PersistKeyInCsp = true};

				var decryptArray = stringToDecrypt.Split(new[] {"-"}, StringSplitOptions.None);
				var decryptByteArray = Array.ConvertAll(decryptArray, s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber)));

				var bytes = rsa.Decrypt(decryptByteArray, true);

				result = Encoding.UTF8.GetString(bytes);
			}
			finally
			{
				// no need for further processing
			}

			return result;
		}
	}
}
using System;

namespace Extenstion_Method
{
	public static class ExtensionMethods
	{
		public static string UppercaseFirstLetter(this string value)
		{
			if (value.Length > 0)
			{
				char[] array = value.ToCharArray();
				array[0] = char.ToUpper(array[0]);
				return new string(array);
			}
			return value;
		}
	}
	class Program
	{
		static void Main()
		{
			//  
			// Use the string extension method on this value.  
			//  
			string value = Console.ReadLine();
			value = value.UppercaseFirstLetter();
			Console.WriteLine(value);
		}
	}
}

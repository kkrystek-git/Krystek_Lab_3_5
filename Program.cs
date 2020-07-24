using System;
using System.Net.Http;

namespace Krystek_Lab_3_5
{
	class Program
	{
		static void Main(string[] args)
		{
			// Name:	Keith Krystek
			// Date:	07.23.2020
			// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
			//
			// Assignment: Lab 3_5
			// =========================================================================
			//
			//
			// 1.Blacklist = a word to check.
			// 2.message = get content of message.
			// 3.test if the message contains the word.
			// 4.If it contains the word, spam is true.
			// 5.If not, the message is ok to post to the web site.
			//

			// 1.Blacklist = a word to check.
				string blacklistword1 = "pooh";
				string blacklistword2 = "cowpie";

			// 2.message = get content of message.
				Console.WriteLine("Please type in your comment and press 'Enter':\n");
				string message = Console.ReadLine();

			// 3.test if the message contains the word.
				bool isSpam = false;
				if (message.Contains(blacklistword1)||message.Contains(blacklistword2))
			
			// 4.If it contains the word, spam is true.
				{
					isSpam = true;
					Console.WriteLine("\nThis message is SPAM.");
				}
			// 5.If not, the message is ok to post to the web site.
				else
				{
					isSpam = false;
					Console.WriteLine("\nThis message is NOT SPAM. Thanks you for your message.");
				};

			// End

		}
	}
}

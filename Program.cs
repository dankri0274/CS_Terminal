using System;

namespace myProject {
	class Program {
		static void Main(string[] args) {
			Console.Write("> ");
			string? cmd = Console.ReadLine();

			if (cmd == "set passwd") {
				// Get the output from function getPass() and store it in a variable
				//! Error: Cannot implicitly convert type 'void' to 'string'
				string pass = getPass();
				if (pass != null) {
					Console.WriteLine(pass);
				}
				Console.WriteLine(pass);
			}			
		}

		//* Hide input
		static string getPass() {
			string? password = null;
			while (true) {
				var key = Console.ReadKey(true);
				if (key.Key == ConsoleKey.Enter)
					break;
				password += key.KeyChar;
			}
			return;
		}
	}
}
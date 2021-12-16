using System;

namespace myProject {
	class Program {
		static void Main(string[] args) {
			Console.Write("> ");
			string? cmd = Console.ReadLine();

			if (cmd == "password") {
				Console.Write("Password: ");
				string? pass = getPass();
				Console.WriteLine("\n" + pass);
			}			
		}

		//* Hide input
		static string getPass() {
			string? password = "";
			while (true) {
				var key = Console.ReadKey(true);
				if (key.Key == ConsoleKey.Enter)
					break;
				password += key.KeyChar;
			}
			return password;
		}
	}
}

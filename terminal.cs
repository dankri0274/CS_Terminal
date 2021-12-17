using System;
using System.Threading;

namespace myProject {
	class Program {
		static void Main(string[] args) {
			bool creating = true;
			//bool running = false;

			Console.Clear();
			Console.Write("Enter a username: ");
			string? usrname = Console.ReadLine();
			int? usrlength = usrname.Length;

			if (usrlength >= 6) {
				Console.WriteLine("Username creation succeeded");
				Thread.Sleep(1000);
				Console.Clear();

				while (creating) {
					Console.Write("Create password: ");
					string? pwd = getPass();
					int? pwdLength = pwd.Length;

					Console.Clear();

					Console.Write("Confirm password: ");
					string? pwdConfirm = getPass();
					int? pwdcLength = pwdConfirm.Length;

					if (pwd == pwdConfirm && pwdLength >= 8 && pwdcLength >= 8) {
						Console.WriteLine("Password creation succeeded");
						creating = false;
					}
					else if (pwdLength < 8 || pwdcLength < 8) {
						Console.WriteLine("Password must be 8 chars or longer");
						Thread.Sleep(1000);
						Console.Clear();
					}
					else if (pwd != pwdConfirm) {
						Console.WriteLine("Passwords don\'t match");
						Thread.Sleep(1000);
						Console.Clear();
					}
				}
			}
			else {
				Console.WriteLine("Username must have a length of min 6 chars");
			}

		}

		//* Hide input
		public static string getPass() {
			string password = "";
			
			ConsoleKeyInfo info = Console.ReadKey(true);
			while (info.Key != ConsoleKey.Enter) {
				if (info.Key != ConsoleKey.Backspace) {
					Console.Write("*"); /* Enter the character you want the
					password to be masked with
					*/
					password += info.KeyChar;
				}
				else if (info.Key == ConsoleKey.Backspace) {
					if (!string.IsNullOrEmpty(password)) {
						//* remove one character from the list of password characters
						password = password.Substring(0, password.Length - 1);
						//* get the location of the cursor
						int pos = Console.CursorLeft;
						//* move the cursor to the left by one character
						Console.SetCursorPosition(pos - 1, Console.CursorTop);
						//* replace it with space
						Console.Write(" ");
						//* move the cursor to the left by one character again
						Console.SetCursorPosition(pos - 1, Console.CursorTop);
					}
				}
				info = Console.ReadKey(true);
			}
			//* add a new line because user pressed enter at the end of their password
			Console.WriteLine();
			return password;
		}
	}
}

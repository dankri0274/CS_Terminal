using System;
using System.Threading;

namespace myProject {
	class Program {
		static void Main(string[] args) {
			bool creating = true;
			bool running = false;

			Console.Write("Enter a username: ");
			string? usrname = Console.ReadLine();
			int usrlength = usrname.Length;

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
				commandLine();
			}
			else {
				Console.WriteLine("Username must have a length of min 6 chars");
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

		static void commandLine() {
			
		}
	}
}

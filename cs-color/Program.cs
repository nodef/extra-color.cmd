// OCOLOR - Get or set Cursor color in Windows Console
using System;
using System.Collections.Generic;

namespace orez.color {
	class Program {

		/// <summary>
		/// Like a sunflower...
		/// </summary>
		/// <param name="args">Input arguments.</param>
		static void Main(string[] args) {
			// constants
			var clr = new Dictionary<string, string> {
				["black"] = "0", ["darkgray"] = "8",
				["darkblue"] = "1", ["blue"] = "9",
				["darkgreen"] = "2", ["green"] = "10",
				["darkcyan"] = "3", ["cyan"] = "11",
				["darkred"] = "4", ["red"] = "12",
				["darkmagenta"] = "5", ["magenta"] = "13",
				["darkyellow"] = "6", ["yellow"] = "14",
				["gray"] = "7", ["white"] = "15"
			};
			// process input
			var f = (args.Length >= 1 ? args[0] : "+0").ToLower();
			var b = (args.Length >= 2 ? args[1] : "+0").ToLower();
			f = f.Length > 3 ? (clr.ContainsKey(f) ? clr[f] : "7") : f;
			b = b.Length > 3 ? (clr.ContainsKey(b) ? clr[b] : "0") : b;
			var fv = (int)((f[0] == '+' || f[0] == '-' ? Console.ForegroundColor : 0) + int.Parse(f));
			var bv = (int)((b[0] == '+' || b[0] == '-' ? Console.BackgroundColor : 0) + int.Parse(b));
			// get or set color
			if(args.Length == 0) Console.WriteLine(fv + " " + bv);
			else {
				Console.ForegroundColor = (ConsoleColor)((fv < 0 ? 0 : fv) % 16);
				Console.BackgroundColor = (ConsoleColor)((bv < 0 ? 0 : bv) % 16);
			}
		}

		private static IDictionary<string, string> GetColors() {
			return new Dictionary<string, string> {
				["black"] = "0", ["darkgray"] = "8",
				["darkblue"] = "1", ["blue"] = "9",
				["darkgreen"] = "2", ["green"] = "10",
				["darkcyan"] = "3", ["cyan"] = "11",
				["darkred"] = "4", ["red"] = "12",
				["darkmagenta"] = "5", ["magenta"] = "13",
				["darkyellow"] = "6", ["yellow"] = "14",
				["gray"] = "7", ["white"] = "15"
			};
		}
	}
}

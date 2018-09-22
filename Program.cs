// ECOLOR - Get or set Cursor color in Windows Console
using System;
using System.Collections.Generic;

namespace App {
	class Program {

		// data
		/// <summary>
		/// Color dictionary, which matches names with color codes.
		/// </summary>
		private static Dictionary<string, string> CodeMap = new Dictionary<string, string> {
			["black"] = "0", ["darkgray"] = "8",
			["darkblue"] = "1", ["blue"] = "9",
			["darkgreen"] = "2", ["green"] = "10",
			["darkcyan"] = "3", ["cyan"] = "11",
			["darkred"] = "4", ["red"] = "12",
			["darkmagenta"] = "5", ["magenta"] = "13",
			["darkyellow"] = "6", ["yellow"] = "14",
			["gray"] = "7", ["white"] = "15"
		};

		/// <summary>
		/// Like a sunflower...
		/// </summary>
		/// <param name="args">Input arguments.</param>
		static void Main(string[] args) {
			// process input
			var fs = args.Length >= 1 ? args[0] : "";
			var bs = args.Length >= 2 ? args[1] : "";
      var f = GetColor(GetCode(fs, (int)Console.ForegroundColor));
			var b = GetColor(GetCode(bs, (int)Console.BackgroundColor));
			// get or set color
			if(args.Length == 0) Console.WriteLine((int)f + " " + (int)b);
			else { Console.ForegroundColor = f; Console.BackgroundColor = b; }
		}

		/// <summary>
		/// Get color code from specified value string.
		/// Value string can start with a '+' or '-' to indicate change.
		/// </summary>
		/// <param name="val">Color value string (ex- "3", "-2" or "green")</param>
		/// <param name="old">Old color code, which is used as origin for change.</param>
		/// <returns>Integer color code.</returns>
		private static int GetCode(string val, int old) {
			int code = 0;
			val = (val.Length == 0 ? "+0" : val).ToLower();
			val = CodeMap.ContainsKey(val) ? CodeMap[val] : val;
			int.TryParse(val, out code);
			if(val[0] == '+' || val[0] == '-') code += old;
			return code;
		}
		/// <summary>
		/// Get console color from color code.
		/// </summary>
		/// <param name="code">Integer color code.</param>
		/// <returns>Console color.</returns>
		private static ConsoleColor GetColor(int code) {
			return (ConsoleColor)(((uint)code) & 0xF);
		}
	}
}

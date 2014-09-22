using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
 
namespace import111 {
	class Program {
		static void Main(string[] args) {
			if (args.Length != 3) {
				Console.WriteLine("usage: import111 [input_path] [column] [output_path]\n" +
					@"example: import111 \import 32 \output");
				return;
			}
			string path = args[0];
			int column = int.Parse(args[1]);
			string outputDir = args[2];
 
			if (!Directory.Exists(outputDir)) {
				Console.WriteLine("creating " + outputDir);
				Directory.CreateDirectory(outputDir);
			}
 
			foreach (string filepath in Directory.EnumerateFiles(path)) {
				Console.Write(filepath + ": ");
				StreamReader reader = File.OpenText(filepath);
				string outputName = Path.GetFileNameWithoutExtension(filepath) + "_1.csv";
				FileStream writer = File.OpenWrite(Path.Combine(outputDir, outputName));
				string contents = reader.ReadToEnd().TrimEnd(new char[]{'\r', '\n'});
				reader.Close();
				string[] split = contents.Split(new char[]{'|'});
				string outputStr = contents + "|" + split[column - 1] + "|";
				byte[] output = Encoding.UTF8.GetBytes(outputStr);
				writer.Write(output, 0, output.Length);
				writer.Close();
				Console.WriteLine(split[column - 1]);
			}
		}
	}
}

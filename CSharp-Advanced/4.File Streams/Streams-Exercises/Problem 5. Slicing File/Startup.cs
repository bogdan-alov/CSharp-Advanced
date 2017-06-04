using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_5.Slicing_File
{
	class Startup
	{
		static void Main(string[] args)
		{

			var n = int.Parse(Console.ReadLine());
			var sourceFile = Console.ReadLine();
			var destinationDirectory = Console.ReadLine();
			Slice(sourceFile, destinationDirectory, n);
			var files = Directory.GetFiles(destinationDirectory);
			var wantedFiles = new List<string>();
			foreach (var file in files)
			{
				if (file.Contains("Part"))
				{
					wantedFiles.Add(file);
				}
			}
			//Assemble(wantedFiles, destinationDirectory);

		}
		/// <summary>
		/// A method which concatinates some files into one file. The variable "example" is used to take the extension of the files.
		/// </summary>
		/// <param name="files"></param>
		/// <param name="destinationDirectory"></param>
		private static void Assemble(List<string> files, string destinationDirectory)
		{
			var example = files.FirstOrDefault();
			var regex = new Regex(@"([.]\w{1,5})");
			var match = regex.Match(example);
			var extension = match.Groups[1];
			var outputFilePath = destinationDirectory + "assembled" + extension;
			using (var outputStream = File.Create(outputFilePath))
			{
				foreach (var inputFilePath in files)
				{
					using (var inputStream = File.OpenRead(inputFilePath))
					{
						// Buffer size can be passed as the second argument.
						inputStream.CopyTo(outputStream);
					}
					Console.WriteLine("The file {0} has been processed.", inputFilePath);
				}
			}
		}
		/// <summary>
		/// Method which slices a file to N pieces. Use file ../../music.mp3 to complete your tests. 
		/// </summary>
		/// <param name="sourceFile"></param>
		/// <param name="destinationDirectory"></param>
		/// <param name="parts"></param>
		private static void Slice(string sourceFile, string destinationDirectory, int parts)
		{
			string inputFile = sourceFile; // Substitute this with your Input File 
			FileStream fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
			int numberOfFiles = parts;
			int sizeOfEachFile = (int)Math.Ceiling((double)fs.Length / numberOfFiles);
			for (int i = 1; i <= numberOfFiles; i++)
			{

				string extension = Path.GetExtension(inputFile);
				FileStream outputFile = new FileStream(destinationDirectory + "Part-" + $"{i - 1}" + ".gz", FileMode.Create, FileAccess.Write);
				using (var compresser = new GZipStream(outputFile, CompressionMode.Compress))
				{
					int bytesRead = 0;
					byte[] buffer = new byte[sizeOfEachFile];
					if ((bytesRead = fs.Read(buffer, 0, sizeOfEachFile)) > 0)
					{
						compresser.Write(buffer, 0, bytesRead);
					}
				}
				
				outputFile.Close();


			}
			fs.Close();
		}
	}
}


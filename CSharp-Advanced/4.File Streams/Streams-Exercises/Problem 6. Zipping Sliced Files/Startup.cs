using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_6.Zipping_Sliced_Files
{
	class Startup
	{
		static void Main(string[] args)
		{

			var n = int.Parse(Console.ReadLine());
			var sourceFile = Console.ReadLine();
			var destinationDirectory = Console.ReadLine();
			var regex = new Regex(@"([.]\w{1,5})");
			var match = regex.Match(sourceFile);
			var extension = match.Groups[1].Value;
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
			
			Assemble(wantedFiles, destinationDirectory, extension);

		}


		/// <summary>
		/// A method which concatinates some files into one file. The variable "example" is used to take the extension of the files.
		/// </summary>
		/// <param name="files"></param>
		/// <param name="destinationDirectory"></param>
		private static void Assemble(List<string> files, string destinationDirectory, string extension)
		{
			foreach (var inputFile in files)
			{

				var outputFile = destinationDirectory + "assembled" + extension;
				using (var inputStream = new FileStream(inputFile, FileMode.Open))
				{
					using (var compressionStream = new GZipStream(inputStream, CompressionMode.Decompress, false))
					{
						using (var outputStream = new FileStream(outputFile, FileMode.Create))
						{
							byte[] buffer = new byte[4096];
							while (true)
							{
								int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
								if (readBytes == 0)
								{
									break;
								}

								inputStream.CopyTo(outputStream);
							}
						}
					}
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
			using (FileStream fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
			{
				int numberOfFiles = parts;
				int sizeOfEachFile = (int)Math.Ceiling((double)fs.Length / numberOfFiles);
				for (int i = 1; i <= numberOfFiles; i++)
				{

					string extension = Path.GetExtension(inputFile);
					using (FileStream outputFile = new FileStream(destinationDirectory + "Part-" + $"{i - 1}" + ".gz", FileMode.Create, FileAccess.Write))
					{
						using (var compresser = new GZipStream(outputFile, CompressionMode.Compress))
						{
							int bytesRead = 0;
							byte[] buffer = new byte[sizeOfEachFile];
							if ((bytesRead = fs.Read(buffer, 0, sizeOfEachFile)) > 0)
							{
								compresser.Write(buffer, 0, bytesRead);
							}
						}
					}
			}
		}
	}
}
}

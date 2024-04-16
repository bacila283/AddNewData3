using System;
using System.IO;
using System.Text;

namespace AddNewData3
{
	public class FileReader
	{
		public static void ReadFile()
		{
			StringBuilder sb = new StringBuilder();
			using (StreamReader sr = new StreamReader("C:\\Users\\bonda\\OneDrive\\Рабочий стол\\Новый текстовый документ (4).txt"))
			{
				while (sr.ReadLine() != ";")
				{
					var line = sr.ReadLine();
					sb.Append("{\"");
					sb.Append(line.Substring(0, line.IndexOf("|") - 1) + "\", ");
					//sb.Append("\"");
					sb.Append(line.Substring(line.IndexOf("|") + 1) + "},\n");
					
				}
				Console.WriteLine(sb.ToString());
			}
		}
	}
}

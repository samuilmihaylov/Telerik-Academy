namespace _4.Kot___Takoa
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            var lineList = new List<string>();

            for (int i = 0; i < linesCount; i++)
            {
                var line = Console.ReadLine();
                lineList.Add(line);
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lineList.Count; i++)
            {
                if (lineList[i].Contains("//"))
                {
                    lineList.RemoveAt(i);
                }

                if (lineList[i].Contains("/*"))
                {
                    lineList.RemoveAt(i);
                }

                if (lineList[i].Contains("*/"))
                {
                    lineList.RemoveAt(i);
                }

                if (!lineList[i].Contains(@"Console.WriteLine("""))
                {
                    lineList[i] = lineList[i].Replace(" ", string.Empty);
                }

                lineList[i] = lineList[i].Replace(" ", string.Empty);
                lineList[i] = lineList[i].Replace("var", "var ");
                lineList[i] = lineList[i].Replace("namespace", "namespace ");
                lineList[i] = lineList[i].Replace("bool", "bool ");
                lineList[i] = lineList[i].Replace("char", "char ");
                lineList[i] = lineList[i].Replace("<char >", "<char>");
                lineList[i] = lineList[i].Replace("decimal", "decimal ");
                lineList[i] = lineList[i].Replace("<decimal >", "<decimal>");
                lineList[i] = lineList[i].Replace("int", "int ");
                lineList[i] = lineList[i].Replace("int .", "int.");
                lineList[i] = lineList[i].Replace("<int >", "<int>");
                lineList[i] = lineList[i].Replace("new", "new ");
                lineList[i] = lineList[i].Replace("using", "using ");
                lineList[i] = lineList[i].Replace("class", "class ");
                lineList[i] = lineList[i].Replace("static", "static ");
                lineList[i] = lineList[i].Replace("string", "string ");
                lineList[i] = lineList[i].Replace("void", "void ");

                sb.Append(lineList[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

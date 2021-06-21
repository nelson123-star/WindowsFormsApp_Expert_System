using System;
using System.Collections.Generic;
using System.IO;


namespace DataSet
{
    public class skills
    {
        public int Poryadochnost { get; set; }
        public int Knowledge { get; set; }
        public int Improving { get; set; }
        public int Communication { get; set; }
        public int JobInteresting { get; set; }
        public int Responsible { get; set; }
    }
    class DataSet
    {

        public static double[] CsvWriterToArray(int NumOfListRow, string xmlFile)
        {
            List<string> Skills = new List<string>();
            Skills = XmlReader(xmlFile);

            string Stroka = Skills[NumOfListRow];
            double[] inputs = new double[Stroka.Length];
            char[] symbol = Stroka.ToCharArray();

            for (int i = 0; i < Stroka.Length; i++)
            {
                inputs[i] = Char.GetNumericValue(symbol[i]);

            }

            return inputs;
        }
        static List<string> XmlReader(string File)
        {
            List<string> Skills = new List<string>();

            string Stroka;
            using (StreamReader streamReader = new StreamReader(File))
            {
                //foreach (string skill in Skills)
                while (!streamReader.EndOfStream)
                {
                    Stroka = streamReader.ReadLine();
                    Skills.Add(Stroka);
                    //Console.WriteLine(Stroka);
                }
            }
            for (int i = 0; i < Skills.Count; i++)
            {
                Skills[i] = Skills[i].Replace(",", "");
                //Console.WriteLine(Skills[i]);
                //if (i == Skills.Count - 1) Environment.Exit(0);
            }
            return Skills;
        }
        static void XmlWriter(string File, string File2)
        {
            List<skills> Skills = new List<skills>();
            List<skills> SkillsResult = new List<skills>();

            Random random = new Random();
            skills skills = new skills();

            int i = 0;
            while (i < 300)
            {
                Skills.Add(new skills()
                {
                    Poryadochnost = random.Next(0, 1),
                    Knowledge = random.Next(0, 1),
                    Improving = random.Next(0, 1),
                    Communication = random.Next(0, 1),
                    JobInteresting = random.Next(0, 1),
                    Responsible = random.Next(0, 1)
                });

                SkillsResult.Add(new skills()
                {
                    Poryadochnost = digitResult(Skills[i].Poryadochnost),
                    Knowledge = digitResult(Skills[i].Knowledge),
                    Improving = digitResult(Skills[i].Improving),
                    Communication = digitResult(Skills[i].Communication),
                    JobInteresting = digitResult(Skills[i].JobInteresting),
                    Responsible = digitResult(Skills[i].Responsible),
                });
                i++;
            }
            using (StreamWriter streamWriter = new StreamWriter(File, false, System.Text.Encoding.Default))
            {
                foreach (var skill in Skills)
                {
                    streamWriter.Write(skill.Poryadochnost.ToString());
                    streamWriter.Write(skill.Knowledge.ToString());
                    streamWriter.Write(skill.Improving.ToString());
                    streamWriter.Write(skill.Communication.ToString());
                    streamWriter.Write(skill.JobInteresting.ToString());
                    streamWriter.Write(skill.Responsible.ToString());
                    streamWriter.Write("\n");
                }
            }
            using (StreamWriter streamWriter = new StreamWriter(File2, false, System.Text.Encoding.Default))
            {
                foreach (var skill in SkillsResult)
                {
                    streamWriter.Write(skill.Poryadochnost.ToString());
                    streamWriter.Write(skill.Knowledge.ToString());
                    streamWriter.Write(skill.Improving.ToString());
                    streamWriter.Write(skill.Communication.ToString());
                    streamWriter.Write(skill.JobInteresting.ToString());
                    streamWriter.Write(skill.Responsible.ToString());
                    streamWriter.Write("\n");
                }
            }
            //Environment.Exit(0);
        }
        static int digitResult(int number)
        {
            if (number > 5) return 1;
            else return 0;
        }
        static void XMLwriter()
        {
            Random random = new Random();
            List<double> weigths = new List<double>();

            int i = 0;
            while (i < 30)
            {
                weigths.Add(random.NextDouble());
                i++;
            }
            using (StreamWriter streamWriter = new StreamWriter("hidden_layer_memory.xml", false, System.Text.Encoding.UTF8))
            {
                streamWriter.WriteLine("<weigths>");
                foreach (var weigth in weigths)
                {
                    streamWriter.Write("\t" + "<weigth>" + weigth.ToString() + "</weigth>");
                    streamWriter.Write("\n");

                }
                streamWriter.WriteLine("</weigths>");
            }
        }

        //static void Main(string[] args)
        //{
        //    //DataSet.XmlWriter("DataSet.xml", "DataSetResult.xml");
        //    //DataSet.XMLwriter();

        //    Console.ReadKey();
        //}
    }
}

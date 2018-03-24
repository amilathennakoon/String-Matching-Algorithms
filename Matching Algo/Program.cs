using ConsoleTableExt;
using MatchingAlgo;
using MatchingAlgoModels;

using SimMetrics.Net.Metric;
using System;
using System.Data;
using System.Linq;
using static MatchingAlgo.ClassEnum;


namespace Matching_Algo
{
    class Program
    {
        static string fName;
        static string LName;

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter First Name ");
                fName = Console.ReadLine().ToLower();

                Console.WriteLine("Enter Last Name ");
                LName = Console.ReadLine().ToLower();


                ////int word1Score = GenerateScoreValue(word1);
                ////  Console.WriteLine(word1Score);

                //Console.WriteLine("Enter Word 2");
                //string word2 = Console.ReadLine().ToUpper();
                ////int word2Score = GenerateScoreValue(word2);
                //// Console.WriteLine(word2Score);



                //Console.WriteLine(val);



                ConsoleTableBuilder
                   .From(GetRealData())
                    .ExportAndWriteLine();
                // Should_Be_Similar();
                Console.ReadKey();
            }


        }

        static int GenerateScoreValue(string word)
        {
            int val = 0;
            char[] letters = word.ToCharArray();

            foreach (var item in letters)
            {
                object ob = Enum.Parse(typeof(EnumAlpabeticLetters), item.ToString());
                val = val + Convert.ToInt32(ob);
            }

            return val;

        }



        public static int SoundExComparision(Person person)
        {
            string[] Words = new[] { "Spotify", "amal", "Sputfy", "Sputfi" };

            int val = 0;
            //MatchRatingApproach _generator = new MatchRatingApproach();
            //Console.WriteLine(_generator.IsSimilar(Words));

            if (Soundex.For(person.FirstName) == Soundex.For(fName))
            {
                val = val + 1;
            }


            if (Soundex.For(person.LastName) == Soundex.For(LName))
            {
                val = val + 1;
            }
            else
            {
                val = val + 0;
            }
            return val;
        }

        static double FindCosignTotal(Person person)
        {
            CosineSimilarity sim = new CosineSimilarity();
            double fNameval = sim.GetSimilarity(fName, person.FirstName.ToLower());
            double LNameval = sim.GetSimilarity(LName, person.LastName.ToLower());
            double fNameval1 = sim.GetSimilarity(fName, person.LastName.ToLower());
            double LNameval1 = sim.GetSimilarity(LName, person.FirstName.ToLower());

            return fNameval + LNameval + fNameval1 + LNameval1;
        }


        static DataTable GetRealData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Office", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("CoSign_Total", typeof(double));
            table.Columns.Add("Phonotic_Total", typeof(int));

            PatientMatchingContext ctx = new PatientMatchingContext();
            foreach (var item in ctx.Person.ToList())
            {
                table.Rows.Add(item.FirstName, item.LastName, item.CompanyName, item.Address, item.City, item.County, FindCosignTotal(item), SoundExComparision(item));
            }

            DataView dv = table.DefaultView;
            dv.Sort = "CoSign_Total,Phonotic_Total ASC";
            DataTable dt = dv.ToTable();
            dt.Columns.RemoveAt(2);
            return dt;
        }


        static DataTable SampleTableData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Position", typeof(string));
            table.Columns.Add("Office", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Start Date", typeof(DateTime));

            table.Rows.Add("Airi Satou", "Accountant", "Tokyo", 33, new DateTime(2017, 05, 09));
            table.Rows.Add("Angelica Ramos", "Chief Executive Officer (CEO)", "New York", 47, new DateTime(2017, 01, 12));
            table.Rows.Add("Ashton Cox", "Junior Technical Author", "London", 46, new DateTime(2017, 04, 02));
            table.Rows.Add("Bradley Greer", "Software Engineer", "San Francisco", 28, new DateTime(2017, 11, 15));

            return table;
        }
    }
}

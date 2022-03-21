



namespace AdventOfCode2021
{

    class FourSevenSegmentDisplay
    {
        string[] Signalpatterns;
        int[] Outputvalue = new int[4];

        Dictionary<string, int> SignaltoValue = new Dictionary<string, int>();

        string[] Outputsignal;
        public FourSevenSegmentDisplay(string line)
        {

            Signalpatterns = line.Split(" | ")[0].Split(" ").ToArray();
            Outputsignal = line.Split(" | ")[1].Split(" ").ToArray();
            Decode();

        }

        private void Print(IEnumerable<char> set)
        {
            foreach (char c in set)
            {
                Console.Write(c + ",");
            }
            Console.WriteLine();

        }

        private IEnumerable<char> SymmetricDifference(IEnumerable<char> a, IEnumerable<char> b)
        {
            var symmetricDifference = a.Except(b).Union(a.Except(b));

            return symmetricDifference;
        }


        private void Decode()
        {
            //find values , 1 ,4,7,8
            string one = Signalpatterns.Where(i => i.Length == 2).First();
            string seven = Signalpatterns.Where(i => i.Length == 3).First();
            string four = Signalpatterns.Where(i => i.Length == 4).First();
            string eight = Signalpatterns.Where(i => i.Length == 7).First();

            // string nine = one.ToCharArray().Union(seven)


            //find the value 9 -> symmetric difference -> union ; 
            string[] lengthsix = Signalpatterns.Where(i => i.Length == 6).ToArray();

            var x1 = lengthsix[0].ToCharArray().ToHashSet();
            var x2 = lengthsix[1].ToCharArray().ToHashSet();
            var x3 = lengthsix[2].ToCharArray().ToHashSet();

            x1.SymmetricExceptWith(x2);
            x2.SymmetricExceptWith(x3);
            x1.UnionWith(x2);
            // find values 0,6,9
            var six = lengthsix.Where(i => x1.Except(i).Count() > 0).First();
            var fourunionseven = four.ToCharArray().Union(seven.ToCharArray());
            var nine = lengthsix.Where(i => i.ToCharArray().Intersect(fourunionseven).Count() == 2).First();
            var zero = lengthsix.Where(i => i != six || i != nine).First();

            // find values 2,5,3 
            // symmetric difference of six and nine , difference intersect 
            var lengthfive = Signalpatterns.Where(i => i.Length == 5).ToArray();


            var two = lengthfive.Where(i => i == eight.ToCharArray().Except(SymmetricDifference(six.ToCharArray(), nine.ToCharArray())).ToString());







            Print(x1);
            // Print(x2);
            // Print(x3);






        }




    }
    class day8
    {
        static List<string> UseRealData(bool ans)
        {
            if (ans)
            {
                return File.ReadAllLines(@"Day8\data.txt").ToList();
            }

            return File.ReadAllLines(@"Day8\practice.txt").ToList();
        }





        // values 1,4,7,8

        static void Part1(List<string> data)
        {
            int uniquesegmentstotal = 0;   // values 1,4,7,8

            // var desiredvalues = new HashSet<int>();
            // desiredvalues.Add(2);
            // desiredvalues.Add(3);
            // desiredvalues.Add(4);
            // desiredvalues.Add(7);



            foreach (string line in data)
            {
                string[] outputvalue = line.Split(" | ")[1].Split(' ');
                // Console.WriteLine(outputvalue.First());
                // Console.WriteLine(outputvalue.Where(segment => desiredvalues.Contains(segment.Length)).Count());
                uniquesegmentstotal += outputvalue.Where(segment => (segment.Length == 2) || (segment.Length == 3) ||
                (segment.Length == 4) || (segment.Length == 7)).Count();




            }

            Console.WriteLine("Total number of Unique segment values: " + uniquesegmentstotal);

        }

        static void Part2(List<string> data)
        {
            List<FourSevenSegmentDisplay> collection = new List<FourSevenSegmentDisplay>();

            foreach (string line in data)
            {
                FourSevenSegmentDisplay entry = new FourSevenSegmentDisplay(line);

            }


        }


        static void Main()
        {

            var data = UseRealData(false); // false uses practice data

            // Part1(data);

            Part2(data);





        }

    }

}
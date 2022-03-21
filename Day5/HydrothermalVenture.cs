
namespace AdventOfCode2021
{
    class day5
    {
        public string[] Data;

        private string Part;

        private bool Diagonals;
        public Dictionary<string, int> PointCollection;

        public Dictionary<string, int> intersectionpoints;
        public day5(string filename, string part)
        {
            Data = File.ReadAllLines(filename);
            Part = part;
            Diagonals = part.ToLower() == "a" ? false : true;
            PointCollection = new Dictionary<string, int>();
            intersectionpoints = new Dictionary<string, int>();

        }

        private void add(int x, int y)
        {
            string cooardinate = x + "," + y;
            try
            {
                PointCollection.Add(cooardinate, 1);
            }
            catch (ArgumentException)
            {
                // Console.WriteLine(x + "," + y);
                PointCollection[cooardinate] += 1;
            }


        }



        public int run()
        {


            foreach (string line in Data)
            {
                var start_end = line.Split(" -> ");
                // Console.WriteLine(start_end.First() + " " + start_end.Last());
                int x1 = Convert.ToInt32(start_end[0].Split(",")[0]);
                int y1 = Convert.ToInt32(start_end[0].Split(",")[1]);

                int x2 = Convert.ToInt32(start_end[1].Split(",")[0]);
                int y2 = Convert.ToInt32(start_end[1].Split(",")[1]);

                if (x2 != x1 && y2 != y1 && Diagonals)
                {
                    // var xmin = Math.Min(x1,x2);
                    // var ymin = Math.Min(y1,y2);

                    // var xmax = Math.Max(x1,x2);
                    // var ymax  = Math.Max(1,y2);
                    var xincrement = x2 > x1 ? true : false;
                    var yincrement = y2 > y1 ? true : false;


                    var iterations = Math.Abs(y2 - y1);
                    int xtracker = x1;
                    int ytracker = y1;
                    for (int i = 0; i <= iterations; i++)
                    {
                        // if(xtracker > xmax || ytracker > ymax ){
                        // Console.Write("error has occured on iteration " + i );
                        // }
                        // Console.WriteLine(xtracker + " " + ytracker);
                        add(xtracker, ytracker);
                        if (xincrement) { xtracker++; } else { xtracker--; }
                        if (yincrement) { ytracker++; } else { ytracker--; }
                    }


                }
                if (y1 == y2)
                {
                    if (x2 - x1 > 0)
                    {
                        for (int i = x1; i <= x2; i++)
                        {
                            add(i, y1);

                        }

                    }
                    else
                    {
                        for (int i = x1; i >= x2; i--)
                        {
                            add(i, y1);

                        }
                    }
                }

                else if (x1 == x2)
                {
                    if (y2 - y1 > 0)
                    {
                        for (int i = y1; i <= y2; i++)
                        {
                            add(x1, i);

                        }

                    }
                    else
                    {
                        for (int i = y1; i >= y2; i--)
                        {
                            add(x1, i);

                        }
                    }
                }





            }
            intersectionpoints = PointCollection.Where(i => i.Value > 1).ToDictionary(i => i.Key, i => i.Value);
            // Console.WriteLine("List of intersection points: ");
            // foreach (string x in intersectionpoints.Keys)
            // {
            //     Console.WriteLine(x);
            // }

            return intersectionpoints.Count();

        }

        // static void Main()
        // {
        //     // var practiceparta = new day5(@"Day5\practice.txt");
        //     // var parta = new day5(@"Day5\data.txt");
        //     // var solutiona = parta.PartA();
        //     // Console.WriteLine("Number of intersections:" + solutiona);

        //     var practicepartb = new day5(@"Day5\practice.txt", "b");
        //     var parta = new day5(@"Day5\data.txt", "a");
        //     var partb = new day5(@"Day5\data.txt", "b");




        //     Console.WriteLine("Number of intersection points: " + partb.run());

        // }

    }
}
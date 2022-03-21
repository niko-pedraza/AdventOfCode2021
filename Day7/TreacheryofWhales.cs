namespace AdventofCode2021
{

    class day7
    {
        static List<int>? CrabPositions;



        static List<int> UseRealData(bool ans)
        {
            if (ans)
            {
                return File.ReadAllLines(@"Day7\data.txt")[0].Split(",").Select(x => int.Parse(x)).ToList();
            }

            return File.ReadAllLines(@"Day7\practice.txt")[0].Split(",").Select(x => int.Parse(x)).ToList();
        }

        static int FuelCost(int pos)
        {
            return CrabPositions.Select(x => Math.Abs(x - pos)).Sum();
        }

        static int TriangleNumberFormula(int n)
        {
            return (n * (n + 1)) / 2;
        }



        static int FuelCostv2(int pos)
        {
            // Console.WriteLine("For positon " + pos);
            // foreach (int x in CrabPositions)
            // {
            //     Console.WriteLine(TriangleNumberFormula(Math.Abs(x - pos)));
            // }

            int k = CrabPositions.Select(x => TriangleNumberFormula(Math.Abs(x - pos))).Sum();

            // Console.WriteLine(k);
            return k;

        }




        // static void Main()
        // {
        //     CrabPositions = UseRealData(true);
        //     int minimumfuel = 0;

        //     foreach (int val in CrabPositions)
        //     {
        //         if (minimumfuel == 0)
        //         {
        //             minimumfuel = FuelCostv2(val);
        //             // Console.WriteLine(minimumfuel);
        //         }
        //         else
        //         {
        //             int k = FuelCostv2(val);
        //             // Console.WriteLine(k);

        //             minimumfuel = Math.Min(minimumfuel, k);


        //         }

        //     }

        //     Console.Write("Minimum Fuel Cost: " + minimumfuel);



        // }

    }
}


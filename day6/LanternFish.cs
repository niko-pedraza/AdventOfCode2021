
namespace AdventofCode2021
{
    class LanterFish
    {
        public static List<long> fishstate = new List<long>(new long[9]);
        public static string[] PracticeData = File.ReadAllLines(@"C:\Users\Plex\Desktop\AdventofCode2021\day6\practice.txt")[0].Split(",");
        public static string[] FullData = File.ReadAllLines(@"C:\Users\Plex\Desktop\AdventofCode2021\day6\data.txt")[0].Split(",");


        static void StatusPrint(int day)
        {
            Console.WriteLine(day + " |" + String.Join(",", fishstate) + "| " + fishstate.Sum());
        }

        static void Days(int days)
        {
            if (days < 1)
            {
                throw new ArgumentException("Input for days must be greater than 0");
            }
            for (int i = 1; i <= days; i++)
            {
                fishstate = fishstate.Skip(1).Append(fishstate[0]).ToList();
                StatusPrint(i);
                fishstate[7] += fishstate[0];

            }
        }

        // static void Main()
        // {

        //     foreach (string x in FullData)
        //     {
        //         fishstate[int.Parse(x)] += 1;
        //     }

        //     StatusPrint(0);
        //     Days(256);





        // }

    }

}





// class FrankieLanternFish
// {

//     public static List<int> DecrementNum(List<int> data)
//     {
//         data = CheckforZeros(data);
//         return data.Select(x => x - 1).ToList();



//     }

//     public static List<int> AppendFish(List<int> data, int fishtoadd)
//     {

//         for (int j = 0; j < fishtoadd; j++)
//         {
//             data.Add(9);
//         }

//         return data;

//     }

//     public static List<int> CheckforZeros(List<int> data)
//     {
//         int zeroCounter = 0;
//         for (int i = 0; i < data.Count; i++)
//         {
//             if (data[i] == 0)
//             {
//                 zeroCounter++;
//                 data[i] = 7;
//             }

//         }

//         var result = AppendFish(data, zeroCounter);
//         // print(result);

//         return result;


//     }

//     public static void print(List<int> data)
//     {
//         foreach (int num in data)
//         {
//             Console.Write(num + ", ");

//         }
//         Console.WriteLine();
//     }
//     static void Main()
//     {
//         var data = File.ReadAllLines(@"day6\data.txt")[0].Split(",").Select(int.Parse).ToList();

//         print(data);
//         for (int i = 0; i < 256; i++)
//         {
//             data = DecrementNum(data);
//             // print(data);
//             // data = CheckforZeros(data);
//             // print(data);
//         }
//         // print(data);
//         Console.WriteLine(data.Count);


//         // Console.WriteLine(data);
//         // foreach (int num in data)
//         // {
//         //     Console.WriteLine(num);
//         // }



//     }


// }
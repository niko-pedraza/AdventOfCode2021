
namespace AdventOfCode2021
{
    class Node{
        
        public int Id;
        public int Value;
        public List<Node> Adjacent;
        
        public static int globalNodeID = -1;

        public Node(int v){
            Id = Interlocked.Increment(ref globalNodeID);
            Value = v;
            Adjacent = new List<Node>();
        }

        public AddEdge(Node to){
            try{
                Adjacent.Add(to);

            }catch(){
                
            }
        }

    }
    class Day9{



        public static void Main(){

        }
    }
}
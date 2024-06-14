namespace BowlingWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] bowlingFrames = new int[10];
            List<int> frames = new List<int>();
            int score = 0;
            int sumScore = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Please enter a Score for frame {i}: ");
                score = Convert.ToInt32(Console.ReadLine());
                
                if (score <= 30)
                {
                    frames.Add(score);
                }
                else
                {
                    Console.WriteLine("That score is not possible please enter a number between 0 and 30");
                    i--;
                }
            }
                foreach (int frame in frames)
                {
                    sumScore += frame;
                } 
                    Console.WriteLine($"Your total score is {sumScore}");            
        }
    }
}
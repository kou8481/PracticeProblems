namespace RecursionFunctions
{
    public class Fibonacci
    {
        public int FindNthNumber(int n)
        {
            if (n == 0)                                 //base condition 1
            {
                return 0;
            }
            
            if (n == 1)                                  //base condition 2
            {
                return 1;
            }

            else
            {
                int recCall1 = FindNthNumber(n - 1);    //recursive call 1
                int recCall2 = FindNthNumber(n - 2);    //recursive call 2

                return recCall1 + recCall2;
            }
        }
    }
} 
//0 1 2 3 4 5 6  7 
//0 1 1 2 3 5 8 13
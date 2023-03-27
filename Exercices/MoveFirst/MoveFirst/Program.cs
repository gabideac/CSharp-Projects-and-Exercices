using System;

namespace MoveFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = ReadValuesList(); //read line + returns int array of first written line
            int[] positionsToMove = ReadPositions(); // read nr of positions(n) + lets user write n numbers, that turn into an array

            for (int i = 0; i < positionsToMove.Length; i++)   
                MoveFirst(values, positionsToMove[i]); //needs to move wrriten nr to first position

            PrintValuesList(values);  // prints the changed list 
            Console.WriteLine(CheckIfSortedAscending(values)); // 
            Console.Read();
        }

        static bool CheckIfSortedAscending(int[] values)
        {
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i-1] > values[i])
                {
                    return false;
                }
            }
                return true;

        }


        static void MoveFirst(  int[] values,  int index)
        {
            for (int i = 0; i <=values.Length; i++)
            {
                if (i == index)
                {
                    int x = values[index];
                    for (int j= index - 1; j>=0; j--)
                    {
                        values[j+1] = values[j]  ;
                    }
                    
                    values[0] = x;
                }

            }
        }
        static int[] ReadPositions()
        {
            int positionsNumber = Convert.ToInt32(Console.ReadLine());
            int[] positions = new int[positionsNumber];

            for (int i = 0; i < positionsNumber; i++)
                positions[i] = Convert.ToInt32(Console.ReadLine());

            return positions;
        }

        static int[] ReadValuesList()
        {
            string[] inputValues = Console.ReadLine().Split(' ');
            int[] values = new int[inputValues.Length];

            for (int i = 0; i < values.Length; i++)
                values[i] = Convert.ToInt32(inputValues[i]);

            return values;
        }

        static void PrintValuesList(int[] valuesList)
        {
            for (int i = 0; i < valuesList.Length; i++)
                Console.Write(valuesList[i] + " ");
            Console.Write('\n');
        }

    }
}
           
                    

                

                


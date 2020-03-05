using System;

namespace Assignment_1_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Net_1_256 = new int[256];
            int[] Net_2_256 = new int[256];
            int[] Net_3_256 = new int[256];

            Net_1_256 = File_Array("Net_1_256.txt");
            Net_2_256 = File_Array("Net_2_256.txt");
            Net_3_256 = File_Array("Net_3_256.txt");
            
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("Which array do you want to analyse (Net_1_256, Net_1_256, Net_1_256): ");
            string input = Console.ReadLine();

            if (input == "Net_1_256")
            {

            }

            else if(input == "Net_2_256")
            {

            }

            else if(input == "Net_3_256")
            {

            }

            else
            {
                Console.WriteLine("Input is incorrect, Try again");
                Menu();
            }
        }
        
        private static int[] File_Array(string FileName)
        {
            int[] numbers = new int[256];
            string line;
            int index = 0;

            System.IO.StreamReader file = new System.IO.StreamReader(FileName);
            while ((line = file.ReadLine()) != null)
            {
                int intline = int.Parse(line);                
                numbers[index] = intline;
                index++;
            }

            return numbers;
        }

        static void ArrayOutput(int[] a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static int[] InsertionSort(int[] data, int n)
        // pre: 0 <= n <= data.length
        // post: values in data[0 … n-1] are in ascending order
        {
            int numSorted = 1; // number of values in place
            int index; // general index
            while (numSorted < n)
            {
                // take the first unsorted value
                int temp = data[numSorted];
                // … and insert it among the sorted
                for (index = numSorted; index > 0; index--)
                {
                    if (temp < data[index - 1])
                    {
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                // reinsert value
                data[index] = temp;
                numSorted++;
            }
        
            return data;
        }
    }
}

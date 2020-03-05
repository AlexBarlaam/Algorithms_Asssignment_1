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
            
            Menu(Net_1_256, Net_2_256, Net_3_256);
        }

        private static void Menu(int[] Net1_256, int[] Net2_256, int[] Net3_256)
        {
            int[] AscendingNet1_256 = new int[256];
            int[] AscendingNet2_256 = new int[256];
            int[] AscendingNet3_256 = new int[256];
            int[] DescendingNet1_256 = new int[256];
            int[] DescendingNet2_256 = new int[256];
            int[] DescendingNet3_256 = new int[256];

            Console.WriteLine("Which array do you want to analyse (Net_1_256, Net_1_256, Net_1_256): ");
            string input = Console.ReadLine();

            if (input == "Net_1_256")
            {
                AscendingNet1_256 = AscendingInsertionSort(Net1_256, Net1_256.Length);
                Console.WriteLine(AscendingNet1_256[9]);

                DescendingNet1_256 = DescendingInsertionSort(Net1_256, Net1_256.Length);
                Console.WriteLine(DescendingNet1_256[9]);
            }

            else if(input == "Net_2_256")
            {
                AscendingNet2_256 = AscendingInsertionSort(Net2_256, Net2_256.Length);
                Console.WriteLine(AscendingNet2_256[9]);

                DescendingNet2_256 = DescendingInsertionSort(Net1_256, Net1_256.Length);
                Console.WriteLine(DescendingNet2_256[9]);
            }

            else if(input == "Net_3_256")
            {
                AscendingNet3_256 = AscendingInsertionSort(Net3_256, Net3_256.Length);
                Console.WriteLine(AscendingNet3_256[9]);

                DescendingNet3_256 = DescendingInsertionSort(Net1_256, Net1_256.Length);
                Console.WriteLine(DescendingNet3_256[9]);
            }

            else
            {
                Console.WriteLine("Input is incorrect, Try again");
                Menu(Net1_256, Net2_256, Net3_256);
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

        private static int[] AscendingInsertionSort(int[] data, int n)
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

        private static int[] DescendingInsertionSort(int[] data, int n)
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
                    if (temp > data[index - 1])
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

using System;
using System.Collections.Generic;

namespace _11___LargestProductInGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            LargestProductInGrid lpg = new LargestProductInGrid();
            int product = lpg.GetProduct(4);


            Console.WriteLine($"Product is {product}");
        }
    }

    public class LargestProductInGrid
    {
        private string s1 = "08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08";
        private string s2 = "49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00";
        private string s3 = "81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65";
        private string s4 = "52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91";
        private string s5 = "22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80";
        private string s6 = "24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50";
        private string s7 = "32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70";
        private string s8 = "67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21";
        private string s9 = "24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72";
        private string s10 = "21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95";
        private string s11 = "78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92";
        private string s12 = "16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57";
        private string s13 = "86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58";
        private string s14 = "19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40";
        private string s15 = "04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66";
        private string s16 = "88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69";
        private string s17 = "04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36";
        private string s18 = "20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16";
        private string s19 = "20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54";
        private string s20 = "01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";

        public int GetProduct(byte Take)
        {
            int product = 0;
            byte[][] grid = this.BuildGrid();
            int HProduct = this.GetHorizontalProduct(grid, Take);
            product = HProduct;
            int VProduct = this.GetVerticalProduct(grid, Take);
            if (VProduct > product)
            {
                product = VProduct;
            }
            int DLProduct = this.GetDiagonalLeftProduct(grid, Take);
            if (DLProduct > product)
            {
                product = DLProduct;
            }
            int DRProduct = this.GetDiagonalRightProduct(grid, Take);
            if (DRProduct > product)
            {
                product = DRProduct;
            }


            return product;
        }

        public int GetHorizontalProduct(byte[][] grid, byte Take)
        {
            Take -= 1;
            int product = 0;
            for (byte hIndex = 0; hIndex <= 19; hIndex++)
            {
                for (byte vIndex = 0; vIndex <= 16; vIndex++)
                {
                    int indexTotal = 1;

                    for (byte index = vIndex; index <= vIndex + Take; index++)
                    {
                        indexTotal *= grid[hIndex][index];
                    }
                    if (product < indexTotal)
                    {
                        product = indexTotal;
                    }
                }
            }

            return product;
        }


        public int GetVerticalProduct(byte[][] grid, byte Take)
        {
            Take -= 1;
            int product = 0;
            for (byte vIndex = 0; vIndex <= 16; vIndex++)
            {
                for (byte hIndex = 0; hIndex <= 19; hIndex++)
                {
                    int indexTotal = 1;

                    for (byte index = vIndex; index <= vIndex + Take; index++)
                    {
                        indexTotal *= grid[index][vIndex];
                    }
                    if (product < indexTotal)
                    {
                        product = indexTotal;
                    }
                }
            }

            return product;
        }

        public int GetDiagonalLeftProduct(byte[][] grid, byte Take)
        {
            Take -= 1;
            int product = 0;
            for (byte vIndex = 0; vIndex <= 16; vIndex++)
            {
                for (byte hIndex = 0; hIndex <= 16; hIndex++)
                {
                    int indexTotal = 1;

                    for (byte index = 0; index <= Take; index++)
                    {
                        indexTotal *= grid[vIndex + index][hIndex + index];
                    }
                    if (product < indexTotal)
                    {
                        product = indexTotal;
                    }
                }
            }

            return product;
        }

        public int GetDiagonalRightProduct(byte[][] grid, byte Take)
        {
            Take -= 1;
            int product = 0;
            for (byte vIndex = 0; vIndex <= 16; vIndex++)
            {
                for (byte hIndex = 19; hIndex >= Take; hIndex--)
                {
                    int indexTotal = 1;

                    for (byte index = 0; index <= Take; index++)
                    {
                        indexTotal *= grid[vIndex + index][hIndex - index];
                    }
                    if (product < indexTotal)
                    {
                        product = indexTotal;
                    }
                }
            }

            return product;
        }





        public byte[][] BuildGrid()
        {
            byte[][] grid = new byte[20][];
            byte[] numbers = this.StringToIntArray(s1);
            grid[0] = numbers;
            numbers = this.StringToIntArray(s2);
            grid[1] = numbers;
            numbers = this.StringToIntArray(s3);
            grid[2] = numbers;
            numbers = this.StringToIntArray(s4);
            grid[3] = numbers;
            numbers = this.StringToIntArray(s5);
            grid[4] = numbers;
            numbers = this.StringToIntArray(s6);
            grid[5] = numbers;
            numbers = this.StringToIntArray(s7);
            grid[6] = numbers;
            numbers = this.StringToIntArray(s8);
            grid[7] = numbers;
            numbers = this.StringToIntArray(s9);
            grid[8] = numbers;
            numbers = this.StringToIntArray(s10);
            grid[9] = numbers;
            numbers = this.StringToIntArray(s11);
            grid[10] = numbers;
            numbers = this.StringToIntArray(s12);
            grid[11] = numbers;
            numbers = this.StringToIntArray(s13);
            grid[12] = numbers;
            numbers = this.StringToIntArray(s14);
            grid[13] = numbers;
            numbers = this.StringToIntArray(s15);
            grid[14] = numbers;
            numbers = this.StringToIntArray(s16);
            grid[15] = numbers;
            numbers = this.StringToIntArray(s17);
            grid[16] = numbers;
            numbers = this.StringToIntArray(s18);
            grid[17] = numbers;
            numbers = this.StringToIntArray(s19);
            grid[18] = numbers;
            numbers = this.StringToIntArray(s20);
            grid[19] = numbers;

            return grid;
        }

        public byte[] StringToIntArray(string Numbers)
        {
            string[] stringArray = Numbers.Split(' ', StringSplitOptions.None);
            byte[] result = new byte[20];
            for (int pos = 0; pos <= stringArray.Length - 1; pos++)
            {
                string sub = stringArray[pos];
                byte parsedNumber;
                if (Byte.TryParse(sub, out parsedNumber))
                {
                    result[pos] = parsedNumber;
                }
            }

            return result;
        }
    }
}

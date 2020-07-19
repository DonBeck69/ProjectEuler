namespace MaxPathSum
{
    public class TriangleData
    {
        private int[][] _triangleData;

        public TriangleData()
        {
            _triangleData = new int[15][];
            _triangleData[0] = new int[] { 75 };
            _triangleData[1] = new int[] { 95, 64 };
            _triangleData[2] = new int[] { 17, 47, 82 };
            _triangleData[3] = new int[] { 18, 35, 87, 10 };
            _triangleData[4] = new int[] { 20, 04, 82, 47, 65 };
            _triangleData[5] = new int[] { 19, 01, 23, 75, 03, 34 };
            _triangleData[6] = new int[] { 88, 02, 77, 73, 07, 63, 67 };
            _triangleData[7] = new int[] { 99, 65, 04, 28, 06, 16, 70, 92 };
            _triangleData[8] = new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 };
            _triangleData[9] = new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 };
            _triangleData[10] = new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 };
            _triangleData[11] = new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 };
            _triangleData[12] = new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 };
            _triangleData[13] = new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 };
            _triangleData[14] = new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 };

        }

        public int[][] Triangle 
        { 
            get => _triangleData;
        }

    }
}

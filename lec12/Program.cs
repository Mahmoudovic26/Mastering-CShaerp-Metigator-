using System;
namespace lec12
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = new IP(192,168,1,1);
            var newip = new IP("192.168.1.1");
            var firstSegment  = ip[0];
            int[,] inputs = new int[,]{
                {9,99,9,5,5,3,3,1,0,5},
                {5,5,5,5,5,5,5,56,6,9},
                {5,6,6,2,51,54,5,59,3,5}
            }; 
            var sudoko = new Sudoko(inputs);
            System.Console.WriteLine(sudoko[0,9]);

            System.Console.WriteLine();
            //System.Console.WriteLine($"IP Address:{newip.Address}");

        }
    }
    public class IP
    {
        private int[] _segments = new int[4];

        public int this[int index]
        {
            get
            {
                return _segments[index];
            }
            set
            {
                _segments[index] = value;
            }
        }

        // Segment 1-255
        public IP(int Segment1,int Segment2,int Segment3,int Segment4)
        {
            _segments[0] = Segment1;
            _segments[1] = Segment2;
            _segments[2] = Segment3;
            _segments[3] = Segment4;

        }
        public IP(string IPAddress)
        {
            var segs = IPAddress.Split(".");
            for (int i = 0; i < segs.Length; i++)
            {
                _segments[i] = Convert.ToInt16(segs[i]);
            }
        }
        public string Address => string.Join(".",_segments);
    }
    public class Sudoko
    {
        private int[,] _matrix;

        public int this[int row, int col]
        {
            get 
            {
                if(row <0 || row >_matrix.GetLength(0)-1)
                    return -1;
                if(col <0 || col > _matrix.GetLength(1)-1)
                    return -1;
                
                return _matrix[row,col];
            }
            set 
            {
                if(value <1 || value >_matrix.GetLength(0)-1)
                    return;

                _matrix[row,col] = value;
            }
        }

        public Sudoko(int[,] matrix)
        {
            _matrix = matrix;
        }

    }
}
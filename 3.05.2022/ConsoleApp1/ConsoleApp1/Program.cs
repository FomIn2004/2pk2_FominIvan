
using System;

namespace pz
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            double[] dob = new double[3];
            char[] qq = { 'H', 'E', 'L' };
            dob[0] = 134523;
            dob[1] = 33454567;
            dob[2] = 4745664;
            char* qwert;
            for (int d = 0; d < dob.Length; d++)
            {
                for (int i = 0; i < sizeof(double); i++)
                {
                    fixed (double* gg = &dob[d])
                    {
                        qwert = (char*)gg;
                        qwert[i] = qq[d];
                        Console.WriteLine(*qwert);
                        Console.ReadKey();

                    }
                }

            }
        }
    }
}
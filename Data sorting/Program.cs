using System;
namespace DataSort
{
    class mainProgram
    {
        public static void Main(string[] arrays){
            int[] arrys =new int[] {10,4,3,8,1,6,7,8,5};
            int temp = 0;

            for (int i = 0; i < arrys.Length; i++)
            {
                for (int j = 0; j < arrys.Length; j++)
                {
                    if (arrys[i] < arrys[j])
                    {
                        temp = arrys[i];
                        arrys[i] = arrys[j];
                        arrys[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arrys.Length; i++)
            {
                System.Console.WriteLine(arrys[i]);
            }
        }
    }
}
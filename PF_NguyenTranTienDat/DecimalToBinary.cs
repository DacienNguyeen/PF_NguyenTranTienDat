using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_NguyenTranTienDat
{
    internal class DecimalToBinary
    {
        static void Main8(string[] args)
        {
            float f = 67.785f;
            string f_string = f.ToString();
            string [] f_string_splitted = f_string.Split(".");
            int[] nums = new int[f_string_splitted.Length];
            for(int i = 0; i< nums.Length; i++)
            {
                nums[i] = int.Parse(f_string_splitted[i]);
            }

            List<int> Binary = new List<int>();
            for(int i = 0;i< nums.Length; i++)
            {
                //67 -> 100011
            }
        }
    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Terminal
    {

        public bool working;

        public void EXIT (){
            working = !working;
        }

        public Dictionary<string, HexNum> MOV(Dictionary<string, HexNum> arr, string firstRegister, string secondRegister)
        {
            
            if (arr.ContainsKey(secondRegister)) {
                arr[firstRegister] = arr[secondRegister];
            }
            else
            {
                //Second register in this else not register but hex number
                arr[firstRegister] = new HexNum(secondRegister);
            }

            
            return arr;
        }

        public Dictionary<string, HexNum> XCHG(Dictionary<string, HexNum> arr, string firstRegister, string secondRegister)
        {
            HexNum temp = arr[firstRegister];
            arr[firstRegister] = arr[secondRegister];
            arr[secondRegister] = temp;
            return arr;
        }

        public void SHOW(Dictionary<string, HexNum> arr)
        {
            Console.WriteLine("### REGISTERS ###");
            foreach (var kvp in arr)
            {
                Console.WriteLine(" ___________________");
                Console.WriteLine($"|{kvp.Key} | {kvp.Value.hexNum.ToUpper()}");

            }
        }

        public void SHOW(string[] arr){
            foreach (var item in arr)
            {
                Console.WriteLine(" ______________________________________");
                Console.WriteLine("| " + item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FibinacciProject {

    class Program {

        void Run1() {
            Random random = new Random();
            for (int idx = 0; idx < 10; idx++) {
                int aRandomNumber = random.Next(1, 11);
                Debug.WriteLine(aRandomNumber);
            }
        }

        void Run() {
            int i = 1;
            int j = 2;
            while(true) {
                var k = i + j;
                i = j;
                j = k;
                if(i > 19000 && j > 19000) {
                    Console.WriteLine(i.ToString() + " and " + j.ToString());
                    Console.ReadKey();
                    break;
                }
            }
        }

        static void Main(string[] args) {
            (new Program()).Run1();
        }
    }
}

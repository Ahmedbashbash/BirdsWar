using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            TheForest theForest = new TheForest();
            theForest.LoadMap("BirdTest1.txt");
            theForest.saveFile();
        }
    }
}

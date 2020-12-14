using System;
using System.Linq;
using System.Text;

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

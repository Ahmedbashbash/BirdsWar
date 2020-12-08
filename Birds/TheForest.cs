using System;
using System.IO;

namespace Birds
{
    class TheForest
    {
        string[,] map;
        int length;
        int birdsNum;
        
        public void LoadMap(string path)
        {
            string[] AllData = File.ReadAllLines(path);
            length = int.Parse(AllData[0].Split(';')[1]);
            map = new string[length, length];
            birdsNum = int.Parse(AllData[0].Split(';')[0]);
            length--;
            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= length; j++)
                {
                    map[i, j] = "";
                }
            }

            for (int i = 1; i <= birdsNum; i++)
            {
                int r = int.Parse(AllData[i].Split(';')[2]);
                int x1 = int.Parse(AllData[i].Split(';')[0]) - r-1;
                int x2 = int.Parse(AllData[i].Split(';')[0]) + r-1;
                int y1 = int.Parse(AllData[i].Split(';')[1]) - r-1;
                int y2 = int.Parse(AllData[i].Split(';')[1]) + r-1;

                if (x1 < 0) x1 = 0;
                if (x2 < 0) x2 = 0;
                if (y1 < 0) y1 = 0;
                if (y2 < 0) y2 = 0;
                if (x1 > length) x1 = length;
                if (x2 > length) x2 = length;
                if (y1 > length) y1 = length;
                if (y2 > length) y2 = length;                


                for (int j = x1; j <= x2; j++)
                {
                    for (int k = y1; k <= y2; k++)
                    {
                        map[j, k] += i;
                    }
                }
            }
        }
        public void saveFile()
        {
            string fileName = "Result.txt";
            string data="";
            int nul = 0;
            int x = 0;
            int y = 0;
            int r = 0;
            int mlen = 0;
            bool[] war = new bool[birdsNum];
            for (int i = 0; i < birdsNum; i++)
            {
                war[i] = false;
            }
            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= length; j++)
                {
                    if (map[i,j]=="")
                    {
                        nul++;
                    }
                    if (map[i,j].Length>mlen)
                    {
                        mlen = map[i, j].Length;
                        x = i + 1;
                        y = j + 1;
                        r = mlen;
                    }
                    for (int k = 0; k < birdsNum; k++)
                    {
                        if (map[i,j].Length > 1 && !war[k] && map[i,j].Contains((k+1).ToString()) )
                        {
                            war[k] = true;
                        }
                    }
                }
            }
            for (int k = 0; k < birdsNum; k++)
            {
                if (!war[k])
                {
                    data += (k + 1) + ";";
                }
            }
            if (data.Length > 0)
            {
                data = data.Substring(0, data.Length - 1);
            }
            data += "\n" + x + ";" + y + ";" + r + "\n" + nul;
            File.WriteAllText(fileName, data);

        }
    }
}

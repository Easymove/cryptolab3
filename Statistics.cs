using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptolab2
{
    class Statistics
    {
        public int[] collectStatArray(string fileName)
        {
            var bytes = File.ReadAllBytes(fileName);
            var stat = new int[16];
            foreach (var block in bytes)
            {
                foreach (var intVal in ExtractValues(block))
                {
                    stat[intVal]++;
                }   
            }
            return stat;
        }

        private int[] ExtractValues(byte block)
        {
            var res = new int[2];
            var bin = Utils.ByteToBoolArray(block);
            res[1] = Utils.ConvertToInt(bin.Take(4).ToArray());
            res[0] = Utils.ConvertToInt(bin.Skip(4).ToArray());
            return res;
        }
    }
}

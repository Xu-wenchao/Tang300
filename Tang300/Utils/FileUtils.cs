using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300.Utils
{
    class FileUtils
    {
        public static void readFileTo(string path, List<string> list)
        {
            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(path, Encoding.GetEncoding("gb2312"));
            string str = null;
            while ((str = sr.ReadLine()) != null)
            {
                list.Add(str);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project
{
    public class DataPreparation
    {
        public void PrepareData(string path)
        {
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                text = text.Replace(",", ".");
                File.WriteAllText(path, text, Encoding.UTF8);
            }
        }
    }
}

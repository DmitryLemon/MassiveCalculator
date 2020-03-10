using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model.FileManager
{
    class Saver : IFileManager
    {
        public int perform()
        {
            string writePath = "HistoryFile/hf.txt";
            string text = "Привет мир!\nПока мир...";
                try
                {
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        sw.WriteAsync(text);
                    }

                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLineAsync("Дозапись");
                        sw.WriteAsync("4,5");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            return 1;
        }

    }
}

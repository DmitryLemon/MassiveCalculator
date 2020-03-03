using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class HistoryManager
    {

        public async Task ReadFromFile()
        {

        }

        public async Task WriteToTemp()
        {
            string writePath = "HistoryFile/hf.txt";
            string text = "Привет мир!\nПока мир...";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    await sw.WriteAsync(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync("Дозапись");
                    await sw.WriteAsync("4,5");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

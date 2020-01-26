using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace model
{
    public class ReservationForm
    {

        private const String DATA_PATH = "..\\..\\..\\Data.txt";



        public List<String> readData()
        {
            List<String> lisData = new List<string>();

            try
            {
                StreamReader sr = new StreamReader(DATA_PATH);
                String line = sr.ReadLine();

                while (line != null)
                {
                    lisData.Add(line);
                    line = sr.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return lisData;
        }


        public void writeData(List<String> listData)
        {
            try
            {
                StreamWriter sw = new StreamWriter(DATA_PATH, true);

                for (int i = 0; i < listData.Count; i++)
                {
                    sw.WriteLine(listData.ElementAt(i));
                }
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

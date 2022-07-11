using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class ReadFiles
    {
        public static Dictionary<string, string> ReadConfig(string pathInputFile)
        {
            try
            {
                Dictionary<string, string> config = new Dictionary<string, string>();
                int count = 0;
                using (StreamReader readFile = new StreamReader(pathInputFile))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        if (count > 0)
                        {
                            row = line.Split('|');
                            config.Add(row[0], row[1]);
                        }
                        count++;
                    }
                }
                return config;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}

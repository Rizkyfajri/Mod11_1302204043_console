using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod11_1302204043_console
{
    public class PusatDataSingleton
    {
        private static PusatDataSingleton _instance = null;
        private List<string> DataTersimpan;

        private PusatDataSingleton()
        {
            this.DataTersimpan = new List<string>();
        }

        public static PusatDataSingleton GetPusatDataSingleton
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PusatDataSingleton();
                }
                return _instance;
            }
        }

        public List<string> GetSemuaData()
        {
            return null;
        }
        public void PrintSemuaData()
        {
            for (int i = 0; i < DataTersimpan.Count; i++)
            {
                Console.WriteLine(DataTersimpan[i]);
            }
        }
        public void AddSebuahData(string input)
        {

        }
        public void HapusSebuahData(int index)
        {

        }


    }
}

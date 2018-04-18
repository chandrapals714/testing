using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.HelperMethods
{
   public class AppConfig
    {
        public  static string GetValue(string Key)
         {
         return ConfigurationManager.AppSettings[Key];
            //djfdsjfdsj
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LogiTec.Utils
{
    public class Config : Singleton<Config>
    {

        public string ConnectionString { get; set; }
       
    }
}

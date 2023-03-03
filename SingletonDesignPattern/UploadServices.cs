using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class UploadServices
    {
        private UploadServices(){ }
         
        private static UploadServices _instance;
        private static readonly object _lock =new  object();
        public static UploadServices Instance()
        {
            if (_instance == null) 
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UploadServices();
                    }
                }
            } 
            return _instance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore.Services
{
    public interface IFirstService
    {
        string Time { get; }
    }

    public class FirstService: IFirstService
    {
        public FirstService()
        {
            Time = DateTime.Now.ToString("hh:mm:ss");
        }
        public string Time { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore.Services
{
    public interface ISecondService
    {
        string Time { get; }
    }
    public class SecondService : ISecondService
    {
        public SecondService()
        {
            Time = DateTime.Now.ToString("hh:mm:ss");
        }
        public string Time { get; }
    }

    public class ViewTimeService : ISecondService
    {
        public ViewTimeService()
        {
            Time = DateTime.Now.ToString("hh:mm:ss");
        }
        public string Time { get; }
    }
}
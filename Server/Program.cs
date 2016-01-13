using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using StudentService;
using Interfaces;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(StudentService.StudentService)))
            {
                host.Open();
                Console.WriteLine("Servise is starting...");
                Console.ReadLine();
            }
        }
    }
}

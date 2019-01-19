using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceBiblio;
using System.ServiceModel;

namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ServiceHost service  = new ServiceHost(typeof(Service)))
                {
                    service.Open();
                    Console.WriteLine("Service  Started");
                    Console.ReadLine();
                    

                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message +"Service wcf Not Started "+e.StackTrace);
                Console.ReadLine();
            }


        }
    }
}

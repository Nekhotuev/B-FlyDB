using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Data;

namespace DbTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //DB initialization, create data for classifiers
            using (ClassifiersContext context = new ClassifiersContext())
            {
                //context.Database.CreateIfNotExists();

                //context.Database.Initialize(true);
                
                var airports = context.Airports.ToList();
                
                foreach (Airport airport in airports)
                {
                    Console.WriteLine(airport.Name);
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCameras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conectionString ="Data Source=LAPTOP-1UQRII1O;Initial Catalog=Cameras;Integrated Security=True";

            DataAccess da= new DataAccess();

         int r=  da.InsertData(conectionString);
            da.ReadData(conectionString);

            Console.WriteLine(r);
        }
    }



}

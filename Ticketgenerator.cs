using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace TicketManagement
{
	class File
	{
        public static int i=1;
        public void ticketcreate(string a,string b,int c)
		{

            FileStream fs = new FileStream("ticketRecipt.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            string str = Console.ReadLine();
            if (i == 1)
            {
                sw.WriteLine("+++++++++++++++++++++++++++++++++++Rawalpindi Railway+++++++++++++++++++++++++++++++++++");
            }
            sw.WriteLine(i+":");
            sw.WriteLine("Name:"+a);
            sw.WriteLine("Destination:"+b);
            sw.WriteLine("TicketNum:" + c);
            sw.Flush();
            sw.Close();
            fs.Close();
            i += 1;
        }
	}
}

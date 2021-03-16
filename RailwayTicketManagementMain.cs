using System;
using System.Collections;
using System.IO;
namespace TicketManagement
{
	class Program
	{
		public static int i;
		
		static void Main(string[] args)
		{
			File obj = new File();
			int index;	
			ArrayList tnos = new ArrayList();
			ArrayList names = new ArrayList();
			ArrayList dest = new ArrayList();
			int choice = 0;
			Console.WriteLine("+++++++++++++++++++++++++++++++++++Rawalpindi Railway++++++++++++++++++++++++++++++++++++");
			
			do
			{
				Console.WriteLine("\n1:Book Ticket\n2:Delete Tickets\n3:View Tickets\n4:Exit");
				choice = Convert.ToInt32(Console.ReadLine());
				if(choice==1)
				{
					var rand = new Random();
					string name, destination;
					Console.WriteLine("Enter Name");
					name = Console.ReadLine();
					Console.WriteLine("Enter Destination");
					destination = Console.ReadLine();
					
					int ticketnum = rand.Next(1000);
					names.Add(name);
					dest.Add(destination);
					tnos.Add(ticketnum);
					obj.ticketcreate(name, destination, ticketnum);
				  
				}
				if(choice==2)
				{
					for (int i = 0; i < names.Count; i++)
					{
						Console.WriteLine(i + ":");
						Console.WriteLine("Name:" + names[i]);
						Console.WriteLine("Destination:" + dest[i]);
						Console.WriteLine("TicketNo:" + tnos[i]);
					}
						Console.WriteLine("Select the index you want to delete");
						index = Convert.ToInt32(Console.ReadLine());
						names.RemoveAt(index);
						dest.RemoveAt(index);
						tnos.RemoveAt(index);
					
				}
				if(choice==3)
				{
					for (int i = 0; i < names.Count; i++)
					{
						Console.WriteLine(i + ":");
						Console.WriteLine("Name:"+names[i]);
						Console.WriteLine("Destination:"+dest[i]);
						Console.WriteLine("TicketNo:"+tnos[i]);
					}
				}
			} while (choice != 4);
		}

	}
}

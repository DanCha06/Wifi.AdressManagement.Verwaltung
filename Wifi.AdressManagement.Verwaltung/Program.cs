using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wifi.AdressManagement.Verwaltung
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            NameData firstname = new NameData();
            NameData lastname = new NameData();


            string Name = firstname.Vorname, Lastname = lastname.Nachname;

            Console.WriteLine("Enter a first name: ");
            firstname.Vorname = Console.ReadLine();
            Console.WriteLine("Enter a last name: ");
            lastname.Nachname = Console.ReadLine();

            Console.WriteLine("--------------------");
            StreamWriter swData = new StreamWriter("c:\\temp\\test.txt", true);
            swData.WriteLine($"{firstname.Vorname} {lastname.Nachname}");
            swData.Close();



            StreamReader srData = new StreamReader("c:\\temp\\test.txt");
            string zeile = srData.ReadLine();
            Console.WriteLine(zeile);


            while (!srData.EndOfStream)
            {
                zeile = srData.ReadLine();
                Console.WriteLine(zeile);
            }
            srData.Close();
            


            //Ende-------------------------------\\
            Console.WriteLine("--------------------");
            Console.WriteLine("Press any key to close");
			Console.ReadKey();
		}
	}

}

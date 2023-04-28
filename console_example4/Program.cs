// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Text;

Console.WriteLine("Hello, Write the url!");
string url=Console.ReadLine();
	WebRequest wb = WebRequest.Create(url);
	WebResponse rp = wb.GetResponse();
	StreamReader reader = new StreamReader(rp.GetResponseStream(), Encoding.ASCII);
	Console.WriteLine(reader.ReadToEnd());
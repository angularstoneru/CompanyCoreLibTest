using CompanyCoreLib;

namespace CompanyCoreLibTest
{
    internal class Program
    {

        //public static List<string> testdatesstrings = new List<string>();
		public static List<DateTime> testdates = new List<DateTime>();

		static void Main(string[] args)
        {
			string[] testdatesstrings = File.ReadLines( "testdates.txt" ).ToArray();

			foreach( string datestring in testdatesstrings )
			{
				if( datestring.StartsWith( "#" ) )
					continue;
				testdates.Add( DateTime.Parse( datestring ) );
			}

			Analytics analytics = new Analytics();
			List<DateTime> dates = analytics.PopularMonths( testdates );
			Console.WriteLine( "Returned {0:d} dates.", dates.Count );

			Console.WriteLine( "Source:" );
			foreach( DateTime date in testdates )
			{
				Console.WriteLine( date.ToString( "yyyy MM dd HH:mm:ss" ) );
			}
			Console.WriteLine( "\nResult:" );
			foreach( DateTime date in dates )
			{
				Console.WriteLine( date.ToString( "yyyy-MM-dd HH:mm" ) );
			}
		}
	}
}

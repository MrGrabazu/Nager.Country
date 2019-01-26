namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Georgia
	/// </summary>
	public class GeorgiaInfo : ICountryInfo
	{
		public string CommonName => "Georgia";
		public string OfficialName => "Georgia";

		public Alpha2Code Alpha2Code => Alpha2Code.GE;
		public Alpha3Code Alpha3Code => Alpha3Code.GEO;
		public int NumericCode => 268;
		public string[] TLD => new [] { ".ge" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AM,
			Alpha2Code.AZ,
			Alpha2Code.RU,
			Alpha2Code.TR,
		};

		public string[] Currencies => new [] { "GEL" };
		public string[] CallingCodes => new [] { "995" };
	}
}

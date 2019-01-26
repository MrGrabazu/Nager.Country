namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// DR Congo
	/// </summary>
	public class DRCongoInfo : ICountryInfo
	{
		public string CommonName => "DR Congo";
		public string OfficialName => "Democratic Republic of the Congo";

		public Alpha2Code Alpha2Code => Alpha2Code.CD;
		public Alpha3Code Alpha3Code => Alpha3Code.COD;
		public int NumericCode => 180;
		public string[] TLD => new [] { ".cd" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.MiddleAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AO,
			Alpha2Code.BI,
			Alpha2Code.CF,
			Alpha2Code.CG,
			Alpha2Code.RW,
			Alpha2Code.SS,
			Alpha2Code.TZ,
			Alpha2Code.UG,
			Alpha2Code.ZM,
		};

		public string[] Currencies => new [] { "CDF" };
		public string[] CallingCodes => new [] { "243" };
	}
}

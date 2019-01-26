namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Brazil
	/// </summary>
	public class BrazilInfo : ICountryInfo
	{
		public string CommonName => "Brazil";
		public string OfficialName => "Federative Republic of Brazil";

		public Alpha2Code Alpha2Code => Alpha2Code.BR;
		public Alpha3Code Alpha3Code => Alpha3Code.BRA;
		public int NumericCode => 076;
		public string[] TLD => new [] { ".br" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.SouthAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AR,
			Alpha2Code.BO,
			Alpha2Code.CO,
			Alpha2Code.GF,
			Alpha2Code.GY,
			Alpha2Code.PY,
			Alpha2Code.PE,
			Alpha2Code.SR,
			Alpha2Code.UY,
			Alpha2Code.VE,
		};

		public string[] Currencies => new [] { "BRL" };
		public string[] CallingCodes => new [] { "55" };
	}
}

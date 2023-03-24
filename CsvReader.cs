using System.Globalization;

namespace AddressBookSystem
{
    internal class CsvReader
    {
        private StreamReader streamReader;
        private CultureInfo culture;

        public CsvReader(StreamReader streamReader, CultureInfo culture)
        {
            this.streamReader = streamReader;
            this.culture = culture;
        }
    }
}
using System.Text;

namespace ipdb
{

    public class CityInfo
    {

        private readonly string[] data;

        public CityInfo(string[] data)
        {
            this.data = data;
        }

        public string getCountryName()
        {
            return data[0];
        }

        public string getRegionName()
        {
            return data[1];
        }

        public string getCityName()
        {
            return data[2];
        }

        public string getOwnerDomain()
        {
            return data[3];
        }

        public string getIspDomain()
        {
            return data[4];
        }

        public string getLatitude()
        {
            return data[5];
        }

        public string getLongitude()
        {
            return data[6];
        }

        public string getTimezone()
        {
            return data[7];
        }

        public string getUtcOffset()
        {
            return data[8];
        }

        public string getChinaAdminCode()
        {
            return data[9];
        }

        public string getIddCode()
        {
            return data[10];
        }

        public string getCountryCode()
        {
            return data[11];
        }

        public string getContinentCode()
        {
            return data[12];
        }

        public string getIDC()
        {
            return data[13];
        }

        public string getBaseStation()
        {
            return data[14];
        }

        public string getCountryCode3()
        {
            return data[15];
        }

        public string getEuropeanUnion()
        {
            return data[16];
        }

        public string getCurrencyCode()
        {
            return data[17];
        }

        public string getCurrencyName()
        {
            return data[18];
        }

        public string getAnycast()
        {
            return data[19];
        }

        public override string ToString()
        {

            var sb = new StringBuilder();

            sb.Append("country_name:");
            sb.Append(getCountryName());
            sb.Append("\n");
            sb.Append("region_name:");
            sb.Append(getRegionName());
            sb.Append("\n");
            sb.Append("city_name:");
            sb.Append(getCityName());
            sb.Append("\n");
            sb.Append("owner_domain:");
            sb.Append(getOwnerDomain());
            sb.Append("\n");
            sb.Append("isp_domain:");
            sb.Append(getIspDomain());
            sb.Append("\n");
            sb.Append("latitude:");
            sb.Append(getLatitude());
            sb.Append("\n");
            sb.Append("longitude:");
            sb.Append(getLongitude());
            sb.Append("\n");

            sb.Append("timezone:");
            sb.Append(getTimezone());
            sb.Append("\n");

            sb.Append("utc_offset:");
            sb.Append(getUtcOffset());
            sb.Append("\n");

            sb.Append("china_admin_code:");
            sb.Append(getChinaAdminCode());
            sb.Append("\n");

            sb.Append("idd_code:");
            sb.Append(getIddCode());
            sb.Append("\n");

            sb.Append("country_code:");
            sb.Append(getCountryCode());
            sb.Append("\n");

            sb.Append("continent_code:");
            sb.Append(getContinentCode());
            sb.Append("\n");

            sb.Append("idc:");
            sb.Append(getIDC());
            sb.Append("\n");

            sb.Append("base_station:");
            sb.Append(getBaseStation());
            sb.Append("\n");

            sb.Append("country_code3:");
            sb.Append(getCountryCode3());
            sb.Append("\n");

            sb.Append("european_union:");
            sb.Append(getEuropeanUnion());
            sb.Append("\n");

            sb.Append("currency_code:");
            sb.Append(getCurrencyCode());
            sb.Append("\n");

            sb.Append("currency_name:");
            sb.Append(getCurrencyName());
            sb.Append("\n");

            sb.Append("anycast:");
            sb.Append(getAnycast());

            return sb.ToString();

        }
    }

}

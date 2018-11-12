using System.Text;

namespace ipdb
{

    public class DistrictInfo
    {

        private readonly string[] data;

        public DistrictInfo(string[] data)
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

        public string getDistrictName()
        {
            return data[3];
        }

        public string getChinaAdminCode()
        {
            return data[4];
        }

        public string getCoveringRadius()
        {
            return data[5];
        }

        public string getLatitude()
        {
            return data[6];
        }

        public string getLongitude()
        {
            return data[7];
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
            sb.Append("district_name:");
            sb.Append(getDistrictName());
            sb.Append("\n");
            sb.Append("china_admin_code:");
            sb.Append(getChinaAdminCode());
            sb.Append("\n");
            sb.Append("covering_radius:");
            sb.Append(getCoveringRadius());
            sb.Append("\n");
            sb.Append("latitude:");
            sb.Append(getLatitude());
            sb.Append("\n");
            sb.Append("longitude:");
            sb.Append(getLongitude());

            return sb.ToString();
        }
    }

}

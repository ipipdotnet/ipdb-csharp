using System;
using System.Linq;

namespace ipdb
{
    class Test
    {
        static void Main(string[] args)
        {
            testCityV4();

            testBaseStation();

            testFree();
            testIDC();
            testDistrict();
            testCity();

            Console.ReadKey();
        }

        public static void testBaseStation()
        {
            try
            {
                var db = new BaseStation("c:/work/ipdb/base_station.ipdb");
                Console.WriteLine(string.Join(", ", db.fields()));

                Console.WriteLine(string.Join(", ", db.find("112.224.4.99", "CN")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void testFree()
        {
            try
            {
                var db = new District("C:/work/ipdb/city.free.ipdb");

                Console.WriteLine(string.Join(", ", db.find("1.12.13.1", "CN")));

                var info = db.findInfo("8.8.8.8", "CN");
                if (info != null)
                {
                    Console.WriteLine(info.getCountryName());
                }

                var m = db.findMap("114.114.114.114", "CN");

                Console.WriteLine(string.Join("\n", m.Select(i => $"{i.Key}: {i.Value}")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void testDistrict()
        {
            try
            {
                var db = new District("C:/work/ipdb/china_district.ipdb");

                Console.WriteLine(string.Join(", ", db.find("1.12.13.1", "CN")));

                var info = db.findInfo("1.12.13.1", "CN");
                if (info != null)
                {
                    Console.WriteLine(info);
                    Console.WriteLine(info.getCountryName());
                }

                var m = db.findMap("1.12.13.1", "CN");

                Console.WriteLine(string.Join("\n", m.Select(i => $"{i.Key}: {i.Value}")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void testIDC()
        {
            try
            {
                var db = new IDC("C:/work/ipdb/idc_list.ipdb");

                Console.WriteLine(string.Join(", ", db.find("1.1.1.1", "CN")));

                var info = db.findInfo("8.8.8.8", "CN");

                Console.WriteLine(info.getCountryName());

                var m = db.findMap("114.114.114.114", "CN");

                Console.WriteLine(string.Join("\n", m.Select(i => $"{i.Key}: {i.Value}")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void testCityV4()
        {
            try
            {
                var db = new City("C:/work/ipdb/city.ipv4.ipdb");

                Console.WriteLine(string.Join(", ", db.find("1.1.1.1", "CN")));

                var info = db.findInfo("118.28.1.1", "CN");

                Console.WriteLine(info);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void testCity()
        {
            try
            {
                var db = new City("C:/work/ipdb/city.ipv6.ipdb");

                Console.WriteLine(string.Join(", ", db.find("2001:250:200::", "CN")));

                var info = db.findInfo("2001:250:201::", "CN");

                Console.WriteLine(info);

                var m = db.findMap("2001:250:220::", "CN");

                Console.WriteLine(string.Join("\n", m.Select(i => $"{i.Key}: {i.Value}")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
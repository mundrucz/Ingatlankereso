namespace IngatlanKereso_backend.Data
{
    public class Location
    {
        public int Id { get; set; }
        public String country { get; set; } = "Magyarország";
        public String county { get; set; }
        public String city { get; set; }
        public String district { get; set; }
        public String street { get; set; }

       /* public Location(String Country, String County, String City, String District, String Street){
            country = Country;
            county = County;
            city = City;
            district = District;
            street = Street;
        }
        public Location (String Country, String County, String City, String District)
        {
            country = Country;
            county = County;
            city = City;
            district = District;
        }
        public Location (String County, String City, String District)
        {
            county = County;
            city = City;
            district = District;
        }*/
    }
}
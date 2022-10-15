namespace IngatlanKereso_backend.Data
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public List<Estate> ads { get; set; }

       /* public User(String Name, String Email, String Password, String PhoneNumner) {
            name = Name;
            email = Email;
            password = Password;
            phoneNumber = PhoneNumner;
        }*/
        public Boolean addEstate(Estate e) {
            if (e == null) {
                return false;
            }
            else if (!ads.Contains(e)) {
                ads.Add(e);
            }
            return true;
        }

        public Boolean removeEstate(Estate e)
        {
            if (e == null)
            {
                return false;
            }
            else if (ads.Contains(e))
            {
                ads.Remove(e);
            }
            return true;
        }
    }
}

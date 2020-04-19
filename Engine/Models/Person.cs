namespace Engine.Models
{
    public class Person
    {
        public string Gender;
        public string Name;
        public string Surname;
        public string StreetAdress;
        public string Postcode;
        public string City;
        public int PhoneNumber;

        public Person(string gender, string name, string surname, string streetadress, string postcode, string city, int phonenumber)
        {
            this.Gender = gender;
            this.Name = name;
            this.Surname = surname;
            this.StreetAdress = streetadress;
            this.Postcode = postcode;
            this.City = city;
            this.PhoneNumber = phonenumber;

        }
    }
}
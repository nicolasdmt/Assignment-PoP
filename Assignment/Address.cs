using System;
namespace Assignment
{
    public class Address
    {
        int addressNb;
        string street;
        string city;
        string country;



        public Address(int ANb, string S, string Ci, string Co)
        {
            if (ANb!=0&&S!=null&&Ci!=null&&Co!=null)
            {
                this.addressNb = ANb;
                this.street = S;
                this.city = Ci;
                this.country = Co;
            }
            else { Console.WriteLine("Impossible to create an adress"); }
        }


        
        public int AddressNb
        {
            get { return addressNb; } set { addressNb = value; }
        }
        public string Street
        {
            get { return street; } set { street = value; }
        }
        public string City
        {
            get { return city; } set { city = value; }
        }
        public string Country
        {
            get { return country; } set { country = value;  }
        }



        public string toString()
        {
            return  addressNb + " " + street + " in " + city + " in " + country;
        }
    }
}

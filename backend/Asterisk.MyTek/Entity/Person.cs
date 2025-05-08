namespace Asterisk.MyTek.Entity
{
    public class Ancestor(string fname, string mname, string lname)
    {
        public string FirstName { get; set; } = fname;
        public string MiddleName { get; set; } = mname;
        public string LastName { get; set; } = lname;
    }

    public class Person(string fname, string mname, string lname, string cityName, string stateName) : Ancestor(fname, mname, lname)
    {
        public Person() : this("Nac", "Mi", "Now", "", "") { }
        public string City { get; set; } = cityName;
        public string State { get; set; } = stateName;

        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string mname, out string lname)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string lname, out string city, out string state)
        {
            fname = FirstName;
            lname = LastName;
            city = City;
            state = State;
        }
    }
}

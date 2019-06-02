using System;

namespace ProteinDB_App
{
    public class User
    {
        private int _id;
        private String _name;
        private String _dateOfBirth;
        private String _job;
        private String _university;


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public String DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public String Job
        {
            get { return _job; }
            set { _job = value; }
        }

        public String University
        {
            get { return _university; }
            set { _university = value; }
        }


        public User() : base()
        {
        }

        public User(String Name, String DateOfBirth, String Job, String University) : base()
        {
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Job = Job;
            this.University = University;
        }

        public override String ToString()
        {
            return _id + "-" + _name;
        }


    }

    
}
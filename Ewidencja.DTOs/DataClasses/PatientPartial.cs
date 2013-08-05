using System;

namespace Ewidencja.DTOs.DataClasses
{
    public class PatientPartial
    {
        private string _cellPhone;

        public int PatientId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }

        public DateTime? DateOfBirth
        {
            get;
            set;
        }


        public string City
        {
            get;
            set;
        }

        public string Street
        {
            get;
            set;
        }

        public string HomeNumber
        {
            get;
            set;
        }

        public string Phone
        {
            get;
            set;
        }

        public string CellPhone
        {
            get
            {
                return _cellPhone;
            }
            set
            {
                _cellPhone = value.Trim().Replace('-', ' ');
            }
        }
    }
}


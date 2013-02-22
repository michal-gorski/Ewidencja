using System;
using System.ComponentModel.DataAnnotations;


namespace Ewidencja.DTOs
{
    public class Patient
    {        
        public int PatientId
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Podaj imię pacjenta")]
        public string Name
        {
            get;
            set;
        }
       
        [Required(ErrorMessage = "Podaj nazwisko pacjenta")]
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

        public string PostalCode
        {
            get;
            set;
        }

        public string Voivodship
        {
            get;
            set;
        }

        public string District
        {
            get;
            set;
        }

        public string Commune
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
            get;
            set;
        }
                
        public string Email
        {
            get;
            set;
        }

    }
}

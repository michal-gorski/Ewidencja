using System;
using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ewidencja.DTOs;

namespace Ewidencja.LegacyDataImporter
{
    internal static class PatientsImporter
    {


        private static string NormaliseName(string input)
        {
            input = input.Replace("  ", " ");
            input = input.Replace(" -", "-");
            input = input.Replace("- ", "-");
            input = input.ToLower();

            char[] array = input.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                array[0] = char.ToUpper(array[0]);
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ' || array[i - 1] == '-')
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }

            return new string(array);
        }

        public static List<Patient> ImportPatients(FbConnection conn)
        {


            string SQLCommandText = "SELECT * FROM PACJENCI P JOIN OSOBY O ON P.ID_OSOBY = O.ID_OSOBY JOIN ADRESY A ON A.ID_ADRESY = O.ID_ADRESY";

            FbCommand comm = new FbCommand(SQLCommandText, conn);

            var reader = comm.ExecuteReader();
            int i = 0;

            var patients = new List<Patient>();
            while (reader.Read())
            {
                Patient patient = new Patient();
                patient.Name = NormaliseName(reader["IMIE"].ToString());
                patient.Surname = NormaliseName(reader["NAZWISKO"].ToString());

                DateTime dateOfBirth;

                if (DateTime.TryParseExact(reader["DATA_URODZENIA"].ToString(), "dd/MM/yyyy hh:mm:ss", null, System.Globalization.DateTimeStyles.None, out dateOfBirth))
                {
                    patient.DateOfBirth = dateOfBirth;
                }

                patient.City = NormaliseName(reader["MIEJSCOWOSC"].ToString());
                patient.Street = NormaliseName(reader["ULICA"].ToString());
                patient.HomeNumber = reader["NUMERBUDYNKU"].ToString();
                patient.PostalCode = reader["KODPOCZTOWY"].ToString();
                patient.Voivodship = NormaliseName(reader["WOJEWODZTWO"].ToString());
                patient.District = NormaliseName(reader["POWIAT"].ToString());
                patient.Commune = NormaliseName(reader["GMINA"].ToString());
                patient.Phone = reader["TELEFON"].ToString();
                patient.CellPhone = reader["TELEFONKOMORKOWY"].ToString();
                patient.Email = reader["EMAIL"].ToString();

                patients.Add(patient);
            }

            reader.Close();

            return patients;
        }
    }
}

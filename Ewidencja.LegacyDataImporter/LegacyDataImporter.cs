using System;
using System.Collections.Generic;
using System.Configuration;

using FirebirdSql.Data.FirebirdClient;
using Ewidencja.DTOs;

namespace Ewidencja.LegacyDataImporter
{
    public class LegacyDataImporter
    {

        public string DBPath { get; set; }
        public LegacyDataImporter(string path)
        {
            DBPath = path;
        }

        private FbConnection GetConnection()
        {
            string _connString =
                @"User=SYSDBA;Password=masterkey;Database=" + DBPath + @";DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";
            FbConnection conn = new FbConnection(_connString);
            conn.Open();     
            
            return conn;
        }

        public List<Patient> ImportPatients()
        {
            return PatientsImporter.ImportPatients(GetConnection());
        }
    }
}

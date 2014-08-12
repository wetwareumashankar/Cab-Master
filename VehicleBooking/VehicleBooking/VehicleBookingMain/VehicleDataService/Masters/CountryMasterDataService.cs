using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperCS.DataAccessLayer;
using VehicleBL.Masters;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace VehicleDataService.Masters
{
    public class CountryMasterDataService : MySqlDataServiceBase
    {
        public CountryMaster Country_Retrieve(int id)
        {
            CountryMaster obj = new CountryMaster();
            using (MySqlDataReader reader = ExecuteDataReader("Country_Retrieve",
                CreateParameter("CountryId", MySqlDbType.Int32, id)))
            {
                while (reader.Read())
                {
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryCode = reader["CountryCode"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.ISDNo = reader["ISDNo"].ToString();
                }
            }
            return obj;
        }

        public List<CountryMaster> Country_RetrieveAll()
        {
            List<CountryMaster> listContry = new List<CountryMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("Country_Retrieve",
                 CreateParameter("CountryId", MySqlDbType.Int32, -1)))
            {
                while (reader.Read())
                {
                    CountryMaster obj = new CountryMaster();
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryCode = reader["CountryCode"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.ISDNo = reader["ISDNo"].ToString();
                    listContry.Add(obj);
                }
            }
            return listContry;
        }

        public List<CountryMaster> Country_Insert(CountryMaster input)
        {
            List<CountryMaster> listContry = new List<CountryMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("Country_InsertUpdateDelete",
                CreateParameter("CountryId", MySqlDbType.Int32, input.CountryId),
                CreateParameter("CountryCode", MySqlDbType.VarChar, input.CountryCode),
                CreateParameter("CountryName", MySqlDbType.VarChar, input.CountryName),
                CreateParameter("ISDNo", MySqlDbType.VarChar, input.ISDNo),
                CreateParameter("Type", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    CountryMaster obj = new CountryMaster();
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryCode = reader["CountryCode"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.ISDNo = reader["ISDNo"].ToString();
                    listContry.Add(obj);
                }
            }
            return listContry;
        }

        public List<CountryMaster> Country_Update(CountryMaster input)
        {
            List<CountryMaster> listContry = new List<CountryMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("Country_InsertUpdateDelete",
                CreateParameter("CountryId", MySqlDbType.Int32, input.CountryId),
                CreateParameter("CountryCode", MySqlDbType.VarChar, input.CountryCode),
                CreateParameter("CountryName", MySqlDbType.VarChar, input.CountryName),
                CreateParameter("ISDNo", MySqlDbType.VarChar, input.ISDNo),
                CreateParameter("Type", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    CountryMaster obj = new CountryMaster();
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryCode = reader["CountryCode"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.ISDNo = reader["ISDNo"].ToString();
                    listContry.Add(obj);
                }
            }
            return listContry;
        }

        public List<CountryMaster> Country_Delete(int countryId)
        {
            List<CountryMaster> listContry = new List<CountryMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("Country_InsertUpdateDelete",
                CreateParameter("CountryId", MySqlDbType.Int32, countryId),
                CreateParameter("Type", MySqlDbType.Int32, 3)))
            {
                while (reader.Read())
                {
                    CountryMaster obj = new CountryMaster();
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryCode = reader["CountryCode"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.ISDNo = reader["ISDNo"].ToString();
                    listContry.Add(obj);
                }
            }
            return listContry;
        }
    }
}

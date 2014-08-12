using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleBL.Masters;
using System.Data;
using System.Data.SqlClient;
using DapperCS.DataAccessLayer;
using MySql.Data.MySqlClient;

namespace VehicleDataService.Masters
{
    public class CityMasterDataService : MySqlDataServiceBase
    {
        public CityMaster City_Retrieve(int id)
        {
            CityMaster obj = new CityMaster();
            using (MySqlDataReader reader = ExecuteDataReader("City_Retrieve",
                CreateParameter("CityId", MySqlDbType.Int32, id)))
            {
                while (reader.Read())
                {
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                }
            }
            return obj;
        }

        public List<CityMaster> City_RetrieveAll()
        {
            List<CityMaster> listCity = new List<CityMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("City_Retrieve"))
            {
                while (reader.Read())
                {
                    CityMaster obj = new CityMaster();
                  obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    listCity.Add(obj);
                }
            }
            return listCity;
        }

        public List<CityMaster> City_Insert(CityMaster input)
        {
            List<CityMaster> listCity = new List<CityMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("City_InsertUpdateDelete",
              CreateParameter("DistrictId", MySqlDbType.Int32, input.DistrictId),
                CreateParameter("CityName", MySqlDbType.VarChar, input.CityName),
                CreateParameter("Type", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    CityMaster obj = new CityMaster();
                   obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    listCity.Add(obj);
                }
            }
            return listCity;
        }

        public List<CityMaster> City_Update(CityMaster input)
        {
            List<CityMaster> listCity = new List<CityMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("City_InsertUpdateDelete",
                CreateParameter("CityId", MySqlDbType.Int32, input.CityId),
               CreateParameter("DistrictId", MySqlDbType.Int32, input.DistrictId),
                CreateParameter("CityName", MySqlDbType.VarChar, input.CityName),
                CreateParameter("Type", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    CityMaster obj = new CityMaster();
                   obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    listCity.Add(obj);
                }
            }
            return listCity;
        }

        public List<CityMaster> City_Delete(int CityId)
        {
            List<CityMaster> listCity = new List<CityMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("City_InsertUpdateDelete",
                CreateParameter("CityId", MySqlDbType.Int32, CityId),
                CreateParameter("Type", MySqlDbType.Int32, 3)))
            {
                while (reader.Read())
                {
                    CityMaster obj = new CityMaster();
                   obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    listCity.Add(obj);
                }
            }
            return listCity;
        }
    
    }
}

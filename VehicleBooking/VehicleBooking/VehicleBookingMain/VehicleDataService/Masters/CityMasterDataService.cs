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
                CreateParameter("CityId_", MySqlDbType.Int32, id),
                CreateParameter("DistrictId_", MySqlDbType.Int32, -1)))
            {
                while (reader.Read())
                {
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    //obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
            }
            return obj;
        }

        public List<CityMaster> City_RetrieveAll(int districtId)
        {
            List<CityMaster> listCity = new List<CityMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("City_Retrieve",
                 CreateParameter("CityId_", MySqlDbType.Int32, -1),
                CreateParameter("DistrictId_", MySqlDbType.Int32, districtId)))
            {
                while (reader.Read())
                {
                    CityMaster obj = new CityMaster();
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    //obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listCity.Add(obj);
                }
            }
            return listCity;
        }

        public List<CityMaster> City_Insert(CityMaster input)
        {
            List<CityMaster> listCity = new List<CityMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("City_InsertUpdateDelete",
              CreateParameter("DistrictId_", MySqlDbType.Int32, input.DistrictId),
                CreateParameter("CityName_", MySqlDbType.VarChar, input.CityName),
                CreateParameter("Type_", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    CityMaster obj = new CityMaster();
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    //obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listCity.Add(obj);
                }
            }
            return listCity;
        }

        public List<CityMaster> City_Update(CityMaster input)
        {
            List<CityMaster> listCity = new List<CityMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("City_InsertUpdateDelete",
                CreateParameter("CityId_", MySqlDbType.Int32, input.CityId),
               CreateParameter("DistrictId_", MySqlDbType.Int32, input.DistrictId),
                CreateParameter("CityName_", MySqlDbType.VarChar, input.CityName),
                CreateParameter("Type_", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    CityMaster obj = new CityMaster();
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    //obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listCity.Add(obj);
                }
            }
            return listCity;
        }

        public List<CityMaster> City_Delete(int CityId)
        {
            List<CityMaster> listCity = new List<CityMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("City_InsertUpdateDelete",
                CreateParameter("CityId_", MySqlDbType.Int32, CityId),
                 CreateParameter("DistrictId_", MySqlDbType.Int32, -1),
                CreateParameter("CityName_", MySqlDbType.VarChar, ""),
                CreateParameter("Type_", MySqlDbType.Int32, 3)))
            {
                while (reader.Read())
                {
                    CityMaster obj = new CityMaster();
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    //obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listCity.Add(obj);
                }
            }
            return listCity;
        }

    }
}

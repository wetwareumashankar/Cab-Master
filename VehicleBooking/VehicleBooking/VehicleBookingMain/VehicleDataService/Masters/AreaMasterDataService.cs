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
   public class AreaMasterDataService: MySqlDataServiceBase
    {
        public AreaMaster Area_Retrieve(int id)
        {
            AreaMaster obj = new AreaMaster();
            using (MySqlDataReader reader = ExecuteDataReader("Area_Retrieve",
                CreateParameter("AreaId", MySqlDbType.Int32, id)))
            {
                while (reader.Read())
                {
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.AreaId = Convert.ToInt32(reader["AreaId"]);
                    obj.AreaName = reader["AreaName"].ToString();
                    obj.ZipCode= reader["ZipCode"].ToString();
                    obj.Latitude = reader["Latitude"].ToString();
                    obj.Longitude = reader["Longitude"].ToString();
                    obj.CreatedDate=Convert.ToDateTime(reader["CreatedDate"].ToString());
                }
            }
            return obj;
        }

        public List<AreaMaster> Area_RetrieveAll()
        {
            List<AreaMaster> listArea = new List<AreaMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("Area_Retrieve"))
            {
                while (reader.Read())
                {
                    AreaMaster obj = new AreaMaster();
                  obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.AreaId = Convert.ToInt32(reader["AreaId"]);
                    obj.AreaName = reader["AreaName"].ToString();
                    obj.ZipCode= reader["ZipCode"].ToString();
                    obj.Latitude = reader["Latitude"].ToString();
                    obj.Longitude = reader["Longitude"].ToString();
                    obj.CreatedDate=Convert.ToDateTime(reader["CreatedDate"].ToString());
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<AreaMaster> Area_Insert(AreaMaster input)
        {
            List<AreaMaster> listArea = new List<AreaMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("Area_InsertUpdateDelete",
              CreateParameter("CityId", MySqlDbType.Int32, input.CityId),
              CreateParameter("ZipCode", MySqlDbType.VarChar, input.ZipCode), 
              CreateParameter("Latitude", MySqlDbType.VarChar, input.Latitude), 
              CreateParameter("Longitude", MySqlDbType.VarChar, input.Longitude),  
              CreateParameter("AreaName", MySqlDbType.VarChar, input.AreaName),
                CreateParameter("Type", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    AreaMaster obj = new AreaMaster();
                   obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.AreaId = Convert.ToInt32(reader["AreaId"]);
                    obj.AreaName = reader["AreaName"].ToString();
                    obj.ZipCode= reader["ZipCode"].ToString();
                    obj.Latitude = reader["Latitude"].ToString();
                    obj.Longitude = reader["Longitude"].ToString();
                    obj.CreatedDate=Convert.ToDateTime(reader["CreatedDate"].ToString());
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<AreaMaster> Area_Update(AreaMaster input)
        {
            List<AreaMaster> listArea = new List<AreaMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("Area_InsertUpdateDelete",
                CreateParameter("AreaId", MySqlDbType.Int32, input.AreaId),
               CreateParameter("CityId", MySqlDbType.Int32, input.CityId),
              CreateParameter("ZipCode", MySqlDbType.VarChar, input.ZipCode), 
              CreateParameter("Latitude", MySqlDbType.VarChar, input.Latitude), 
              CreateParameter("Longitude", MySqlDbType.VarChar, input.Longitude),  
              CreateParameter("AreaName", MySqlDbType.VarChar, input.AreaName),
                CreateParameter("Type", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    AreaMaster obj = new AreaMaster();
                   obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.AreaId = Convert.ToInt32(reader["AreaId"]);
                    obj.AreaName = reader["AreaName"].ToString();
                    obj.ZipCode= reader["ZipCode"].ToString();
                    obj.Latitude = reader["Latitude"].ToString();
                    obj.Longitude = reader["Longitude"].ToString();
                    obj.CreatedDate=Convert.ToDateTime(reader["CreatedDate"].ToString());
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<AreaMaster> Area_Delete(int AreaId)
        {
            List<AreaMaster> listArea = new List<AreaMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("Area_InsertUpdateDelete",
                CreateParameter("AreaId", MySqlDbType.Int32, AreaId),
                CreateParameter("Type", MySqlDbType.Int32, 3)))
            {
                while (reader.Read())
                {
                    AreaMaster obj = new AreaMaster();
                  obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.CityName = reader["CityName"].ToString();
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.AreaId = Convert.ToInt32(reader["AreaId"]);
                    obj.AreaName = reader["AreaName"].ToString();
                    obj.ZipCode= reader["ZipCode"].ToString();
                    obj.Latitude = reader["Latitude"].ToString();
                    obj.Longitude = reader["Longitude"].ToString();
                    obj.CreatedDate=Convert.ToDateTime(reader["CreatedDate"].ToString());
                    listArea.Add(obj);
                }
            }
            return listArea;
        }
    }
}

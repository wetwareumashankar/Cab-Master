using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using VehicleBL.Masters;
using DapperCS.DataAccessLayer;
using MySql.Data.MySqlClient;

namespace VehicleDataService.Masters
{
    public class DistrictMasterDataService : MySqlDataServiceBase
    {
        public DistrictMaster District_Retrieve(int id)
        {
            DistrictMaster obj = new DistrictMaster();
            using (MySqlDataReader reader = ExecuteDataReader("District_Retrieve",
                CreateParameter("DistrictId_", MySqlDbType.Int32, id),
                 CreateParameter("StateId_", MySqlDbType.Int32, -1)
                ))
            {
                while (reader.Read())
                {
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);

                }
            }
            return obj;
        }

        public List<DistrictMaster> District_RetrieveAll(int stateId)
        {
            List<DistrictMaster> listDistrict = new List<DistrictMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("District_Retrieve",
                 CreateParameter("DistrictId_", MySqlDbType.Int32, -1),
                 CreateParameter("StateId_", MySqlDbType.Int32, stateId)))
            {
                while (reader.Read())
                {
                    DistrictMaster obj = new DistrictMaster();
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listDistrict.Add(obj);
                }
            }
            return listDistrict;
        }

        public List<DistrictMaster> District_Insert(DistrictMaster input)
        {
            List<DistrictMaster> listDistrict = new List<DistrictMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("District_InsertUpdateDelete",
              CreateParameter("StateId_", MySqlDbType.Int32, input.StateId),
                CreateParameter("DistrictName_", MySqlDbType.VarChar, input.DistrictName),
                CreateParameter("Type_", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    DistrictMaster obj = new DistrictMaster();
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listDistrict.Add(obj);
                }
            }
            return listDistrict;
        }

        public List<DistrictMaster> District_Update(DistrictMaster input)
        {
            List<DistrictMaster> listDistrict = new List<DistrictMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("District_InsertUpdateDelete",
                CreateParameter("DistrictId_", MySqlDbType.Int32, input.DistrictId),
               CreateParameter("StateId_", MySqlDbType.Int32, input.StateId),
                CreateParameter("DistrictName_", MySqlDbType.VarChar, input.DistrictName),
                CreateParameter("Type_", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    DistrictMaster obj = new DistrictMaster();
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    listDistrict.Add(obj);
                }
            }
            return listDistrict;
        }

        public List<DistrictMaster> District_Delete(int DistrictId)
        {
            List<DistrictMaster> listDistrict = new List<DistrictMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("District_InsertUpdateDelete",
                CreateParameter("DistrictId_", MySqlDbType.Int32, DistrictId),
                CreateParameter("Type_", MySqlDbType.Int32, 3)))
            {
                while (reader.Read())
                {
                    DistrictMaster obj = new DistrictMaster();
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateName = reader["StateName"].ToString();
                    //obj.CountryName = reader["CountryName"].ToString();
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.DistrictName = reader["DistrictName"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listDistrict.Add(obj);
                }
            }
            return listDistrict;
        }

    }
}

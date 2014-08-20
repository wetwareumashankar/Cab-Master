using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperCS.DataAccessLayer;
using VehicleBL.Masters;
using MySql.Data.MySqlClient;

namespace VehicleDataService.Masters
{
    class CompanyMasterDataService : MySqlDataServiceBase
    {
        public CompanyMaster CompanyMaster_Retrieve(int id)
        {
            CompanyMaster obj = new CompanyMaster();
            using (MySqlDataReader reader = ExecuteDataReader("CompanyMaster_Retrieve",
                CreateParameter("CompanyId_", MySqlDbType.Int32, id)
                ))
            {
                while (reader.Read())
                {
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"]);
                    obj.CompanyName = reader["CompanyName"].ToString();
                    obj.CompanyPhoneNo = reader["CompanyPhoneNo"].ToString();
                    obj.CompanyWebsite = reader["CompanyWebsite"].ToString();
                    obj.CompanyAddress = reader["CompanyAddress"].ToString();
                    obj.CompanyCode = reader["CompanyCode"].ToString();
                    obj.CompanyEmailId = reader["CompanyEmailId"].ToString();

                    obj.OwnerName = reader["OwnerName"].ToString();
                    obj.OwnerEmailId = reader["OwnerEmailId"].ToString();
                    obj.OwnerPhone = reader["OwnerPhone"].ToString();



                    obj.CountryId = Convert.ToInt32(reader["CountryId"].ToString());
                    obj.StateId = Convert.ToInt32(reader["StateId"].ToString());
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"].ToString());
                    obj.CityId = Convert.ToInt32(reader["CityId"].ToString());

                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                }
            }
            return obj;
        }

        public List<CompanyMaster> CompanyMaster_RetrieveAll()
        {
            List<CompanyMaster> listArea = new List<CompanyMaster>();

            using (MySqlDataReader reader = ExecuteDataReader("CompanyMaster_Retrieve",
                CreateParameter("CompanyId_", MySqlDbType.Int32, -1)
                ))
            {
                while (reader.Read())
                {
                    CompanyMaster obj = new CompanyMaster();
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"]);
                    obj.CompanyName = reader["CompanyName"].ToString();
                    obj.CompanyPhoneNo = reader["CompanyPhoneNo"].ToString();
                    obj.CompanyWebsite = reader["CompanyWebsite"].ToString();
                    obj.CompanyAddress = reader["CompanyAddress"].ToString();
                    obj.CompanyCode = reader["CompanyCode"].ToString();
                    obj.CompanyEmailId = reader["CompanyEmailId"].ToString();

                    obj.OwnerName = reader["OwnerName"].ToString();
                    obj.OwnerEmailId = reader["OwnerEmailId"].ToString();
                    obj.OwnerPhone = reader["OwnerPhone"].ToString();



                    obj.CountryId = Convert.ToInt32(reader["CountryId"].ToString());
                    obj.StateId = Convert.ToInt32(reader["StateId"].ToString());
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"].ToString());
                    obj.CityId = Convert.ToInt32(reader["CityId"].ToString());

                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<CompanyMaster> CompanyMaster_Insert(CompanyMaster input)
        {
            List<CompanyMaster> listArea = new List<CompanyMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("CompanyMaster_InsertUpdateDelete",
                CreateParameter("CompanyId_", MySqlDbType.Int32, -1),

              CreateParameter("CompanyAddress_", MySqlDbType.VarChar, input.CompanyAddress),
              CreateParameter("CompanyCode_", MySqlDbType.VarChar, input.CompanyCode),
              CreateParameter("CompanyEmailId_", MySqlDbType.VarChar, input.CompanyEmailId),
              CreateParameter("CompanyName_", MySqlDbType.VarChar, input.CompanyName),
              CreateParameter("CompanyPhoneNo_", MySqlDbType.VarChar, input.CompanyPhoneNo),

              CreateParameter("CompanyWebsite_", MySqlDbType.VarChar, input.CompanyWebsite),
              CreateParameter("OwnerName_", MySqlDbType.DateTime, input.OwnerName),
              CreateParameter("OwnerEmailId_", MySqlDbType.VarChar, input.OwnerEmailId),
              CreateParameter("OwnerPhone_", MySqlDbType.VarChar, input.OwnerPhone),



              CreateParameter("CountryId_", MySqlDbType.Int32, input.CountryId),
              CreateParameter("StateId_", MySqlDbType.Int32, input.StateId),
              CreateParameter("DistrictId_", MySqlDbType.Int32, input.DistrictId),
              CreateParameter("CityId_", MySqlDbType.Int32, input.CityId),

                CreateParameter("Type_", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    CompanyMaster obj = new CompanyMaster();
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"]);
                    obj.CompanyName = reader["CompanyName"].ToString();
                    obj.CompanyPhoneNo = reader["CompanyPhoneNo"].ToString();
                    obj.CompanyWebsite = reader["CompanyWebsite"].ToString();
                    obj.CompanyAddress = reader["CompanyAddress"].ToString();
                    obj.CompanyCode = reader["CompanyCode"].ToString();
                    obj.CompanyEmailId = reader["CompanyEmailId"].ToString();

                    obj.OwnerName = reader["OwnerName"].ToString();
                    obj.OwnerEmailId = reader["OwnerEmailId"].ToString();
                    obj.OwnerPhone = reader["OwnerPhone"].ToString();



                    obj.CountryId = Convert.ToInt32(reader["CountryId"].ToString());
                    obj.StateId = Convert.ToInt32(reader["StateId"].ToString());
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"].ToString());
                    obj.CityId = Convert.ToInt32(reader["CityId"].ToString());

                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<CompanyMaster> CompanyMaster_Update(CompanyMaster input)
        {
            List<CompanyMaster> listArea = new List<CompanyMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("CompanyMaster_InsertUpdateDelete",
                CreateParameter("CompanyId_", MySqlDbType.Int32, input.CompanyId),

              CreateParameter("CompanyAddress_", MySqlDbType.VarChar, input.CompanyAddress),
              CreateParameter("CompanyCode_", MySqlDbType.VarChar, input.CompanyCode),
              CreateParameter("CompanyEmailId_", MySqlDbType.VarChar, input.CompanyEmailId),
              CreateParameter("CompanyName_", MySqlDbType.VarChar, input.CompanyName),
              CreateParameter("CompanyPhoneNo_", MySqlDbType.VarChar, input.CompanyPhoneNo),

              CreateParameter("CompanyWebsite_", MySqlDbType.VarChar, input.CompanyWebsite),
              CreateParameter("OwnerName_", MySqlDbType.DateTime, input.OwnerName),
              CreateParameter("OwnerEmailId_", MySqlDbType.VarChar, input.OwnerEmailId),
              CreateParameter("OwnerPhone_", MySqlDbType.VarChar, input.OwnerPhone),



              CreateParameter("CountryId_", MySqlDbType.Int32, input.CountryId),
              CreateParameter("StateId_", MySqlDbType.Int32, input.StateId),
              CreateParameter("DistrictId_", MySqlDbType.Int32, input.DistrictId),
              CreateParameter("CityId_", MySqlDbType.Int32, input.CityId),

                CreateParameter("Type_", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    CompanyMaster obj = new CompanyMaster();
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"]);
                    obj.CompanyName = reader["CompanyName"].ToString();
                    obj.CompanyPhoneNo = reader["CompanyPhoneNo"].ToString();
                    obj.CompanyWebsite = reader["CompanyWebsite"].ToString();
                    obj.CompanyAddress = reader["CompanyAddress"].ToString();
                    obj.CompanyCode = reader["CompanyCode"].ToString();
                    obj.CompanyEmailId = reader["CompanyEmailId"].ToString();

                    obj.OwnerName = reader["OwnerName"].ToString();
                    obj.OwnerEmailId = reader["OwnerEmailId"].ToString();
                    obj.OwnerPhone = reader["OwnerPhone"].ToString();



                    obj.CountryId = Convert.ToInt32(reader["CountryId"].ToString());
                    obj.StateId = Convert.ToInt32(reader["StateId"].ToString());
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"].ToString());
                    obj.CityId = Convert.ToInt32(reader["CityId"].ToString());

                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<CompanyMaster> CompanyMaster_Delete(int companyId)
        {
            List<CompanyMaster> listArea = new List<CompanyMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("CompanyMaster_InsertUpdateDelete",
                CreateParameter("CompanyId_", MySqlDbType.Int32, companyId),

              CreateParameter("CompanyAddress_", MySqlDbType.VarChar, ""),
              CreateParameter("CompanyCode_", MySqlDbType.VarChar, ""),
              CreateParameter("CompanyEmailId_", MySqlDbType.VarChar, ""),
              CreateParameter("CompanyName_", MySqlDbType.VarChar,""),
              CreateParameter("CompanyPhoneNo_", MySqlDbType.VarChar, ""),

              CreateParameter("CompanyWebsite_", MySqlDbType.VarChar, ""),
              CreateParameter("OwnerName_", MySqlDbType.DateTime, ""),
              CreateParameter("OwnerEmailId_", MySqlDbType.VarChar, ""),
              CreateParameter("OwnerPhone_", MySqlDbType.VarChar, ""),



              CreateParameter("CountryId_", MySqlDbType.Int32, -1),
              CreateParameter("StateId_", MySqlDbType.Int32, -1),
              CreateParameter("DistrictId_", MySqlDbType.Int32, -1),
              CreateParameter("CityId_", MySqlDbType.Int32, -1),

                CreateParameter("Type_", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    CompanyMaster obj = new CompanyMaster();
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"]);
                    obj.CompanyName = reader["CompanyName"].ToString();
                    obj.CompanyPhoneNo = reader["CompanyPhoneNo"].ToString();
                    obj.CompanyWebsite = reader["CompanyWebsite"].ToString();
                    obj.CompanyAddress = reader["CompanyAddress"].ToString();
                    obj.CompanyCode = reader["CompanyCode"].ToString();
                    obj.CompanyEmailId = reader["CompanyEmailId"].ToString();

                    obj.OwnerName = reader["OwnerName"].ToString();
                    obj.OwnerEmailId = reader["OwnerEmailId"].ToString();
                    obj.OwnerPhone = reader["OwnerPhone"].ToString();



                    obj.CountryId = Convert.ToInt32(reader["CountryId"].ToString());
                    obj.StateId = Convert.ToInt32(reader["StateId"].ToString());
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"].ToString());
                    obj.CityId = Convert.ToInt32(reader["CityId"].ToString());

                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    listArea.Add(obj);
                }
            }
            return listArea;
        }
    }
}

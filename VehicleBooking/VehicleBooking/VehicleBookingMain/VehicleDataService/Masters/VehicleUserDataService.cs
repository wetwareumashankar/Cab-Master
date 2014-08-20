using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperCS.DataAccessLayer;
using VehicleBL.Masters;
using MySql.Data.MySqlClient;

namespace VehicleDataService.Masters
{
    public class VehicleUserDataService : MySqlDataServiceBase
    {
        public VehicleUsersMaster vehicleusers_Retrieve(int id)
        {
            VehicleUsersMaster obj = new VehicleUsersMaster();
            using (MySqlDataReader reader = ExecuteDataReader("vehicleusers_Retrieve",
                CreateParameter("UserId_", MySqlDbType.Int32, id)
                ))
            {
                while (reader.Read())
                {
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.StateId = Convert.ToInt32(reader["CityId"]);
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.UserId = Convert.ToInt32(reader["UserId"]);

                    obj.UserName = reader["UserName"].ToString();

                    obj.FullName = reader["FullName"].ToString();
                    obj.PhoneNo = reader["PhoneNo"].ToString();
                    obj.EmailId = reader["EmailId"].ToString();
                    obj.AdhaarNo = reader["AdhaarNo"].ToString();

                    //obj.EmergencyContactName = reader["EmergencyContactName"].ToString();
                    //obj.EmergencyContactNo = reader["EmergencyContactNo"].ToString();

                    obj.Address = reader["Address"].ToString();
                    obj.VoterId = reader["VoterId"].ToString();
                    obj.DLNo = reader["DLNo"].ToString();
                    obj.DLExpiryDate = Convert.ToDateTime(reader["DLExpiryDate"]);

                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
            }
            return obj;
        }

        public List<VehicleUsersMaster> vehicleusers_RetrieveAll()
        {
            List<VehicleUsersMaster> listvehicleusers = new List<VehicleUsersMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("vehicleusers_Retrieve",
                CreateParameter("UserId_", MySqlDbType.Int32, -1)))
            {
                while (reader.Read())
                {
                    VehicleUsersMaster obj = new VehicleUsersMaster();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.StateId = Convert.ToInt32(reader["CityId"]);
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.UserId = Convert.ToInt32(reader["UserId"]);

                    obj.UserName = reader["UserName"].ToString();

                    obj.FullName = reader["FullName"].ToString();
                    obj.PhoneNo = reader["PhoneNo"].ToString();
                    obj.EmailId = reader["EmailId"].ToString();
                    obj.AdhaarNo = reader["AdhaarNo"].ToString();

                    //obj.EmergencyContactName = reader["EmergencyContactName"].ToString();
                    //obj.EmergencyContactNo = reader["EmergencyContactNo"].ToString();

                    obj.Address = reader["Address"].ToString();
                    obj.VoterId = reader["VoterId"].ToString();
                    obj.DLNo = reader["DLNo"].ToString();
                    obj.DLExpiryDate = Convert.ToDateTime(reader["DLExpiryDate"]);

                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listvehicleusers.Add(obj);
                }
            }
            return listvehicleusers;
        }

        public List<VehicleUsersMaster> vehicleusers_Insert(VehicleUsersMaster input)
        {
            List<VehicleUsersMaster> listvehicleusers = new List<VehicleUsersMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("vehicleusers_InsertUpdateDelete",
                CreateParameter("UserId_", MySqlDbType.Int32, -1),
              CreateParameter("CountryId_", MySqlDbType.Int32, input.CountryId),
              CreateParameter("StateId_", MySqlDbType.Int32, input.StateId),
              CreateParameter("CityId_", MySqlDbType.Int32, input.CityId),
              CreateParameter("DistrictId_", MySqlDbType.Int32, input.DistrictId),
              CreateParameter("Address_", MySqlDbType.VarChar, input.Address),
              CreateParameter("AdhaarNo_", MySqlDbType.VarChar, input.AdhaarNo),
              CreateParameter("DLExpiryDate_", MySqlDbType.DateTime, input.DLExpiryDate),
              CreateParameter("DLNo_", MySqlDbType.VarChar, input.DLNo),
              CreateParameter("EmailId_", MySqlDbType.VarChar, input.EmailId),
              CreateParameter("FullName_", MySqlDbType.VarChar, input.FullName),
              CreateParameter("Password_", MySqlDbType.VarChar, input.Password),
              CreateParameter("PhoneNo_", MySqlDbType.VarChar, input.PhoneNo),
              CreateParameter("UserName_", MySqlDbType.VarChar, input.UserName),
              CreateParameter("VoterId_", MySqlDbType.VarChar, input.VoterId),
                CreateParameter("Type_", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    VehicleUsersMaster obj = new VehicleUsersMaster();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.StateId = Convert.ToInt32(reader["CityId"]);
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.UserId = Convert.ToInt32(reader["UserId"]);

                    obj.UserName = reader["UserName"].ToString();

                    obj.FullName = reader["FullName"].ToString();
                    obj.PhoneNo = reader["PhoneNo"].ToString();
                    obj.EmailId = reader["EmailId"].ToString();
                    obj.AdhaarNo = reader["AdhaarNo"].ToString();

                    obj.Address = reader["Address"].ToString();
                    obj.VoterId = reader["VoterId"].ToString();
                    obj.DLNo = reader["DLNo"].ToString();
                    obj.DLExpiryDate = Convert.ToDateTime(reader["DLExpiryDate"]);

                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listvehicleusers.Add(obj);
                }
            }
            return listvehicleusers;
        }

        public List<VehicleUsersMaster> vehicleusers_Update(VehicleUsersMaster input)
        {
            List<VehicleUsersMaster> listvehicleusers = new List<VehicleUsersMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("vehicleusers_InsertUpdateDelete",
               CreateParameter("UserId_", MySqlDbType.Int32, input.UserId),
              CreateParameter("CountryId_", MySqlDbType.Int32, input.CountryId),
              CreateParameter("StateId_", MySqlDbType.Int32, input.StateId),
              CreateParameter("CityId_", MySqlDbType.Int32, input.CityId),
              CreateParameter("DistrictId_", MySqlDbType.Int32, input.DistrictId),
              CreateParameter("Address_", MySqlDbType.VarChar, input.Address),
              CreateParameter("AdhaarNo_", MySqlDbType.VarChar, input.AdhaarNo),
              CreateParameter("DLExpiryDate_", MySqlDbType.DateTime, input.DLExpiryDate),
              CreateParameter("DLNo_", MySqlDbType.VarChar, input.DLNo),
              CreateParameter("EmailId_", MySqlDbType.VarChar, input.EmailId),
              CreateParameter("FullName_", MySqlDbType.VarChar, input.FullName),
              CreateParameter("Password_", MySqlDbType.VarChar, input.Password),
              CreateParameter("PhoneNo_", MySqlDbType.VarChar, input.PhoneNo),
              CreateParameter("UserName_", MySqlDbType.VarChar, input.UserName),
              CreateParameter("VoterId_", MySqlDbType.VarChar, input.VoterId),
                CreateParameter("Type_", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    VehicleUsersMaster obj = new VehicleUsersMaster();

                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.StateId = Convert.ToInt32(reader["CityId"]);
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.UserId = Convert.ToInt32(reader["UserId"]);

                    obj.UserName = reader["UserName"].ToString();

                    obj.FullName = reader["FullName"].ToString();
                    obj.PhoneNo = reader["PhoneNo"].ToString();
                    obj.EmailId = reader["EmailId"].ToString();
                    obj.AdhaarNo = reader["AdhaarNo"].ToString();

                    obj.Address = reader["Address"].ToString();
                    obj.VoterId = reader["VoterId"].ToString();
                    obj.DLNo = reader["DLNo"].ToString();
                    obj.DLExpiryDate = Convert.ToDateTime(reader["DLExpiryDate"]);

                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listvehicleusers.Add(obj);
                }
            }
            return listvehicleusers;
        }

        public List<VehicleUsersMaster> vehicleusers_Delete(int userId)
        {
            List<VehicleUsersMaster> listvehicleusers = new List<VehicleUsersMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("vehicleusers_InsertUpdateDelete",
                CreateParameter("UserId_", MySqlDbType.Int32, userId),
              CreateParameter("CountryId_", MySqlDbType.Int32, -1),
              CreateParameter("StateId_", MySqlDbType.Int32, -1),
              CreateParameter("CityId_", MySqlDbType.Int32, -1),
              CreateParameter("DistrictId_", MySqlDbType.Int32, -1),
              CreateParameter("Address_", MySqlDbType.VarChar, ""),
              CreateParameter("AdhaarNo_", MySqlDbType.VarChar, ""),
              CreateParameter("DLExpiryDate_", MySqlDbType.DateTime, DateTime.Now),
              CreateParameter("DLNo_", MySqlDbType.VarChar, ""),
              CreateParameter("EmailId_", MySqlDbType.VarChar, ""),
              CreateParameter("FullName_", MySqlDbType.VarChar, ""),
              CreateParameter("Password_", MySqlDbType.VarChar, ""),
              CreateParameter("PhoneNo_", MySqlDbType.VarChar,""),
              CreateParameter("UserName_", MySqlDbType.VarChar, ""),
              CreateParameter("VoterId_", MySqlDbType.VarChar, ""),
                CreateParameter("Type", MySqlDbType.Int32, 3)))
            {
                while (reader.Read())
                {
                    VehicleUsersMaster obj = new VehicleUsersMaster();
                    obj.CityId = Convert.ToInt32(reader["CityId"]);
                    obj.StateId = Convert.ToInt32(reader["CityId"]);
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    obj.UserId = Convert.ToInt32(reader["UserId"]);

                    obj.UserName = reader["UserName"].ToString();

                    obj.FullName = reader["FullName"].ToString();
                    obj.PhoneNo = reader["PhoneNo"].ToString();
                    obj.EmailId = reader["EmailId"].ToString();
                    obj.AdhaarNo = reader["AdhaarNo"].ToString();

                    obj.Address = reader["Address"].ToString();
                    obj.VoterId = reader["VoterId"].ToString();
                    obj.DLNo = reader["DLNo"].ToString();
                    obj.DLExpiryDate = Convert.ToDateTime(reader["DLExpiryDate"]);

                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listvehicleusers.Add(obj);
                }
            }
            return listvehicleusers;
        }
    }
}

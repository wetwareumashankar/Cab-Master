using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperCS.DataAccessLayer;
using VehicleBL.Masters;
using MySql.Data.MySqlClient;

namespace VehicleDataService.Masters
{
    public class VehicleMasterDataService : MySqlDataServiceBase
    {
        public VehicleMaster VehicleMaster_Retrieve(int id)
        {
            VehicleMaster obj = new VehicleMaster();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleMaster_Retrieve",
                CreateParameter("VehicleId_", MySqlDbType.Int32, id)
                ))
            {
                while (reader.Read())
                {
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleId = Convert.ToInt32(reader["VehicleId"].ToString());
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"].ToString());
                    obj.PurchaseDate = Convert.ToDateTime(reader["PurchaseDate"]);
                    obj.VehicleNo = reader["VehicleNo"].ToString();
                    obj.Color = reader["Color"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
            }
            return obj;
        }

        public List<VehicleMaster> VehicleMaster_RetrieveAll()
        {
            List<VehicleMaster> listArea = new List<VehicleMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleMaster_Retrieve",
                  CreateParameter("VehicleId_", MySqlDbType.Int32, -1)
                  ))
            {
                while (reader.Read())
                {
                    VehicleMaster obj = new VehicleMaster();
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleId = Convert.ToInt32(reader["VehicleId"].ToString());
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"].ToString());
                    obj.PurchaseDate = Convert.ToDateTime(reader["PurchaseDate"]);
                    obj.VehicleNo = reader["VehicleNo"].ToString();
                    obj.Color = reader["Color"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<VehicleMaster> VehicleMaster_Insert(VehicleMaster input)
        {
            List<VehicleMaster> listArea = new List<VehicleMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleMaster_InsertUpdateDelete",
                CreateParameter("VehicleId_", MySqlDbType.Int32, -1),
              CreateParameter("VehicleTypeId_", MySqlDbType.Int32, input.VehicleTypeId),
              CreateParameter("CompanyId_", MySqlDbType.Int32, input.CompanyId),
              CreateParameter("PurchaseDate_", MySqlDbType.DateTime, input.PurchaseDate),
              CreateParameter("VehicleNo_", MySqlDbType.VarChar, input.VehicleNo),
              CreateParameter("Color_", MySqlDbType.VarChar, input.Color),
                CreateParameter("Type_", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    VehicleMaster obj = new VehicleMaster();
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleId = Convert.ToInt32(reader["VehicleId"].ToString());
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"].ToString());
                    obj.PurchaseDate = Convert.ToDateTime(reader["PurchaseDate"]);
                    obj.VehicleNo = reader["VehicleNo"].ToString();
                    obj.Color = reader["Color"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<VehicleMaster> VehicleMaster_Update(VehicleMaster input)
        {
            List<VehicleMaster> listArea = new List<VehicleMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleMaster_InsertUpdateDelete",
                CreateParameter("VehicleId_", MySqlDbType.Int32, input.VehicleId),
              CreateParameter("VehicleTypeId_", MySqlDbType.Int32, input.VehicleTypeId),
              CreateParameter("CompanyId_", MySqlDbType.Int32, input.CompanyId),
              CreateParameter("PurchaseDate_", MySqlDbType.DateTime, input.PurchaseDate),
              CreateParameter("VehicleNo_", MySqlDbType.VarChar, input.VehicleNo),
              CreateParameter("Color_", MySqlDbType.VarChar, input.Color),
                CreateParameter("Type_", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    VehicleMaster obj = new VehicleMaster();
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleId = Convert.ToInt32(reader["VehicleId"].ToString());
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"].ToString());
                    obj.PurchaseDate = Convert.ToDateTime(reader["PurchaseDate"]);
                    obj.VehicleNo = reader["VehicleNo"].ToString();
                    obj.Color = reader["Color"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<VehicleMaster> VehicleMaster_Delete(int vehicleId)
        {
            List<VehicleMaster> listArea = new List<VehicleMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleMaster_InsertUpdateDelete",
                CreateParameter("VehicleId_", MySqlDbType.Int32, vehicleId),
              CreateParameter("VehicleTypeId_", MySqlDbType.Int32,-1),
              CreateParameter("CompanyId_", MySqlDbType.Int32, -1),
              CreateParameter("PurchaseDate_", MySqlDbType.DateTime, DateTime.Now),
              CreateParameter("VehicleNo_", MySqlDbType.VarChar, ""),
              CreateParameter("Color_", MySqlDbType.VarChar, ""),
                CreateParameter("Type_", MySqlDbType.Int32, 3)))
            {
                while (reader.Read())
                {
                    VehicleMaster obj = new VehicleMaster();
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleId = Convert.ToInt32(reader["VehicleId"].ToString());
                    obj.CompanyId = Convert.ToInt32(reader["CompanyId"].ToString());
                    obj.PurchaseDate = Convert.ToDateTime(reader["PurchaseDate"]);
                    obj.VehicleNo = reader["VehicleNo"].ToString();
                    obj.Color = reader["Color"].ToString();
                    obj.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    listArea.Add(obj);
                }
            }
            return listArea;
        }
    }
}

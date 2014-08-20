using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperCS.DataAccessLayer;
using VehicleBL.Masters;
using MySql.Data.MySqlClient;

namespace VehicleDataService.Masters
{
    public class VehicleTypeDataService : MySqlDataServiceBase
    {
        public VehicleTypeMaster VehicleType_Retrieve(int id)
        {
            VehicleTypeMaster obj = new VehicleTypeMaster();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleType_Retrieve",
                CreateParameter("VehicleTypeId_", MySqlDbType.Int32, id)
                ))
            {
                while (reader.Read())
                {
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleTypeName = reader["VehicleTypeName"].ToString();
                    obj.ServiceType = reader["ServiceType"].ToString();
                    obj.Remarks = reader["Remarks"].ToString();
                    obj.ExtraCapacity = reader["ExtraCapacity"].ToString();
                    obj.Capacity = reader["Capacity"].ToString();
                    obj.LuggageCapacity = reader["LuggageCapacity"].ToString();
                }
            }
            return obj;
        }

        public List<VehicleTypeMaster> VehicleType_RetrieveAll()
        {
            List<VehicleTypeMaster> listArea = new List<VehicleTypeMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleType_Retrieve",
                CreateParameter("VehicleTypeId_", MySqlDbType.Int32, -1)
                ))
            {
                while (reader.Read())
                {
                    VehicleTypeMaster obj = new VehicleTypeMaster();
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleTypeName = reader["VehicleTypeName"].ToString();
                    obj.ServiceType = reader["ServiceType"].ToString();
                    obj.Remarks = reader["Remarks"].ToString();
                    obj.ExtraCapacity = reader["ExtraCapacity"].ToString();
                    obj.Capacity = reader["Capacity"].ToString();
                    obj.LuggageCapacity = reader["LuggageCapacity"].ToString();
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<VehicleTypeMaster> VehicleType_Insert(VehicleTypeMaster input)
        {
            List<VehicleTypeMaster> listArea = new List<VehicleTypeMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleType_InsertUpdateDelete",
              CreateParameter("VehicleTypeId_", MySqlDbType.Int32, -1),
              CreateParameter("VehicleTypeName_", MySqlDbType.VarChar, input.VehicleTypeName),
              CreateParameter("ServiceType_", MySqlDbType.VarChar, input.ServiceType),
              CreateParameter("Remarks_", MySqlDbType.VarChar, input.Remarks),
              CreateParameter("ExtraCapacity_", MySqlDbType.VarChar, input.ExtraCapacity),
              CreateParameter("LuggageCapacity_", MySqlDbType.VarChar, input.LuggageCapacity),
                CreateParameter("Type_", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    VehicleTypeMaster obj = new VehicleTypeMaster();
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleTypeName = reader["VehicleTypeName"].ToString();
                    obj.ServiceType = reader["ServiceType"].ToString();
                    obj.Remarks = reader["Remarks"].ToString();
                    obj.ExtraCapacity = reader["ExtraCapacity"].ToString();
                    obj.LuggageCapacity = reader["LuggageCapacity"].ToString();
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<VehicleTypeMaster> VehicleType_Update(VehicleTypeMaster input)
        {
            List<VehicleTypeMaster> listArea = new List<VehicleTypeMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleType_InsertUpdateDelete",
              CreateParameter("VehicleTypeId_", MySqlDbType.Int32, input.VehicleTypeId),
              CreateParameter("VehicleTypeName_", MySqlDbType.VarChar, input.VehicleTypeName),
              CreateParameter("ServiceType_", MySqlDbType.VarChar, input.ServiceType),
              CreateParameter("Remarks_", MySqlDbType.VarChar, input.Remarks),
              CreateParameter("ExtraCapacity_", MySqlDbType.VarChar, input.ExtraCapacity),
              CreateParameter("LuggageCapacity_", MySqlDbType.VarChar, input.LuggageCapacity),
                CreateParameter("Type_", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    VehicleTypeMaster obj = new VehicleTypeMaster();
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleTypeName = reader["VehicleTypeName"].ToString();
                    obj.ServiceType = reader["ServiceType"].ToString();
                    obj.Remarks = reader["Remarks"].ToString();
                    obj.ExtraCapacity = reader["ExtraCapacity"].ToString();
                    obj.LuggageCapacity = reader["LuggageCapacity"].ToString();
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

        public List<VehicleTypeMaster> VehicleType_Delete(int vehicleTypeId)
        {
            List<VehicleTypeMaster> listArea = new List<VehicleTypeMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("VehicleType_InsertUpdateDelete",
              CreateParameter("VehicleTypeId_", MySqlDbType.Int32, vehicleTypeId),
              CreateParameter("VehicleTypeName_", MySqlDbType.VarChar, ""),
              CreateParameter("ServiceType_", MySqlDbType.VarChar, ""),
              CreateParameter("Remarks_", MySqlDbType.VarChar, ""),
              CreateParameter("ExtraCapacity_", MySqlDbType.VarChar, ""),
              CreateParameter("LuggageCapacity_", MySqlDbType.VarChar, ""),
                CreateParameter("Type_", MySqlDbType.Int32, 3)))
            {
                while (reader.Read())
                {
                    VehicleTypeMaster obj = new VehicleTypeMaster();
                    obj.VehicleTypeId = Convert.ToInt32(reader["VehicleTypeId"]);
                    obj.VehicleTypeName = reader["VehicleTypeName"].ToString();
                    obj.ServiceType = reader["ServiceType"].ToString();
                    obj.Remarks = reader["Remarks"].ToString();
                    obj.ExtraCapacity = reader["ExtraCapacity"].ToString();
                    obj.LuggageCapacity = reader["LuggageCapacity"].ToString();
                    listArea.Add(obj);
                }
            }
            return listArea;
        }

    }
}

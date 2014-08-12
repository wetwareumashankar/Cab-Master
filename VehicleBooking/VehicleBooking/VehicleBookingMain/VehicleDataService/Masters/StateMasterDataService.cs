using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DapperCS.DataAccessLayer;
using VehicleBL.Masters;
using MySql.Data.MySqlClient;

namespace VehicleDataService.Masters
{
    public class StateMasterDataService : MySqlDataServiceBase
    {
        public StateMaster State_Retrieve(int id)
        {
            StateMaster obj = new StateMaster();
            using (MySqlDataReader reader = ExecuteDataReader("State_Retrieve",
                CreateParameter("StateId", MySqlDbType.Int32, id)))
            {
                while (reader.Read())
                {
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateCode = reader["StateCode"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.STDCode = reader["STDCode"].ToString();
                }
            }
            return obj;
        }

        public List<StateMaster> State_RetrieveAll(int countryId)
        {
            List<StateMaster> listState = new List<StateMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("State_Retrieve",
                 CreateParameter("CountryId", MySqlDbType.Int32, countryId)))
            {
                while (reader.Read())
                {
                    StateMaster obj = new StateMaster();
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateCode = reader["StateCode"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.STDCode = reader["STDCode"].ToString();
                    listState.Add(obj);
                }
            }
            return listState;
        }

        public List<StateMaster> State_Insert(StateMaster input)
        {
            List<StateMaster> listState = new List<StateMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("State_InsertUpdateDelete",
                CreateParameter("CountryId", MySqlDbType.Int32, input.CountryId),
                CreateParameter("StateCode", MySqlDbType.VarChar, input.StateCode),
                CreateParameter("StateName", MySqlDbType.VarChar, input.StateName),
                CreateParameter("STDCode", MySqlDbType.VarChar, input.STDCode),
                CreateParameter("Type", MySqlDbType.Int32, 1)))
            {
                while (reader.Read())
                {
                    StateMaster obj = new StateMaster();
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateCode = reader["StateCode"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.STDCode = reader["STDCode"].ToString();
                    listState.Add(obj);
                }
            }
            return listState;
        }

        public List<StateMaster> State_Update(StateMaster input)
        {
            List<StateMaster> listState = new List<StateMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("State_InsertUpdateDelete",
                CreateParameter("StateId", MySqlDbType.Int32, input.StateId),
               CreateParameter("CountryId", MySqlDbType.Int32, input.CountryId),
                CreateParameter("StateCode", MySqlDbType.VarChar, input.StateCode),
                CreateParameter("StateName", MySqlDbType.VarChar, input.StateName),
                CreateParameter("STDCode", MySqlDbType.VarChar, input.STDCode),
                CreateParameter("Type", MySqlDbType.Int32, 2)))
            {
                while (reader.Read())
                {
                    StateMaster obj = new StateMaster();
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateCode = reader["StateCode"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.STDCode = reader["STDCode"].ToString();
                    listState.Add(obj);
                }
            }
            return listState;
        }

        public List<StateMaster> State_Delete(int stateId)
        {
            List<StateMaster> listState = new List<StateMaster>();
            using (MySqlDataReader reader = ExecuteDataReader("State_InsertUpdateDelete",
                CreateParameter("stateId", MySqlDbType.Int32, stateId),
                CreateParameter("Type", MySqlDbType.Int32, 3)))
            {
                while (reader.Read())
                {
                    StateMaster obj = new StateMaster();
                    obj.CountryId = Convert.ToInt32(reader["CountryId"]);
                    obj.CountryName = reader["CountryName"].ToString();
                    obj.StateId = Convert.ToInt32(reader["StateId"]);
                    obj.StateCode = reader["StateCode"].ToString();
                    obj.StateName = reader["StateName"].ToString();
                    obj.STDCode = reader["STDCode"].ToString();
                    listState.Add(obj);
                }
            }
            return listState;
        }

    }
}

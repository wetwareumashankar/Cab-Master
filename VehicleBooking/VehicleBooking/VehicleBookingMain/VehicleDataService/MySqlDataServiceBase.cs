using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DapperCS.Common;
using MySql.Data.MySqlClient;

namespace DapperCS.DataAccessLayer
{

    ////////////////////////////////////////////////////////////////////////////
    /// <summary>
    ///   Defines common DataService routines for transaction management, 
    ///   stored procedure execution, parameter creation, and null value 
    ///   checking
    /// </summary>	
    ////////////////////////////////////////////////////////////////////////////
    public class MySqlDataServiceBase
    {
        public MySqlDataServiceBase()
        {
        }


        ////////////////////////////////////////////////////////////////////////
        // Connection and Transaction Methods
        ////////////////////////////////////////////////////////////////////////
        public static string GetConnectionString()
        {
            // return ConfigurationManager.ConnectionStrings["RemoteFastrackConnString"].ConnectionString;
            return ConfigurationManager.ConnectionStrings["MySqlVehicleConString"].ConnectionString;
        }

        ////////////////////////////////////////////////////////////////////////
        // ExecuteDataSet Methods
        ////////////////////////////////////////////////////////////////////////
        

        ////////////////////////////////////////////////////////////////////////
        // ExecuteNonQuery Methods
        ////////////////////////////////////////////////////////////////////////
        public void ExecuteNonQuery(string procName,
            params IDataParameter[] procParams)
        {
            MySqlCommand  cmd;
            ExecuteNonQuery(out cmd, procName, procParams);
        }


        public void ExecuteNonQuery(out MySqlCommand  cmd, string procName,
            params IDataParameter[] procParams)
        {
            //Method variables
            MySqlConnection cnx = null;
            cmd = null;  //Avoids "Use of unassigned variable" compiler error

            try
            {
                //Setup command object
                cmd = new MySqlCommand (procName);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int index = 0; index < procParams.Length; index++)
                {
                    cmd.Parameters.Add(procParams[index]);
                }

               
                cnx = new MySqlConnection(GetConnectionString());
                cmd.Connection = cnx;
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
                
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                cnx.Close();
                cnx.Dispose(); //Implicitly calls cnx.Close()
                
                if (cmd != null) cmd.Dispose();
            }
        }

        public void ExecuteNonQuery(out MySqlCommand  cmd, string SQLstring)
        {
            //Method variables
            MySqlConnection cnx = null;
            cmd = null;  //Avoids "Use of unassigned variable" compiler error

            try
            {
                //Setup command object
                cmd = new MySqlCommand (SQLstring);
                cmd.CommandType = CommandType.Text;
               
                cnx = new MySqlConnection(GetConnectionString());
                cmd.Connection = cnx;
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
               
                //Execute the command
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
               
                cnx.Close();
                cnx.Dispose(); //Implicitly calls cnx.Close()
                if (cmd != null) cmd.Dispose();
            }
        }
        
        public void ExecuteCreateQuery(string SQLstring)
        {
            MySqlConnection cnx = null;
            MySqlCommand  cmd = new MySqlCommand ();

            try
            {
                //Setup command object
                cmd = new MySqlCommand (SQLstring);
                cmd.CommandType = CommandType.Text;
              
                cnx = new MySqlConnection(GetConnectionString());
                cmd.Connection = cnx;
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
               
                //Fill the dataset
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (cmd != null) cmd.Dispose();
               
                cnx.Close();
                cnx.Dispose(); //Implicitly calls cnx.Close()
              
            }

        }

        public MySqlDataReader ExecuteDataReader(string SQLstring)
        {
            //Method variables
            MySqlConnection cnx = null;
            MySqlCommand  cmd = new MySqlCommand (SQLstring);
            MySqlDataReader dr;
            try
            {

                cnx = new MySqlConnection(GetConnectionString());
                cmd.Connection = cnx;
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
             
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
              
                return dr;
            }
            catch
            {
                throw;
            }
            finally
            {
               
            }
        }

        public MySqlDataReader ExecuteDataReader(string procName,
             params IDataParameter[] procParams)
        {
            //Method variables
            MySqlConnection cnx = null;
            MySqlCommand  cmd = null;  //Avoids "Use of unassigned variable" compiler error

            //Setup command object
            cmd = new MySqlCommand (procName);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int index = 0; index < procParams.Length; index++)
            {
                cmd.Parameters.Add(procParams[index]);
            }
            //Method variables

            MySqlDataReader dr;
            try
            {
              
                cnx = new MySqlConnection(GetConnectionString());
                cmd.Connection = cnx;
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
               
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
             
                return dr;
            }
            catch
            {
                throw;
            }
            finally
            {
               
            }
        }


        ////////////////////////////////////////////////////////////////////////
        // CreateParameter Methods
        ////////////////////////////////////////////////////////////////////////
        public MySqlParameter CreateParameter(string paramName,
            MySqlDbType paramType, object paramValue)
        {
            MySqlParameter param = new MySqlParameter(paramName, paramType);
            try
            {
                if (paramValue != DBNull.Value)
                {
                    switch (paramType)
                    {
                        case MySqlDbType.VarChar:
                        case MySqlDbType.Text:
                            paramValue = CheckParamValue((string)paramValue);
                            break;
                        case MySqlDbType.DateTime:
                            paramValue = CheckParamValue((DateTime)paramValue);
                            break;
                        case MySqlDbType.Int32:
                            paramValue = CheckParamValue((int)paramValue);
                            break;
                        case MySqlDbType.Guid:
                            paramValue = CheckParamValue(GetGuid(paramValue));
                            break;
                        case MySqlDbType.Bit:
                            if (paramValue is bool) paramValue = (int)((bool)paramValue ? 1 : 0);
                            if ((int)paramValue < 0 || (int)paramValue > 1) paramValue = Constants.NullInt;
                            paramValue = CheckParamValue((int)paramValue);
                            break;
                        case MySqlDbType.Float:
                            paramValue = CheckParamValue(Convert.ToSingle(paramValue));
                            break;
                        case MySqlDbType.Decimal:
                            paramValue = CheckParamValue((decimal)paramValue);
                            break;
                    }
                }
                param.Value = paramValue;
            }
            catch (Exception ex)
            {
            }
            return param;
        }

        public MySqlParameter CreateParameter(string paramName, MySqlDbType paramType, ParameterDirection direction)
        {
            MySqlParameter returnVal = CreateParameter(paramName, paramType, DBNull.Value);
            returnVal.Direction = direction;
            return returnVal;
        }

        public MySqlParameter CreateParameter(string paramName, MySqlDbType paramType, object paramValue, ParameterDirection direction)
        {
            MySqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
            returnVal.Direction = direction;
            return returnVal;
        }

        public MySqlParameter CreateParameter(string paramName, MySqlDbType paramType, object paramValue, int size)
        {
            MySqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
            returnVal.Size = size;
            return returnVal;
        }

        public MySqlParameter CreateParameter(string paramName, MySqlDbType paramType, object paramValue, int size, ParameterDirection direction)
        {
            MySqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
            returnVal.Direction = direction;
            returnVal.Size = size;
            return returnVal;
        }

        public MySqlParameter CreateParameter(string paramName, MySqlDbType paramType, object paramValue, int size, byte precision)
        {
            MySqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
            returnVal.Size = size;
            ((MySqlParameter)returnVal).Precision = precision;
            return returnVal;
        }

        public MySqlParameter CreateParameter(string paramName, MySqlDbType paramType, object paramValue, int size, byte precision, ParameterDirection direction)
        {
            MySqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
            returnVal.Direction = direction;
            returnVal.Size = size;
            returnVal.Precision = precision;
            return returnVal;
        }


        ////////////////////////////////////////////////////////////////////////
        // CheckParamValue Methods
        ////////////////////////////////////////////////////////////////////////
        public Guid GetGuid(object value)
        {
            Guid returnVal = Constants.NullGuid;
            if (value is string)
            {
                returnVal = new Guid((string)value);
            }
            else if (value is Guid)
            {
                returnVal = (Guid)value;
            }
            return returnVal;
        }

        public object CheckParamValue(string paramValue)
        {
            if (string.IsNullOrEmpty(paramValue))
            {
                return DBNull.Value;
            }
            else
            {
                return paramValue;
            }
        }

        public object CheckParamValue(Guid paramValue)
        {
            if (paramValue.Equals(Constants.NullGuid))
            {
                return DBNull.Value;
            }
            else
            {
                return paramValue;
            }
        }

        public object CheckParamValue(DateTime paramValue)
        {
            if (paramValue.Equals(Constants.NullDateTime))
            {
                return DBNull.Value;
            }
            else
            {
                return paramValue;
            }
        }

        public object CheckParamValue(double paramValue)
        {
            if (paramValue.Equals(Constants.NullDouble))
            {
                return DBNull.Value;
            }
            else
            {
                return paramValue;
            }
        }

        public object CheckParamValue(float paramValue)
        {
            if (paramValue.Equals(Constants.NullFloat))
            {
                return DBNull.Value;
            }
            else
            {
                return paramValue;
            }
        }

        public object CheckParamValue(Decimal paramValue)
        {
            if (paramValue.Equals(Constants.NullDecimal))
            {
                return DBNull.Value;
            }
            else
            {
                return paramValue;
            }
        }

        public object CheckParamValue(int paramValue)
        {
            if (paramValue.Equals(Constants.NullInt))
            {
                return DBNull.Value;
            }
            else
            {
                return paramValue;
            }
        }

    } //class 

} //namespace
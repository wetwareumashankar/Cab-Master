using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DapperCS.Common;

namespace DapperCS.DataAccessLayer
{

    ////////////////////////////////////////////////////////////////////////////
    /// <summary>
    ///   Defines common DataService routines for transaction management, 
    ///   stored procedure execution, parameter creation, and null value 
    ///   checking
    /// </summary>	
    ////////////////////////////////////////////////////////////////////////////
    public class DataServiceBase
    {
        public DataServiceBase()
        {
        }


        ////////////////////////////////////////////////////////////////////////
        // Connection and Transaction Methods
        ////////////////////////////////////////////////////////////////////////
        public static string GetConnectionString()
        {
            // return ConfigurationManager.ConnectionStrings["RemoteFastrackConnString"].ConnectionString;
            return ConfigurationManager.ConnectionStrings["VehicleConString"].ConnectionString;
        }

        ////////////////////////////////////////////////////////////////////////
        // ExecuteDataSet Methods
        ////////////////////////////////////////////////////////////////////////
        public DataSet ExecuteDataSet(string procName,
            params IDataParameter[] procParams)
        {
            SqlCommand cmd;
            return ExecuteDataSet(out cmd, procName, procParams);
        }


        public DataSet ExecuteDataSet(out SqlCommand cmd, string procName,
            params IDataParameter[] procParams)
        {
            SqlConnection cnx = null;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd = null;

            try
            {
                //Setup command object
                cmd = new SqlCommand(procName);
                cmd.CommandType = CommandType.StoredProcedure;
                if (procParams != null)
                {
                    for (int index = 0; index < procParams.Length; index++)
                    {
                        cmd.Parameters.Add(procParams[index]);
                    }
                }
                da.SelectCommand = (SqlCommand)cmd;
                System.Diagnostics.Trace.Write(da.SelectCommand);
                cnx = new SqlConnection(GetConnectionString());
                cmd.Connection = cnx;
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
                da.Fill(ds);
            }
            catch
            {
                throw;
            }
            finally
            {
                if (da != null) da.Dispose();
                if (cmd != null) cmd.Dispose();
                cnx.Close();
                cnx.Dispose(); //Implicitly calls cnx.Close()
            }
            return ds;
        }


        ////////////////////////////////////////////////////////////////////////
        // ExecuteNonQuery Methods
        ////////////////////////////////////////////////////////////////////////
        public void ExecuteNonQuery(string procName,
            params IDataParameter[] procParams)
        {
            SqlCommand cmd;
            ExecuteNonQuery(out cmd, procName, procParams);
        }


        public void ExecuteNonQuery(out SqlCommand cmd, string procName,
            params IDataParameter[] procParams)
        {
            //Method variables
            SqlConnection cnx = null;
            cmd = null;  //Avoids "Use of unassigned variable" compiler error

            try
            {
                //Setup command object
                cmd = new SqlCommand(procName);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int index = 0; index < procParams.Length; index++)
                {
                    cmd.Parameters.Add(procParams[index]);
                }

               
                cnx = new SqlConnection(GetConnectionString());
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

        public void ExecuteNonQuery(out SqlCommand cmd, string SQLstring)
        {
            //Method variables
            SqlConnection cnx = null;
            cmd = null;  //Avoids "Use of unassigned variable" compiler error

            try
            {
                //Setup command object
                cmd = new SqlCommand(SQLstring);
                cmd.CommandType = CommandType.Text;
               
                cnx = new SqlConnection(GetConnectionString());
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
        public DataTable ExecuteQuery(string SQLstring)
        {
            SqlConnection cnx = null;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            try
            {
                //Setup command object
                cmd = new SqlCommand(SQLstring);
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = (SqlCommand)cmd;

                cnx = new SqlConnection(GetConnectionString());
                cmd.Connection = cnx;
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
             
                //Fill the dataset
                da.Fill(dt);
            }
            catch
            {
                throw;
            }
            finally
            {
                if (da != null) da.Dispose();
                if (cmd != null) cmd.Dispose();
                
                cnx.Close();
                cnx.Dispose(); //Implicitly calls cnx.Close()
            }
            return dt;
        }


        public void ExecuteCreateQuery(string SQLstring)
        {
            SqlConnection cnx = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                //Setup command object
                cmd = new SqlCommand(SQLstring);
                cmd.CommandType = CommandType.Text;
              
                cnx = new SqlConnection(GetConnectionString());
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



        public SqlDataReader ExecuteDataReader(string SQLstring)
        {
            //Method variables
            SqlConnection cnx = null;
            SqlCommand cmd = new SqlCommand(SQLstring);
            SqlDataReader dr;
            try
            {
              
                cnx = new SqlConnection(GetConnectionString());
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

        public SqlDataReader ExecuteDataReader(string procName,
             params IDataParameter[] procParams)
        {
            //Method variables
            SqlConnection cnx = null;
            SqlCommand cmd = null;  //Avoids "Use of unassigned variable" compiler error

            //Setup command object
            cmd = new SqlCommand(procName);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int index = 0; index < procParams.Length; index++)
            {
                cmd.Parameters.Add(procParams[index]);
            }
            //Method variables

            SqlDataReader dr;
            try
            {
              
                cnx = new SqlConnection(GetConnectionString());
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
        public SqlParameter CreateParameter(string paramName,
            SqlDbType paramType, object paramValue)
        {
            SqlParameter param = new SqlParameter(paramName, paramType);
            try
            {
                if (paramValue != DBNull.Value)
                {
                    switch (paramType)
                    {
                        case SqlDbType.VarChar:
                        case SqlDbType.NVarChar:
                        case SqlDbType.Char:
                        case SqlDbType.NChar:
                        case SqlDbType.Text:
                            paramValue = CheckParamValue((string)paramValue);
                            break;
                        case SqlDbType.DateTime:
                            paramValue = CheckParamValue((DateTime)paramValue);
                            break;
                        case SqlDbType.Int:
                            paramValue = CheckParamValue((int)paramValue);
                            break;
                        case SqlDbType.UniqueIdentifier:
                            paramValue = CheckParamValue(GetGuid(paramValue));
                            break;
                        case SqlDbType.Bit:
                            if (paramValue is bool) paramValue = (int)((bool)paramValue ? 1 : 0);
                            if ((int)paramValue < 0 || (int)paramValue > 1) paramValue = Constants.NullInt;
                            paramValue = CheckParamValue((int)paramValue);
                            break;
                        case SqlDbType.Float:
                            paramValue = CheckParamValue(Convert.ToSingle(paramValue));
                            break;
                        case SqlDbType.Decimal:
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

        public SqlParameter CreateParameter(string paramName, SqlDbType paramType, ParameterDirection direction)
        {
            SqlParameter returnVal = CreateParameter(paramName, paramType, DBNull.Value);
            returnVal.Direction = direction;
            return returnVal;
        }

        public SqlParameter CreateParameter(string paramName, SqlDbType paramType, object paramValue, ParameterDirection direction)
        {
            SqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
            returnVal.Direction = direction;
            return returnVal;
        }

        public SqlParameter CreateParameter(string paramName, SqlDbType paramType, object paramValue, int size)
        {
            SqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
            returnVal.Size = size;
            return returnVal;
        }

        public SqlParameter CreateParameter(string paramName, SqlDbType paramType, object paramValue, int size, ParameterDirection direction)
        {
            SqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
            returnVal.Direction = direction;
            returnVal.Size = size;
            return returnVal;
        }

        public SqlParameter CreateParameter(string paramName, SqlDbType paramType, object paramValue, int size, byte precision)
        {
            SqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
            returnVal.Size = size;
            ((SqlParameter)returnVal).Precision = precision;
            return returnVal;
        }

        public SqlParameter CreateParameter(string paramName, SqlDbType paramType, object paramValue, int size, byte precision, ParameterDirection direction)
        {
            SqlParameter returnVal = CreateParameter(paramName, paramType, paramValue);
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
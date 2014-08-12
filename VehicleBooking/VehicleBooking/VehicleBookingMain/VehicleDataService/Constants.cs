using System;
using System.Web;


namespace DapperCS.Common
{
    ////////////////////////////////////////////////////////////////////////////
    /// <summary>
    ///   Contains a listing of constants used throughout the application
    /// </summary>
    ////////////////////////////////////////////////////////////////////////////
    public static class Loggedin
    {
        //public static bool LoggedinUser()
        //{
        //    //HttpApplication app = new HttpApplication();

        //    if (System.Convert.ToString(HttpContext.Current.Session["loginid"]) == "")
        //        return false;
        //    else
        //        return true;
        //}

    }
    public sealed class Constants
    {
        /// <summary>
        /// The value used to represent a null DateTime value
        /// </summary>
        public static DateTime NullDateTime = DateTime.MinValue;

        /// <summary>
        /// The value used to represent a null decimal value
        /// </summary>
        public static decimal NullDecimal = 0;//;decimal.MinValue;

        /// <summary>
        /// The value used to represent a null double value
        /// </summary>
        public static double NullDouble = 0;//double.MinValue;

        /// <summary>
        /// The value used to represent a null Guid value
        /// </summary>
        public static Guid NullGuid = Guid.Empty;

        /// <summary>
        /// The value used to represent a null int value
        /// </summary>
        public static int NullInt = 0;//int.MinValue;

        /// <summary>
        /// The value used to represent a null long value
        /// </summary>
        public static long NullLong = 0;//long.MinValue;

        /// <summary>
        /// The value used to represent a null float value
        /// </summary>
        public static float NullFloat =0;// float.MinValue;

        /// <summary>
        /// The value used to represent a null string value
        /// </summary>
        public static string NullString = string.Empty;

        /// <summary>
        /// Maximum DateTime value allowed by SQL Server
        /// </summary>
        public static DateTime SqlMaxDate = new DateTime(9999, 1, 3, 23, 59, 59);

        /// <summary>
        /// Minimum DateTime value allowed by SQL Server
        /// </summary>
        public static DateTime SqlMinDate = new DateTime(1753, 1, 1, 00, 00, 00);
    }
    
}
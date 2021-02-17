using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BHHomepage.DatabaseConnection
{
    public class DatabaseConnection
    {
        
        public static void DatabaseConnect()
        {
            
            OracleConfiguration.WalletLocation = AppContext.BaseDirectory +"OracleWallet";
            OracleConnection orclCon = null;
            try
            {
                orclCon = new OracleConnection("User Id=admin; Password=!As224145789; data Source = (description= (retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1522)(host=adb.us-phoenix-1.oraclecloud.com))(connect_data=(service_name=ajbed4yxqkprezl_bhhomepagedb_high.adb.oraclecloud.com))(security=(ssl_server_cert_dn=\"CN = adwc.uscom - east - 1.oraclecloud.com, OU = Oracle BMCS US, O = Oracle Corporation, L = Redwood City, ST = California, C = US\")))");
                orclCon.Open();
                OracleCommand orclCmd = orclCon.CreateCommand();
                orclCmd.CommandText ="select * from Tb_user";
                OracleDataReader rdr = orclCmd.ExecuteReader();
                while (rdr.Read())
                    Console.WriteLine("Employee Name:" +rdr.GetString(0));
                Console.ReadLine();
                rdr.Dispose();
                orclCmd.Dispose();
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            
            finally{
                if (orclCon !=null) orclCon.Close();
            }
        }
    }
}

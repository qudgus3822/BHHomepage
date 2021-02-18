using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BHHomepage.DatabaseConnection
{
    public class DatabaseConnection
    {
        
        public static OracleConnection DatabaseConnect()
        {
            
            OracleConfiguration.WalletLocation = AppContext.BaseDirectory +"OracleWallet";
            OracleConnection orclCon = null;
            try
            {
                orclCon = new OracleConnection("User Id=admin; Password=!As224145789; data Source = (description= (retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1522)(host=adb.us-phoenix-1.oraclecloud.com))(connect_data=(service_name=ajbed4yxqkprezl_bhhomepagedb_high.adb.oraclecloud.com))(security=(ssl_server_cert_dn=\"CN = adwc.uscom - east - 1.oraclecloud.com, OU = Oracle BMCS US, O = Oracle Corporation, L = Redwood City, ST = California, C = US\")))");


                return orclCon;

            }
            catch(Exception e)
            {
                return null;
            }
           
        }
    }
}

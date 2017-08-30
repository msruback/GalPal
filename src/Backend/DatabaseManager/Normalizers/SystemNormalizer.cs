using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseManager.Normalizers
{
    class SystemNormalizer : INormalizer
    {
        private SqlConnection connection;
        private String searchQuery;
        private String addQuery;
        private String updateQuery;
        private SqlParameter id, eddbId, name, x, y, z, population, governmentId, allegianceId, stateId, securityId, economyId, reserveId;
        private SqlParameter powerStateId, powerId, isPermitLocked, isPopulated;

        public SystemNormalizer(SqlConnection conn)
        {
            connection = conn;
            
            //Set up SQL statements
            searchQuery = "WHERE EXISTS id=@ID";

            //Set Up Parameters
            id.ParameterName = "@ID";
            id.SqlDbType = SqlDbType.Int;

        }

        public void GetData()
        {
            using (connection)
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(searchQuery))
                {
                    SqlParameter IDparam = new SqlParameter(), EDDBIDparam = new SqlParameter();
                    IDparam.ParameterName = "@ID";
                    
                }
            }
        }
    }
}

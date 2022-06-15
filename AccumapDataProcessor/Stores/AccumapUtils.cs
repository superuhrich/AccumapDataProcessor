using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using AccumapDataProcessor.DapperModels;
using System.Configuration;

namespace AccumapDataProcessor.Stores
{
    public static class AccumapUtils {

        //The connection string to Synapse
        private static IDbConnection conn =
          new SqlConnection(ConfigurationManager.ConnectionStrings["Synapse"].ConnectionString);
        

        


        /// <summary>
        /// Method to get well level details from a list of UWI's. 
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Well>> GetWells(List<string> locationList) {
            // The query string
            var sql = @"
            select
            w.*,
            ba.*
            from [stage].[t_ihs_well] w
            join [stage].[t_ihs_business_associate] ba on (w.[OPERATOR] = ba.[BUSINESS_ASSOCIATE])
            where UWI in @locationList";

            // The tables in synapse are snake string,  while classes are upper camel case. 
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            // Make the query
            var wellList = await conn.QueryAsync<Well>(sql, new {locationList});
            
            //Return it
            return wellList.ToList();

        }
    }
}

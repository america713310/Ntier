using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace DataAccessLayer
{
    public class GenericRepository<T> where T : class, new()//, IGenericRepository<T> where T: class, new()
    {
        static Database Db = (new DatabaseProviderFactory()).Create("Data Source=DAUREN23\\MSSQLSERVER_DAUR;Initial Catalog=NTier;Integrated Security=True");
        
        /// <summary>
        /// Get LIST
        /// </summary>
        /// <param name="procName"> from Procedure [Enum] </param>
        /// <returns> LIST </returns>
        public static IEnumerable<T> GetAll(System.ValueType procName)
        {
            return Db.ExecuteSprocAccessor<T>(procName.ToString());
        }

        /// <summary>
        /// return single line
        /// </summary>
        /// <param name="procName"> from Procedure [Enum] </param>
        /// <param name="id"> integare </param>
        /// <returns> LIST </returns>
        public static T GetById(System.ValueType procName, int id)
        {
            return Db.ExecuteSprocAccessor<T>(procName.ToString(), id).FirstOrDefault();
        }

        /// <summary>
        /// get list, if your procedure returns only one row, you have to get it by 
        /// extention method [.FirstOrDefault();]
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="value"></param>
        /// <returns> LIST </returns>
        public static IEnumerable<T> GetByValue(System.ValueType procName, params object[] value)
        {
            return Db.ExecuteSprocAccessor<T>(procName.ToString(), value);
        }

        /// <summary>
        /// in some case it's easy to use "select as table"
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DataSet GetByValueAsTable(System.ValueType procName, params object[] value)
        {
            using (DbCommand com = Db.GetStoredProcCommand(procName.ToString(), value))
            {
                return Db.ExecuteDataSet(com);
            }
        }

        /// <summary>
        /// return DATASET
        /// </summary>
        /// <param name="procName"> from Procedure [Enum] </param>
        /// <param name="model"> you have to keep parameter order as in the procedure </param>
        public static DataSet SaveOrUpdate(System.ValueType procName, params object[] model)
        {
            using (DbCommand com = Db.GetStoredProcCommand(procName.ToString(), model))
            {
                // Db.ExecuteNonQuery(com);
                return Db.ExecuteDataSet(com);
            }
        }
    }
}

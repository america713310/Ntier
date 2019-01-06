using BusinessLogicLayer.Interfaces;
using CORE.Faculty;
using DataAccessLayer;
using DataAccessLayer.Enum;
using System.Collections.Generic;

namespace BusinessLogicLayer.NTierBLL
{
    public class FacultyBLL : ICrud<FacultyDTO>
    {
        //public int CreateOrUpdate(FacultyDTO model)
        //{
        //    var result = GenericRepository<object>.GetByValueAsTable(GeneralEnums.GetFaculties, model.Id, model.Title, model.Description).Tables[0];
        //    return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0][0]) : -1;
        //}

        //public bool Delete(int id)
        //{
        //    var result = GenericRepository<object>.GetByValueAsTable(GeneralEnums.GetFaculties, id).Tables[0];
        //    return result.Rows.Count > 0 ? Convert.ToBoolean(result.Rows[0][0]) : false;
        //}

        public IEnumerable<FacultyDTO> Get(int? id, string searchText = null)
        {
            return GenericRepository<FacultyDTO>.GetByValue(GeneralEnums.GetFaculties, id, searchText);
        }
    }
}

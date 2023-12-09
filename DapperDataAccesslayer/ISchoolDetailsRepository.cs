using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccessLayer
{
    public interface ISchoolDetailsRepository
    {
        public SchoolDetail InsertSP(SchoolDetail SchoolDetail);
        public IEnumerable<SchoolDetail> ReadSP();
        public SchoolDetail FindSchoolDetailsByIdSP(long Id);
        public void DeleteSchoolDetailsByIdSP(long Id);
        public SchoolDetail UpdateSchoolDetailsByIdSP(long Id, SchoolDetail Sch);

    }
}

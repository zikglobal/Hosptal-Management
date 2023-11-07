using Hospital.ViewModels;
using Hospitals.Utitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
    public interface IHospitalInfo
    {
        PagedResult<HospitalInfoViewModel>GetAll(int pageNumber, int pageSize);

        HospitalInfoViewModel GetHositalById(int HospitalId);
        void UpdateHospitalInfo(HospitalInfoViewModel hospitalInfo);
        void InsertHosipalInfo(HospitalInfoViewModel hospitalInfo);
        void DeleteHosipalInfo(int id);

    }
}

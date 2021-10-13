using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.DataLayer
{
    class StudentData : RecordData
    {
        public string Number;
        public string Name;
        public string Surname;
        public string DOB;
        public string Gender;
        public string Phone;
        public string Address;
        public string ModuleCodes;
        public string ImagePath;

        public  StudentData (string _Num,string _Name,string _Surname,string _DOB,string _Gender,string _Phone,string _Address,string _Codes,string _Path)
        {
            Number = _Num;
            Name = _Name;
            Surname = _Surname;
            DOB = _DOB;
            Gender = _Gender;
            Phone = _Phone;
            Address = _Address;
            ModuleCodes = _Codes;
            ImagePath = _Path;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.DataLayer
{
    class ModuleData : RecordData
    {
        public string Code;
        public string Name;
        public string Description;
        public string ResourceLink;

        public  ModuleData  (string _C,string _N, string _D, string _R)
        {
            Code = _C;
            Name = _N;
            Description = _D;
            ResourceLink = _R;
        }
    }
}

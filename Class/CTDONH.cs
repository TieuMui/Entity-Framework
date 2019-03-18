using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Class
{
    using System;
    using System.Collections.Generic;
    public partial class CTDONH
    {
        public string SODH { get; set; }
        public string MAVTU { get; set; }
        public int SLDAT { get; set; }
        public virtual DONDH DONDH { get; set; }
        
    }
}

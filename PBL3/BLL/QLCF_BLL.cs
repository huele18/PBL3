using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class QLCF_BLL
    {
        private static QLCF_BLL instance;
        public static QLCF_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QLCF_BLL();
                }
               return instance;
            }
        }
        
        
        
    }
}

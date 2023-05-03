using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class FoodCategory_BLL
    {
        private static FoodCategory_BLL instance;
        public static FoodCategory_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodCategory_BLL();
                }
                return instance;
            }
            private set { }
        }
        public bool checkID(int id)
        {
            foreach (FoodCategory f in FoodCategory_DAL.Instance.getFoodCategory())
            {
                if(f.idFoodCategory == id)
                {
                    return true;
                }
            }
            return false;
        }
        public void addFoodCategory(FoodCategory f)
        {
            FoodCategory_DAL.Instance.add(f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace Turbo.az.Classes
{
    class CommonMethods
    {
        ClassInfoAdapter classInfoAdapter = new ClassInfoAdapter();
        public void SetGeneralInfo(LookUpEdit lkUpEdtGenInfo, string typeID)
        {
            lkUpEdtGenInfo.Properties.DataSource = classInfoAdapter.GetGeneralInfo(typeID);
            lkUpEdtGenInfo.Properties.DisplayMember = "NAME";
            lkUpEdtGenInfo.Properties.ValueMember = "ID";
        }
        public void SetYears(LookUpEdit lkUpEdtYear)
        {
            List<int> listYears = new List<int>();
            int currenctYear = DateTime.Now.Year;
            for (int i = 1960; i < currenctYear; i++)
            {
                listYears.Add(i);
            }
            lkUpEdtYear.Properties.DataSource = listYears;
        }
        public void SetBrandData(LookUpEdit lkUpEdtBrand)
        {
            lkUpEdtBrand.Properties.DataSource = classInfoAdapter.GetBrands();
            lkUpEdtBrand.Properties.DisplayMember = "BRAND_NAME";
            lkUpEdtBrand.Properties.ValueMember = "ID";
        }
        public void SetModelData(LookUpEdit lkUpEdtModel,string brandID)
        {
            lkUpEdtModel.Properties.DataSource = classInfoAdapter.GetModels(brandID);
            lkUpEdtModel.Properties.DisplayMember = "MODEL_NAME";
            lkUpEdtModel.Properties.ValueMember = "ID";
        }
    }
}

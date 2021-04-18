using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az.Utils;

namespace Turbo.az.Classes
{
    class ClassInfoAdapter
    {
        SqlUtils sqlUtils = SqlUtils.GetInstance();
        public DataTable GetBrands()
        {       
            string query = "Select ID, BRAND_NAME from CAR_BRANDS";
            return sqlUtils.GetDataWithAdapter(query);           
        }
        public DataTable GetModels(String brandId)
        {    
            string query = $"Select ID, MODEL_NAME from CAR_MODELS Where BRAND_ID={brandId}";
            return sqlUtils.GetDataWithAdapter(query);
        }
        public DataTable GetGeneralInfo(string typeID)
        {
            string query = $"Select ID,NAME from GENERAL_INFO Where TYPE_ID={typeID}";
            return sqlUtils.GetDataWithAdapter(query);
        }
        public DataTable GetImage(string adsID)
        {
            string query = $"SELECT [ID],[CAR_IMAGE],[ADS_ID] FROM [dbo].[TB_ADS_IMAGE] Where ADS_ID={adsID}";
            return sqlUtils.GetDataWithAdapter(query);
        }
    }
}

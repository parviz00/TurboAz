using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turbo.az.Classes;
using Turbo.az.Utils;

namespace Turbo.az.Forms
{   
    public partial class FrmCars : Form
    {
        CommonMethods commonMethods = new CommonMethods();
        public FrmCars()
        {
            InitializeComponent();
        }

        private void btnAddAds_Click(object sender, EventArgs e)
        {
            FrmAddCar frmAddCar = new FrmAddCar();
            frmAddCar.ShowDialog();
        }

        private void FrmCars_Load(object sender, EventArgs e)
        {
            commonMethods.SetBrandData(lkUpEdtBrand);
            commonMethods.SetGeneralInfo(lkUpEdtCurrency, "3");
            commonMethods.SetYears(lkUpEdtYearBegin);
            commonMethods.SetYears(lkUpEdtYearEnd);
            commonMethods.SetGeneralInfo(lkUpEdtCity, "6");
            GetCars();
        }
       

        private void lkUpEdtBrand_EditValueChanged(object sender, EventArgs e)
        {
            commonMethods.SetModelData(lkUpEdtModel, lkUpEdtBrand.EditValue.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetCars();
        }
        private void GetCars()
        {
            string query = $@"
            SELECT
            ADS.[ID],
            ADS.[PRICE],
            BRD.BRAND_NAME+' '+MDL.MODEL_NAME CAR_FULL_NAME,
            ADS.YEAR,
            GN1.NAME ENGINE_SIZE,
            ADS.WOLK,
            GN.NAME CITY_NAME,           
            (Select top(1) IMG.CAR_IMAGE from TB_ADS_IMAGE IMG WHERE IMG.ADS_ID= ADS.[ID]) CAR_IMAGE
            FROM [dbo].[TB_ADS] ADS
            JOIN CAR_MODELS MDL ON MDL.ID=ADS.MODEL_ID
            JOIN CAR_BRANDS BRD ON MDL.BRAND_ID=BRD.ID
            JOIN GENERAL_INFO GN ON GN.ID=ADS.CITY_ID
            JOIN GENERAL_INFO GN1 ON GN1.ID=ADS.ENGINE_SIZE_ID
            WHERE CURRENCY_ID={lkUpEdtCurrency.EditValue}";
            //AND ADS.CREDIT ={ chkSearchCredit.EditValue} AND ADS.BARTER ={ chkSearchBarter.EditValue}";

            if (lkUpEdtBrand.EditValue !=null && (int)lkUpEdtBrand.EditValue !=72)
            {
                query = query + $" AND MDL.BRAND_ID={lkUpEdtBrand.EditValue}";
            }
            if (lkUpEdtModel.EditValue != null)
            {
                query = query + $" AND ADS.[MODEL_ID]={lkUpEdtModel.EditValue}";
            }
            if (txtMinPrice.EditValue != null && txtMinPrice.Text != "")
            {
                query = query + $" AND ADS.[PRICE]>={txtMinPrice.EditValue}";
            }
            if (txtMaxPrice.EditValue != null && txtMaxPrice.Text != "")
            {
                query = query + $" AND ADS.[PRICE] <={txtMaxPrice.EditValue}";
            }
            if (lkUpEdtYearBegin.EditValue != null)
            {
                query = query + $" AND ADS.[YEAR]={lkUpEdtYearBegin.EditValue}";
            }
            if (lkUpEdtYearEnd.EditValue != null)
            {
                query = query + $" AND ADS.[YEAR]={lkUpEdtYearEnd.EditValue}";
            }
            if (lkUpEdtCity.EditValue != null)
            {
                query = query + $" AND ADS.[CITY_ID]={lkUpEdtCity.EditValue}";
            }
            DataTable dtTableCars = SqlUtils.GetInstance().GetDataWithAdapter(query);
            grdCntrlCars.DataSource = dtTableCars;
        }

    }
}

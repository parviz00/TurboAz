using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Turbo.az.Classes;
using Turbo.az.Utils;

namespace Turbo.az
{
    public partial class FrmAddCar : Form
    {
        ClassInfoAdapter classInfoAdapter = new ClassInfoAdapter();
        CommonMethods commonMethods = new CommonMethods();
        public FrmAddCar()
        {
            InitializeComponent();
        }

        private void FrmAddCar_Load(object sender, EventArgs e)
        {
            commonMethods.SetBrandData(lkUpEdtBrand);
            commonMethods.SetGeneralInfo(lkUpEdtBodyType, "1");
            commonMethods.SetGeneralInfo(lkUpEdtColor, "2");
            commonMethods.SetGeneralInfo(lkUpEdtFuelType, "4");
            commonMethods.SetGeneralInfo(lkUpEdtSeater, "5");
            commonMethods.SetGeneralInfo(lkUpEdtCity, "6");
            commonMethods.SetGeneralInfo(lkUpEdtEngineSize, "7");
            commonMethods.SetGeneralInfo(lkUpedtTransmission, "8");
            commonMethods.SetYears(lkUpEdtYear);
            grdCntrlImages.DataSource = classInfoAdapter.GetImage("-1");
        }
        private void GetImageDataSource()
        {

        }


        private void lkUpEdtBrand_EditValueChanged(object sender, EventArgs e)
        {
            commonMethods.SetModelData(lkUpEdtModel, lkUpEdtBrand.EditValue.ToString());
        }

        private void SetGeneralInfo(LookUpEdit lkUpEdtGenInfo, string typeID)
        {
            lkUpEdtGenInfo.Properties.DataSource = classInfoAdapter.GetGeneralInfo(typeID);
            lkUpEdtGenInfo.Properties.DisplayMember = "NAME";
            lkUpEdtGenInfo.Properties.ValueMember = "ID";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ControlComponenetEmpty())
            {
                if (MessageBox.Show("Elan yerləşdirmək istədiyinizdən əminsiniz?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InserAllInfo();
                }

            }
        }
        private bool ControlComponenetEmpty()
        {
            bool control = true;
            if (lkUpEdtBrand.EditValue == null)
            {
                lkUpEdtBrand.ErrorText = " Markanı seçin ";
                control = false;
            }
            if (lkUpEdtModel.EditValue == null)
            {
                lkUpEdtModel.ErrorText = " Modeli seçin ";
                control = false;
            }
            if (lkUpEdtBodyType.EditValue == null)
            {
                lkUpEdtBodyType.ErrorText = " Ban növünü seçin ";
                control = false;
            }
            if (lkUpEdtColor.EditValue == null)
            {
                lkUpEdtColor.ErrorText = " Rəngi seçin ";
                control = false;
            }
            if (nmUpDownPrice.Value == 0)
            {
                MessageBox.Show("Qiyməti daxil edin");
                control = false;
            }
            if (lkUpEdtFuelType.EditValue == null)
            {
                lkUpEdtFuelType.ErrorText = " Yanacağ növünü seçin ";
                control = false;
            }
            if (lkUpEdtSeater.EditValue == null)
            {
                lkUpEdtSeater.ErrorText = " Ötürücünü seçin ";
                control = false;
            }
            if (lkUpedtTransmission.EditValue == null)
            {
                lkUpedtTransmission.ErrorText = " Sürətlər qutusunu seçin ";
                control = false;
            }
            if (lkUpEdtYear.EditValue == null)
            {
                lkUpEdtYear.ErrorText = " Buraxılış ilini seçin ";
                control = false;
            }
            if (lkUpEdtEngineSize.EditValue == null)
            {
                lkUpEdtEngineSize.ErrorText = " Mühərrikin həcmini seçin ";
                control = false;
            }
            if (txtName.EditValue == null)
            {
                txtName.ErrorText = " Adınızı daxil edin ";
                control = false;
            }
            if (lkUpEdtCity.EditValue == null)
            {
                lkUpEdtCity.ErrorText = " Şəhəri seçin ";
                control = false;
            }
            if (txtEmail.EditValue == null)
            {
                txtEmail.ErrorText = " E-mail adressinizi daxil edin ";
                control = false;
            }
            if (crdVwImages.DataRowCount < 3)
            {
                MessageBox.Show("Minimum 3 şəkil daxil edin!!!");
                control = false;
            }
            if (memoEdtNote==null || memoEdtNote !=null)
            {
                control = true;
            }
            return control;
        }
        private void InserAllInfo()
        {
            SqlTransaction sqlTransaction = null;
            // try
            // {
            SqlConnection sqlConnection = new SqlConnection(SqlUtils.GetInstance().conString);
            sqlConnection.Open();
            sqlTransaction = sqlConnection.BeginTransaction();
            string insertedId = InsertAds(sqlTransaction);
            InsertAdsImage(sqlTransaction, insertedId);
            sqlTransaction.Commit();
            sqlConnection.Close();
            MessageBox.Show("Məlumat yadda saxlanıldı!!!");
            this.Close();
        }
        private void InsertAdsImage(SqlTransaction sqlTransaction, string adsID)
        {
            DataTable dtTableImages = (DataTable)grdCntrlImages.DataSource;
            for (int i = 0; i < dtTableImages.Rows.Count; i++)
            {
                DataRow dtRowImages = dtTableImages.Rows[i];
                string query = @"INSERT INTO [dbo].[TB_ADS_IMAGE]
                          (CAR_IMAGE,ADS_ID)
                           VALUES               
                          (@CAR_IMAGE,@ADS_ID)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlTransaction.Connection);
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.Parameters.Add("@CAR_IMAGE", SqlDbType.VarBinary).Value = dtRowImages["CAR_IMAGE"];
                sqlCommand.Parameters.Add("@ADS_ID", SqlDbType.Int).Value = adsID;
                sqlCommand.ExecuteNonQuery();
            }
        }
        private string InsertAds(SqlTransaction sqlTransaction)
        {
            string query = @"INSERT INTO [dbo].[TB_ADS]
           ([MODEL_ID]
           ,[BODY_TYPE_ID]
           ,[WOLK]
           ,[COLOR_ID]
           ,[PRICE]
           ,[CURRENCY_ID]
           ,[CREDIT]
           ,[BARTER]
           ,[FUEL_TYPE_ID]
           ,[TRANSMISSION_ID]
           ,[YEAR]
           ,[ENGINE_SIZE_ID]
           ,[HP]
           ,[NOTE]
           ,[ALLOY_WHEELS]
           ,[CENTRAL_CLOSURE]
           ,[LEATHER_SALON]
           ,[SEAT_VENT]
           ,[ABS]
           ,[PARK_RADAR]
           ,[XENON_LAMPS]
           ,[LYUK]
           ,[CONDITIONER]
           ,[REAR_CAMERA]
           ,[RAIN_SENSOR]
           ,[SEAT_HEATING]
           ,[SIDE_CURTAINS]
           ,[NAME]
           ,[CITY_ID]
           ,[EMAIL]
           ,[SEATER_ID])
     VALUES
           (@MODEL_ID
           ,@BODY_TYPE_ID
           ,@WOLK
           ,@COLOR_ID 
           ,@PRICE
           ,@CURRENCY_ID
           ,@CREDIT 
           ,@BARTER
           ,@FUEL_TYPE_ID
           ,@TRANSMISSION_ID 
           ,@YEAR
           ,@ENGINE_SIZE_ID
           ,@HP 
           ,@NOTE
           ,@ALLOY_WHEELS
           ,@CENTRAL_CLOSURE 
           ,@LEATHER_SALON
           ,@SEAT_VENT
           ,@ABS
           ,@PARK_RADAR
           ,@XENON_LAMPS
           ,@LYUK
           ,@CONDITIONER
           ,@REAR_CAMERA
           ,@RAIN_SENSOR
           ,@SEAT_HEATING
           ,@SIDE_CURTAINS
           ,@NAME
           ,@CITY_ID
           ,@EMAIL
           ,@SEATER_ID); SELECT SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(query, sqlTransaction.Connection);
            sqlCommand.Transaction = sqlTransaction;
            sqlCommand.Parameters.Add("MODEL_ID", SqlDbType.Int).Value = lkUpEdtModel.EditValue;
            sqlCommand.Parameters.Add("BODY_TYPE_ID", SqlDbType.Int).Value = lkUpEdtBodyType.EditValue;
            sqlCommand.Parameters.Add("WOLK", SqlDbType.Int).Value = nmUpDownWolk.Value;
            sqlCommand.Parameters.Add("COLOR_ID", SqlDbType.Int).Value = lkUpEdtColor.EditValue;
            sqlCommand.Parameters.Add("PRICE", SqlDbType.Int).Value = nmUpDownPrice.Value;
            sqlCommand.Parameters.Add("CURRENCY_ID", SqlDbType.Int).Value = rdGrpCurrency.EditValue;
            sqlCommand.Parameters.Add("CREDIT", SqlDbType.Bit).Value = chkCredit.Checked;
            sqlCommand.Parameters.Add("BARTER", SqlDbType.Bit).Value = chkBarter.Checked;
            sqlCommand.Parameters.Add("FUEL_TYPE_ID", SqlDbType.Int).Value = lkUpEdtFuelType.EditValue;
            sqlCommand.Parameters.Add("TRANSMISSION_ID", SqlDbType.Int).Value = lkUpedtTransmission.EditValue;
            sqlCommand.Parameters.Add("YEAR", SqlDbType.Int).Value = lkUpEdtYear.EditValue;
            sqlCommand.Parameters.Add("ENGINE_SIZE_ID", SqlDbType.Int).Value = lkUpEdtEngineSize.EditValue;
            sqlCommand.Parameters.Add("HP", SqlDbType.Int).Value = nmUpDownHp.Value;
            sqlCommand.Parameters.Add("NOTE", SqlDbType.NVarChar).Value = memoEdtNote.Text;
            sqlCommand.Parameters.Add("ALLOY_WHEELS", SqlDbType.Bit).Value = chkAlloyWheels.Checked;
            sqlCommand.Parameters.Add("CENTRAL_CLOSURE", SqlDbType.Bit).Value = chkCentralClosure.Checked;
            sqlCommand.Parameters.Add("LEATHER_SALON", SqlDbType.Bit).Value = chkLeatherSalon.Checked;
            sqlCommand.Parameters.Add("SEAT_VENT", SqlDbType.Bit).Value = chkSeatVent.Checked;
            sqlCommand.Parameters.Add("ABS", SqlDbType.Bit).Value = chkABS.Checked;
            sqlCommand.Parameters.Add("PARK_RADAR", SqlDbType.Bit).Value = chkParkRadar.Checked;
            sqlCommand.Parameters.Add("XENON_LAMPS", SqlDbType.Bit).Value = chkXenonLamps.Checked;
            sqlCommand.Parameters.Add("LYUK", SqlDbType.Bit).Value = chkLyuk.Checked;
            sqlCommand.Parameters.Add("CONDITIONER", SqlDbType.Bit).Value = chkConditioner.Checked;
            sqlCommand.Parameters.Add("REAR_CAMERA", SqlDbType.Bit).Value = chkRearCamera.Checked;
            sqlCommand.Parameters.Add("RAIN_SENSOR", SqlDbType.Bit).Value = chkRainSensor.Checked;
            sqlCommand.Parameters.Add("SEAT_HEATING", SqlDbType.Bit).Value = chkSeatHeating.Checked;
            sqlCommand.Parameters.Add("SIDE_CURTAINS", SqlDbType.Bit).Value = chkSideCurtains.Checked;
            sqlCommand.Parameters.Add("NAME", SqlDbType.NVarChar).Value = txtName.EditValue;
            sqlCommand.Parameters.Add("CITY_ID", SqlDbType.Int).Value = lkUpEdtCity.EditValue;
            sqlCommand.Parameters.Add("EMAIL", SqlDbType.NVarChar).Value = txtEmail.EditValue;
            sqlCommand.Parameters.Add("SEATER_ID", SqlDbType.Int).Value = lkUpEdtSeater.EditValue;
            return sqlCommand.ExecuteScalar().ToString();
        }

        private void grpCntrlPictures_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button == grpCntrlPictures.CustomHeaderButtons[0])
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Images files | *.jpg; *.png; *.jpeg; *.tiff";
                DataTable dtTableImage = (DataTable)grdCntrlImages.DataSource;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        dtTableImage.Rows.Add(0, GetByteImage(fileName));
                        GetByteImage(fileName);
                    }
                }
            }
        }
        private byte[] GetByteImage(string fileName)
        {
            byte[] imgByteArray = null;
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            imgByteArray = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            return imgByteArray;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

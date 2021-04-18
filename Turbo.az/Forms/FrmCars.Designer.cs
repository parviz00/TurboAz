
namespace Turbo.az.Forms
{
    partial class FrmCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lkUpEdtCity = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaxPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtMinPrice = new DevExpress.XtraEditors.TextEdit();
            this.lkUpEdtYearEnd = new DevExpress.XtraEditors.LookUpEdit();
            this.lkUpEdtYearBegin = new DevExpress.XtraEditors.LookUpEdit();
            this.grdCntrlCars = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAds = new DevExpress.XtraEditors.SimpleButton();
            this.chkSearchBarter = new DevExpress.XtraEditors.CheckEdit();
            this.chkSearchCredit = new DevExpress.XtraEditors.CheckEdit();
            this.lkUpEdtCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkUpEdtModel = new DevExpress.XtraEditors.LookUpEdit();
            this.lkUpEdtBrand = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtYearEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtYearBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSearchBarter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSearchCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtBrand.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.lkUpEdtCity);
            this.panelControl1.Controls.Add(this.txtMaxPrice);
            this.panelControl1.Controls.Add(this.txtMinPrice);
            this.panelControl1.Controls.Add(this.lkUpEdtYearEnd);
            this.panelControl1.Controls.Add(this.lkUpEdtYearBegin);
            this.panelControl1.Controls.Add(this.grdCntrlCars);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.btnAddAds);
            this.panelControl1.Controls.Add(this.chkSearchBarter);
            this.panelControl1.Controls.Add(this.chkSearchCredit);
            this.panelControl1.Controls.Add(this.lkUpEdtCurrency);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lkUpEdtModel);
            this.panelControl1.Controls.Add(this.lkUpEdtBrand);
            this.panelControl1.Location = new System.Drawing.Point(-1, -1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(820, 451);
            this.panelControl1.TabIndex = 0;
            // 
            // lkUpEdtCity
            // 
            this.lkUpEdtCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lkUpEdtCity.Location = new System.Drawing.Point(425, 14);
            this.lkUpEdtCity.Name = "lkUpEdtCity";
            this.lkUpEdtCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEdtCity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Şəhər")});
            this.lkUpEdtCity.Properties.NullText = "Bütün şəhərlər";
            this.lkUpEdtCity.Size = new System.Drawing.Size(104, 20);
            this.lkUpEdtCity.TabIndex = 28;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaxPrice.EditValue = "";
            this.txtMaxPrice.Location = new System.Drawing.Point(358, 14);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(61, 20);
            this.txtMaxPrice.TabIndex = 27;
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMinPrice.EditValue = "";
            this.txtMinPrice.Location = new System.Drawing.Point(291, 14);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(61, 20);
            this.txtMinPrice.TabIndex = 26;
            // 
            // lkUpEdtYearEnd
            // 
            this.lkUpEdtYearEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lkUpEdtYearEnd.Location = new System.Drawing.Point(332, 40);
            this.lkUpEdtYearEnd.Name = "lkUpEdtYearEnd";
            this.lkUpEdtYearEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEdtYearEnd.Properties.NullText = "";
            this.lkUpEdtYearEnd.Size = new System.Drawing.Size(90, 20);
            this.lkUpEdtYearEnd.TabIndex = 25;
            // 
            // lkUpEdtYearBegin
            // 
            this.lkUpEdtYearBegin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lkUpEdtYearBegin.Location = new System.Drawing.Point(236, 40);
            this.lkUpEdtYearBegin.Name = "lkUpEdtYearBegin";
            this.lkUpEdtYearBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEdtYearBegin.Properties.NullText = "";
            this.lkUpEdtYearBegin.Size = new System.Drawing.Size(90, 20);
            this.lkUpEdtYearBegin.TabIndex = 24;
            // 
            // grdCntrlCars
            // 
            this.grdCntrlCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCntrlCars.Location = new System.Drawing.Point(0, 63);
            this.grdCntrlCars.MainView = this.cardView1;
            this.grdCntrlCars.Name = "grdCntrlCars";
            this.grdCntrlCars.Size = new System.Drawing.Size(820, 390);
            this.grdCntrlCars.TabIndex = 19;
            this.grdCntrlCars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cardView1.Appearance.ViewCaption.Options.UseFont = true;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.cardView1.GridControl = this.grdCntrlCars;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.FieldAutoHeight = true;
            this.cardView1.OptionsBehavior.Sizeable = false;
            this.cardView1.OptionsView.ShowFieldCaptions = false;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CAR_IMAGE";
            this.gridColumn2.FieldName = "CAR_IMAGE";
            this.gridColumn2.ImageOptions.SvgImageSize = new System.Drawing.Size(0, 250);
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 250;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Red;
            this.gridColumn3.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn3.Caption = "PRICE";
            this.gridColumn3.FieldName = "PRICE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CAR_FULL_NAME";
            this.gridColumn4.FieldName = "CAR_FULL_NAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "YEAR";
            this.gridColumn5.FieldName = "YEAR";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ENGINE_SIZE";
            this.gridColumn6.FieldName = "ENGINE_SIZE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "WOLK";
            this.gridColumn7.FieldName = "WOLK";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "CITY_NAME";
            this.gridColumn8.FieldName = "CITY_NAME";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseBackColor = true;
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(681, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddAds
            // 
            this.btnAddAds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAds.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddAds.Appearance.Options.UseBackColor = true;
            this.btnAddAds.Location = new System.Drawing.Point(681, 38);
            this.btnAddAds.Name = "btnAddAds";
            this.btnAddAds.Size = new System.Drawing.Size(111, 23);
            this.btnAddAds.TabIndex = 17;
            this.btnAddAds.Text = "Elan yerləşdir";
            this.btnAddAds.Click += new System.EventHandler(this.btnAddAds_Click);
            // 
            // chkSearchBarter
            // 
            this.chkSearchBarter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSearchBarter.EditValue = 0;
            this.chkSearchBarter.Location = new System.Drawing.Point(598, 40);
            this.chkSearchBarter.Name = "chkSearchBarter";
            this.chkSearchBarter.Properties.Caption = "Barter";
            this.chkSearchBarter.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkSearchBarter.Properties.ValueChecked = 1;
            this.chkSearchBarter.Properties.ValueUnchecked = 0;
            this.chkSearchBarter.Size = new System.Drawing.Size(95, 20);
            this.chkSearchBarter.TabIndex = 15;
            // 
            // chkSearchCredit
            // 
            this.chkSearchCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSearchCredit.EditValue = 0;
            this.chkSearchCredit.Location = new System.Drawing.Point(598, 14);
            this.chkSearchCredit.Name = "chkSearchCredit";
            this.chkSearchCredit.Properties.Caption = "Kredit";
            this.chkSearchCredit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkSearchCredit.Properties.ValueChecked = 1;
            this.chkSearchCredit.Properties.ValueUnchecked = 0;
            this.chkSearchCredit.Size = new System.Drawing.Size(95, 20);
            this.chkSearchCredit.TabIndex = 14;
            // 
            // lkUpEdtCurrency
            // 
            this.lkUpEdtCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lkUpEdtCurrency.EditValue = 35;
            this.lkUpEdtCurrency.Location = new System.Drawing.Point(236, 14);
            this.lkUpEdtCurrency.Name = "lkUpEdtCurrency";
            this.lkUpEdtCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEdtCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "Valyuta")});
            this.lkUpEdtCurrency.Properties.NullText = "";
            this.lkUpEdtCurrency.Size = new System.Drawing.Size(49, 20);
            this.lkUpEdtCurrency.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(155, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Buraxılış ili";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(155, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Qiymət";
            // 
            // lkUpEdtModel
            // 
            this.lkUpEdtModel.Location = new System.Drawing.Point(20, 40);
            this.lkUpEdtModel.Name = "lkUpEdtModel";
            this.lkUpEdtModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEdtModel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MODEL_NAME", "Model")});
            this.lkUpEdtModel.Properties.NullText = "Bütün modellər";
            this.lkUpEdtModel.Size = new System.Drawing.Size(103, 20);
            this.lkUpEdtModel.TabIndex = 1;
            // 
            // lkUpEdtBrand
            // 
            this.lkUpEdtBrand.Location = new System.Drawing.Point(20, 14);
            this.lkUpEdtBrand.Name = "lkUpEdtBrand";
            this.lkUpEdtBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUpEdtBrand.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRAND_NAME", "Marka")});
            this.lkUpEdtBrand.Properties.NullText = "Bütün markalar";
            this.lkUpEdtBrand.Size = new System.Drawing.Size(103, 20);
            this.lkUpEdtBrand.TabIndex = 0;
            this.lkUpEdtBrand.EditValueChanged += new System.EventHandler(this.lkUpEdtBrand_EditValueChanged);
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.panelControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmCars";
            this.Text = "FrmCars";
            this.Load += new System.EventHandler(this.FrmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtYearEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtYearBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSearchBarter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSearchCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUpEdtBrand.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkUpEdtCurrency;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkUpEdtModel;
        private DevExpress.XtraEditors.LookUpEdit lkUpEdtBrand;
        private DevExpress.XtraEditors.CheckEdit chkSearchBarter;
        private DevExpress.XtraEditors.CheckEdit chkSearchCredit;
        private DevExpress.XtraGrid.GridControl grdCntrlCars;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnAddAds;
        private DevExpress.XtraEditors.LookUpEdit lkUpEdtYearEnd;
        private DevExpress.XtraEditors.LookUpEdit lkUpEdtYearBegin;
        private DevExpress.XtraEditors.TextEdit txtMaxPrice;
        private DevExpress.XtraEditors.TextEdit txtMinPrice;
        private DevExpress.XtraEditors.LookUpEdit lkUpEdtCity;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}
﻿
namespace PlaneClient
{
    partial class FrmPlane
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlane));
            this.gvPlane = new Telerik.WinControls.UI.RadGridView();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPricee = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBrand = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSize = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.btn_delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.materialBlueGreyTheme2 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.radThemeManager2 = new Telerik.WinControls.RadThemeManager();
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlane.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPlane
            // 
            this.gvPlane.Location = new System.Drawing.Point(15, 92);
            // 
            // 
            // 
            this.gvPlane.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gvPlane.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvPlane.Name = "gvPlane";
            this.gvPlane.Size = new System.Drawing.Size(789, 402);
            this.gvPlane.TabIndex = 0;
            this.gvPlane.ThemeName = "MaterialBlueGrey";
            this.gvPlane.SelectionChanged += new System.EventHandler(this.gvPlane_SelectionChanged);
            this.gvPlane.Click += new System.EventHandler(this.gvPlane_Click);
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtId.HintForeColor = System.Drawing.Color.Empty;
            this.txtId.HintText = "";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtId.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtId.LineThickness = 4;
            this.txtId.Location = new System.Drawing.Point(920, 101);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(364, 33);
            this.txtId.TabIndex = 55;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPricee
            // 
            this.txtPricee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricee.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPricee.HintForeColor = System.Drawing.Color.Empty;
            this.txtPricee.HintText = "";
            this.txtPricee.isPassword = false;
            this.txtPricee.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtPricee.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtPricee.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtPricee.LineThickness = 4;
            this.txtPricee.Location = new System.Drawing.Point(920, 307);
            this.txtPricee.Margin = new System.Windows.Forms.Padding(4);
            this.txtPricee.Name = "txtPricee";
            this.txtPricee.Size = new System.Drawing.Size(364, 33);
            this.txtPricee.TabIndex = 53;
            this.txtPricee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtName.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtName.LineThickness = 4;
            this.txtName.Location = new System.Drawing.Point(920, 238);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 33);
            this.txtName.TabIndex = 52;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBrand
            // 
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtBrand.HintForeColor = System.Drawing.Color.Empty;
            this.txtBrand.HintText = "";
            this.txtBrand.isPassword = false;
            this.txtBrand.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtBrand.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtBrand.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtBrand.LineThickness = 4;
            this.txtBrand.Location = new System.Drawing.Point(920, 165);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(364, 33);
            this.txtBrand.TabIndex = 51;
            this.txtBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.txt_search.HintForeColor = System.Drawing.Color.Empty;
            this.txt_search.HintText = "";
            this.txt_search.isPassword = false;
            this.txt_search.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.txt_search.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_search.LineMouseHoverColor = System.Drawing.Color.PaleTurquoise;
            this.txt_search.LineThickness = 4;
            this.txt_search.Location = new System.Drawing.Point(15, 15);
            this.txt_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(597, 49);
            this.txt_search.TabIndex = 56;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSize
            // 
            this.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSize.HintForeColor = System.Drawing.Color.Empty;
            this.txtSize.HintText = "";
            this.txtSize.isPassword = false;
            this.txtSize.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtSize.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtSize.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtSize.LineThickness = 4;
            this.txtSize.Location = new System.Drawing.Point(920, 384);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(364, 33);
            this.txtSize.TabIndex = 60;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_delete
            // 
            this.btn_delete.ActiveBorderThickness = 1;
            this.btn_delete.ActiveCornerRadius = 20;
            this.btn_delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_delete.ActiveForecolor = System.Drawing.Color.White;
            this.btn_delete.ActiveLineColor = System.Drawing.Color.DarkKhaki;
            this.btn_delete.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.ButtonText = "Delete";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_delete.IdleBorderThickness = 2;
            this.btn_delete.IdleCornerRadius = 35;
            this.btn_delete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_delete.IdleForecolor = System.Drawing.Color.SandyBrown;
            this.btn_delete.IdleLineColor = System.Drawing.Color.LightCyan;
            this.btn_delete.Location = new System.Drawing.Point(1146, 25);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 50);
            this.btn_delete.TabIndex = 66;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ActiveBorderThickness = 1;
            this.btn_edit.ActiveCornerRadius = 20;
            this.btn_edit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_edit.ActiveForecolor = System.Drawing.Color.White;
            this.btn_edit.ActiveLineColor = System.Drawing.Color.DarkKhaki;
            this.btn_edit.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.ButtonText = "Update";
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_edit.IdleBorderThickness = 2;
            this.btn_edit.IdleCornerRadius = 35;
            this.btn_edit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_edit.IdleForecolor = System.Drawing.Color.SandyBrown;
            this.btn_edit.IdleLineColor = System.Drawing.Color.LightCyan;
            this.btn_edit.Location = new System.Drawing.Point(998, 25);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(138, 50);
            this.btn_edit.TabIndex = 65;
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.DarkKhaki;
            this.btn_add.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Add";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 2;
            this.btn_add.IdleCornerRadius = 35;
            this.btn_add.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btn_add.IdleForecolor = System.Drawing.Color.SandyBrown;
            this.btn_add.IdleLineColor = System.Drawing.Color.LightCyan;
            this.btn_add.Location = new System.Drawing.Point(850, 25);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(138, 50);
            this.btn_add.TabIndex = 64;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(869, 117);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(21, 17);
            this.bunifuCustomLabel1.TabIndex = 67;
            this.bunifuCustomLabel1.Text = "ID";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(869, 181);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(46, 17);
            this.bunifuCustomLabel2.TabIndex = 68;
            this.bunifuCustomLabel2.Text = "Brand";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(869, 254);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(45, 17);
            this.bunifuCustomLabel3.TabIndex = 69;
            this.bunifuCustomLabel3.Text = "Name";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(869, 323);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(39, 17);
            this.bunifuCustomLabel4.TabIndex = 70;
            this.bunifuCustomLabel4.Text = "Price";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(869, 400);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(33, 17);
            this.bunifuCustomLabel5.TabIndex = 71;
            this.bunifuCustomLabel5.Text = "Size";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlaneClient.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(620, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(822, 92);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(33, 424);
            this.bunifuSeparator1.TabIndex = 73;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // FrmPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1302, 537);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPricee);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.gvPlane);
            this.Name = "FrmPlane";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.FrmPlane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPlane.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvPlane;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPricee;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBrand;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_search;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSize;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_delete;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_edit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme2;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.RadThemeManager radThemeManager2;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
    }
}


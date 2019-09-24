﻿namespace CassidyBookStore.Forms
{
    partial class Form_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSlideMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExpenses = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStorage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDetails = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSell = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.btnSlideMenu);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnUsers);
            this.panelLeft.Controls.Add(this.btnExpenses);
            this.panelLeft.Controls.Add(this.btnStorage);
            this.panelLeft.Controls.Add(this.btnDetails);
            this.panelLeft.Controls.Add(this.btnSell);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelAnimator.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(43)))), ((int)(((byte)(115)))));
            this.panelLeft.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.panelLeft.GradientTopLeft = System.Drawing.Color.Plum;
            this.panelLeft.GradientTopRight = System.Drawing.Color.Cornsilk;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Quality = 10;
            this.panelLeft.Size = new System.Drawing.Size(217, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // btnSlideMenu
            // 
            this.btnSlideMenu.Activecolor = System.Drawing.Color.Transparent;
            this.btnSlideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlideMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSlideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlideMenu.BorderRadius = 0;
            this.btnSlideMenu.ButtonText = "";
            this.btnSlideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnSlideMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnSlideMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnSlideMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSlideMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSlideMenu.Iconimage")));
            this.btnSlideMenu.Iconimage_right = null;
            this.btnSlideMenu.Iconimage_right_Selected = null;
            this.btnSlideMenu.Iconimage_Selected = null;
            this.btnSlideMenu.IconMarginLeft = 0;
            this.btnSlideMenu.IconMarginRight = 0;
            this.btnSlideMenu.IconRightVisible = true;
            this.btnSlideMenu.IconRightZoom = 0D;
            this.btnSlideMenu.IconVisible = true;
            this.btnSlideMenu.IconZoom = 60D;
            this.btnSlideMenu.IsTab = true;
            this.btnSlideMenu.Location = new System.Drawing.Point(155, 0);
            this.btnSlideMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSlideMenu.Name = "btnSlideMenu";
            this.btnSlideMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSlideMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSlideMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSlideMenu.selected = false;
            this.btnSlideMenu.Size = new System.Drawing.Size(62, 70);
            this.btnSlideMenu.TabIndex = 7;
            this.btnSlideMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSlideMenu.Textcolor = System.Drawing.Color.White;
            this.btnSlideMenu.TextFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlideMenu.Click += new System.EventHandler(this.BtnSlideMenu_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "    Log Out";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 60D;
            this.btnLogout.IsTab = true;
            this.btnLogout.Location = new System.Drawing.Point(0, 598);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(217, 70);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "    Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsers.BorderRadius = 0;
            this.btnUsers.ButtonText = "    Users";
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnUsers, BunifuAnimatorNS.DecorationType.None);
            this.btnUsers.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsers.Iconimage")));
            this.btnUsers.Iconimage_right = null;
            this.btnUsers.Iconimage_right_Selected = null;
            this.btnUsers.Iconimage_Selected = null;
            this.btnUsers.IconMarginLeft = 0;
            this.btnUsers.IconMarginRight = 0;
            this.btnUsers.IconRightVisible = true;
            this.btnUsers.IconRightZoom = 0D;
            this.btnUsers.IconVisible = true;
            this.btnUsers.IconZoom = 60D;
            this.btnUsers.IsTab = true;
            this.btnUsers.Location = new System.Drawing.Point(0, 528);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUsers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnUsers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsers.selected = false;
            this.btnUsers.Size = new System.Drawing.Size(217, 70);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "    Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Textcolor = System.Drawing.Color.White;
            this.btnUsers.TextFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExpenses
            // 
            this.btnExpenses.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnExpenses.BackColor = System.Drawing.Color.Transparent;
            this.btnExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpenses.BorderRadius = 0;
            this.btnExpenses.ButtonText = "    Expenses";
            this.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnExpenses, BunifuAnimatorNS.DecorationType.None);
            this.btnExpenses.DisabledColor = System.Drawing.Color.Gray;
            this.btnExpenses.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExpenses.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExpenses.Iconimage")));
            this.btnExpenses.Iconimage_right = null;
            this.btnExpenses.Iconimage_right_Selected = null;
            this.btnExpenses.Iconimage_Selected = null;
            this.btnExpenses.IconMarginLeft = 0;
            this.btnExpenses.IconMarginRight = 0;
            this.btnExpenses.IconRightVisible = true;
            this.btnExpenses.IconRightZoom = 0D;
            this.btnExpenses.IconVisible = true;
            this.btnExpenses.IconZoom = 60D;
            this.btnExpenses.IsTab = true;
            this.btnExpenses.Location = new System.Drawing.Point(0, 458);
            this.btnExpenses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExpenses.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnExpenses.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExpenses.selected = false;
            this.btnExpenses.Size = new System.Drawing.Size(217, 70);
            this.btnExpenses.TabIndex = 4;
            this.btnExpenses.Text = "    Expenses";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Textcolor = System.Drawing.Color.White;
            this.btnExpenses.TextFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnStorage
            // 
            this.btnStorage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnStorage.BackColor = System.Drawing.Color.Transparent;
            this.btnStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStorage.BorderRadius = 0;
            this.btnStorage.ButtonText = "    Storage";
            this.btnStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnStorage, BunifuAnimatorNS.DecorationType.None);
            this.btnStorage.DisabledColor = System.Drawing.Color.Gray;
            this.btnStorage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStorage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStorage.Iconimage")));
            this.btnStorage.Iconimage_right = null;
            this.btnStorage.Iconimage_right_Selected = null;
            this.btnStorage.Iconimage_Selected = null;
            this.btnStorage.IconMarginLeft = 0;
            this.btnStorage.IconMarginRight = 0;
            this.btnStorage.IconRightVisible = true;
            this.btnStorage.IconRightZoom = 0D;
            this.btnStorage.IconVisible = true;
            this.btnStorage.IconZoom = 60D;
            this.btnStorage.IsTab = true;
            this.btnStorage.Location = new System.Drawing.Point(0, 388);
            this.btnStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStorage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnStorage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStorage.selected = false;
            this.btnStorage.Size = new System.Drawing.Size(217, 70);
            this.btnStorage.TabIndex = 3;
            this.btnStorage.Text = "    Storage";
            this.btnStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorage.Textcolor = System.Drawing.Color.White;
            this.btnStorage.TextFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDetails
            // 
            this.btnDetails.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.BorderRadius = 0;
            this.btnDetails.ButtonText = "    Details";
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnDetails, BunifuAnimatorNS.DecorationType.None);
            this.btnDetails.DisabledColor = System.Drawing.Color.Gray;
            this.btnDetails.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetails.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDetails.Iconimage")));
            this.btnDetails.Iconimage_right = null;
            this.btnDetails.Iconimage_right_Selected = null;
            this.btnDetails.Iconimage_Selected = null;
            this.btnDetails.IconMarginLeft = 0;
            this.btnDetails.IconMarginRight = 0;
            this.btnDetails.IconRightVisible = true;
            this.btnDetails.IconRightZoom = 0D;
            this.btnDetails.IconVisible = true;
            this.btnDetails.IconZoom = 60D;
            this.btnDetails.IsTab = true;
            this.btnDetails.Location = new System.Drawing.Point(0, 318);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDetails.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDetails.selected = false;
            this.btnDetails.Size = new System.Drawing.Size(217, 70);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "    Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Textcolor = System.Drawing.Color.White;
            this.btnDetails.TextFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSell
            // 
            this.btnSell.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSell.BackColor = System.Drawing.Color.Transparent;
            this.btnSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSell.BorderRadius = 0;
            this.btnSell.ButtonText = "    Sell";
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnSell, BunifuAnimatorNS.DecorationType.None);
            this.btnSell.DisabledColor = System.Drawing.Color.Gray;
            this.btnSell.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSell.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSell.Iconimage")));
            this.btnSell.Iconimage_right = null;
            this.btnSell.Iconimage_right_Selected = null;
            this.btnSell.Iconimage_Selected = null;
            this.btnSell.IconMarginLeft = 0;
            this.btnSell.IconMarginRight = 0;
            this.btnSell.IconRightVisible = true;
            this.btnSell.IconRightZoom = 0D;
            this.btnSell.IconVisible = true;
            this.btnSell.IconZoom = 60D;
            this.btnSell.IsTab = true;
            this.btnSell.Location = new System.Drawing.Point(0, 248);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSell.Name = "btnSell";
            this.btnSell.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSell.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSell.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSell.selected = false;
            this.btnSell.Size = new System.Drawing.Size(217, 70);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "    Sell";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Textcolor = System.Drawing.Color.White;
            this.btnSell.TextFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "    Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 60D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 178);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(217, 70);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "    Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.panelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation1;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelLeft);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelLeft;
        private Bunifu.Framework.UI.BunifuFlatButton btnSlideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsers;
        private Bunifu.Framework.UI.BunifuFlatButton btnExpenses;
        private Bunifu.Framework.UI.BunifuFlatButton btnStorage;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetails;
        private Bunifu.Framework.UI.BunifuFlatButton btnSell;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
    }
}
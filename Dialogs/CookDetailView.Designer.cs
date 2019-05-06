namespace MabiCooker2
{
    partial class CookDetailView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookDetailView));
            this.pDisplayInfo = new System.Windows.Forms.Panel();
            this.lStuffThreePrice = new System.Windows.Forms.Label();
            this.lStuffTwoPrice = new System.Windows.Forms.Label();
            this.lStuffOnePrice = new System.Windows.Forms.Label();
            this.lStuffThree = new System.Windows.Forms.LinkLabel();
            this.lStuffTwo = new System.Windows.Forms.LinkLabel();
            this.lStuffOne = new System.Windows.Forms.LinkLabel();
            this.lRank = new System.Windows.Forms.Label();
            this.lPicture = new System.Windows.Forms.PictureBox();
            this.tiCheckAlert = new System.Windows.Forms.Timer(this.components);
            this.pAlertShowing = new System.Windows.Forms.StatusStrip();
            this.lMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lEffects = new System.Windows.Forms.RichTextBox();
            this.bBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bDisplayRatio = new System.Windows.Forms.ToolStripButton();
            this.bModFav = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pDisplayInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lPicture)).BeginInit();
            this.pAlertShowing.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDisplayInfo
            // 
            this.pDisplayInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pDisplayInfo.Controls.Add(this.lStuffThreePrice);
            this.pDisplayInfo.Controls.Add(this.lStuffTwoPrice);
            this.pDisplayInfo.Controls.Add(this.lStuffOnePrice);
            this.pDisplayInfo.Controls.Add(this.lStuffThree);
            this.pDisplayInfo.Controls.Add(this.lStuffTwo);
            this.pDisplayInfo.Controls.Add(this.lStuffOne);
            this.pDisplayInfo.Controls.Add(this.lRank);
            resources.ApplyResources(this.pDisplayInfo, "pDisplayInfo");
            this.pDisplayInfo.Name = "pDisplayInfo";
            // 
            // lStuffThreePrice
            // 
            resources.ApplyResources(this.lStuffThreePrice, "lStuffThreePrice");
            this.lStuffThreePrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lStuffThreePrice.Name = "lStuffThreePrice";
            this.lStuffThreePrice.MouseLeave += new System.EventHandler(this.reset_message_bar);
            this.lStuffThreePrice.MouseHover += new System.EventHandler(this.lStuffThree_MouseHover);
            // 
            // lStuffTwoPrice
            // 
            resources.ApplyResources(this.lStuffTwoPrice, "lStuffTwoPrice");
            this.lStuffTwoPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lStuffTwoPrice.Name = "lStuffTwoPrice";
            this.lStuffTwoPrice.MouseLeave += new System.EventHandler(this.reset_message_bar);
            this.lStuffTwoPrice.MouseHover += new System.EventHandler(this.lStuffTwo_MouseHover);
            // 
            // lStuffOnePrice
            // 
            resources.ApplyResources(this.lStuffOnePrice, "lStuffOnePrice");
            this.lStuffOnePrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lStuffOnePrice.Name = "lStuffOnePrice";
            this.lStuffOnePrice.MouseLeave += new System.EventHandler(this.reset_message_bar);
            this.lStuffOnePrice.MouseHover += new System.EventHandler(this.lStuffOne_MouseHover);
            // 
            // lStuffThree
            // 
            resources.ApplyResources(this.lStuffThree, "lStuffThree");
            this.lStuffThree.LinkColor = System.Drawing.Color.Blue;
            this.lStuffThree.Name = "lStuffThree";
            this.lStuffThree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStuffThree_LinkClicked);
            this.lStuffThree.MouseLeave += new System.EventHandler(this.reset_message_bar);
            this.lStuffThree.MouseHover += new System.EventHandler(this.lStuffThree_MouseHover);
            // 
            // lStuffTwo
            // 
            resources.ApplyResources(this.lStuffTwo, "lStuffTwo");
            this.lStuffTwo.LinkColor = System.Drawing.Color.Blue;
            this.lStuffTwo.Name = "lStuffTwo";
            this.lStuffTwo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStuffTwo_LinkClicked);
            this.lStuffTwo.MouseLeave += new System.EventHandler(this.reset_message_bar);
            this.lStuffTwo.MouseHover += new System.EventHandler(this.lStuffTwo_MouseHover);
            // 
            // lStuffOne
            // 
            resources.ApplyResources(this.lStuffOne, "lStuffOne");
            this.lStuffOne.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
            this.lStuffOne.LinkColor = System.Drawing.Color.Blue;
            this.lStuffOne.Name = "lStuffOne";
            this.lStuffOne.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStuffOne_LinkClicked);
            this.lStuffOne.MouseLeave += new System.EventHandler(this.reset_message_bar);
            this.lStuffOne.MouseHover += new System.EventHandler(this.lStuffOne_MouseHover);
            // 
            // lRank
            // 
            resources.ApplyResources(this.lRank, "lRank");
            this.lRank.BackColor = System.Drawing.Color.Transparent;
            this.lRank.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lRank.Name = "lRank";
            // 
            // lPicture
            // 
            this.lPicture.InitialImage = global::MabiCooker2.Properties.Resources.Blank;
            resources.ApplyResources(this.lPicture, "lPicture");
            this.lPicture.Name = "lPicture";
            this.lPicture.TabStop = false;
            // 
            // tiCheckAlert
            // 
            this.tiCheckAlert.Interval = 3000;
            this.tiCheckAlert.Tick += new System.EventHandler(this.tiCheckAlert_Tick);
            // 
            // pAlertShowing
            // 
            this.pAlertShowing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lMessage});
            resources.ApplyResources(this.pAlertShowing, "pAlertShowing");
            this.pAlertShowing.Name = "pAlertShowing";
            // 
            // lMessage
            // 
            this.lMessage.Name = "lMessage";
            resources.ApplyResources(this.lMessage, "lMessage");
            // 
            // lEffects
            // 
            this.lEffects.BackColor = System.Drawing.SystemColors.Info;
            this.lEffects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lEffects.DetectUrls = false;
            resources.ApplyResources(this.lEffects, "lEffects");
            this.lEffects.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lEffects.Name = "lEffects";
            this.lEffects.ReadOnly = true;
            this.lEffects.MouseLeave += new System.EventHandler(this.reset_message_bar);
            // 
            // bBack
            // 
            this.bBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bBack.Image = global::MabiCooker2.Properties.Resources.Back;
            resources.ApplyResources(this.bBack, "bBack");
            this.bBack.Name = "bBack";
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            this.bBack.MouseLeave += new System.EventHandler(this.reset_message_bar);
            this.bBack.MouseHover += new System.EventHandler(this.bBack_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // bDisplayRatio
            // 
            this.bDisplayRatio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bDisplayRatio.Image = global::MabiCooker2.Properties.Resources.Ratio;
            resources.ApplyResources(this.bDisplayRatio, "bDisplayRatio");
            this.bDisplayRatio.Name = "bDisplayRatio";
            this.bDisplayRatio.Click += new System.EventHandler(this.bDisplayRatio_Click);
            this.bDisplayRatio.MouseLeave += new System.EventHandler(this.reset_message_bar);
            this.bDisplayRatio.MouseHover += new System.EventHandler(this.bDisplayRatio_MouseHover);
            // 
            // bModFav
            // 
            this.bModFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bModFav.Image = global::MabiCooker2.Properties.Resources.Favorite;
            resources.ApplyResources(this.bModFav, "bModFav");
            this.bModFav.Name = "bModFav";
            this.bModFav.Click += new System.EventHandler(this.bModFav_Click);
            this.bModFav.MouseLeave += new System.EventHandler(this.reset_message_bar);
            this.bModFav.MouseHover += new System.EventHandler(this.bModFav_MouseHover);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bBack,
            this.toolStripSeparator2,
            this.bDisplayRatio,
            this.bModFav});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // CookDetailView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lEffects);
            this.Controls.Add(this.lPicture);
            this.Controls.Add(this.pAlertShowing);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pDisplayInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CookDetailView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CookDetailView_FormClosed);
            this.pDisplayInfo.ResumeLayout(false);
            this.pDisplayInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lPicture)).EndInit();
            this.pAlertShowing.ResumeLayout(false);
            this.pAlertShowing.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDisplayInfo;
        private System.Windows.Forms.Label lRank;
        private System.Windows.Forms.Timer tiCheckAlert;
        private System.Windows.Forms.LinkLabel lStuffThree;
        private System.Windows.Forms.LinkLabel lStuffTwo;
        private System.Windows.Forms.LinkLabel lStuffOne;
        private System.Windows.Forms.Label lStuffThreePrice;
        private System.Windows.Forms.Label lStuffTwoPrice;
        private System.Windows.Forms.Label lStuffOnePrice;
        private System.Windows.Forms.PictureBox lPicture;
        private System.Windows.Forms.StatusStrip pAlertShowing;
        private System.Windows.Forms.RichTextBox lEffects;
        private System.Windows.Forms.ToolStripStatusLabel lMessage;
        private System.Windows.Forms.ToolStripButton bBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bDisplayRatio;
        private System.Windows.Forms.ToolStripButton bModFav;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
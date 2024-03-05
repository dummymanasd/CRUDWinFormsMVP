
namespace CRUDWinFormsMVP.Views
{
    partial class PetView
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab2 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraTabControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
            this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.ultraTabPageControl2 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.SearchPets = new Infragistics.Win.Misc.UltraLabel();
            this.searchButton = new Infragistics.Win.Misc.UltraButton();
            this.addNew = new Infragistics.Win.Misc.UltraButton();
            this.editbtn = new Infragistics.Win.Misc.UltraButton();
            this.deletebtn = new Infragistics.Win.Misc.UltraButton();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabControl1)).BeginInit();
            this.ultraTabControl1.SuspendLayout();
            this.ultraTabSharedControlsPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(50, 12);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(108, 34);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "PETS";
            // 
            // ultraPanel1
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            this.ultraPanel1.Appearance = appearance1;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel1);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraPanel1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(800, 52);
            this.ultraPanel1.TabIndex = 1;
            // 
            // ultraTabControl1
            // 
            this.ultraTabControl1.Controls.Add(this.ultraTabSharedControlsPage1);
            this.ultraTabControl1.Controls.Add(this.ultraTabPageControl2);
            this.ultraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraTabControl1.Location = new System.Drawing.Point(0, 52);
            this.ultraTabControl1.Name = "ultraTabControl1";
            this.ultraTabControl1.SharedControls.AddRange(new System.Windows.Forms.Control[] {
            this.deletebtn,
            this.editbtn,
            this.addNew,
            this.searchButton,
            this.SearchPets});
            this.ultraTabControl1.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.ultraTabControl1.Size = new System.Drawing.Size(800, 398);
            this.ultraTabControl1.TabIndex = 2;
            ultraTab2.TabPage = this.ultraTabPageControl2;
            ultraTab2.Text = "Pet Detail";
            this.ultraTabControl1.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab2});
            this.ultraTabControl1.SelectedTabChanged += new Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventHandler(this.ultraTabControl1_SelectedTabChanged);
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Controls.Add(this.deletebtn);
            this.ultraTabSharedControlsPage1.Controls.Add(this.editbtn);
            this.ultraTabSharedControlsPage1.Controls.Add(this.addNew);
            this.ultraTabSharedControlsPage1.Controls.Add(this.searchButton);
            this.ultraTabSharedControlsPage1.Controls.Add(this.SearchPets);
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(1, 24);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(796, 371);
            this.ultraTabSharedControlsPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.ultraTabSharedControlsPage1_Paint);
            // 
            // ultraTabPageControl2
            // 
            this.ultraTabPageControl2.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabPageControl2.Name = "ultraTabPageControl2";
            this.ultraTabPageControl2.Size = new System.Drawing.Size(796, 371);
            // 
            // SearchPets
            // 
            this.SearchPets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPets.Location = new System.Drawing.Point(14, 20);
            this.SearchPets.Name = "SearchPets";
            this.SearchPets.Size = new System.Drawing.Size(163, 23);
            this.SearchPets.TabIndex = 0;
            this.SearchPets.Text = "Search Pet:";
            this.SearchPets.Click += new System.EventHandler(this.ultraLabel2_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(551, 54);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = " Search";
            // 
            // addNew
            // 
            this.addNew.Location = new System.Drawing.Point(688, 112);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(75, 23);
            this.addNew.TabIndex = 2;
            this.addNew.Text = "Add New";
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(688, 175);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 3;
            this.editbtn.Text = "Edit";
            this.editbtn.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(688, 244);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Text = "Delete";
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ultraTabControl1);
            this.Controls.Add(this.ultraPanel1);
            this.Name = "PetView";
            this.Text = "PetView";
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabControl1)).EndInit();
            this.ultraTabControl1.ResumeLayout(false);
            this.ultraTabSharedControlsPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.UltraWinTabControl.UltraTabControl ultraTabControl1;
        private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl2;
        private Infragistics.Win.Misc.UltraLabel SearchPets;
        private Infragistics.Win.Misc.UltraButton editbtn;
        private Infragistics.Win.Misc.UltraButton addNew;
        private Infragistics.Win.Misc.UltraButton searchButton;
        private Infragistics.Win.Misc.UltraButton deletebtn;
    }
}
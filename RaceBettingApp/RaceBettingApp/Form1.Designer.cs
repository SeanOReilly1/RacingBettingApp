namespace RaceBettingApp
{
    partial class Form1
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
            this.lblRaceCourse = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLenght = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.txtRaceCourse = new System.Windows.Forms.TextBox();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chkWinner = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.dgvHorseBets = new System.Windows.Forms.DataGridView();
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.btnSortDate = new System.Windows.Forms.Button();
            this.btnAmmountWon = new System.Windows.Forms.Button();
            this.btnPopularCourse = new System.Windows.Forms.Button();
            this.btnViewAllTracks = new System.Windows.Forms.Button();
            this.btnGetOldData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorseBets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaceCourse
            // 
            this.lblRaceCourse.AutoSize = true;
            this.lblRaceCourse.Location = new System.Drawing.Point(49, 45);
            this.lblRaceCourse.Name = "lblRaceCourse";
            this.lblRaceCourse.Size = new System.Drawing.Size(90, 17);
            this.lblRaceCourse.TabIndex = 0;
            this.lblRaceCourse.Text = "Race Course";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(49, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Location = new System.Drawing.Point(49, 151);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(52, 17);
            this.lblLenght.TabIndex = 2;
            this.lblLenght.Text = "Lenght";
            this.lblLenght.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(49, 206);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(48, 17);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "Result";
            // 
            // txtRaceCourse
            // 
            this.txtRaceCourse.Location = new System.Drawing.Point(148, 45);
            this.txtRaceCourse.Name = "txtRaceCourse";
            this.txtRaceCourse.Size = new System.Drawing.Size(100, 22);
            this.txtRaceCourse.TabIndex = 4;
            // 
            // txtLenght
            // 
            this.txtLenght.Location = new System.Drawing.Point(148, 146);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(100, 22);
            this.txtLenght.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(148, 92);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 8;
            // 
            // chkWinner
            // 
            this.chkWinner.AutoSize = true;
            this.chkWinner.Location = new System.Drawing.Point(148, 206);
            this.chkWinner.Name = "chkWinner";
            this.chkWinner.Size = new System.Drawing.Size(75, 21);
            this.chkWinner.TabIndex = 9;
            this.chkWinner.Text = "Winner";
            this.chkWinner.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(172, 266);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dgvHorseBets
            // 
            this.dgvHorseBets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorseBets.Location = new System.Drawing.Point(52, 345);
            this.dgvHorseBets.Name = "dgvHorseBets";
            this.dgvHorseBets.RowTemplate.Height = 24;
            this.dgvHorseBets.Size = new System.Drawing.Size(797, 150);
            this.dgvHorseBets.TabIndex = 12;
            // 
            // rtbRead
            // 
            this.rtbRead.Location = new System.Drawing.Point(422, 42);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.Size = new System.Drawing.Size(374, 96);
            this.rtbRead.TabIndex = 13;
            this.rtbRead.Text = "";
            // 
            // btnSortDate
            // 
            this.btnSortDate.Location = new System.Drawing.Point(52, 308);
            this.btnSortDate.Name = "btnSortDate";
            this.btnSortDate.Size = new System.Drawing.Size(75, 23);
            this.btnSortDate.TabIndex = 14;
            this.btnSortDate.Text = "Sort By Date";
            this.btnSortDate.UseVisualStyleBackColor = true;
            this.btnSortDate.Click += new System.EventHandler(this.btnSortDate_Click);
            // 
            // btnAmmountWon
            // 
            this.btnAmmountWon.Location = new System.Drawing.Point(446, 160);
            this.btnAmmountWon.Name = "btnAmmountWon";
            this.btnAmmountWon.Size = new System.Drawing.Size(104, 35);
            this.btnAmmountWon.TabIndex = 15;
            this.btnAmmountWon.Text = "Amount Won";
            this.btnAmmountWon.UseVisualStyleBackColor = true;
            this.btnAmmountWon.Click += new System.EventHandler(this.btnAmmountWon_Click);
            // 
            // btnPopularCourse
            // 
            this.btnPopularCourse.Location = new System.Drawing.Point(575, 160);
            this.btnPopularCourse.Name = "btnPopularCourse";
            this.btnPopularCourse.Size = new System.Drawing.Size(124, 35);
            this.btnPopularCourse.TabIndex = 16;
            this.btnPopularCourse.Text = "Popular Course";
            this.btnPopularCourse.UseVisualStyleBackColor = true;
            this.btnPopularCourse.Click += new System.EventHandler(this.btnPopularCourse_Click);
            // 
            // btnViewAllTracks
            // 
            this.btnViewAllTracks.Location = new System.Drawing.Point(172, 308);
            this.btnViewAllTracks.Name = "btnViewAllTracks";
            this.btnViewAllTracks.Size = new System.Drawing.Size(130, 23);
            this.btnViewAllTracks.TabIndex = 17;
            this.btnViewAllTracks.Text = "Order Tracks";
            this.btnViewAllTracks.UseVisualStyleBackColor = true;
            this.btnViewAllTracks.Click += new System.EventHandler(this.btnViewAllTracks_Click);
            // 
            // btnGetOldData
            // 
            this.btnGetOldData.Location = new System.Drawing.Point(377, 293);
            this.btnGetOldData.Name = "btnGetOldData";
            this.btnGetOldData.Size = new System.Drawing.Size(173, 38);
            this.btnGetOldData.TabIndex = 18;
            this.btnGetOldData.Text = "Get Old Data Override";
            this.btnGetOldData.UseVisualStyleBackColor = true;
            this.btnGetOldData.Click += new System.EventHandler(this.btnGetOldData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 517);
            this.Controls.Add(this.btnGetOldData);
            this.Controls.Add(this.btnViewAllTracks);
            this.Controls.Add(this.btnPopularCourse);
            this.Controls.Add(this.btnAmmountWon);
            this.Controls.Add(this.btnSortDate);
            this.Controls.Add(this.rtbRead);
            this.Controls.Add(this.dgvHorseBets);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkWinner);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtLenght);
            this.Controls.Add(this.txtRaceCourse);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblLenght);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRaceCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorseBets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaceCourse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.TextBox txtRaceCourse;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chkWinner;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dgvHorseBets;
        private System.Windows.Forms.RichTextBox rtbRead;
        private System.Windows.Forms.Button btnSortDate;
        private System.Windows.Forms.Button btnAmmountWon;
        private System.Windows.Forms.Button btnPopularCourse;
        private System.Windows.Forms.Button btnViewAllTracks;
        private System.Windows.Forms.Button btnGetOldData;
    }
}


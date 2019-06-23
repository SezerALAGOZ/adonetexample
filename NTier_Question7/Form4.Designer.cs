namespace NTier_Question7
{
   partial class Form4
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
         this.btnNext = new System.Windows.Forms.Button();
         this.groupBoxSelectDisplayWeeks = new System.Windows.Forms.GroupBox();
         this.txtSelectsWeek = new System.Windows.Forms.TextBox();
         this.btnSelectsWeek = new System.Windows.Forms.Button();
         this.dtListDisplayWeeks = new System.Windows.Forms.DataGridView();
         this.lblSelectsWeek = new System.Windows.Forms.Label();
         this.groupBoxUpdateDisplayWeeks = new System.Windows.Forms.GroupBox();
         this.btnUpdateWeek = new System.Windows.Forms.Button();
         this.txtDisplayWeeksIDToBeUpdated = new System.Windows.Forms.TextBox();
         this.txtUpdateWeekName = new System.Windows.Forms.TextBox();
         this.lblDisplayWeeksIDOfUpdatedWeek = new System.Windows.Forms.Label();
         this.lblUpdateWeekName = new System.Windows.Forms.Label();
         this.groupBoxDisplayWeeksIDDelete = new System.Windows.Forms.GroupBox();
         this.btnDeleteWeek = new System.Windows.Forms.Button();
         this.txtDeleteWeek = new System.Windows.Forms.TextBox();
         this.lblDeleteWeek = new System.Windows.Forms.Label();
         this.groupBoxDisplayWeeks = new System.Windows.Forms.GroupBox();
         this.btnInsertWeek = new System.Windows.Forms.Button();
         this.lblInsertWeek = new System.Windows.Forms.Label();
         this.txtInsertWeek = new System.Windows.Forms.TextBox();
         this.groupBoxSelectDisplayWeeks.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtListDisplayWeeks)).BeginInit();
         this.groupBoxUpdateDisplayWeeks.SuspendLayout();
         this.groupBoxDisplayWeeksIDDelete.SuspendLayout();
         this.groupBoxDisplayWeeks.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnNext
         // 
         this.btnNext.BackColor = System.Drawing.Color.LightCoral;
         this.btnNext.Location = new System.Drawing.Point(706, 483);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(190, 42);
         this.btnNext.TabIndex = 23;
         this.btnNext.Text = "NEXT";
         this.btnNext.UseVisualStyleBackColor = false;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // groupBoxSelectDisplayWeeks
         // 
         this.groupBoxSelectDisplayWeeks.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxSelectDisplayWeeks.Controls.Add(this.txtSelectsWeek);
         this.groupBoxSelectDisplayWeeks.Controls.Add(this.btnSelectsWeek);
         this.groupBoxSelectDisplayWeeks.Controls.Add(this.dtListDisplayWeeks);
         this.groupBoxSelectDisplayWeeks.Controls.Add(this.lblSelectsWeek);
         this.groupBoxSelectDisplayWeeks.Location = new System.Drawing.Point(14, 253);
         this.groupBoxSelectDisplayWeeks.Name = "groupBoxSelectDisplayWeeks";
         this.groupBoxSelectDisplayWeeks.Size = new System.Drawing.Size(584, 282);
         this.groupBoxSelectDisplayWeeks.TabIndex = 22;
         this.groupBoxSelectDisplayWeeks.TabStop = false;
         this.groupBoxSelectDisplayWeeks.Text = "Hafta Listele";
         // 
         // txtSelectsWeek
         // 
         this.txtSelectsWeek.Location = new System.Drawing.Point(299, 49);
         this.txtSelectsWeek.Name = "txtSelectsWeek";
         this.txtSelectsWeek.Size = new System.Drawing.Size(234, 20);
         this.txtSelectsWeek.TabIndex = 3;
         // 
         // btnSelectsWeek
         // 
         this.btnSelectsWeek.Location = new System.Drawing.Point(299, 78);
         this.btnSelectsWeek.Name = "btnSelectsWeek";
         this.btnSelectsWeek.Size = new System.Drawing.Size(234, 36);
         this.btnSelectsWeek.TabIndex = 2;
         this.btnSelectsWeek.Text = "Listele";
         this.btnSelectsWeek.UseVisualStyleBackColor = true;
         this.btnSelectsWeek.Click += new System.EventHandler(this.btnSelectsWeek_Click);
         // 
         // dtListDisplayWeeks
         // 
         this.dtListDisplayWeeks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtListDisplayWeeks.Location = new System.Drawing.Point(31, 122);
         this.dtListDisplayWeeks.Name = "dtListDisplayWeeks";
         this.dtListDisplayWeeks.Size = new System.Drawing.Size(502, 150);
         this.dtListDisplayWeeks.TabIndex = 1;
         // 
         // lblSelectsWeek
         // 
         this.lblSelectsWeek.AutoSize = true;
         this.lblSelectsWeek.Location = new System.Drawing.Point(194, 52);
         this.lblSelectsWeek.Name = "lblSelectsWeek";
         this.lblSelectsWeek.Size = new System.Drawing.Size(51, 15);
         this.lblSelectsWeek.TabIndex = 0;
         this.lblSelectsWeek.Text = "Hafta ID";
         // 
         // groupBoxUpdateDisplayWeeks
         // 
         this.groupBoxUpdateDisplayWeeks.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxUpdateDisplayWeeks.Controls.Add(this.btnUpdateWeek);
         this.groupBoxUpdateDisplayWeeks.Controls.Add(this.txtDisplayWeeksIDToBeUpdated);
         this.groupBoxUpdateDisplayWeeks.Controls.Add(this.txtUpdateWeekName);
         this.groupBoxUpdateDisplayWeeks.Controls.Add(this.lblDisplayWeeksIDOfUpdatedWeek);
         this.groupBoxUpdateDisplayWeeks.Controls.Add(this.lblUpdateWeekName);
         this.groupBoxUpdateDisplayWeeks.Location = new System.Drawing.Point(309, 23);
         this.groupBoxUpdateDisplayWeeks.Name = "groupBoxUpdateDisplayWeeks";
         this.groupBoxUpdateDisplayWeeks.Size = new System.Drawing.Size(289, 218);
         this.groupBoxUpdateDisplayWeeks.TabIndex = 21;
         this.groupBoxUpdateDisplayWeeks.TabStop = false;
         this.groupBoxUpdateDisplayWeeks.Text = "Hafta Güncelleme";
         // 
         // btnUpdateWeek
         // 
         this.btnUpdateWeek.Location = new System.Drawing.Point(19, 150);
         this.btnUpdateWeek.Name = "btnUpdateWeek";
         this.btnUpdateWeek.Size = new System.Drawing.Size(251, 45);
         this.btnUpdateWeek.TabIndex = 8;
         this.btnUpdateWeek.Text = "Hafta Güncelle";
         this.btnUpdateWeek.UseVisualStyleBackColor = true;
         this.btnUpdateWeek.Click += new System.EventHandler(this.btnUpdateWeek_Click);
         // 
         // txtDisplayWeeksIDToBeUpdated
         // 
         this.txtDisplayWeeksIDToBeUpdated.Location = new System.Drawing.Point(170, 99);
         this.txtDisplayWeeksIDToBeUpdated.Name = "txtDisplayWeeksIDToBeUpdated";
         this.txtDisplayWeeksIDToBeUpdated.Size = new System.Drawing.Size(100, 20);
         this.txtDisplayWeeksIDToBeUpdated.TabIndex = 7;
         // 
         // txtUpdateWeekName
         // 
         this.txtUpdateWeekName.Location = new System.Drawing.Point(170, 39);
         this.txtUpdateWeekName.Name = "txtUpdateWeekName";
         this.txtUpdateWeekName.Size = new System.Drawing.Size(100, 20);
         this.txtUpdateWeekName.TabIndex = 4;
         // 
         // lblDisplayWeeksIDOfUpdatedWeek
         // 
         this.lblDisplayWeeksIDOfUpdatedWeek.AutoSize = true;
         this.lblDisplayWeeksIDOfUpdatedWeek.Location = new System.Drawing.Point(16, 99);
         this.lblDisplayWeeksIDOfUpdatedWeek.Name = "lblDisplayWeeksIDOfUpdatedWeek";
         this.lblDisplayWeeksIDOfUpdatedWeek.Size = new System.Drawing.Size(136, 15);
         this.lblDisplayWeeksIDOfUpdatedWeek.TabIndex = 3;
         this.lblDisplayWeeksIDOfUpdatedWeek.Text = "Güncellenecek Hafta ID";
         // 
         // lblUpdateWeekName
         // 
         this.lblUpdateWeekName.AutoSize = true;
         this.lblUpdateWeekName.Location = new System.Drawing.Point(16, 42);
         this.lblUpdateWeekName.Name = "lblUpdateWeekName";
         this.lblUpdateWeekName.Size = new System.Drawing.Size(56, 15);
         this.lblUpdateWeekName.TabIndex = 0;
         this.lblUpdateWeekName.Text = "Hafta Adı";
         // 
         // groupBoxDisplayWeeksIDDelete
         // 
         this.groupBoxDisplayWeeksIDDelete.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxDisplayWeeksIDDelete.Controls.Add(this.btnDeleteWeek);
         this.groupBoxDisplayWeeksIDDelete.Controls.Add(this.txtDeleteWeek);
         this.groupBoxDisplayWeeksIDDelete.Controls.Add(this.lblDeleteWeek);
         this.groupBoxDisplayWeeksIDDelete.Location = new System.Drawing.Point(622, 23);
         this.groupBoxDisplayWeeksIDDelete.Name = "groupBoxDisplayWeeksIDDelete";
         this.groupBoxDisplayWeeksIDDelete.Size = new System.Drawing.Size(274, 344);
         this.groupBoxDisplayWeeksIDDelete.TabIndex = 20;
         this.groupBoxDisplayWeeksIDDelete.TabStop = false;
         this.groupBoxDisplayWeeksIDDelete.Text = "Hafta Silme";
         // 
         // btnDeleteWeek
         // 
         this.btnDeleteWeek.Location = new System.Drawing.Point(87, 100);
         this.btnDeleteWeek.Name = "btnDeleteWeek";
         this.btnDeleteWeek.Size = new System.Drawing.Size(159, 42);
         this.btnDeleteWeek.TabIndex = 2;
         this.btnDeleteWeek.Text = "Hafta Sil";
         this.btnDeleteWeek.UseVisualStyleBackColor = true;
         this.btnDeleteWeek.Click += new System.EventHandler(this.btnDeleteWeek_Click);
         // 
         // txtDeleteWeek
         // 
         this.txtDeleteWeek.Location = new System.Drawing.Point(87, 42);
         this.txtDeleteWeek.Name = "txtDeleteWeek";
         this.txtDeleteWeek.Size = new System.Drawing.Size(159, 20);
         this.txtDeleteWeek.TabIndex = 1;
         // 
         // lblDeleteWeek
         // 
         this.lblDeleteWeek.AutoSize = true;
         this.lblDeleteWeek.Location = new System.Drawing.Point(21, 42);
         this.lblDeleteWeek.Name = "lblDeleteWeek";
         this.lblDeleteWeek.Size = new System.Drawing.Size(51, 15);
         this.lblDeleteWeek.TabIndex = 0;
         this.lblDeleteWeek.Text = "Hafta ID";
         // 
         // groupBoxDisplayWeeks
         // 
         this.groupBoxDisplayWeeks.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxDisplayWeeks.Controls.Add(this.btnInsertWeek);
         this.groupBoxDisplayWeeks.Controls.Add(this.lblInsertWeek);
         this.groupBoxDisplayWeeks.Controls.Add(this.txtInsertWeek);
         this.groupBoxDisplayWeeks.Location = new System.Drawing.Point(14, 23);
         this.groupBoxDisplayWeeks.Name = "groupBoxDisplayWeeks";
         this.groupBoxDisplayWeeks.Size = new System.Drawing.Size(274, 160);
         this.groupBoxDisplayWeeks.TabIndex = 19;
         this.groupBoxDisplayWeeks.TabStop = false;
         this.groupBoxDisplayWeeks.Text = "Hafta Ekleme";
         // 
         // btnInsertWeek
         // 
         this.btnInsertWeek.Location = new System.Drawing.Point(117, 92);
         this.btnInsertWeek.Name = "btnInsertWeek";
         this.btnInsertWeek.Size = new System.Drawing.Size(100, 32);
         this.btnInsertWeek.TabIndex = 6;
         this.btnInsertWeek.Text = "Hafta Ekle";
         this.btnInsertWeek.UseVisualStyleBackColor = true;
         this.btnInsertWeek.Click += new System.EventHandler(this.btnInsertWeek_Click);
         // 
         // lblInsertWeek
         // 
         this.lblInsertWeek.AutoSize = true;
         this.lblInsertWeek.Location = new System.Drawing.Point(18, 42);
         this.lblInsertWeek.Name = "lblInsertWeek";
         this.lblInsertWeek.Size = new System.Drawing.Size(56, 15);
         this.lblInsertWeek.TabIndex = 0;
         this.lblInsertWeek.Text = "Hafta Adı";
         // 
         // txtInsertWeek
         // 
         this.txtInsertWeek.Location = new System.Drawing.Point(117, 39);
         this.txtInsertWeek.Name = "txtInsertWeek";
         this.txtInsertWeek.Size = new System.Drawing.Size(100, 20);
         this.txtInsertWeek.TabIndex = 2;
         // 
         // Form4
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Thistle;
         this.ClientSize = new System.Drawing.Size(917, 547);
         this.Controls.Add(this.btnNext);
         this.Controls.Add(this.groupBoxSelectDisplayWeeks);
         this.Controls.Add(this.groupBoxUpdateDisplayWeeks);
         this.Controls.Add(this.groupBoxDisplayWeeksIDDelete);
         this.Controls.Add(this.groupBoxDisplayWeeks);
         this.Name = "Form4";
         this.Text = "WEEKS";
         this.groupBoxSelectDisplayWeeks.ResumeLayout(false);
         this.groupBoxSelectDisplayWeeks.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtListDisplayWeeks)).EndInit();
         this.groupBoxUpdateDisplayWeeks.ResumeLayout(false);
         this.groupBoxUpdateDisplayWeeks.PerformLayout();
         this.groupBoxDisplayWeeksIDDelete.ResumeLayout(false);
         this.groupBoxDisplayWeeksIDDelete.PerformLayout();
         this.groupBoxDisplayWeeks.ResumeLayout(false);
         this.groupBoxDisplayWeeks.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnNext;
      private System.Windows.Forms.GroupBox groupBoxSelectDisplayWeeks;
      private System.Windows.Forms.TextBox txtSelectsWeek;
      private System.Windows.Forms.Button btnSelectsWeek;
      private System.Windows.Forms.DataGridView dtListDisplayWeeks;
      private System.Windows.Forms.Label lblSelectsWeek;
      private System.Windows.Forms.GroupBox groupBoxUpdateDisplayWeeks;
      private System.Windows.Forms.Button btnUpdateWeek;
      private System.Windows.Forms.TextBox txtDisplayWeeksIDToBeUpdated;
      private System.Windows.Forms.TextBox txtUpdateWeekName;
      private System.Windows.Forms.Label lblDisplayWeeksIDOfUpdatedWeek;
      private System.Windows.Forms.Label lblUpdateWeekName;
      private System.Windows.Forms.GroupBox groupBoxDisplayWeeksIDDelete;
      private System.Windows.Forms.Button btnDeleteWeek;
      private System.Windows.Forms.TextBox txtDeleteWeek;
      private System.Windows.Forms.Label lblDeleteWeek;
      private System.Windows.Forms.GroupBox groupBoxDisplayWeeks;
      private System.Windows.Forms.Button btnInsertWeek;
      private System.Windows.Forms.Label lblInsertWeek;
      private System.Windows.Forms.TextBox txtInsertWeek;
   }
}
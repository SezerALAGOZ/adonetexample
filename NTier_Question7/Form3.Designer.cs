namespace NTier_Question7
{
   partial class Form3
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
         this.groupBoxSelectSaloons = new System.Windows.Forms.GroupBox();
         this.txtSelectsSaloon = new System.Windows.Forms.TextBox();
         this.btnSelectsSaloon = new System.Windows.Forms.Button();
         this.dtListSaloons = new System.Windows.Forms.DataGridView();
         this.lblSelectsSaloon = new System.Windows.Forms.Label();
         this.groupBoxUpdateSaloon = new System.Windows.Forms.GroupBox();
         this.lblUpdateSaloonCapacity = new System.Windows.Forms.Label();
         this.txtUpdateSaloonCapacity = new System.Windows.Forms.TextBox();
         this.btnUpdateSaloon = new System.Windows.Forms.Button();
         this.txtSaloonIDToBeUpdated = new System.Windows.Forms.TextBox();
         this.txtUpdateSaloonName = new System.Windows.Forms.TextBox();
         this.lblSaloonIDOfUpdatedSaloon = new System.Windows.Forms.Label();
         this.lblUpdateSaloonName = new System.Windows.Forms.Label();
         this.groupBoxSaloonIDDelete = new System.Windows.Forms.GroupBox();
         this.btnDeleteSaloon = new System.Windows.Forms.Button();
         this.txtDeleteSaloon = new System.Windows.Forms.TextBox();
         this.lblDeleteSaloon = new System.Windows.Forms.Label();
         this.groupBoxSaloons = new System.Windows.Forms.GroupBox();
         this.lblInsertSaloonCapacity = new System.Windows.Forms.Label();
         this.txtInsertSaloonCapacity = new System.Windows.Forms.TextBox();
         this.btnInsertSaloon = new System.Windows.Forms.Button();
         this.lblInsertSaloon = new System.Windows.Forms.Label();
         this.txtInsertSaloon = new System.Windows.Forms.TextBox();
         this.groupBoxSelectSaloons.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtListSaloons)).BeginInit();
         this.groupBoxUpdateSaloon.SuspendLayout();
         this.groupBoxSaloonIDDelete.SuspendLayout();
         this.groupBoxSaloons.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnNext
         // 
         this.btnNext.BackColor = System.Drawing.Color.LightCoral;
         this.btnNext.Location = new System.Drawing.Point(956, 385);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(190, 42);
         this.btnNext.TabIndex = 18;
         this.btnNext.Text = "NEXT";
         this.btnNext.UseVisualStyleBackColor = false;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // groupBoxSelectSaloons
         // 
         this.groupBoxSelectSaloons.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxSelectSaloons.Controls.Add(this.txtSelectsSaloon);
         this.groupBoxSelectSaloons.Controls.Add(this.btnSelectsSaloon);
         this.groupBoxSelectSaloons.Controls.Add(this.dtListSaloons);
         this.groupBoxSelectSaloons.Controls.Add(this.lblSelectsSaloon);
         this.groupBoxSelectSaloons.Location = new System.Drawing.Point(628, 23);
         this.groupBoxSelectSaloons.Name = "groupBoxSelectSaloons";
         this.groupBoxSelectSaloons.Size = new System.Drawing.Size(553, 356);
         this.groupBoxSelectSaloons.TabIndex = 17;
         this.groupBoxSelectSaloons.TabStop = false;
         this.groupBoxSelectSaloons.Text = "Salon Listele";
         // 
         // txtSelectsSaloon
         // 
         this.txtSelectsSaloon.Location = new System.Drawing.Point(299, 49);
         this.txtSelectsSaloon.Name = "txtSelectsSaloon";
         this.txtSelectsSaloon.Size = new System.Drawing.Size(234, 20);
         this.txtSelectsSaloon.TabIndex = 3;
         // 
         // btnSelectsSaloon
         // 
         this.btnSelectsSaloon.Location = new System.Drawing.Point(299, 78);
         this.btnSelectsSaloon.Name = "btnSelectsSaloon";
         this.btnSelectsSaloon.Size = new System.Drawing.Size(234, 36);
         this.btnSelectsSaloon.TabIndex = 2;
         this.btnSelectsSaloon.Text = "Listele";
         this.btnSelectsSaloon.UseVisualStyleBackColor = true;
         this.btnSelectsSaloon.Click += new System.EventHandler(this.btnSelectsSaloon_Click);
         // 
         // dtListSaloons
         // 
         this.dtListSaloons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtListSaloons.Location = new System.Drawing.Point(31, 122);
         this.dtListSaloons.Name = "dtListSaloons";
         this.dtListSaloons.Size = new System.Drawing.Size(502, 215);
         this.dtListSaloons.TabIndex = 1;
         // 
         // lblSelectsSaloon
         // 
         this.lblSelectsSaloon.AutoSize = true;
         this.lblSelectsSaloon.Location = new System.Drawing.Point(194, 52);
         this.lblSelectsSaloon.Name = "lblSelectsSaloon";
         this.lblSelectsSaloon.Size = new System.Drawing.Size(54, 15);
         this.lblSelectsSaloon.TabIndex = 0;
         this.lblSelectsSaloon.Text = "Salon ID";
         // 
         // groupBoxUpdateSaloon
         // 
         this.groupBoxUpdateSaloon.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxUpdateSaloon.Controls.Add(this.lblUpdateSaloonCapacity);
         this.groupBoxUpdateSaloon.Controls.Add(this.txtUpdateSaloonCapacity);
         this.groupBoxUpdateSaloon.Controls.Add(this.btnUpdateSaloon);
         this.groupBoxUpdateSaloon.Controls.Add(this.txtSaloonIDToBeUpdated);
         this.groupBoxUpdateSaloon.Controls.Add(this.txtUpdateSaloonName);
         this.groupBoxUpdateSaloon.Controls.Add(this.lblSaloonIDOfUpdatedSaloon);
         this.groupBoxUpdateSaloon.Controls.Add(this.lblUpdateSaloonName);
         this.groupBoxUpdateSaloon.Location = new System.Drawing.Point(309, 23);
         this.groupBoxUpdateSaloon.Name = "groupBoxUpdateSaloon";
         this.groupBoxUpdateSaloon.Size = new System.Drawing.Size(289, 405);
         this.groupBoxUpdateSaloon.TabIndex = 16;
         this.groupBoxUpdateSaloon.TabStop = false;
         this.groupBoxUpdateSaloon.Text = "Salon Güncelle";
         // 
         // lblUpdateSaloonCapacity
         // 
         this.lblUpdateSaloonCapacity.AutoSize = true;
         this.lblUpdateSaloonCapacity.Location = new System.Drawing.Point(15, 76);
         this.lblUpdateSaloonCapacity.Name = "lblUpdateSaloonCapacity";
         this.lblUpdateSaloonCapacity.Size = new System.Drawing.Size(55, 15);
         this.lblUpdateSaloonCapacity.TabIndex = 9;
         this.lblUpdateSaloonCapacity.Text = "Kapasite";
         // 
         // txtUpdateSaloonCapacity
         // 
         this.txtUpdateSaloonCapacity.Location = new System.Drawing.Point(170, 71);
         this.txtUpdateSaloonCapacity.Name = "txtUpdateSaloonCapacity";
         this.txtUpdateSaloonCapacity.Size = new System.Drawing.Size(100, 20);
         this.txtUpdateSaloonCapacity.TabIndex = 10;
         // 
         // btnUpdateSaloon
         // 
         this.btnUpdateSaloon.Location = new System.Drawing.Point(19, 208);
         this.btnUpdateSaloon.Name = "btnUpdateSaloon";
         this.btnUpdateSaloon.Size = new System.Drawing.Size(251, 45);
         this.btnUpdateSaloon.TabIndex = 8;
         this.btnUpdateSaloon.Text = "Salon Güncelle";
         this.btnUpdateSaloon.UseVisualStyleBackColor = true;
         this.btnUpdateSaloon.Click += new System.EventHandler(this.btnUpdateSaloon_Click);
         // 
         // txtSaloonIDToBeUpdated
         // 
         this.txtSaloonIDToBeUpdated.Location = new System.Drawing.Point(170, 119);
         this.txtSaloonIDToBeUpdated.Name = "txtSaloonIDToBeUpdated";
         this.txtSaloonIDToBeUpdated.Size = new System.Drawing.Size(100, 20);
         this.txtSaloonIDToBeUpdated.TabIndex = 7;
         // 
         // txtUpdateSaloonName
         // 
         this.txtUpdateSaloonName.Location = new System.Drawing.Point(170, 39);
         this.txtUpdateSaloonName.Name = "txtUpdateSaloonName";
         this.txtUpdateSaloonName.Size = new System.Drawing.Size(100, 20);
         this.txtUpdateSaloonName.TabIndex = 4;
         // 
         // lblSaloonIDOfUpdatedSaloon
         // 
         this.lblSaloonIDOfUpdatedSaloon.AutoSize = true;
         this.lblSaloonIDOfUpdatedSaloon.Location = new System.Drawing.Point(16, 119);
         this.lblSaloonIDOfUpdatedSaloon.Name = "lblSaloonIDOfUpdatedSaloon";
         this.lblSaloonIDOfUpdatedSaloon.Size = new System.Drawing.Size(139, 15);
         this.lblSaloonIDOfUpdatedSaloon.TabIndex = 3;
         this.lblSaloonIDOfUpdatedSaloon.Text = "Güncellenecek Salon ID";
         // 
         // lblUpdateSaloonName
         // 
         this.lblUpdateSaloonName.AutoSize = true;
         this.lblUpdateSaloonName.Location = new System.Drawing.Point(16, 42);
         this.lblUpdateSaloonName.Name = "lblUpdateSaloonName";
         this.lblUpdateSaloonName.Size = new System.Drawing.Size(59, 15);
         this.lblUpdateSaloonName.TabIndex = 0;
         this.lblUpdateSaloonName.Text = "Salon Adı";
         // 
         // groupBoxSaloonIDDelete
         // 
         this.groupBoxSaloonIDDelete.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxSaloonIDDelete.Controls.Add(this.btnDeleteSaloon);
         this.groupBoxSaloonIDDelete.Controls.Add(this.txtDeleteSaloon);
         this.groupBoxSaloonIDDelete.Controls.Add(this.lblDeleteSaloon);
         this.groupBoxSaloonIDDelete.Location = new System.Drawing.Point(14, 261);
         this.groupBoxSaloonIDDelete.Name = "groupBoxSaloonIDDelete";
         this.groupBoxSaloonIDDelete.Size = new System.Drawing.Size(274, 167);
         this.groupBoxSaloonIDDelete.TabIndex = 15;
         this.groupBoxSaloonIDDelete.TabStop = false;
         this.groupBoxSaloonIDDelete.Text = "Salon Silme";
         // 
         // btnDeleteSaloon
         // 
         this.btnDeleteSaloon.Location = new System.Drawing.Point(87, 100);
         this.btnDeleteSaloon.Name = "btnDeleteSaloon";
         this.btnDeleteSaloon.Size = new System.Drawing.Size(159, 42);
         this.btnDeleteSaloon.TabIndex = 2;
         this.btnDeleteSaloon.Text = "Salon Sil";
         this.btnDeleteSaloon.UseVisualStyleBackColor = true;
         this.btnDeleteSaloon.Click += new System.EventHandler(this.btnDeleteSaloon_Click);
         // 
         // txtDeleteSaloon
         // 
         this.txtDeleteSaloon.Location = new System.Drawing.Point(87, 42);
         this.txtDeleteSaloon.Name = "txtDeleteSaloon";
         this.txtDeleteSaloon.Size = new System.Drawing.Size(159, 20);
         this.txtDeleteSaloon.TabIndex = 1;
         // 
         // lblDeleteSaloon
         // 
         this.lblDeleteSaloon.AutoSize = true;
         this.lblDeleteSaloon.Location = new System.Drawing.Point(21, 42);
         this.lblDeleteSaloon.Name = "lblDeleteSaloon";
         this.lblDeleteSaloon.Size = new System.Drawing.Size(54, 15);
         this.lblDeleteSaloon.TabIndex = 0;
         this.lblDeleteSaloon.Text = "Salon ID";
         // 
         // groupBoxSaloons
         // 
         this.groupBoxSaloons.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxSaloons.Controls.Add(this.lblInsertSaloonCapacity);
         this.groupBoxSaloons.Controls.Add(this.txtInsertSaloonCapacity);
         this.groupBoxSaloons.Controls.Add(this.btnInsertSaloon);
         this.groupBoxSaloons.Controls.Add(this.lblInsertSaloon);
         this.groupBoxSaloons.Controls.Add(this.txtInsertSaloon);
         this.groupBoxSaloons.Location = new System.Drawing.Point(14, 23);
         this.groupBoxSaloons.Name = "groupBoxSaloons";
         this.groupBoxSaloons.Size = new System.Drawing.Size(274, 214);
         this.groupBoxSaloons.TabIndex = 14;
         this.groupBoxSaloons.TabStop = false;
         this.groupBoxSaloons.Text = "Salon Ekleme";
         // 
         // lblInsertSaloonCapacity
         // 
         this.lblInsertSaloonCapacity.AutoSize = true;
         this.lblInsertSaloonCapacity.Location = new System.Drawing.Point(18, 90);
         this.lblInsertSaloonCapacity.Name = "lblInsertSaloonCapacity";
         this.lblInsertSaloonCapacity.Size = new System.Drawing.Size(55, 15);
         this.lblInsertSaloonCapacity.TabIndex = 7;
         this.lblInsertSaloonCapacity.Text = "Kapasite";
         // 
         // txtInsertSaloonCapacity
         // 
         this.txtInsertSaloonCapacity.Location = new System.Drawing.Point(117, 87);
         this.txtInsertSaloonCapacity.Name = "txtInsertSaloonCapacity";
         this.txtInsertSaloonCapacity.Size = new System.Drawing.Size(100, 20);
         this.txtInsertSaloonCapacity.TabIndex = 8;
         // 
         // btnInsertSaloon
         // 
         this.btnInsertSaloon.Location = new System.Drawing.Point(117, 122);
         this.btnInsertSaloon.Name = "btnInsertSaloon";
         this.btnInsertSaloon.Size = new System.Drawing.Size(100, 32);
         this.btnInsertSaloon.TabIndex = 6;
         this.btnInsertSaloon.Text = "Salon Ekle";
         this.btnInsertSaloon.UseVisualStyleBackColor = true;
         this.btnInsertSaloon.Click += new System.EventHandler(this.btnInsertSaloon_Click);
         // 
         // lblInsertSaloon
         // 
         this.lblInsertSaloon.AutoSize = true;
         this.lblInsertSaloon.Location = new System.Drawing.Point(18, 42);
         this.lblInsertSaloon.Name = "lblInsertSaloon";
         this.lblInsertSaloon.Size = new System.Drawing.Size(59, 15);
         this.lblInsertSaloon.TabIndex = 0;
         this.lblInsertSaloon.Text = "Salon Adı";
         // 
         // txtInsertSaloon
         // 
         this.txtInsertSaloon.Location = new System.Drawing.Point(117, 39);
         this.txtInsertSaloon.Name = "txtInsertSaloon";
         this.txtInsertSaloon.Size = new System.Drawing.Size(100, 20);
         this.txtInsertSaloon.TabIndex = 2;
         // 
         // Form3
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Thistle;
         this.ClientSize = new System.Drawing.Size(1195, 450);
         this.Controls.Add(this.btnNext);
         this.Controls.Add(this.groupBoxSelectSaloons);
         this.Controls.Add(this.groupBoxUpdateSaloon);
         this.Controls.Add(this.groupBoxSaloonIDDelete);
         this.Controls.Add(this.groupBoxSaloons);
         this.Name = "Form3";
         this.Text = "SALOONS";
         this.groupBoxSelectSaloons.ResumeLayout(false);
         this.groupBoxSelectSaloons.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtListSaloons)).EndInit();
         this.groupBoxUpdateSaloon.ResumeLayout(false);
         this.groupBoxUpdateSaloon.PerformLayout();
         this.groupBoxSaloonIDDelete.ResumeLayout(false);
         this.groupBoxSaloonIDDelete.PerformLayout();
         this.groupBoxSaloons.ResumeLayout(false);
         this.groupBoxSaloons.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnNext;
      private System.Windows.Forms.GroupBox groupBoxSelectSaloons;
      private System.Windows.Forms.TextBox txtSelectsSaloon;
      private System.Windows.Forms.Button btnSelectsSaloon;
      private System.Windows.Forms.DataGridView dtListSaloons;
      private System.Windows.Forms.Label lblSelectsSaloon;
      private System.Windows.Forms.GroupBox groupBoxUpdateSaloon;
      private System.Windows.Forms.Button btnUpdateSaloon;
      private System.Windows.Forms.TextBox txtSaloonIDToBeUpdated;
      private System.Windows.Forms.TextBox txtUpdateSaloonName;
      private System.Windows.Forms.Label lblSaloonIDOfUpdatedSaloon;
      private System.Windows.Forms.Label lblUpdateSaloonName;
      private System.Windows.Forms.GroupBox groupBoxSaloonIDDelete;
      private System.Windows.Forms.Button btnDeleteSaloon;
      private System.Windows.Forms.TextBox txtDeleteSaloon;
      private System.Windows.Forms.Label lblDeleteSaloon;
      private System.Windows.Forms.GroupBox groupBoxSaloons;
      private System.Windows.Forms.Button btnInsertSaloon;
      private System.Windows.Forms.Label lblInsertSaloon;
      private System.Windows.Forms.TextBox txtInsertSaloon;
      private System.Windows.Forms.Label lblUpdateSaloonCapacity;
      private System.Windows.Forms.TextBox txtUpdateSaloonCapacity;
      private System.Windows.Forms.Label lblInsertSaloonCapacity;
      private System.Windows.Forms.TextBox txtInsertSaloonCapacity;
   }
}
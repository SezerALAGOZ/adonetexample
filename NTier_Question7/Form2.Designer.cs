namespace NTier_Question7
{
   partial class Form2
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
         this.groupBoxSelectCategories = new System.Windows.Forms.GroupBox();
         this.txtSelectsCategory = new System.Windows.Forms.TextBox();
         this.btnSelectsCategory = new System.Windows.Forms.Button();
         this.dtListCategories = new System.Windows.Forms.DataGridView();
         this.lblSelectsCategory = new System.Windows.Forms.Label();
         this.groupBoxUpdateCategory = new System.Windows.Forms.GroupBox();
         this.btnUpdateCategory = new System.Windows.Forms.Button();
         this.txtCategoryIDToBeUpdated = new System.Windows.Forms.TextBox();
         this.txtUpdateCategoryName = new System.Windows.Forms.TextBox();
         this.lblCategoryIDOfUpdatedCategory = new System.Windows.Forms.Label();
         this.lblUpdateCategoryName = new System.Windows.Forms.Label();
         this.groupBoxCategoryDelete = new System.Windows.Forms.GroupBox();
         this.btnDeleteCategory = new System.Windows.Forms.Button();
         this.txtDeleteCategory = new System.Windows.Forms.TextBox();
         this.lblDeleteCategory = new System.Windows.Forms.Label();
         this.groupBoxCategories = new System.Windows.Forms.GroupBox();
         this.btnInsertCategory = new System.Windows.Forms.Button();
         this.lblInsertCategory = new System.Windows.Forms.Label();
         this.txtInsertCategory = new System.Windows.Forms.TextBox();
         this.groupBoxSelectCategories.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtListCategories)).BeginInit();
         this.groupBoxUpdateCategory.SuspendLayout();
         this.groupBoxCategoryDelete.SuspendLayout();
         this.groupBoxCategories.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnNext
         // 
         this.btnNext.BackColor = System.Drawing.Color.LightCoral;
         this.btnNext.Location = new System.Drawing.Point(981, 382);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(190, 42);
         this.btnNext.TabIndex = 13;
         this.btnNext.Text = "NEXT";
         this.btnNext.UseVisualStyleBackColor = false;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // groupBoxSelectCategories
         // 
         this.groupBoxSelectCategories.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxSelectCategories.Controls.Add(this.txtSelectsCategory);
         this.groupBoxSelectCategories.Controls.Add(this.btnSelectsCategory);
         this.groupBoxSelectCategories.Controls.Add(this.dtListCategories);
         this.groupBoxSelectCategories.Controls.Add(this.lblSelectsCategory);
         this.groupBoxSelectCategories.Location = new System.Drawing.Point(638, 20);
         this.groupBoxSelectCategories.Name = "groupBoxSelectCategories";
         this.groupBoxSelectCategories.Size = new System.Drawing.Size(553, 356);
         this.groupBoxSelectCategories.TabIndex = 12;
         this.groupBoxSelectCategories.TabStop = false;
         this.groupBoxSelectCategories.Text = "Kategori Listele";
         // 
         // txtSelectsCategory
         // 
         this.txtSelectsCategory.Location = new System.Drawing.Point(299, 49);
         this.txtSelectsCategory.Name = "txtSelectsCategory";
         this.txtSelectsCategory.Size = new System.Drawing.Size(234, 20);
         this.txtSelectsCategory.TabIndex = 3;
         // 
         // btnSelectsCategory
         // 
         this.btnSelectsCategory.Location = new System.Drawing.Point(299, 78);
         this.btnSelectsCategory.Name = "btnSelectsCategory";
         this.btnSelectsCategory.Size = new System.Drawing.Size(234, 36);
         this.btnSelectsCategory.TabIndex = 2;
         this.btnSelectsCategory.Text = "Listele";
         this.btnSelectsCategory.UseVisualStyleBackColor = true;
         this.btnSelectsCategory.Click += new System.EventHandler(this.btnSelectsCategory_Click);
         // 
         // dtListCategories
         // 
         this.dtListCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtListCategories.Location = new System.Drawing.Point(31, 122);
         this.dtListCategories.Name = "dtListCategories";
         this.dtListCategories.Size = new System.Drawing.Size(502, 215);
         this.dtListCategories.TabIndex = 1;
         // 
         // lblSelectsCategory
         // 
         this.lblSelectsCategory.AutoSize = true;
         this.lblSelectsCategory.Location = new System.Drawing.Point(194, 52);
         this.lblSelectsCategory.Name = "lblSelectsCategory";
         this.lblSelectsCategory.Size = new System.Drawing.Size(68, 15);
         this.lblSelectsCategory.TabIndex = 0;
         this.lblSelectsCategory.Text = "Kategori ID";
         // 
         // groupBoxUpdateCategory
         // 
         this.groupBoxUpdateCategory.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxUpdateCategory.Controls.Add(this.btnUpdateCategory);
         this.groupBoxUpdateCategory.Controls.Add(this.txtCategoryIDToBeUpdated);
         this.groupBoxUpdateCategory.Controls.Add(this.txtUpdateCategoryName);
         this.groupBoxUpdateCategory.Controls.Add(this.lblCategoryIDOfUpdatedCategory);
         this.groupBoxUpdateCategory.Controls.Add(this.lblUpdateCategoryName);
         this.groupBoxUpdateCategory.Location = new System.Drawing.Point(319, 20);
         this.groupBoxUpdateCategory.Name = "groupBoxUpdateCategory";
         this.groupBoxUpdateCategory.Size = new System.Drawing.Size(289, 405);
         this.groupBoxUpdateCategory.TabIndex = 11;
         this.groupBoxUpdateCategory.TabStop = false;
         this.groupBoxUpdateCategory.Text = "Kategory Güncelle";
         // 
         // btnUpdateCategory
         // 
         this.btnUpdateCategory.Location = new System.Drawing.Point(19, 167);
         this.btnUpdateCategory.Name = "btnUpdateCategory";
         this.btnUpdateCategory.Size = new System.Drawing.Size(251, 45);
         this.btnUpdateCategory.TabIndex = 8;
         this.btnUpdateCategory.Text = "Kategori Güncelle";
         this.btnUpdateCategory.UseVisualStyleBackColor = true;
         this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
         // 
         // txtCategoryIDToBeUpdated
         // 
         this.txtCategoryIDToBeUpdated.Location = new System.Drawing.Point(170, 99);
         this.txtCategoryIDToBeUpdated.Name = "txtCategoryIDToBeUpdated";
         this.txtCategoryIDToBeUpdated.Size = new System.Drawing.Size(100, 20);
         this.txtCategoryIDToBeUpdated.TabIndex = 7;
         // 
         // txtUpdateCategoryName
         // 
         this.txtUpdateCategoryName.Location = new System.Drawing.Point(170, 39);
         this.txtUpdateCategoryName.Name = "txtUpdateCategoryName";
         this.txtUpdateCategoryName.Size = new System.Drawing.Size(100, 20);
         this.txtUpdateCategoryName.TabIndex = 4;
         // 
         // lblCategoryIDOfUpdatedCategory
         // 
         this.lblCategoryIDOfUpdatedCategory.AutoSize = true;
         this.lblCategoryIDOfUpdatedCategory.Location = new System.Drawing.Point(16, 99);
         this.lblCategoryIDOfUpdatedCategory.Name = "lblCategoryIDOfUpdatedCategory";
         this.lblCategoryIDOfUpdatedCategory.Size = new System.Drawing.Size(153, 15);
         this.lblCategoryIDOfUpdatedCategory.TabIndex = 3;
         this.lblCategoryIDOfUpdatedCategory.Text = "Güncellenecek Kategori ID";
         // 
         // lblUpdateCategoryName
         // 
         this.lblUpdateCategoryName.AutoSize = true;
         this.lblUpdateCategoryName.Location = new System.Drawing.Point(16, 42);
         this.lblUpdateCategoryName.Name = "lblUpdateCategoryName";
         this.lblUpdateCategoryName.Size = new System.Drawing.Size(75, 15);
         this.lblUpdateCategoryName.TabIndex = 0;
         this.lblUpdateCategoryName.Text = "Kategory Adı";
         // 
         // groupBoxCategoryDelete
         // 
         this.groupBoxCategoryDelete.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxCategoryDelete.Controls.Add(this.btnDeleteCategory);
         this.groupBoxCategoryDelete.Controls.Add(this.txtDeleteCategory);
         this.groupBoxCategoryDelete.Controls.Add(this.lblDeleteCategory);
         this.groupBoxCategoryDelete.Location = new System.Drawing.Point(24, 258);
         this.groupBoxCategoryDelete.Name = "groupBoxCategoryDelete";
         this.groupBoxCategoryDelete.Size = new System.Drawing.Size(274, 167);
         this.groupBoxCategoryDelete.TabIndex = 10;
         this.groupBoxCategoryDelete.TabStop = false;
         this.groupBoxCategoryDelete.Text = "Kategori Silme";
         // 
         // btnDeleteCategory
         // 
         this.btnDeleteCategory.Location = new System.Drawing.Point(87, 100);
         this.btnDeleteCategory.Name = "btnDeleteCategory";
         this.btnDeleteCategory.Size = new System.Drawing.Size(159, 42);
         this.btnDeleteCategory.TabIndex = 2;
         this.btnDeleteCategory.Text = "Kategori Sil";
         this.btnDeleteCategory.UseVisualStyleBackColor = true;
         this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
         // 
         // txtDeleteCategory
         // 
         this.txtDeleteCategory.Location = new System.Drawing.Point(87, 42);
         this.txtDeleteCategory.Name = "txtDeleteCategory";
         this.txtDeleteCategory.Size = new System.Drawing.Size(159, 20);
         this.txtDeleteCategory.TabIndex = 1;
         // 
         // lblDeleteCategory
         // 
         this.lblDeleteCategory.AutoSize = true;
         this.lblDeleteCategory.Location = new System.Drawing.Point(21, 42);
         this.lblDeleteCategory.Name = "lblDeleteCategory";
         this.lblDeleteCategory.Size = new System.Drawing.Size(68, 15);
         this.lblDeleteCategory.TabIndex = 0;
         this.lblDeleteCategory.Text = "Kategori ID";
         // 
         // groupBoxCategories
         // 
         this.groupBoxCategories.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxCategories.Controls.Add(this.btnInsertCategory);
         this.groupBoxCategories.Controls.Add(this.lblInsertCategory);
         this.groupBoxCategories.Controls.Add(this.txtInsertCategory);
         this.groupBoxCategories.Location = new System.Drawing.Point(24, 20);
         this.groupBoxCategories.Name = "groupBoxCategories";
         this.groupBoxCategories.Size = new System.Drawing.Size(274, 214);
         this.groupBoxCategories.TabIndex = 9;
         this.groupBoxCategories.TabStop = false;
         this.groupBoxCategories.Text = "Kategori Ekleme";
         // 
         // btnInsertCategory
         // 
         this.btnInsertCategory.Location = new System.Drawing.Point(117, 82);
         this.btnInsertCategory.Name = "btnInsertCategory";
         this.btnInsertCategory.Size = new System.Drawing.Size(100, 32);
         this.btnInsertCategory.TabIndex = 6;
         this.btnInsertCategory.Text = "Kategori Ekle";
         this.btnInsertCategory.UseVisualStyleBackColor = true;
         this.btnInsertCategory.Click += new System.EventHandler(this.btnInsertCategory_Click);
         // 
         // lblInsertCategory
         // 
         this.lblInsertCategory.AutoSize = true;
         this.lblInsertCategory.Location = new System.Drawing.Point(18, 42);
         this.lblInsertCategory.Name = "lblInsertCategory";
         this.lblInsertCategory.Size = new System.Drawing.Size(73, 15);
         this.lblInsertCategory.TabIndex = 0;
         this.lblInsertCategory.Text = "Kategori Adı";
         // 
         // txtInsertCategory
         // 
         this.txtInsertCategory.Location = new System.Drawing.Point(117, 39);
         this.txtInsertCategory.Name = "txtInsertCategory";
         this.txtInsertCategory.Size = new System.Drawing.Size(100, 20);
         this.txtInsertCategory.TabIndex = 2;
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Thistle;
         this.ClientSize = new System.Drawing.Size(1234, 450);
         this.Controls.Add(this.btnNext);
         this.Controls.Add(this.groupBoxSelectCategories);
         this.Controls.Add(this.groupBoxUpdateCategory);
         this.Controls.Add(this.groupBoxCategoryDelete);
         this.Controls.Add(this.groupBoxCategories);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "Form2";
         this.Text = "CATEGORIES";
         this.groupBoxSelectCategories.ResumeLayout(false);
         this.groupBoxSelectCategories.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtListCategories)).EndInit();
         this.groupBoxUpdateCategory.ResumeLayout(false);
         this.groupBoxUpdateCategory.PerformLayout();
         this.groupBoxCategoryDelete.ResumeLayout(false);
         this.groupBoxCategoryDelete.PerformLayout();
         this.groupBoxCategories.ResumeLayout(false);
         this.groupBoxCategories.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnNext;
      private System.Windows.Forms.GroupBox groupBoxSelectCategories;
      private System.Windows.Forms.TextBox txtSelectsCategory;
      private System.Windows.Forms.Button btnSelectsCategory;
      private System.Windows.Forms.DataGridView dtListCategories;
      private System.Windows.Forms.Label lblSelectsCategory;
      private System.Windows.Forms.GroupBox groupBoxUpdateCategory;
      private System.Windows.Forms.Button btnUpdateCategory;
      private System.Windows.Forms.TextBox txtCategoryIDToBeUpdated;
      private System.Windows.Forms.TextBox txtUpdateCategoryName;
      private System.Windows.Forms.Label lblCategoryIDOfUpdatedCategory;
      private System.Windows.Forms.Label lblUpdateCategoryName;
      private System.Windows.Forms.GroupBox groupBoxCategoryDelete;
      private System.Windows.Forms.Button btnDeleteCategory;
      private System.Windows.Forms.TextBox txtDeleteCategory;
      private System.Windows.Forms.Label lblDeleteCategory;
      private System.Windows.Forms.GroupBox groupBoxCategories;
      private System.Windows.Forms.Button btnInsertCategory;
      private System.Windows.Forms.Label lblInsertCategory;
      private System.Windows.Forms.TextBox txtInsertCategory;
   }
}
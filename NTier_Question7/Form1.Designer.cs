namespace NTier_Question7
{
   partial class Form1
   {
      /// <summary>
      ///Gerekli tasarımcı değişkeni.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///Kullanılan tüm kaynakları temizleyin.
      /// </summary>
      ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer üretilen kod

      /// <summary>
      /// Tasarımcı desteği için gerekli metot - bu metodun 
      ///içeriğini kod düzenleyici ile değiştirmeyin.
      /// </summary>
      private void InitializeComponent()
      {
         this.lblInsertMovie = new System.Windows.Forms.Label();
         this.lblMovieDescription = new System.Windows.Forms.Label();
         this.txtInsertMovie = new System.Windows.Forms.TextBox();
         this.txtMovieDescription = new System.Windows.Forms.TextBox();
         this.groupBoxMovies = new System.Windows.Forms.GroupBox();
         this.btnInsertMovie = new System.Windows.Forms.Button();
         this.txtMovieDuration = new System.Windows.Forms.TextBox();
         this.lblMovieDuration = new System.Windows.Forms.Label();
         this.groupBoxMovieDelete = new System.Windows.Forms.GroupBox();
         this.btnDeleteMovie = new System.Windows.Forms.Button();
         this.txtDeleteMovie = new System.Windows.Forms.TextBox();
         this.lblDeleteMovie = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnUpdateMovie = new System.Windows.Forms.Button();
         this.txtMovieIDToBeUpdated = new System.Windows.Forms.TextBox();
         this.txtUpdateMovieDuration = new System.Windows.Forms.TextBox();
         this.txtUpdateMovieDescription = new System.Windows.Forms.TextBox();
         this.txtUpdateMovieName = new System.Windows.Forms.TextBox();
         this.lblMovieIDOfUpdatedMovie = new System.Windows.Forms.Label();
         this.lblUpdateMovieDuration = new System.Windows.Forms.Label();
         this.lblUpdateMovieDescription = new System.Windows.Forms.Label();
         this.lblUpdateMovieName = new System.Windows.Forms.Label();
         this.groupBoxSelectMovies = new System.Windows.Forms.GroupBox();
         this.txtSelectsMovie = new System.Windows.Forms.TextBox();
         this.btnSelectsMovie = new System.Windows.Forms.Button();
         this.dtListMovies = new System.Windows.Forms.DataGridView();
         this.lblSelectMovies = new System.Windows.Forms.Label();
         this.btnNext = new System.Windows.Forms.Button();
         this.groupBoxMovies.SuspendLayout();
         this.groupBoxMovieDelete.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBoxSelectMovies.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtListMovies)).BeginInit();
         this.SuspendLayout();
         // 
         // lblInsertMovie
         // 
         this.lblInsertMovie.AutoSize = true;
         this.lblInsertMovie.Location = new System.Drawing.Point(18, 42);
         this.lblInsertMovie.Name = "lblInsertMovie";
         this.lblInsertMovie.Size = new System.Drawing.Size(51, 15);
         this.lblInsertMovie.TabIndex = 0;
         this.lblInsertMovie.Text = "Film Adı";
         // 
         // lblMovieDescription
         // 
         this.lblMovieDescription.AutoSize = true;
         this.lblMovieDescription.Location = new System.Drawing.Point(18, 78);
         this.lblMovieDescription.Name = "lblMovieDescription";
         this.lblMovieDescription.Size = new System.Drawing.Size(93, 15);
         this.lblMovieDescription.TabIndex = 1;
         this.lblMovieDescription.Text = "Film Açıklaması";
         // 
         // txtInsertMovie
         // 
         this.txtInsertMovie.Location = new System.Drawing.Point(117, 39);
         this.txtInsertMovie.Name = "txtInsertMovie";
         this.txtInsertMovie.Size = new System.Drawing.Size(100, 20);
         this.txtInsertMovie.TabIndex = 2;
         // 
         // txtMovieDescription
         // 
         this.txtMovieDescription.Location = new System.Drawing.Point(117, 75);
         this.txtMovieDescription.Name = "txtMovieDescription";
         this.txtMovieDescription.Size = new System.Drawing.Size(100, 20);
         this.txtMovieDescription.TabIndex = 3;
         // 
         // groupBoxMovies
         // 
         this.groupBoxMovies.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxMovies.Controls.Add(this.btnInsertMovie);
         this.groupBoxMovies.Controls.Add(this.txtMovieDuration);
         this.groupBoxMovies.Controls.Add(this.lblMovieDuration);
         this.groupBoxMovies.Controls.Add(this.lblInsertMovie);
         this.groupBoxMovies.Controls.Add(this.txtMovieDescription);
         this.groupBoxMovies.Controls.Add(this.lblMovieDescription);
         this.groupBoxMovies.Controls.Add(this.txtInsertMovie);
         this.groupBoxMovies.Location = new System.Drawing.Point(33, 33);
         this.groupBoxMovies.Name = "groupBoxMovies";
         this.groupBoxMovies.Size = new System.Drawing.Size(274, 214);
         this.groupBoxMovies.TabIndex = 4;
         this.groupBoxMovies.TabStop = false;
         this.groupBoxMovies.Text = "Film Ekleme";
         // 
         // btnInsertMovie
         // 
         this.btnInsertMovie.Location = new System.Drawing.Point(117, 163);
         this.btnInsertMovie.Name = "btnInsertMovie";
         this.btnInsertMovie.Size = new System.Drawing.Size(100, 32);
         this.btnInsertMovie.TabIndex = 6;
         this.btnInsertMovie.Text = "Film Ekle";
         this.btnInsertMovie.UseVisualStyleBackColor = true;
         this.btnInsertMovie.Click += new System.EventHandler(this.btnInsertMovie_Click);
         // 
         // txtMovieDuration
         // 
         this.txtMovieDuration.Location = new System.Drawing.Point(117, 122);
         this.txtMovieDuration.Name = "txtMovieDuration";
         this.txtMovieDuration.Size = new System.Drawing.Size(100, 20);
         this.txtMovieDuration.TabIndex = 5;
         // 
         // lblMovieDuration
         // 
         this.lblMovieDuration.AutoSize = true;
         this.lblMovieDuration.Location = new System.Drawing.Point(21, 122);
         this.lblMovieDuration.Name = "lblMovieDuration";
         this.lblMovieDuration.Size = new System.Drawing.Size(69, 15);
         this.lblMovieDuration.TabIndex = 4;
         this.lblMovieDuration.Text = "Film Süresi";
         // 
         // groupBoxMovieDelete
         // 
         this.groupBoxMovieDelete.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxMovieDelete.Controls.Add(this.btnDeleteMovie);
         this.groupBoxMovieDelete.Controls.Add(this.txtDeleteMovie);
         this.groupBoxMovieDelete.Controls.Add(this.lblDeleteMovie);
         this.groupBoxMovieDelete.Location = new System.Drawing.Point(33, 271);
         this.groupBoxMovieDelete.Name = "groupBoxMovieDelete";
         this.groupBoxMovieDelete.Size = new System.Drawing.Size(274, 167);
         this.groupBoxMovieDelete.TabIndex = 5;
         this.groupBoxMovieDelete.TabStop = false;
         this.groupBoxMovieDelete.Text = "Film Silme";
         // 
         // btnDeleteMovie
         // 
         this.btnDeleteMovie.Location = new System.Drawing.Point(87, 100);
         this.btnDeleteMovie.Name = "btnDeleteMovie";
         this.btnDeleteMovie.Size = new System.Drawing.Size(159, 42);
         this.btnDeleteMovie.TabIndex = 2;
         this.btnDeleteMovie.Text = "Film Sil";
         this.btnDeleteMovie.UseVisualStyleBackColor = true;
         this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
         // 
         // txtDeleteMovie
         // 
         this.txtDeleteMovie.Location = new System.Drawing.Point(87, 42);
         this.txtDeleteMovie.Name = "txtDeleteMovie";
         this.txtDeleteMovie.Size = new System.Drawing.Size(159, 20);
         this.txtDeleteMovie.TabIndex = 1;
         // 
         // lblDeleteMovie
         // 
         this.lblDeleteMovie.AutoSize = true;
         this.lblDeleteMovie.Location = new System.Drawing.Point(21, 42);
         this.lblDeleteMovie.Name = "lblDeleteMovie";
         this.lblDeleteMovie.Size = new System.Drawing.Size(46, 15);
         this.lblDeleteMovie.TabIndex = 0;
         this.lblDeleteMovie.Text = "Film ID";
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
         this.groupBox1.Controls.Add(this.btnUpdateMovie);
         this.groupBox1.Controls.Add(this.txtMovieIDToBeUpdated);
         this.groupBox1.Controls.Add(this.txtUpdateMovieDuration);
         this.groupBox1.Controls.Add(this.txtUpdateMovieDescription);
         this.groupBox1.Controls.Add(this.txtUpdateMovieName);
         this.groupBox1.Controls.Add(this.lblMovieIDOfUpdatedMovie);
         this.groupBox1.Controls.Add(this.lblUpdateMovieDuration);
         this.groupBox1.Controls.Add(this.lblUpdateMovieDescription);
         this.groupBox1.Controls.Add(this.lblUpdateMovieName);
         this.groupBox1.Location = new System.Drawing.Point(328, 33);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(289, 405);
         this.groupBox1.TabIndex = 6;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Film Güncelle";
         // 
         // btnUpdateMovie
         // 
         this.btnUpdateMovie.Location = new System.Drawing.Point(170, 227);
         this.btnUpdateMovie.Name = "btnUpdateMovie";
         this.btnUpdateMovie.Size = new System.Drawing.Size(100, 45);
         this.btnUpdateMovie.TabIndex = 8;
         this.btnUpdateMovie.Text = "Film Güncelle";
         this.btnUpdateMovie.UseVisualStyleBackColor = true;
         this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
         // 
         // txtMovieIDToBeUpdated
         // 
         this.txtMovieIDToBeUpdated.Location = new System.Drawing.Point(170, 159);
         this.txtMovieIDToBeUpdated.Name = "txtMovieIDToBeUpdated";
         this.txtMovieIDToBeUpdated.Size = new System.Drawing.Size(100, 20);
         this.txtMovieIDToBeUpdated.TabIndex = 7;
         // 
         // txtUpdateMovieDuration
         // 
         this.txtUpdateMovieDuration.Location = new System.Drawing.Point(170, 122);
         this.txtUpdateMovieDuration.Name = "txtUpdateMovieDuration";
         this.txtUpdateMovieDuration.Size = new System.Drawing.Size(100, 20);
         this.txtUpdateMovieDuration.TabIndex = 6;
         // 
         // txtUpdateMovieDescription
         // 
         this.txtUpdateMovieDescription.Location = new System.Drawing.Point(170, 78);
         this.txtUpdateMovieDescription.Name = "txtUpdateMovieDescription";
         this.txtUpdateMovieDescription.Size = new System.Drawing.Size(100, 20);
         this.txtUpdateMovieDescription.TabIndex = 5;
         // 
         // txtUpdateMovieName
         // 
         this.txtUpdateMovieName.Location = new System.Drawing.Point(170, 39);
         this.txtUpdateMovieName.Name = "txtUpdateMovieName";
         this.txtUpdateMovieName.Size = new System.Drawing.Size(100, 20);
         this.txtUpdateMovieName.TabIndex = 4;
         // 
         // lblMovieIDOfUpdatedMovie
         // 
         this.lblMovieIDOfUpdatedMovie.AutoSize = true;
         this.lblMovieIDOfUpdatedMovie.Location = new System.Drawing.Point(16, 159);
         this.lblMovieIDOfUpdatedMovie.Name = "lblMovieIDOfUpdatedMovie";
         this.lblMovieIDOfUpdatedMovie.Size = new System.Drawing.Size(131, 15);
         this.lblMovieIDOfUpdatedMovie.TabIndex = 3;
         this.lblMovieIDOfUpdatedMovie.Text = "Güncellenecek Film ID";
         // 
         // lblUpdateMovieDuration
         // 
         this.lblUpdateMovieDuration.AutoSize = true;
         this.lblUpdateMovieDuration.Location = new System.Drawing.Point(16, 122);
         this.lblUpdateMovieDuration.Name = "lblUpdateMovieDuration";
         this.lblUpdateMovieDuration.Size = new System.Drawing.Size(69, 15);
         this.lblUpdateMovieDuration.TabIndex = 2;
         this.lblUpdateMovieDuration.Text = "Film Süresi";
         // 
         // lblUpdateMovieDescription
         // 
         this.lblUpdateMovieDescription.AutoSize = true;
         this.lblUpdateMovieDescription.Location = new System.Drawing.Point(16, 78);
         this.lblUpdateMovieDescription.Name = "lblUpdateMovieDescription";
         this.lblUpdateMovieDescription.Size = new System.Drawing.Size(93, 15);
         this.lblUpdateMovieDescription.TabIndex = 1;
         this.lblUpdateMovieDescription.Text = "Film Açıklaması";
         // 
         // lblUpdateMovieName
         // 
         this.lblUpdateMovieName.AutoSize = true;
         this.lblUpdateMovieName.Location = new System.Drawing.Point(16, 42);
         this.lblUpdateMovieName.Name = "lblUpdateMovieName";
         this.lblUpdateMovieName.Size = new System.Drawing.Size(51, 15);
         this.lblUpdateMovieName.TabIndex = 0;
         this.lblUpdateMovieName.Text = "Film Adı";
         // 
         // groupBoxSelectMovies
         // 
         this.groupBoxSelectMovies.BackColor = System.Drawing.Color.LightGreen;
         this.groupBoxSelectMovies.Controls.Add(this.txtSelectsMovie);
         this.groupBoxSelectMovies.Controls.Add(this.btnSelectsMovie);
         this.groupBoxSelectMovies.Controls.Add(this.dtListMovies);
         this.groupBoxSelectMovies.Controls.Add(this.lblSelectMovies);
         this.groupBoxSelectMovies.Location = new System.Drawing.Point(647, 33);
         this.groupBoxSelectMovies.Name = "groupBoxSelectMovies";
         this.groupBoxSelectMovies.Size = new System.Drawing.Size(553, 356);
         this.groupBoxSelectMovies.TabIndex = 7;
         this.groupBoxSelectMovies.TabStop = false;
         this.groupBoxSelectMovies.Text = "Film Listele";
         // 
         // txtSelectsMovie
         // 
         this.txtSelectsMovie.Location = new System.Drawing.Point(299, 49);
         this.txtSelectsMovie.Name = "txtSelectsMovie";
         this.txtSelectsMovie.Size = new System.Drawing.Size(234, 20);
         this.txtSelectsMovie.TabIndex = 3;
         // 
         // btnSelectsMovie
         // 
         this.btnSelectsMovie.Location = new System.Drawing.Point(299, 78);
         this.btnSelectsMovie.Name = "btnSelectsMovie";
         this.btnSelectsMovie.Size = new System.Drawing.Size(234, 36);
         this.btnSelectsMovie.TabIndex = 2;
         this.btnSelectsMovie.Text = "Listele";
         this.btnSelectsMovie.UseVisualStyleBackColor = true;
         this.btnSelectsMovie.Click += new System.EventHandler(this.btnSelectsMovie_Click);
         // 
         // dtListMovies
         // 
         this.dtListMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtListMovies.Location = new System.Drawing.Point(31, 122);
         this.dtListMovies.Name = "dtListMovies";
         this.dtListMovies.Size = new System.Drawing.Size(502, 215);
         this.dtListMovies.TabIndex = 1;
         // 
         // lblSelectMovies
         // 
         this.lblSelectMovies.AutoSize = true;
         this.lblSelectMovies.Location = new System.Drawing.Point(194, 52);
         this.lblSelectMovies.Name = "lblSelectMovies";
         this.lblSelectMovies.Size = new System.Drawing.Size(46, 15);
         this.lblSelectMovies.TabIndex = 0;
         this.lblSelectMovies.Text = "Film ID";
         // 
         // btnNext
         // 
         this.btnNext.BackColor = System.Drawing.Color.LightCoral;
         this.btnNext.Location = new System.Drawing.Point(990, 395);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(190, 42);
         this.btnNext.TabIndex = 8;
         this.btnNext.Text = "NEXT";
         this.btnNext.UseVisualStyleBackColor = false;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Thistle;
         this.ClientSize = new System.Drawing.Size(1209, 450);
         this.Controls.Add(this.btnNext);
         this.Controls.Add(this.groupBoxSelectMovies);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.groupBoxMovieDelete);
         this.Controls.Add(this.groupBoxMovies);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "Form1";
         this.Text = "MOVIES";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.groupBoxMovies.ResumeLayout(false);
         this.groupBoxMovies.PerformLayout();
         this.groupBoxMovieDelete.ResumeLayout(false);
         this.groupBoxMovieDelete.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBoxSelectMovies.ResumeLayout(false);
         this.groupBoxSelectMovies.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtListMovies)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label lblInsertMovie;
      private System.Windows.Forms.Label lblMovieDescription;
      private System.Windows.Forms.TextBox txtInsertMovie;
      private System.Windows.Forms.TextBox txtMovieDescription;
      private System.Windows.Forms.GroupBox groupBoxMovies;
      private System.Windows.Forms.Button btnInsertMovie;
      private System.Windows.Forms.TextBox txtMovieDuration;
      private System.Windows.Forms.Label lblMovieDuration;
      private System.Windows.Forms.GroupBox groupBoxMovieDelete;
      private System.Windows.Forms.Button btnDeleteMovie;
      private System.Windows.Forms.TextBox txtDeleteMovie;
      private System.Windows.Forms.Label lblDeleteMovie;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button btnUpdateMovie;
      private System.Windows.Forms.TextBox txtMovieIDToBeUpdated;
      private System.Windows.Forms.TextBox txtUpdateMovieDuration;
      private System.Windows.Forms.TextBox txtUpdateMovieDescription;
      private System.Windows.Forms.TextBox txtUpdateMovieName;
      private System.Windows.Forms.Label lblMovieIDOfUpdatedMovie;
      private System.Windows.Forms.Label lblUpdateMovieDuration;
      private System.Windows.Forms.Label lblUpdateMovieDescription;
      private System.Windows.Forms.Label lblUpdateMovieName;
      private System.Windows.Forms.GroupBox groupBoxSelectMovies;
      private System.Windows.Forms.TextBox txtSelectsMovie;
      private System.Windows.Forms.Button btnSelectsMovie;
      private System.Windows.Forms.DataGridView dtListMovies;
      private System.Windows.Forms.Label lblSelectMovies;
      private System.Windows.Forms.Button btnNext;
   }
}


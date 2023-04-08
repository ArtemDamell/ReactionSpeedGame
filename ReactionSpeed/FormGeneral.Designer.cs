namespace ReactionSpeed
{
    partial class FormGeneral
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneral));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_img1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_img2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_img3 = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_help = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_img1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_img2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_img3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 253);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox_img1
            // 
            this.pictureBox_img1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_img1.Image = global::ReactionSpeed.Properties.Resources.cat1;
            this.pictureBox_img1.InitialImage = null;
            this.pictureBox_img1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_img1.Name = "pictureBox_img1";
            this.pictureBox_img1.Size = new System.Drawing.Size(214, 247);
            this.pictureBox_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_img1.TabIndex = 0;
            this.pictureBox_img1.TabStop = false;
            this.pictureBox_img1.Click += new System.EventHandler(this.pictureBox_img1_Click);
            // 
            // pictureBox_img2
            // 
            this.pictureBox_img2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_img2.Image = global::ReactionSpeed.Properties.Resources.cat2;
            this.pictureBox_img2.Location = new System.Drawing.Point(223, 3);
            this.pictureBox_img2.Name = "pictureBox_img2";
            this.pictureBox_img2.Size = new System.Drawing.Size(214, 247);
            this.pictureBox_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_img2.TabIndex = 1;
            this.pictureBox_img2.TabStop = false;
            this.pictureBox_img2.Click += new System.EventHandler(this.pictureBox_img1_Click);
            // 
            // pictureBox_img3
            // 
            this.pictureBox_img3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_img3.Image = global::ReactionSpeed.Properties.Resources.cat3;
            this.pictureBox_img3.Location = new System.Drawing.Point(443, 3);
            this.pictureBox_img3.Name = "pictureBox_img3";
            this.pictureBox_img3.Size = new System.Drawing.Size(216, 247);
            this.pictureBox_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_img3.TabIndex = 2;
            this.pictureBox_img3.TabStop = false;
            this.pictureBox_img3.Click += new System.EventHandler(this.pictureBox_img1_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(283, 328);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(124, 47);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_help
            // 
            this.label_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_help.Location = new System.Drawing.Point(12, 268);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(659, 44);
            this.label_help.TabIndex = 2;
            this.label_help.Text = "Click on the pictures immediately after they appear";
            this.label_help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 399);
            this.progress.MarqueeAnimationSpeed = 1;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(662, 31);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(455, 328);
            this.trackBar1.Maximum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(216, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Easy";
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormGeneral";
            this.Text = "Reaction Speed";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox_img1;
        private System.Windows.Forms.PictureBox pictureBox_img2;
        private System.Windows.Forms.PictureBox pictureBox_img3;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


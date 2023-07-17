namespace Assignment5
{
    partial class formCarRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCarRace));
            this.pb_Car1 = new System.Windows.Forms.PictureBox();
            this.pb_Car2 = new System.Windows.Forms.PictureBox();
            this.gb_RaceControl = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_Car1 = new System.Windows.Forms.Label();
            this.lbl_Car2 = new System.Windows.Forms.Label();
            this.RaceHistory = new System.Windows.Forms.DataGridView();
            this.Winner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeElapsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmr_Car2 = new System.Windows.Forms.Timer(this.components);
            this.tmr_Car1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_TimePassed = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Grp_bx_Speed = new System.Windows.Forms.GroupBox();
            this.btnC1_Increase = new System.Windows.Forms.Button();
            this.btnC2_Increase = new System.Windows.Forms.Button();
            this.btnC2_Decrease = new System.Windows.Forms.Button();
            this.btnC1_Decrease = new System.Windows.Forms.Button();
            this.lblC1_Car1 = new System.Windows.Forms.Label();
            this.lblC2_Car2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Car2)).BeginInit();
            this.gb_RaceControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RaceHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Grp_bx_Speed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Car1
            // 
            this.pb_Car1.ImageLocation = "C:\\Users\\leejo\\OneDrive\\Documents\\Seneca\\ECT Summer 2023\\PRG 455\\Assignment5\\Assi" +
    "gnment5\\Source Files\\Car_2.png";
            this.pb_Car1.Location = new System.Drawing.Point(10, 50);
            this.pb_Car1.Name = "pb_Car1";
            this.pb_Car1.Size = new System.Drawing.Size(227, 106);
            this.pb_Car1.TabIndex = 0;
            this.pb_Car1.TabStop = false;
            // 
            // pb_Car2
            // 
            this.pb_Car2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pb_Car2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_Car2.ErrorImage")));
            this.pb_Car2.ImageLocation = "C:\\Users\\leejo\\OneDrive\\Documents\\Seneca\\ECT Summer 2023\\PRG 455\\Assignment5\\Assi" +
    "gnment5\\Source Files\\Car_1.png";
            this.pb_Car2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Car2.InitialImage")));
            this.pb_Car2.Location = new System.Drawing.Point(10, 210);
            this.pb_Car2.Name = "pb_Car2";
            this.pb_Car2.Size = new System.Drawing.Size(227, 99);
            this.pb_Car2.TabIndex = 1;
            this.pb_Car2.TabStop = false;
            // 
            // gb_RaceControl
            // 
            this.gb_RaceControl.BackColor = System.Drawing.Color.White;
            this.gb_RaceControl.Controls.Add(this.btn_Exit);
            this.gb_RaceControl.Controls.Add(this.btn_Restart);
            this.gb_RaceControl.Controls.Add(this.btn_Start);
            this.gb_RaceControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_RaceControl.ForeColor = System.Drawing.Color.Red;
            this.gb_RaceControl.Location = new System.Drawing.Point(43, 427);
            this.gb_RaceControl.Name = "gb_RaceControl";
            this.gb_RaceControl.Size = new System.Drawing.Size(317, 100);
            this.gb_RaceControl.TabIndex = 2;
            this.gb_RaceControl.TabStop = false;
            this.gb_RaceControl.Text = "Race Controls";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(212, 43);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(70, 24);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restart.Location = new System.Drawing.Point(124, 41);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(70, 24);
            this.btn_Restart.TabIndex = 1;
            this.btn_Restart.Text = "Reset";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(30, 41);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(70, 24);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start Race";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_Car1
            // 
            this.lbl_Car1.AutoSize = true;
            this.lbl_Car1.Location = new System.Drawing.Point(9, 32);
            this.lbl_Car1.Name = "lbl_Car1";
            this.lbl_Car1.Size = new System.Drawing.Size(32, 13);
            this.lbl_Car1.TabIndex = 3;
            this.lbl_Car1.Text = "Car 1";
            // 
            // lbl_Car2
            // 
            this.lbl_Car2.AutoSize = true;
            this.lbl_Car2.Location = new System.Drawing.Point(9, 167);
            this.lbl_Car2.Name = "lbl_Car2";
            this.lbl_Car2.Size = new System.Drawing.Size(32, 13);
            this.lbl_Car2.TabIndex = 4;
            this.lbl_Car2.Text = "Car 2";
            // 
            // RaceHistory
            // 
            this.RaceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RaceHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Winner,
            this.Loser,
            this.TimeElapsed});
            this.RaceHistory.Location = new System.Drawing.Point(752, 427);
            this.RaceHistory.Name = "RaceHistory";
            this.RaceHistory.Size = new System.Drawing.Size(335, 122);
            this.RaceHistory.TabIndex = 5;
            // 
            // Winner
            // 
            this.Winner.HeaderText = "Winner";
            this.Winner.Name = "Winner";
            this.Winner.ReadOnly = true;
            // 
            // Loser
            // 
            this.Loser.HeaderText = "Loser";
            this.Loser.Name = "Loser";
            this.Loser.ReadOnly = true;
            // 
            // TimeElapsed
            // 
            this.TimeElapsed.HeaderText = "Time Elapsed (Seconds)";
            this.TimeElapsed.Name = "TimeElapsed";
            this.TimeElapsed.ReadOnly = true;
            this.TimeElapsed.Width = 90;
            // 
            // tmr_Car2
            // 
            this.tmr_Car2.Tick += new System.EventHandler(this.tmr_Car2_Tick);
            // 
            // tmr_Car1
            // 
            this.tmr_Car1.Tick += new System.EventHandler(this.tmr_Car1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.Black;
            this.lbl_time.Location = new System.Drawing.Point(749, 399);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(99, 15);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "Time Elapsed:";
            // 
            // lbl_TimePassed
            // 
            this.lbl_TimePassed.AutoSize = true;
            this.lbl_TimePassed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_TimePassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimePassed.ForeColor = System.Drawing.Color.Black;
            this.lbl_TimePassed.Location = new System.Drawing.Point(841, 399);
            this.lbl_TimePassed.Name = "lbl_TimePassed";
            this.lbl_TimePassed.Size = new System.Drawing.Size(35, 15);
            this.lbl_TimePassed.TabIndex = 8;
            this.lbl_TimePassed.Text = "0:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1060, 329);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Grp_bx_Speed
            // 
            this.Grp_bx_Speed.BackColor = System.Drawing.Color.White;
            this.Grp_bx_Speed.Controls.Add(this.lblC2_Car2);
            this.Grp_bx_Speed.Controls.Add(this.lblC1_Car1);
            this.Grp_bx_Speed.Controls.Add(this.btnC2_Decrease);
            this.Grp_bx_Speed.Controls.Add(this.btnC1_Decrease);
            this.Grp_bx_Speed.Controls.Add(this.btnC2_Increase);
            this.Grp_bx_Speed.Controls.Add(this.btnC1_Increase);
            this.Grp_bx_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_bx_Speed.ForeColor = System.Drawing.Color.Black;
            this.Grp_bx_Speed.Location = new System.Drawing.Point(442, 427);
            this.Grp_bx_Speed.Name = "Grp_bx_Speed";
            this.Grp_bx_Speed.Size = new System.Drawing.Size(223, 100);
            this.Grp_bx_Speed.TabIndex = 3;
            this.Grp_bx_Speed.TabStop = false;
            this.Grp_bx_Speed.Text = "Change Car Speed";
            // 
            // btnC1_Increase
            // 
            this.btnC1_Increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC1_Increase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnC1_Increase.Location = new System.Drawing.Point(26, 19);
            this.btnC1_Increase.Name = "btnC1_Increase";
            this.btnC1_Increase.Size = new System.Drawing.Size(75, 23);
            this.btnC1_Increase.TabIndex = 0;
            this.btnC1_Increase.Text = "Increase";
            this.btnC1_Increase.UseVisualStyleBackColor = true;
            this.btnC1_Increase.Click += new System.EventHandler(this.btnC1_Increase_Click);
            // 
            // btnC2_Increase
            // 
            this.btnC2_Increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC2_Increase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnC2_Increase.Location = new System.Drawing.Point(127, 19);
            this.btnC2_Increase.Name = "btnC2_Increase";
            this.btnC2_Increase.Size = new System.Drawing.Size(75, 23);
            this.btnC2_Increase.TabIndex = 1;
            this.btnC2_Increase.Text = "Increase";
            this.btnC2_Increase.UseVisualStyleBackColor = true;
            this.btnC2_Increase.Click += new System.EventHandler(this.btnC2_Increase_Click);
            // 
            // btnC2_Decrease
            // 
            this.btnC2_Decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC2_Decrease.ForeColor = System.Drawing.Color.Red;
            this.btnC2_Decrease.Location = new System.Drawing.Point(127, 71);
            this.btnC2_Decrease.Name = "btnC2_Decrease";
            this.btnC2_Decrease.Size = new System.Drawing.Size(75, 23);
            this.btnC2_Decrease.TabIndex = 3;
            this.btnC2_Decrease.Text = "Decrease";
            this.btnC2_Decrease.UseVisualStyleBackColor = true;
            this.btnC2_Decrease.Click += new System.EventHandler(this.btnC2_Decrease_Click);
            // 
            // btnC1_Decrease
            // 
            this.btnC1_Decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC1_Decrease.ForeColor = System.Drawing.Color.Red;
            this.btnC1_Decrease.Location = new System.Drawing.Point(26, 71);
            this.btnC1_Decrease.Name = "btnC1_Decrease";
            this.btnC1_Decrease.Size = new System.Drawing.Size(75, 23);
            this.btnC1_Decrease.TabIndex = 2;
            this.btnC1_Decrease.Text = "Decrease";
            this.btnC1_Decrease.UseVisualStyleBackColor = true;
            this.btnC1_Decrease.Click += new System.EventHandler(this.btnC1_Decrease_Click);
            // 
            // lblC1_Car1
            // 
            this.lblC1_Car1.AutoSize = true;
            this.lblC1_Car1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC1_Car1.ForeColor = System.Drawing.Color.Black;
            this.lblC1_Car1.Location = new System.Drawing.Point(46, 52);
            this.lblC1_Car1.Name = "lblC1_Car1";
            this.lblC1_Car1.Size = new System.Drawing.Size(36, 15);
            this.lblC1_Car1.TabIndex = 4;
            this.lblC1_Car1.Text = "Car 1";
            // 
            // lblC2_Car2
            // 
            this.lblC2_Car2.AutoSize = true;
            this.lblC2_Car2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC2_Car2.ForeColor = System.Drawing.Color.Black;
            this.lblC2_Car2.Location = new System.Drawing.Point(147, 52);
            this.lblC2_Car2.Name = "lblC2_Car2";
            this.lblC2_Car2.Size = new System.Drawing.Size(36, 15);
            this.lblC2_Car2.TabIndex = 5;
            this.lblC2_Car2.Text = "Car 2";
            // 
            // formCarRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.Grp_bx_Speed);
            this.Controls.Add(this.lbl_TimePassed);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.RaceHistory);
            this.Controls.Add(this.lbl_Car2);
            this.Controls.Add(this.lbl_Car1);
            this.Controls.Add(this.gb_RaceControl);
            this.Controls.Add(this.pb_Car2);
            this.Controls.Add(this.pb_Car1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "formCarRace";
            this.Text = "Car Race";
            this.Load += new System.EventHandler(this.formCarRace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Car2)).EndInit();
            this.gb_RaceControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RaceHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Grp_bx_Speed.ResumeLayout(false);
            this.Grp_bx_Speed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Car1;
        private System.Windows.Forms.PictureBox pb_Car2;
        private System.Windows.Forms.GroupBox gb_RaceControl;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Car1;
        private System.Windows.Forms.Label lbl_Car2;
        private System.Windows.Forms.DataGridView RaceHistory;
        private System.Windows.Forms.Timer tmr_Car2;
        private System.Windows.Forms.Timer tmr_Car1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Winner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loser;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeElapsed;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_TimePassed;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox Grp_bx_Speed;
        private System.Windows.Forms.Label lblC2_Car2;
        private System.Windows.Forms.Label lblC1_Car1;
        private System.Windows.Forms.Button btnC2_Decrease;
        private System.Windows.Forms.Button btnC1_Decrease;
        private System.Windows.Forms.Button btnC2_Increase;
        private System.Windows.Forms.Button btnC1_Increase;
    }
}


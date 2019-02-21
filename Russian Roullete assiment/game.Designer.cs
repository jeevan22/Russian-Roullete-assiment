namespace Russian_Roullete_assiment
{
    partial class game
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_retry = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(212, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Russian Roullete";
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_load.Location = new System.Drawing.Point(78, 91);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(83, 34);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_spin.Location = new System.Drawing.Point(265, 91);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(83, 34);
            this.btn_spin.TabIndex = 2;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Shoot.Location = new System.Drawing.Point(430, 91);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(108, 34);
            this.btn_Shoot.TabIndex = 3;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = true;
            this.btn_Shoot.Click += new System.EventHandler(this.btn_Shoot_Click);
            // 
            // btn_retry
            // 
            this.btn_retry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retry.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_retry.Location = new System.Drawing.Point(601, 91);
            this.btn_retry.Name = "btn_retry";
            this.btn_retry.Size = new System.Drawing.Size(83, 34);
            this.btn_retry.TabIndex = 4;
            this.btn_retry.Text = "Retry";
            this.btn_retry.UseVisualStyleBackColor = true;
            this.btn_retry.Click += new System.EventHandler(this.btn_retry_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(78, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 272);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Russian_Roullete_assiment.Properties.Resources.suicide_a_man_put_a_gun_to_his_head_black_and_white_on_shutterstock_800x430;
            this.ClientSize = new System.Drawing.Size(799, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_retry);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label1);
            this.Name = "game";
            this.Text = "game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_retry;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
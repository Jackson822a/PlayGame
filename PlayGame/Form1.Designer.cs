namespace PlayGame
{
    partial class form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.save3 = new System.Windows.Forms.Button();
            this.save4 = new System.Windows.Forms.Button();
            this.data1 = new System.Windows.Forms.Label();
            this.data2 = new System.Windows.Forms.Label();
            this.data3 = new System.Windows.Forms.Label();
            this.data4 = new System.Windows.Forms.Label();
            this.settings1 = new System.Windows.Forms.Button();
            this.exit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Font = new System.Drawing.Font("Magneto", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(356, 133);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(299, 94);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // save1
            // 
            this.save1.Font = new System.Drawing.Font("Magneto", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save1.Location = new System.Drawing.Point(104, 35);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(601, 92);
            this.save1.TabIndex = 2;
            this.save1.Text = "Save 1";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Visible = false;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // save2
            // 
            this.save2.Font = new System.Drawing.Font("Magneto", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save2.Location = new System.Drawing.Point(104, 166);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(601, 92);
            this.save2.TabIndex = 3;
            this.save2.Text = "Save 2";
            this.save2.UseVisualStyleBackColor = true;
            this.save2.Visible = false;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // save3
            // 
            this.save3.Font = new System.Drawing.Font("Magneto", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save3.Location = new System.Drawing.Point(104, 284);
            this.save3.Name = "save3";
            this.save3.Size = new System.Drawing.Size(601, 92);
            this.save3.TabIndex = 4;
            this.save3.Text = "Save 3";
            this.save3.UseVisualStyleBackColor = true;
            this.save3.Visible = false;
            this.save3.Click += new System.EventHandler(this.save3_Click);
            // 
            // save4
            // 
            this.save4.Font = new System.Drawing.Font("Magneto", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save4.Location = new System.Drawing.Point(104, 408);
            this.save4.Name = "save4";
            this.save4.Size = new System.Drawing.Size(601, 92);
            this.save4.TabIndex = 5;
            this.save4.Text = "Save 4";
            this.save4.UseVisualStyleBackColor = true;
            this.save4.Visible = false;
            this.save4.Click += new System.EventHandler(this.save4_Click);
            // 
            // data1
            // 
            this.data1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.data1.Font = new System.Drawing.Font("Magneto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data1.Location = new System.Drawing.Point(733, 35);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(218, 92);
            this.data1.TabIndex = 6;
            this.data1.Text = "13%";
            this.data1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.data1.Visible = false;
            this.data1.Click += new System.EventHandler(this.data1_Click);
            // 
            // data2
            // 
            this.data2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.data2.Font = new System.Drawing.Font("Magneto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data2.Location = new System.Drawing.Point(733, 166);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(218, 92);
            this.data2.TabIndex = 7;
            this.data2.Text = "0%";
            this.data2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.data2.Visible = false;
            this.data2.Click += new System.EventHandler(this.data2_Click);
            // 
            // data3
            // 
            this.data3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.data3.Font = new System.Drawing.Font("Magneto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data3.Location = new System.Drawing.Point(733, 288);
            this.data3.Name = "data3";
            this.data3.Size = new System.Drawing.Size(218, 92);
            this.data3.TabIndex = 8;
            this.data3.Text = "74%";
            this.data3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.data3.Visible = false;
            this.data3.Click += new System.EventHandler(this.data3_Click);
            // 
            // data4
            // 
            this.data4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.data4.Font = new System.Drawing.Font("Magneto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data4.Location = new System.Drawing.Point(733, 408);
            this.data4.Name = "data4";
            this.data4.Size = new System.Drawing.Size(218, 92);
            this.data4.TabIndex = 9;
            this.data4.Text = "0%";
            this.data4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.data4.Visible = false;
            this.data4.Click += new System.EventHandler(this.data4_Click);
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.Transparent;
            this.settings1.Font = new System.Drawing.Font("Magneto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings1.Location = new System.Drawing.Point(400, 284);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(210, 82);
            this.settings1.TabIndex = 10;
            this.settings1.Text = "Settings";
            this.settings1.UseVisualStyleBackColor = false;
            this.settings1.Click += new System.EventHandler(this.settings1_Click);
            // 
            // exit1
            // 
            this.exit1.BackColor = System.Drawing.Color.Transparent;
            this.exit1.Font = new System.Drawing.Font("Magneto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit1.Location = new System.Drawing.Point(400, 399);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(210, 82);
            this.exit1.TabIndex = 11;
            this.exit1.Text = "Exit";
            this.exit1.UseVisualStyleBackColor = false;
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(978, 531);
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.data4);
            this.Controls.Add(this.data3);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.save4);
            this.Controls.Add(this.save3);
            this.Controls.Add(this.save2);
            this.Controls.Add(this.save1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button save2;
        private System.Windows.Forms.Button save3;
        private System.Windows.Forms.Button save4;
        private System.Windows.Forms.Label data1;
        private System.Windows.Forms.Label data2;
        private System.Windows.Forms.Label data3;
        private System.Windows.Forms.Label data4;
        private System.Windows.Forms.Button settings1;
        private System.Windows.Forms.Button exit1;
    }
}


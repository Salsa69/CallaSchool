namespace CallaSchool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_exit = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_dateInc = new System.Windows.Forms.Button();
            this.button_dateDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(92)))));
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(92)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(408, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(33, 33);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "✕";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button_min
            // 
            this.button_min.FlatAppearance.BorderSize = 0;
            this.button_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.button_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_min.ForeColor = System.Drawing.Color.White;
            this.button_min.Location = new System.Drawing.Point(375, 0);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(33, 33);
            this.button_min.TabIndex = 1;
            this.button_min.Text = "—";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.min_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(60, 66);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(45, 19);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "label1";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(240, 26);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Calla\'s School Agenda";
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.label_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.label_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_MouseUp);
            // 
            // button_dateInc
            // 
            this.button_dateInc.FlatAppearance.BorderSize = 0;
            this.button_dateInc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.button_dateInc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.button_dateInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dateInc.ForeColor = System.Drawing.Color.White;
            this.button_dateInc.Location = new System.Drawing.Point(219, 60);
            this.button_dateInc.Name = "button_dateInc";
            this.button_dateInc.Size = new System.Drawing.Size(33, 33);
            this.button_dateInc.TabIndex = 4;
            this.button_dateInc.Text = "—";
            this.button_dateInc.UseVisualStyleBackColor = true;
            this.button_dateInc.Click += new System.EventHandler(this.button_dateInc_Click);
            // 
            // button_dateDec
            // 
            this.button_dateDec.FlatAppearance.BorderSize = 0;
            this.button_dateDec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.button_dateDec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.button_dateDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dateDec.ForeColor = System.Drawing.Color.White;
            this.button_dateDec.Location = new System.Drawing.Point(25, 60);
            this.button_dateDec.Name = "button_dateDec";
            this.button_dateDec.Size = new System.Drawing.Size(33, 33);
            this.button_dateDec.TabIndex = 5;
            this.button_dateDec.Text = "—";
            this.button_dateDec.UseVisualStyleBackColor = true;
            this.button_dateDec.Click += new System.EventHandler(this.button_dateDec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(441, 383);
            this.Controls.Add(this.button_dateDec);
            this.Controls.Add(this.button_dateInc);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_exit;
        private Button button_min;
        private Label label_date;
        private Label label_Title;
        private Button button_dateInc;
        private Button button_dateDec;
    }
}
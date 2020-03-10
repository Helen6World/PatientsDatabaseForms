namespace PatientsDBWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_entering = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_log_in = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_entering
            // 
            this.lb_entering.AutoSize = true;
            this.lb_entering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.lb_entering.Location = new System.Drawing.Point(100, 30);
            this.lb_entering.Name = "lb_entering";
            this.lb_entering.Size = new System.Drawing.Size(145, 18);
            this.lb_entering.TabIndex = 0;
            this.lb_entering.Text = "Вхід до програми";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_password.Location = new System.Drawing.Point(50, 118);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(62, 18);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Пароль:";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.Location = new System.Drawing.Point(50, 84);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(47, 18);
            this.lb_login.TabIndex = 2;
            this.lb_login.Text = "Логін:";
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(131, 81);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(150, 25);
            this.tb_login.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Open Sans Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.tb_password.Location = new System.Drawing.Point(131, 118);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(150, 22);
            this.tb_password.TabIndex = 4;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // btn_log_in
            // 
            this.btn_log_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_log_in.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_log_in.Location = new System.Drawing.Point(119, 210);
            this.btn_log_in.Name = "btn_log_in";
            this.btn_log_in.Size = new System.Drawing.Size(109, 28);
            this.btn_log_in.TabIndex = 5;
            this.btn_log_in.Text = "Ввійти";
            this.btn_log_in.UseVisualStyleBackColor = false;
            this.btn_log_in.Click += new System.EventHandler(this.btn_log_in_Click);
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(61, 172);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(231, 13);
            this.lb_error.TabIndex = 6;
            this.lb_error.Text = "Неправильне введення, введіть дані ще раз";
            this.lb_error.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.btn_log_in);
            this.panel1.Controls.Add(this.lb_error);
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Controls.Add(this.lb_entering);
            this.panel1.Controls.Add(this.lb_password);
            this.panel1.Controls.Add(this.lb_login);
            this.panel1.Location = new System.Drawing.Point(226, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 269);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Пацієнти";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_entering;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_log_in;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace TiKey_Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnunlock = new System.Windows.Forms.Button();
            this.cbrol = new System.Windows.Forms.CheckBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.btnunlock);
            this.groupBox1.Controls.Add(this.cbrol);
            this.groupBox1.Controls.Add(this.txtpw);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TiKey";
            // 
            // btnlock
            // 
            this.btnlock.Location = new System.Drawing.Point(216, 87);
            this.btnlock.Name = "btnlock";
            this.btnlock.Size = new System.Drawing.Size(106, 39);
            this.btnlock.TabIndex = 4;
            this.btnlock.Text = "Khoá";
            this.btnlock.UseVisualStyleBackColor = true;
            this.btnlock.Click += new System.EventHandler(this.btnlock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu:";
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(10, 87);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(200, 39);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "Đặt lại mật khẩu";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Visible = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnunlock
            // 
            this.btnunlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunlock.Location = new System.Drawing.Point(328, 87);
            this.btnunlock.Name = "btnunlock";
            this.btnunlock.Size = new System.Drawing.Size(106, 39);
            this.btnunlock.TabIndex = 2;
            this.btnunlock.Text = "Mở khoá";
            this.btnunlock.UseVisualStyleBackColor = true;
            this.btnunlock.Click += new System.EventHandler(this.btnunlock_Click);
            // 
            // cbrol
            // 
            this.cbrol.AutoSize = true;
            this.cbrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrol.Location = new System.Drawing.Point(10, 60);
            this.cbrol.Name = "cbrol";
            this.cbrol.Size = new System.Drawing.Size(233, 24);
            this.cbrol.TabIndex = 1;
            this.cbrol.Text = "Cho phép chỉnh sửa dữ liệu";
            this.cbrol.UseVisualStyleBackColor = true;
            // 
            // txtpw
            // 
            this.txtpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.Location = new System.Drawing.Point(107, 28);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.Size = new System.Drawing.Size(327, 26);
            this.txtpw.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 168);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "TiKey Unlocker v1.00";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnunlock;
        private System.Windows.Forms.CheckBox cbrol;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Button btnlock;
    }
}


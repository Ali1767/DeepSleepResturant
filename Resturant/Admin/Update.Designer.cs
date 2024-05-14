namespace Resturant.Admin
{
    partial class Update
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
            this.txtOld = new System.Windows.Forms.TextBox();
            this.txtNew23 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNamebtn = new System.Windows.Forms.Button();
            this.Passwordbtn = new System.Windows.Forms.Button();
            this.Emailbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(265, 156);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(269, 22);
            this.txtOld.TabIndex = 0;
            // 
            // txtNew23
            // 
            this.txtNew23.Location = new System.Drawing.Point(265, 245);
            this.txtNew23.Name = "txtNew23";
            this.txtNew23.Size = new System.Drawing.Size(269, 22);
            this.txtNew23.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "OLD ONE ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "NEW ONE ";
            // 
            // UserNamebtn
            // 
            this.UserNamebtn.BackColor = System.Drawing.Color.White;
            this.UserNamebtn.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamebtn.Location = new System.Drawing.Point(160, 342);
            this.UserNamebtn.Name = "UserNamebtn";
            this.UserNamebtn.Size = new System.Drawing.Size(113, 38);
            this.UserNamebtn.TabIndex = 4;
            this.UserNamebtn.Text = "User Name ";
            this.UserNamebtn.UseVisualStyleBackColor = false;
            this.UserNamebtn.Click += new System.EventHandler(this.UserNamebtn_Click);
            // 
            // Passwordbtn
            // 
            this.Passwordbtn.BackColor = System.Drawing.Color.White;
            this.Passwordbtn.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordbtn.Location = new System.Drawing.Point(350, 342);
            this.Passwordbtn.Name = "Passwordbtn";
            this.Passwordbtn.Size = new System.Drawing.Size(117, 38);
            this.Passwordbtn.TabIndex = 5;
            this.Passwordbtn.Text = "Password";
            this.Passwordbtn.UseVisualStyleBackColor = false;
            this.Passwordbtn.Click += new System.EventHandler(this.Passwordbtn_Click);
            // 
            // Emailbtn
            // 
            this.Emailbtn.BackColor = System.Drawing.Color.White;
            this.Emailbtn.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailbtn.Location = new System.Drawing.Point(550, 342);
            this.Emailbtn.Name = "Emailbtn";
            this.Emailbtn.Size = new System.Drawing.Size(104, 38);
            this.Emailbtn.TabIndex = 6;
            this.Emailbtn.Text = "Email";
            this.Emailbtn.UseVisualStyleBackColor = false;
            this.Emailbtn.Click += new System.EventHandler(this.Emailbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "HOME";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Emailbtn);
            this.Controls.Add(this.Passwordbtn);
            this.Controls.Add(this.UserNamebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNew23);
            this.Controls.Add(this.txtOld);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.TextBox txtNew23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UserNamebtn;
        private System.Windows.Forms.Button Passwordbtn;
        private System.Windows.Forms.Button Emailbtn;
        private System.Windows.Forms.Button button2;
    }
}
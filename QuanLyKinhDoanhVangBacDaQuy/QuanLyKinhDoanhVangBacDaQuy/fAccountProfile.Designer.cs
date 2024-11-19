namespace QuanLyKinhDoanhVangBacDaQuy
{
    partial class fAccountProfile
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
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassword = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPass = new TextBox();
            labelPassword = new Label();
            panel5 = new Panel();
            txbReEnterPass = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            btnExitUpdate = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(49, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(678, 81);
            panel2.TabIndex = 2;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(231, 25);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(344, 31);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(49, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 81);
            panel1.TabIndex = 3;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(231, 25);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.ReadOnly = true;
            txbDisplayName.Size = new Size(344, 31);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 31);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassword);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(49, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(678, 81);
            panel3.TabIndex = 4;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(231, 25);
            txbPassword.Name = "txbPassword";
            txbPassword.ReadOnly = true;
            txbPassword.Size = new Size(344, 31);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 31);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPass);
            panel4.Controls.Add(labelPassword);
            panel4.Location = new Point(49, 300);
            panel4.Name = "panel4";
            panel4.Size = new Size(678, 81);
            panel4.TabIndex = 5;
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(231, 22);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.ReadOnly = true;
            txbNewPass.Size = new Size(344, 31);
            txbNewPass.TabIndex = 1;
            txbNewPass.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(36, 28);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(126, 25);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Mật khẩu mới:";
            labelPassword.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(49, 400);
            panel5.Name = "panel5";
            panel5.Size = new Size(678, 81);
            panel5.TabIndex = 6;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(231, 22);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.ReadOnly = true;
            txbReEnterPass.Size = new Size(344, 31);
            txbReEnterPass.TabIndex = 1;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 28);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 0;
            label4.Text = "Nhập lại mật khẩu mới:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(615, 499);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExitUpdate
            // 
            btnExitUpdate.Location = new Point(497, 499);
            btnExitUpdate.Name = "btnExitUpdate";
            btnExitUpdate.Size = new Size(112, 34);
            btnExitUpdate.TabIndex = 8;
            btnExitUpdate.Text = "Thoát";
            btnExitUpdate.UseVisualStyleBackColor = true;
            btnExitUpdate.Click += btnExitUpdate_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExitUpdate;
            ClientSize = new Size(790, 557);
            Controls.Add(btnExitUpdate);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassword;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPass;
        private Label labelPassword;
        private Panel panel5;
        private TextBox txbReEnterPass;
        private Label label4;
        private Button btnUpdate;
        private Button btnExitUpdate;
    }
}
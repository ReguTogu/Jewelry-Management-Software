namespace QuanLyKinhDoanhVangBacDaQuy
{
    partial class fManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            lịchSửKhoToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            loạiDịchVụToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            panel3 = new Panel();
            btnCheckOut = new Button();
            panel4 = new Panel();
            nmJewelryCount = new NumericUpDown();
            btnAddJewelry = new Button();
            cbJewelry = new ComboBox();
            cbCategory = new ComboBox();
            nhậpHàngToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmJewelryCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem, lịchSửKhoToolStripMenuItem, kháchHàngToolStripMenuItem, loạiDịchVụToolStripMenuItem, nhậpHàngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1289, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(81, 29);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += nhàCungCấpToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(182, 29);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // thôngCáNhânToolStripMenuItem
            // 
            thôngCáNhânToolStripMenuItem.Name = "thôngCáNhânToolStripMenuItem";
            thôngCáNhânToolStripMenuItem.Size = new Size(270, 34);
            thôngCáNhânToolStripMenuItem.Text = "Thông cá nhân";
            thôngCáNhânToolStripMenuItem.Click += thôngCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(270, 34);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // lịchSửKhoToolStripMenuItem
            // 
            lịchSửKhoToolStripMenuItem.Name = "lịchSửKhoToolStripMenuItem";
            lịchSửKhoToolStripMenuItem.Size = new Size(117, 29);
            lịchSửKhoToolStripMenuItem.Text = "Lịch sử kho";
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(120, 29);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // loạiDịchVụToolStripMenuItem
            // 
            loạiDịchVụToolStripMenuItem.Name = "loạiDịchVụToolStripMenuItem";
            loạiDịchVụToolStripMenuItem.Size = new Size(87, 29);
            loạiDịchVụToolStripMenuItem.Text = "Dịch vụ";
            loạiDịchVụToolStripMenuItem.Click += loạiDịchVụToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(12, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 332);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Location = new Point(13, 21);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(967, 287);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(12, 488);
            panel3.Name = "panel3";
            panel3.Size = new Size(995, 95);
            panel3.TabIndex = 3;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(826, 32);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(154, 34);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmJewelryCount);
            panel4.Controls.Add(btnAddJewelry);
            panel4.Controls.Add(cbJewelry);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(12, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(995, 98);
            panel4.TabIndex = 4;
            // 
            // nmJewelryCount
            // 
            nmJewelryCount.Location = new Point(573, 15);
            nmJewelryCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmJewelryCount.Name = "nmJewelryCount";
            nmJewelryCount.Size = new Size(65, 31);
            nmJewelryCount.TabIndex = 3;
            // 
            // btnAddJewelry
            // 
            btnAddJewelry.Location = new Point(386, 15);
            btnAddJewelry.Name = "btnAddJewelry";
            btnAddJewelry.Size = new Size(154, 34);
            btnAddJewelry.TabIndex = 2;
            btnAddJewelry.Text = "Thêm";
            btnAddJewelry.UseVisualStyleBackColor = true;
            btnAddJewelry.Click += btnAddJewelry_Click;
            // 
            // cbJewelry
            // 
            cbJewelry.FormattingEnabled = true;
            cbJewelry.Location = new Point(13, 54);
            cbJewelry.Name = "cbJewelry";
            cbJewelry.Size = new Size(336, 33);
            cbJewelry.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(13, 15);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(336, 33);
            cbCategory.TabIndex = 0;
            // 
            // nhậpHàngToolStripMenuItem
            // 
            nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            nhậpHàngToolStripMenuItem.Size = new Size(116, 29);
            nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            // 
            // fManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 602);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Name = "fManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý kinh doanh vàng bạc đá quý";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmJewelryCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem lịchSửKhoToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem loạiDịchVụToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListView lsvBill;
        private Panel panel4;
        private ComboBox cbJewelry;
        private ComboBox cbCategory;
        private Button btnAddJewelry;
        private NumericUpDown nmJewelryCount;
        private Button btnCheckOut;
        private ToolStripMenuItem nhậpHàngToolStripMenuItem;
    }
}
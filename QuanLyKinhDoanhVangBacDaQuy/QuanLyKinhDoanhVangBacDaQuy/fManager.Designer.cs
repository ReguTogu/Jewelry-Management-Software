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
            nhậpHàngToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            panel3 = new Panel();
            btnCheckOut = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            labelPhieuBH = new Label();
            nmJewelryCount = new NumericUpDown();
            btnAddJewelry = new Button();
            cbJewelry = new ComboBox();
            cbCategory = new ComboBox();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmJewelryCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem, nhậpHàngToolStripMenuItem, kháchHàngToolStripMenuItem, loạiDịchVụToolStripMenuItem, lịchSửKhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(814, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += nhàCungCấpToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // thôngCáNhânToolStripMenuItem
            // 
            thôngCáNhânToolStripMenuItem.Name = "thôngCáNhânToolStripMenuItem";
            thôngCáNhânToolStripMenuItem.Size = new Size(224, 26);
            thôngCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngCáNhânToolStripMenuItem.Click += thôngCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // lịchSửKhoToolStripMenuItem
            // 
            lịchSửKhoToolStripMenuItem.Name = "lịchSửKhoToolStripMenuItem";
            lịchSửKhoToolStripMenuItem.Size = new Size(131, 24);
            lịchSửKhoToolStripMenuItem.Text = "Báo cáo tồn kho";
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(122, 24);
            kháchHàngToolStripMenuItem.Text = "Tra cứu dịch vụ";
            // 
            // loạiDịchVụToolStripMenuItem
            // 
            loạiDịchVụToolStripMenuItem.Name = "loạiDịchVụToolStripMenuItem";
            loạiDịchVụToolStripMenuItem.Size = new Size(110, 24);
            loạiDịchVụToolStripMenuItem.Text = "Phiếu dịch vụ";
            loạiDịchVụToolStripMenuItem.Click += loạiDịchVụToolStripMenuItem_Click;
            // 
            // nhậpHàngToolStripMenuItem
            // 
            nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            nhậpHàngToolStripMenuItem.Size = new Size(133, 24);
            nhậpHàngToolStripMenuItem.Text = "Phiếu nhập hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(10, 120);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(796, 266);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Location = new Point(10, 17);
            lsvBill.Margin = new Padding(2);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(774, 230);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(10, 425);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(796, 41);
            panel3.TabIndex = 3;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(660, 7);
            btnCheckOut.Margin = new Padding(2);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(123, 27);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(nmJewelryCount);
            panel4.Controls.Add(btnAddJewelry);
            panel4.Controls.Add(cbJewelry);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(10, 37);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(796, 78);
            panel4.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelPhieuBH);
            panel1.Location = new Point(596, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 55);
            panel1.TabIndex = 6;
            // 
            // labelPhieuBH
            // 
            labelPhieuBH.AutoSize = true;
            labelPhieuBH.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhieuBH.ForeColor = SystemColors.WindowText;
            labelPhieuBH.Location = new Point(22, 11);
            labelPhieuBH.Name = "labelPhieuBH";
            labelPhieuBH.Size = new Size(156, 28);
            labelPhieuBH.TabIndex = 5;
            labelPhieuBH.Text = "Phiếu bán hàng";
            // 
            // nmJewelryCount
            // 
            nmJewelryCount.Location = new Point(458, 12);
            nmJewelryCount.Margin = new Padding(2);
            nmJewelryCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmJewelryCount.Name = "nmJewelryCount";
            nmJewelryCount.Size = new Size(52, 27);
            nmJewelryCount.TabIndex = 3;
            // 
            // btnAddJewelry
            // 
            btnAddJewelry.Location = new Point(309, 12);
            btnAddJewelry.Margin = new Padding(2);
            btnAddJewelry.Name = "btnAddJewelry";
            btnAddJewelry.Size = new Size(123, 27);
            btnAddJewelry.TabIndex = 2;
            btnAddJewelry.Text = "Thêm";
            btnAddJewelry.UseVisualStyleBackColor = true;
            btnAddJewelry.Click += btnAddJewelry_Click;
            // 
            // cbJewelry
            // 
            cbJewelry.FormattingEnabled = true;
            cbJewelry.Location = new Point(10, 43);
            cbJewelry.Margin = new Padding(2);
            cbJewelry.Name = "cbJewelry";
            cbJewelry.Size = new Size(270, 28);
            cbJewelry.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(10, 12);
            cbCategory.Margin = new Padding(2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(270, 28);
            cbCategory.TabIndex = 0;
            // 
            // fManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 477);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
            Name = "fManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý kinh doanh vàng bạc đá quý";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label labelPhieuBH;
        private Panel panel1;
    }
}
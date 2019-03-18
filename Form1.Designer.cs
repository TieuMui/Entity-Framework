namespace EntityFrameWork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btthem = new DevComponents.DotNetBar.ButtonX();
            this.btsua = new DevComponents.DotNetBar.ButtonX();
            this.btxoa = new DevComponents.DotNetBar.ButtonX();
            this.btxem = new DevComponents.DotNetBar.ButtonX();
            this.txtsodh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btthoat = new DevComponents.DotNetBar.ButtonX();
            this.txtmavtu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bthuy = new DevComponents.DotNetBar.ButtonX();
            this.txtsld = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(621, 183);
            this.dgv.TabIndex = 0;
            //this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btthem
            // 
            this.btthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btthem.Location = new System.Drawing.Point(34, 285);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btsua.Location = new System.Drawing.Point(139, 285);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btxoa.Location = new System.Drawing.Point(251, 285);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.Click += new System.EventHandler(this.txxoa_Click);
            // 
            // btxem
            // 
            this.btxem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btxem.Location = new System.Drawing.Point(353, 285);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(75, 23);
            this.btxem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btxem.TabIndex = 4;
            this.btxem.Text = "Xem";
            this.btxem.Click += new System.EventHandler(this.btxem_Click);
            // 
            // txtsodh
            // 
            // 
            // 
            // 
            this.txtsodh.Border.Class = "TextBoxBorder";
            this.txtsodh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsodh.Location = new System.Drawing.Point(34, 216);
            this.txtsodh.Name = "txtsodh";
            this.txtsodh.PreventEnterBeep = true;
            this.txtsodh.Size = new System.Drawing.Size(100, 20);
            this.txtsodh.TabIndex = 5;
            // 
            // btthoat
            // 
            this.btthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btthoat.Location = new System.Drawing.Point(460, 284);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Thoát";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // txtmavtu
            // 
            // 
            // 
            // 
            this.txtmavtu.Border.Class = "TextBoxBorder";
            this.txtmavtu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmavtu.Location = new System.Drawing.Point(167, 216);
            this.txtmavtu.Name = "txtmavtu";
            this.txtmavtu.PreventEnterBeep = true;
            this.txtmavtu.Size = new System.Drawing.Size(100, 20);
            this.txtmavtu.TabIndex = 8;
            // 
            // bthuy
            // 
            this.bthuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bthuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bthuy.Location = new System.Drawing.Point(251, 328);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(75, 23);
            this.bthuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bthuy.TabIndex = 10;
            this.bthuy.Text = "Hủy";
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // txtsld
            // 
            // 
            // 
            // 
            this.txtsld.Border.Class = "TextBoxBorder";
            this.txtsld.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsld.Location = new System.Drawing.Point(288, 216);
            this.txtsld.Name = "txtsld";
            this.txtsld.PreventEnterBeep = true;
            this.txtsld.Size = new System.Drawing.Size(100, 20);
            this.txtsld.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 352);
            this.Controls.Add(this.txtsld);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.txtmavtu);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.txtsodh);
            this.Controls.Add(this.btxem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.ButtonX btthem;
        private DevComponents.DotNetBar.ButtonX btsua;
        private DevComponents.DotNetBar.ButtonX btxoa;
        private DevComponents.DotNetBar.ButtonX btxem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsodh;
        private DevComponents.DotNetBar.ButtonX btthoat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmavtu;
        private DevComponents.DotNetBar.ButtonX bthuy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsld;
    }
}


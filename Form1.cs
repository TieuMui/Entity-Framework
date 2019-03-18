using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace EntityFrameWork
{
    public partial class Form1 : Office2007Form
    {
        QLBanHangEntities db = new QLBanHangEntities();
        public Form1()
        {
            InitializeComponent();
            //LoadData();
            //AddBinding();
        }
        bool isThem;
        private void DieuKhien(bool t)
        {
            txtsodh.Enabled = t;
            txtmavtu.Enabled = t;
            txtsld.Enabled = t;
            btthem.Enabled = t;
            btsua.Enabled = !t;

            btxoa.Enabled = !t;
            btthoat.Enabled = !t;
            dgv.Enabled = !t;
        }
        void AddBinding()
        {
            txtsodh.DataBindings.Clear();
            // txtsodh.DataBindings.Add("Text", "SODH");
            txtsodh.DataBindings.Add(new Binding("Text", dgv.DataSource, "SODH"));
            txtmavtu.DataBindings.Add(new Binding("Text", dgv.DataSource, "MAVTU"));
            txtsld.DataBindings.Add(new Binding("Text", dgv.DataSource, "SLDAT"));
        }
        void LoadData()
        {

            //{
            //    var result = from c in CTDONH
            //                 //where c.ID > 1 && c.ID < 4
            //                 select c;

            //    dgv.DataSource = result.ToList();
            //}
            //QLBanHangEntities db = new QLBanHangEntities();
            //var result = from c in db.CTDONH select new { SoDH = c.SODH, VatTu = c.MAVTU, SLDat = c.SLDAT };
            //dgv.DataSource = result.ToList();
            var data = from dh in db.CTDONH select new { SODH = dh.SODH, MAVTU = dh.MAVTU, SLDAT = dh.SLDAT };
            dgv.DataSource = data.ToList();

            this.dgv.Columns[0].HeaderText = "Số Đơn Hàng";
            this.dgv.Columns[1].HeaderText = "Mã Vật Tư";
            this.dgv.Columns[2].HeaderText = "Số Lượng Đặt ";
        }
        void InsertCNDONH()
        {
            try
            {
                CTDONH dh = new CTDONH();

                dh.SODH = txtsodh.Text.ToString();
                dh.MAVTU = txtmavtu.Text.ToString();
                dh.SLDAT = Convert.ToInt32(txtsld.Text.ToString());

                db.CTDONH.Add(dh);
                db.SaveChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
                throw;
            }
        }
        void DeleteSCTDONDH()
        {
            int id = Convert.ToInt32(txtsodh.Text);
            CTDONH dh = db.CTDONH.Where(p => p.SODH == txtsodh.Text && p.MAVTU == txtmavtu.Text).SingleOrDefault();
            db.CTDONH.Remove(dh);
            db.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            //AddBinding();
            //DieuKhien(false);
        }

        private void btxem_Click(object sender, EventArgs e)
        {

        }


        private void btthem_Click(object sender, EventArgs e)
        {
            isThem = true;
            InsertCNDONH();
            //DieuKhien(true);
            //txtsodh.Clear();
            //txtmavtu.Clear();
            //txtsld.Clear();
        }

        private void txxoa_Click(object sender, EventArgs e)
        {
            DeleteSCTDONDH();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            isThem = false;
            DieuKhien(true);
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            isThem = true;
            DieuKhien(false);
        }


        //private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DieuKhien();
        //    string soDH = this.dgv.CurrentRow.Cells[0].Value.ToString();
        //    CTDONH dh = db.CTDONH.Single(v => v.SODH.Equals(soDH));
        //    txtsodh.Text = dh.SODH;
        //    txtmavtu.Text = dh.MAVTU;
        //    txtsld.Text = dh.SLDAT.ToString();

        //}

        private void DieuKhien()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhtarlik_otomasyon
{
    public partial class RaporDetay : Form
    {
        public RaporDetay()
        {
            InitializeComponent();
        }
        public DataSet ds;
        public string sokak;


        private void RaporDetay_Load(object sender, EventArgs e)
        {
            
            detayRapor1.SetDataSource(ds.Tables[0]);
            detayRapor1.SetParameterValue("sokakS", sokak);
            crystalReportViewer1.ReportSource = detayRapor1;
        }
    }
}

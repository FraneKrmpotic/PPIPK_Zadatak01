using PPIPK_projetct_1._1.Dal;
using PPIPK_projetct_1._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPIPK_projetct_1._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            try
            {
                CbDatabase.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
            }
            catch (Exception e)
            {
                TbQuery.Text = e.Message;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            FlpResults.Controls.Clear();
            try
            {
                DataSet ds = RepositoryFactory.GetRepository().CreateDataSet(TbQuery.Text);
                foreach (var dataTable in ds.Tables)
                {
                    DataGrid dataGrid = new DataGrid();
                    dataGrid.DataSource = dataTable;
                    dataGrid.Width = FlpResults.Width;
                    FlpResults.Controls.Add(dataGrid);
                }
            }
            catch (Exception d)
            {
                LblMessage.Text = d.Message;              
            }
        }
    }
}

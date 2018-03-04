using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.IO;

namespace BIKSPR
{
    public partial class FrmMain : Form
    {
        DataTable dt;
        internal enum MODE { NEW, VIEW, EDIT };

        string strSqlConn = "Data Source=DRAGON\\SQLEXPRESS;Initial Catalog=BIKSPR;User ID=sa;";  //Password=
        internal static SqlConnection conn;
        string sDestinationTableName = null;

        public FrmMain()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------------------------------------------
        private void FrmMain_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strSqlConn);
            pZNTableAdapter.Connection = bNKSEEKTableAdapter.Connection = conn;
            //pZNTableAdapter.Fill(bIKSPR_DS.PZN);
            //bNKSEEKTableAdapter.Fill(bIKSPR_DS.BNKSEEK);
            FillData();
        }
        //---------------------------------------------------------------------------------------------------------------
        internal void FillData()
        {
            pZNTableAdapter.Fill(bIKSPR_DS.PZN);
            bNKSEEKTableAdapter.Fill(bIKSPR_DS.BNKSEEK);
        }
        //---------------------------------------------------------------------------------------------------------------
        private void chBxPZN_CheckedChanged(object sender, EventArgs e)
        {
            cmbBxPZN.Enabled = chBxPZN.Checked;
        } 
        //---------------------------------------------------------------------------------------------------------------
        private void btnOpenFile_Click(object sender, EventArgs e) //выбор загружаемого файла 
        {
            openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath); 
            //openFileDialog.FileName = "BNKSEEK.DBF";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OdbcConnection dbfConn = new OdbcConnection("Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + 
                    Path.GetDirectoryName(openFileDialog.FileName) + ";Excusive=No; Null=No;DELETED=No;BACKGROUNDFETCH=NO;");
                dbfConn.Open(); 
                dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter($"Select * from {openFileDialog.FileName}", dbfConn);
                sDestinationTableName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                lblFileName.Text = Path.GetFileName(openFileDialog.FileName);
                da.Fill(dt);
                dGV.DataSource = dt;
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        private void btnCancelOp_Click(object sender, EventArgs e) //отмена выбора загружаемого файла 
        {
            dt.Clear();
            dGV.DataSource = null;
            lblFileName.Text = "пусто";
            sDestinationTableName = null;
            //dbfTable.Cancel();
        }
        //---------------------------------------------------------------------------------------------------------------
        private void btnLoadData_Click(object sender, EventArgs e) //подготовка к загрузке данных в таблицу 
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                if (Array.IndexOf(new string[] { "PZN", "REG", "TNP", "UER" }, sDestinationTableName.ToUpper()) > 0)
                {
                    dGV.DataSource = null;
                    if (chBxClearData.Checked) DeleteAllBNKSEEKData();
                    if (LoadBNKSEEKDataToBase(dt))
                    {
                        switch (sDestinationTableName.ToUpper())
                        {
                            case "PZN":
                                pZNTableAdapter.Fill(this.bIKSPR_DS.PZN);
                                break;
                            case "REG":
                                break;
                            case "TNP":
                                break;
                            case "UER":
                                break;
                        }
                        bNKSEEKTableAdapter.Fill(this.bIKSPR_DS.BNKSEEK);
                        MessageBox.Show("Данные загружены");
                    }
                }
                else MessageBox.Show($"Объект {sDestinationTableName.ToUpper()} не поддерживается");
            }
            else MessageBox.Show("Нет данных для загрузки");
        }
        //---------------------------------------------------------------------------------------------------------------
        private bool LoadBNKSEEKDataToBase(DataTable dt) //загрузка данных в таблицу 
        {
            bool good = false;
            if (conn.State != ConnectionState.Open) conn.Open();
            if (!string.IsNullOrEmpty(sDestinationTableName))
            {
                var bc = new SqlBulkCopy(conn) { DestinationTableName = sDestinationTableName.ToUpper() };
                try
                {
                    //по условию задачи удаляем не нужные столбцы (их нет в целевой таблице)
                    dt.Columns.Remove("VKEY");
                    if (sDestinationTableName.ToUpper().CompareTo("BNKSEEK") == 0)
                    {
                        dt.Columns.Remove("NAMEN");
                        dt.Columns.Remove("NEWKS");
                        dt.Columns.Remove("PERMFO");
                        dt.Columns.Remove("SROK");
                        dt.Columns.Remove("AT1");
                        dt.Columns.Remove("AT2");
                        dt.Columns.Remove("CKS");
                        dt.Columns.Remove("VKEYDEL");
                        dt.Columns.Remove("DT_IZMR");
                    }
                    bc.WriteToServer(dt);
                    good = true;
                }
                catch (ArgumentException ae) { MessageBox.Show($"Схема данных не соответствует таблице {sDestinationTableName.ToUpper()}\n\n{ae.Message}"); }
                catch (Exception exc) { MessageBox.Show(exc.ToString()); }
                finally { bc.Close(); }
            }
            return good;
        }
        //---------------------------------------------------------------------------------------------------------------
        private void DeleteAllBNKSEEKData() //очистка таблицы перед загрузкой новых данных
        {
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand sqlCom = new SqlCommand("Begin Transaction; Delete From " + sDestinationTableName.ToUpper() + "; Commit;", conn);  
            sqlCom.ExecuteNonQuery();
        }
        //---------------------------------------------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e) //удаление текущей записи грида
        {
            if (MessageBox.Show("Удалить текущую запись?", "Запрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bNKSEEKBindingSource.RemoveCurrent();
                bIKSPR_DS.BNKSEEK.AcceptChanges();
                bNKSEEKTableAdapter.Update(bIKSPR_DS.BNKSEEK); 
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        private void btnFind_Click(object sender, EventArgs e) //поиск по реквизитам
        { 
            string sFilter = "";
            if (!string.IsNullOrEmpty(txtBxNewNum.Text)) sFilter = $"NEWNUM LIKE \'{txtBxNewNum.Text}\'"; 
            if (!string.IsNullOrEmpty(txtBxRGN.Text))
                if (!string.IsNullOrEmpty(sFilter)) sFilter += $" AND RGN_TXT LIKE \'{txtBxRGN.Text}\'";
                else sFilter = $"RGN_TXT LIKE \'{txtBxRGN.Text}\'";
            if (cmbBxPZN.Enabled) 
                if (!string.IsNullOrEmpty(sFilter)) sFilter += $" AND PZN = \'{cmbBxPZN.SelectedValue}\'";
                else sFilter = $"PZN = \'{cmbBxPZN.SelectedValue}\'";
            if (!string.IsNullOrEmpty(sFilter)) bNKSEEKBindingSource.Filter = sFilter;
        }
        //---------------------------------------------------------------------------------------------------------------
        private void btnClearF_Click(object sender, EventArgs e) //очистка поисковых реквизитов
        {
            txtBxNewNum.Clear();
            txtBxRGN.Clear();
            chBxPZN.Checked = false;
            bNKSEEKBindingSource.RemoveFilter();
        }
        //---------------------------------------------------------------------------------------------------------------
        private void btnView_Click(object sender, EventArgs e) //просмотр текущей записи грида в карточке
        {
            FrmCard frmCard = new FrmCard();
            frmCard.Owner = this;
            frmCard.SetCurrent(((DataRowView)bNKSEEKBindingSource.Current).Row);
            frmCard.Show(MODE.VIEW);
        }
        //---------------------------------------------------------------------------------------------------------------
        private void btnNew_Click(object sender, EventArgs e) //создание новой записи в карточке
        {
            FrmCard frmCard = new FrmCard();
            frmCard.Owner = this;
            frmCard.Show(MODE.NEW);
        }
        //---------------------------------------------------------------------------------------------------------------
        private void btnEdit_Click(object sender, EventArgs e) //редактирование текущей записи грида в карточке
        {
            FrmCard frmCard = new FrmCard();
            frmCard.Owner = this;
            frmCard.SetCurrent(((DataRowView)bNKSEEKBindingSource.Current).Row);
            frmCard.Show(MODE.EDIT);
        }
        //---------------------------------------------------------------------------------------------------------------

    }
}

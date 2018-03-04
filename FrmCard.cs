using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIKSPR
{
    public partial class FrmCard : Form
    {
        DataRow curr = null;
        FrmMain.MODE MODE;
        public FrmCard()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------------------------------------------------
        private void FrmCard_Load(object sender, EventArgs e)
        {
            tNPTableAdapter.Connection = rEGTableAdapter.Connection = uERTableAdapter.Connection =
                pZNTableAdapter.Connection = bNKSEEKTableAdapter.Connection = FrmMain.conn;
            tNPTableAdapter.Fill(bIKSPR_DS.TNP);
            rEGTableAdapter.Fill(bIKSPR_DS.REG);
            uERTableAdapter.Fill(bIKSPR_DS.UER);
            pZNTableAdapter.Fill(bIKSPR_DS.PZN);
            bNKSEEKTableAdapter.Fill(bIKSPR_DS.BNKSEEK);
            // поиск требуемой записи для заполнения полей карты элемента справочника
            if (curr != null && bNKSEEKBindingSource.SupportsSearching) 
                bNKSEEKBindingSource.CurrencyManager.Position =
                    bNKSEEKBindingSource.Find("NEWNUM", curr.Field<string>("NEWNUM"));
            btnSave.Enabled = true;
            switch (MODE)
            { 
                case FrmMain.MODE.NEW:
                    this.Text += " [НОВЫЙ]";
                    bNKSEEKBindingSource.AddNew();
                    cmBxPZN.SelectedValue = -1;
                    dTPIN.Value = DateTime.Now;
                    dTPIN.Checked = false;
                    break;
                case FrmMain.MODE.VIEW:
                    this.Text += " [ПРОСМОТР]";
                    EnableInterface(false, this);
                    btnSave.Enabled = false;
                    break;
                case FrmMain.MODE.EDIT:
                    this.Text += " [РЕДАКТИРОВАНИЕ]";
                    EnableInterface(true, this);
                    break;
            }
            dTPIZM.Enabled = false;
            dTPIZM.Value = DateTime.Now;
            txtBxNEWNUM.ReadOnly = true;
        }
        //--------------------------------------------------------------------------------------------------------
        internal void SetCurrent(DataRow current) => curr = current;
        //--------------------------------------------------------------------------------------------------------
        internal void Show(FrmMain.MODE mode)
        {
            MODE = mode;
            this.Show();
        }
        //--------------------------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateField()) return;
                this.Validate();
                bNKSEEKBindingSource.EndEdit();
                bNKSEEKTableAdapter.Update(this.bIKSPR_DS);
                //this.tableAdapterManager.UpdateAll(this.bIKSPR_DS);
                MessageBox.Show("Сохранено.");
                if (MODE != FrmMain.MODE.VIEW) ((FrmMain)this.Owner).FillData();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
        //--------------------------------------------------------------------------------------------------------
        private bool ValidateField()
        {
            bool rez;
            if (rez = string.IsNullOrEmpty(txtBxNEWNUM.Text)) MessageBox.Show("Поле <NEWNUM> является обязательным и не может быть пустым.");
            else 
                if ((MODE != FrmMain.MODE.EDIT) && (rez = bNKSEEKBindingSource.Find("NEWNUM", txtBxNEWNUM.Text) >= 0))
                    MessageBox.Show("Значение поля <NEWNUM> уже есть в справочнике. Задайте иное.");

            if (rez = cmBxUER.SelectedValue == null) MessageBox.Show("Поле <UER> является обязательным и не может быть пустым.");
            if (rez = cmBxRGN.SelectedValue == null) MessageBox.Show("Поле <RGN> является обязательным и не может быть пустым.");
            if (rez = string.IsNullOrEmpty(txtBxNAMEP.Text)) MessageBox.Show("Поле <NAMEP> является обязательным и не может быть пустым.");
            if (rez = !dTPIN.Checked) MessageBox.Show("Поле <DATE_IN> является обязательным и не может быть пустым.");
            return !rez;
        }
        //--------------------------------------------------------------------------------------------------------
        private void EnableInterface(bool enbl, Control c)
        {
            foreach (Control co in c.Controls)
            {
                if (co is TextBox) ((TextBox)co).ReadOnly = !enbl;
                if (co is DateTimePicker) ((DateTimePicker)co).Enabled = enbl;
                if (co is MaskedTextBox) ((MaskedTextBox)co).ReadOnly = !enbl;
                if (co is CheckBox) ((CheckBox)co).Enabled = enbl;
                if (co is ComboBox) ((ComboBox)co).Enabled = enbl;
                if (co is LinkLabel) ((LinkLabel)co).Enabled = enbl;
                EnableInterface(enbl, co);
            }
        }
        //--------------------------------------------------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            bNKSEEKBindingSource.CancelEdit();
            Close();
        }
        //--------------------------------------------------------------------------------------------------------

    }
}



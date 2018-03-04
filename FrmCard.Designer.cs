namespace BIKSPR
{
    partial class FrmCard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxREAL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBxPZN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBxUER = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmBxRGN = new System.Windows.Forms.ComboBox();
            this.txtBxIND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmBxTNP = new System.Windows.Forms.ComboBox();
            this.txtBxTNP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxADR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxRKC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxNAMEP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxNEWNUM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bIKSPR_DS = new BIKSPR.BIKSPR_DS();
            this.bNKSEEKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bNKSEEKTableAdapter = new BIKSPR.BIKSPR_DSTableAdapters.BNKSEEKTableAdapter();
            this.tableAdapterManager = new BIKSPR.BIKSPR_DSTableAdapters.TableAdapterManager();
            this.pZNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pZNTableAdapter = new BIKSPR.BIKSPR_DSTableAdapters.PZNTableAdapter();
            this.uERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uERTableAdapter = new BIKSPR.BIKSPR_DSTableAdapters.UERTableAdapter();
            this.rEGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEGTableAdapter = new BIKSPR.BIKSPR_DSTableAdapters.REGTableAdapter();
            this.tNPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tNPTableAdapter = new BIKSPR.BIKSPR_DSTableAdapters.TNPTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBxTELEF = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBxREGN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBxOKPO = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBxKSNP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dTPIZM = new System.Windows.Forms.DateTimePicker();
            this.dTPIN = new System.Windows.Forms.DateTimePicker();
            this.dTPCH = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bIKSPR_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNKSEEKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Real";
            // 
            // txtBxREAL
            // 
            this.txtBxREAL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "REAL", true));
            this.txtBxREAL.Location = new System.Drawing.Point(85, 6);
            this.txtBxREAL.MaxLength = 4;
            this.txtBxREAL.Name = "txtBxREAL";
            this.txtBxREAL.Size = new System.Drawing.Size(69, 20);
            this.txtBxREAL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PZN";
            // 
            // cmBxPZN
            // 
            this.cmBxPZN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bNKSEEKBindingSource, "PZN", true));
            this.cmBxPZN.DataSource = this.pZNBindingSource;
            this.cmBxPZN.DisplayMember = "NAME";
            this.cmBxPZN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxPZN.FormattingEnabled = true;
            this.cmBxPZN.Location = new System.Drawing.Point(85, 31);
            this.cmBxPZN.Name = "cmBxPZN";
            this.cmBxPZN.Size = new System.Drawing.Size(278, 21);
            this.cmBxPZN.TabIndex = 4;
            this.cmBxPZN.ValueMember = "PZN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UER *";
            // 
            // cmBxUER
            // 
            this.cmBxUER.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bNKSEEKBindingSource, "UER", true));
            this.cmBxUER.DataSource = this.uERBindingSource;
            this.cmBxUER.DisplayMember = "UERNAME";
            this.cmBxUER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxUER.FormattingEnabled = true;
            this.cmBxUER.Location = new System.Drawing.Point(85, 59);
            this.cmBxUER.Name = "cmBxUER";
            this.cmBxUER.Size = new System.Drawing.Size(278, 21);
            this.cmBxUER.TabIndex = 6;
            this.cmBxUER.ValueMember = "UER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RGN *";
            // 
            // cmBxRGN
            // 
            this.cmBxRGN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bNKSEEKBindingSource, "RGN", true));
            this.cmBxRGN.DataSource = this.rEGBindingSource;
            this.cmBxRGN.DisplayMember = "NAME";
            this.cmBxRGN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxRGN.FormattingEnabled = true;
            this.cmBxRGN.Location = new System.Drawing.Point(85, 88);
            this.cmBxRGN.Name = "cmBxRGN";
            this.cmBxRGN.Size = new System.Drawing.Size(278, 21);
            this.cmBxRGN.TabIndex = 8;
            this.cmBxRGN.ValueMember = "RGN";
            // 
            // txtBxIND
            // 
            this.txtBxIND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "IND", true));
            this.txtBxIND.Location = new System.Drawing.Point(85, 117);
            this.txtBxIND.MaxLength = 6;
            this.txtBxIND.Name = "txtBxIND";
            this.txtBxIND.Size = new System.Drawing.Size(69, 20);
            this.txtBxIND.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "IND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "TNP";
            // 
            // cmBxTNP
            // 
            this.cmBxTNP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bNKSEEKBindingSource, "TNP", true));
            this.cmBxTNP.DataSource = this.tNPBindingSource;
            this.cmBxTNP.DisplayMember = "SHORTNAME";
            this.cmBxTNP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxTNP.FormattingEnabled = true;
            this.cmBxTNP.Location = new System.Drawing.Point(85, 146);
            this.cmBxTNP.Name = "cmBxTNP";
            this.cmBxTNP.Size = new System.Drawing.Size(278, 21);
            this.cmBxTNP.TabIndex = 12;
            this.cmBxTNP.ValueMember = "TNP";
            // 
            // txtBxTNP
            // 
            this.txtBxTNP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "NNP", true));
            this.txtBxTNP.Location = new System.Drawing.Point(85, 175);
            this.txtBxTNP.MaxLength = 25;
            this.txtBxTNP.Name = "txtBxTNP";
            this.txtBxTNP.Size = new System.Drawing.Size(164, 20);
            this.txtBxTNP.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "NNP";
            // 
            // txtBxADR
            // 
            this.txtBxADR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "ADR", true));
            this.txtBxADR.Location = new System.Drawing.Point(85, 203);
            this.txtBxADR.MaxLength = 30;
            this.txtBxADR.Name = "txtBxADR";
            this.txtBxADR.Size = new System.Drawing.Size(164, 20);
            this.txtBxADR.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ADR";
            // 
            // txtBxRKC
            // 
            this.txtBxRKC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "RKC", true));
            this.txtBxRKC.Location = new System.Drawing.Point(85, 231);
            this.txtBxRKC.MaxLength = 9;
            this.txtBxRKC.Name = "txtBxRKC";
            this.txtBxRKC.Size = new System.Drawing.Size(69, 20);
            this.txtBxRKC.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "RKC";
            // 
            // txtBxNAMEP
            // 
            this.txtBxNAMEP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "NAMEP", true));
            this.txtBxNAMEP.Location = new System.Drawing.Point(85, 258);
            this.txtBxNAMEP.MaxLength = 45;
            this.txtBxNAMEP.Name = "txtBxNAMEP";
            this.txtBxNAMEP.Size = new System.Drawing.Size(223, 20);
            this.txtBxNAMEP.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "NAMEP *";
            // 
            // txtBxNEWNUM
            // 
            this.txtBxNEWNUM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "NEWNUM", true));
            this.txtBxNEWNUM.Location = new System.Drawing.Point(85, 285);
            this.txtBxNEWNUM.MaxLength = 9;
            this.txtBxNEWNUM.Name = "txtBxNEWNUM";
            this.txtBxNEWNUM.Size = new System.Drawing.Size(69, 20);
            this.txtBxNEWNUM.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "NEWNUM * **";
            // 
            // bIKSPR_DS
            // 
            this.bIKSPR_DS.DataSetName = "BIKSPR_DS";
            this.bIKSPR_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bNKSEEKBindingSource
            // 
            this.bNKSEEKBindingSource.DataMember = "BNKSEEK";
            this.bNKSEEKBindingSource.DataSource = this.bIKSPR_DS;
            // 
            // bNKSEEKTableAdapter
            // 
            this.bNKSEEKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BNKSEEKTableAdapter = this.bNKSEEKTableAdapter;
            this.tableAdapterManager.PZNTableAdapter = this.pZNTableAdapter;
            this.tableAdapterManager.REGTableAdapter = this.rEGTableAdapter;
            this.tableAdapterManager.TNPTableAdapter = this.tNPTableAdapter;
            this.tableAdapterManager.UERTableAdapter = this.uERTableAdapter;
            this.tableAdapterManager.UpdateOrder = BIKSPR.BIKSPR_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pZNBindingSource
            // 
            this.pZNBindingSource.DataMember = "PZN";
            this.pZNBindingSource.DataSource = this.bIKSPR_DS;
            // 
            // pZNTableAdapter
            // 
            this.pZNTableAdapter.ClearBeforeFill = true;
            // 
            // uERBindingSource
            // 
            this.uERBindingSource.DataMember = "UER";
            this.uERBindingSource.DataSource = this.bIKSPR_DS;
            // 
            // uERTableAdapter
            // 
            this.uERTableAdapter.ClearBeforeFill = true;
            // 
            // rEGBindingSource
            // 
            this.rEGBindingSource.DataMember = "REG";
            this.rEGBindingSource.DataSource = this.bIKSPR_DS;
            // 
            // rEGTableAdapter
            // 
            this.rEGTableAdapter.ClearBeforeFill = true;
            // 
            // tNPBindingSource
            // 
            this.tNPBindingSource.DataMember = "TNP";
            this.tNPBindingSource.DataSource = this.bIKSPR_DS;
            // 
            // tNPTableAdapter
            // 
            this.tNPTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(136, 519);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBxTELEF
            // 
            this.txtBxTELEF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "TELEF", true));
            this.txtBxTELEF.Location = new System.Drawing.Point(85, 312);
            this.txtBxTELEF.MaxLength = 25;
            this.txtBxTELEF.Name = "txtBxTELEF";
            this.txtBxTELEF.Size = new System.Drawing.Size(164, 20);
            this.txtBxTELEF.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "TELEF";
            // 
            // txtBxREGN
            // 
            this.txtBxREGN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "REGN", true));
            this.txtBxREGN.Location = new System.Drawing.Point(85, 338);
            this.txtBxREGN.MaxLength = 9;
            this.txtBxREGN.Name = "txtBxREGN";
            this.txtBxREGN.Size = new System.Drawing.Size(69, 20);
            this.txtBxREGN.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "REGN";
            // 
            // txtBxOKPO
            // 
            this.txtBxOKPO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "OKPO", true));
            this.txtBxOKPO.Location = new System.Drawing.Point(85, 364);
            this.txtBxOKPO.MaxLength = 8;
            this.txtBxOKPO.Name = "txtBxOKPO";
            this.txtBxOKPO.Size = new System.Drawing.Size(69, 20);
            this.txtBxOKPO.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "OKPO";
            // 
            // txtBxKSNP
            // 
            this.txtBxKSNP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bNKSEEKBindingSource, "KSNP", true));
            this.txtBxKSNP.Location = new System.Drawing.Point(85, 418);
            this.txtBxKSNP.MaxLength = 20;
            this.txtBxKSNP.Name = "txtBxKSNP";
            this.txtBxKSNP.Size = new System.Drawing.Size(164, 20);
            this.txtBxKSNP.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "KSNP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 394);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "DT_IZM *";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 448);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "DATE_IN *";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 475);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "DATE_CH";
            // 
            // dTPIZM
            // 
            this.dTPIZM.Checked = false;
            this.dTPIZM.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bNKSEEKBindingSource, "DT_IZM", true));
            this.dTPIZM.Location = new System.Drawing.Point(85, 391);
            this.dTPIZM.Name = "dTPIZM";
            this.dTPIZM.ShowCheckBox = true;
            this.dTPIZM.Size = new System.Drawing.Size(164, 20);
            this.dTPIZM.TabIndex = 36;
            // 
            // dTPIN
            // 
            this.dTPIN.Checked = false;
            this.dTPIN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bNKSEEKBindingSource, "DATE_IN", true));
            this.dTPIN.Location = new System.Drawing.Point(85, 445);
            this.dTPIN.Name = "dTPIN";
            this.dTPIN.ShowCheckBox = true;
            this.dTPIN.Size = new System.Drawing.Size(164, 20);
            this.dTPIN.TabIndex = 37;
            // 
            // dTPCH
            // 
            this.dTPCH.Checked = false;
            this.dTPCH.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bNKSEEKBindingSource, "DATE_CH", true));
            this.dTPCH.Location = new System.Drawing.Point(85, 472);
            this.dTPCH.Name = "dTPCH";
            this.dTPCH.ShowCheckBox = true;
            this.dTPCH.Size = new System.Drawing.Size(164, 20);
            this.dTPCH.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(170, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "* - обязательные поля";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(170, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(214, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "** - наложено ограничение уникальности";
            // 
            // FrmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 555);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dTPCH);
            this.Controls.Add(this.dTPIN);
            this.Controls.Add(this.dTPIZM);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBxKSNP);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBxOKPO);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBxREGN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBxTELEF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBxNEWNUM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBxNAMEP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBxRKC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBxADR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBxTNP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmBxTNP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxIND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmBxRGN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmBxUER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmBxPZN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxREAL);
            this.Controls.Add(this.label1);
            this.Name = "FrmCard";
            this.Text = "Элемент справочника";
            this.Load += new System.EventHandler(this.FrmCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bIKSPR_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNKSEEKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pZNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxREAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmBxPZN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBxUER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmBxRGN;
        private System.Windows.Forms.TextBox txtBxIND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmBxTNP;
        private System.Windows.Forms.TextBox txtBxTNP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxADR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxRKC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxNAMEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBxNEWNUM;
        private System.Windows.Forms.Label label11;
        private BIKSPR_DS bIKSPR_DS;
        private System.Windows.Forms.BindingSource bNKSEEKBindingSource;
        private BIKSPR_DSTableAdapters.BNKSEEKTableAdapter bNKSEEKTableAdapter;
        private BIKSPR_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private BIKSPR_DSTableAdapters.PZNTableAdapter pZNTableAdapter;
        private System.Windows.Forms.BindingSource pZNBindingSource;
        private BIKSPR_DSTableAdapters.UERTableAdapter uERTableAdapter;
        private System.Windows.Forms.BindingSource uERBindingSource;
        private BIKSPR_DSTableAdapters.REGTableAdapter rEGTableAdapter;
        private System.Windows.Forms.BindingSource rEGBindingSource;
        private BIKSPR_DSTableAdapters.TNPTableAdapter tNPTableAdapter;
        private System.Windows.Forms.BindingSource tNPBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBxTELEF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBxREGN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBxOKPO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBxKSNP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dTPIZM;
        private System.Windows.Forms.DateTimePicker dTPIN;
        private System.Windows.Forms.DateTimePicker dTPCH;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}
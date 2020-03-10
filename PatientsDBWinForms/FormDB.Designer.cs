namespace PatientsDBWinForms
{
    partial class FormDB
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDB));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_delete_all = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new PatientsDBWinForms.AppData();
            this.btn_choose = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lb_patientID = new System.Windows.Forms.Label();
            this.tb_blood_type = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lb_blood_type = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_flat = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_disease = new System.Windows.Forms.TextBox();
            this.dGVPatients = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalcardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_flat = new System.Windows.Forms.Label();
            this.tb_med_card_number = new System.Windows.Forms.TextBox();
            this.lb_phone_number = new System.Windows.Forms.Label();
            this.tb_district_number = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.lb_surname = new System.Windows.Forms.Label();
            this.tb_house = new System.Windows.Forms.TextBox();
            this.lb_disease = new System.Windows.Forms.Label();
            this.lb_first_name = new System.Windows.Forms.Label();
            this.lb_med_card_number = new System.Windows.Forms.Label();
            this.tb_street = new System.Windows.Forms.TextBox();
            this.lb_district_number = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.mtb_phone_number = new System.Windows.Forms.MaskedTextBox();
            this.tb_nationality = new System.Windows.Forms.TextBox();
            this.tb_patientsID = new System.Windows.Forms.TextBox();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.lb_second_name = new System.Windows.Forms.Label();
            this.tb_second_name = new System.Windows.Forms.TextBox();
            this.lb_nationality = new System.Windows.Forms.Label();
            this.lb_house = new System.Windows.Forms.Label();
            this.lb_height = new System.Windows.Forms.Label();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.lb_street = new System.Windows.Forms.Label();
            this.lb_weight = new System.Windows.Forms.Label();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.tb_gender = new System.Windows.Forms.TextBox();
            this.lb_birthday = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(363, 214);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 29);
            this.btn_save.TabIndex = 51;
            this.btn_save.Text = "Зберегти";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(478, 214);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 29);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "Видалити";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_delete_all
            // 
            this.btn_delete_all.Location = new System.Drawing.Point(595, 214);
            this.btn_delete_all.Name = "btn_delete_all";
            this.btn_delete_all.Size = new System.Drawing.Size(88, 29);
            this.btn_delete_all.TabIndex = 53;
            this.btn_delete_all.Text = "Видалити все";
            this.btn_delete_all.UseVisualStyleBackColor = true;
            this.btn_delete_all.Click += new System.EventHandler(this.btn_delete_all_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(700, 213);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(88, 29);
            this.btn_sort.TabIndex = 54;
            this.btn_sort.Text = "Відсортувати";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "birthday", true));
            this.dateTimePicker.Location = new System.Drawing.Point(448, 45);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(17, 121);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(88, 27);
            this.btn_choose.TabIndex = 44;
            this.btn_choose.Text = "Обрати";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.patientsBindingSource, "photo", true));
            this.pictureBox.Location = new System.Drawing.Point(13, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(98, 99);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            // 
            // lb_patientID
            // 
            this.lb_patientID.AutoSize = true;
            this.lb_patientID.Location = new System.Drawing.Point(14, 150);
            this.lb_patientID.Name = "lb_patientID";
            this.lb_patientID.Size = new System.Drawing.Size(90, 13);
            this.lb_patientID.TabIndex = 0;
            this.lb_patientID.Text = "Номер пацієнта:";
            // 
            // tb_blood_type
            // 
            this.tb_blood_type.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "blood_type", true));
            this.tb_blood_type.Location = new System.Drawing.Point(674, 117);
            this.tb_blood_type.Name = "tb_blood_type";
            this.tb_blood_type.Size = new System.Drawing.Size(104, 20);
            this.tb_blood_type.TabIndex = 31;
            this.tb_blood_type.TextChanged += new System.EventHandler(this.tb_blood_type_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(242, 214);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 29);
            this.btn_cancel.TabIndex = 50;
            this.btn_cancel.Text = "Відмінити";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lb_blood_type
            // 
            this.lb_blood_type.AutoSize = true;
            this.lb_blood_type.Location = new System.Drawing.Point(559, 124);
            this.lb_blood_type.Name = "lb_blood_type";
            this.lb_blood_type.Size = new System.Drawing.Size(68, 13);
            this.lb_blood_type.TabIndex = 15;
            this.lb_blood_type.Text = "Група крові:";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(127, 213);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(88, 29);
            this.btn_edit.TabIndex = 49;
            this.btn_edit.Text = "Редагувати";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_flat
            // 
            this.tb_flat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "flat", true));
            this.tb_flat.Location = new System.Drawing.Point(674, 10);
            this.tb_flat.Name = "tb_flat";
            this.tb_flat.Size = new System.Drawing.Size(104, 20);
            this.tb_flat.TabIndex = 27;
            this.tb_flat.TextChanged += new System.EventHandler(this.tb_flat_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 213);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(88, 30);
            this.btn_add.TabIndex = 48;
            this.btn_add.Text = "Додати";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_disease
            // 
            this.tb_disease.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "disease", true));
            this.tb_disease.Location = new System.Drawing.Point(674, 90);
            this.tb_disease.Name = "tb_disease";
            this.tb_disease.Size = new System.Drawing.Size(104, 20);
            this.tb_disease.TabIndex = 30;
            this.tb_disease.TextChanged += new System.EventHandler(this.tb_disease_TextChanged);
            // 
            // dGVPatients
            // 
            this.dGVPatients.AllowUserToAddRows = false;
            this.dGVPatients.AutoGenerateColumns = false;
            this.dGVPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.secondnameDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.flatDataGridViewTextBoxColumn,
            this.districtnumberDataGridViewTextBoxColumn,
            this.medicalcardDataGridViewTextBoxColumn,
            this.diseaseDataGridViewTextBoxColumn,
            this.bloodtypeDataGridViewTextBoxColumn});
            this.dGVPatients.DataSource = this.patientsBindingSource;
            this.dGVPatients.Location = new System.Drawing.Point(4, 262);
            this.dGVPatients.Name = "dGVPatients";
            this.dGVPatients.Size = new System.Drawing.Size(790, 285);
            this.dGVPatients.TabIndex = 58;
            this.dGVPatients.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dGVPatients_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "номер";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "прізвище";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "імя";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // secondnameDataGridViewTextBoxColumn
            // 
            this.secondnameDataGridViewTextBoxColumn.DataPropertyName = "second_name";
            this.secondnameDataGridViewTextBoxColumn.HeaderText = "по батькові";
            this.secondnameDataGridViewTextBoxColumn.Name = "secondnameDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "національність";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "стать";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "зріст";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "вага";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "дата народження";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "телефон";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "вулиця";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "house";
            this.houseDataGridViewTextBoxColumn.HeaderText = "будинок";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            // 
            // flatDataGridViewTextBoxColumn
            // 
            this.flatDataGridViewTextBoxColumn.DataPropertyName = "flat";
            this.flatDataGridViewTextBoxColumn.HeaderText = "квартира";
            this.flatDataGridViewTextBoxColumn.Name = "flatDataGridViewTextBoxColumn";
            // 
            // districtnumberDataGridViewTextBoxColumn
            // 
            this.districtnumberDataGridViewTextBoxColumn.DataPropertyName = "district_number";
            this.districtnumberDataGridViewTextBoxColumn.HeaderText = "номер дільниці";
            this.districtnumberDataGridViewTextBoxColumn.Name = "districtnumberDataGridViewTextBoxColumn";
            // 
            // medicalcardDataGridViewTextBoxColumn
            // 
            this.medicalcardDataGridViewTextBoxColumn.DataPropertyName = "medical_card";
            this.medicalcardDataGridViewTextBoxColumn.HeaderText = "мед карта";
            this.medicalcardDataGridViewTextBoxColumn.Name = "medicalcardDataGridViewTextBoxColumn";
            // 
            // diseaseDataGridViewTextBoxColumn
            // 
            this.diseaseDataGridViewTextBoxColumn.DataPropertyName = "disease";
            this.diseaseDataGridViewTextBoxColumn.HeaderText = "діагноз";
            this.diseaseDataGridViewTextBoxColumn.Name = "diseaseDataGridViewTextBoxColumn";
            // 
            // bloodtypeDataGridViewTextBoxColumn
            // 
            this.bloodtypeDataGridViewTextBoxColumn.DataPropertyName = "blood_type";
            this.bloodtypeDataGridViewTextBoxColumn.HeaderText = "група крові";
            this.bloodtypeDataGridViewTextBoxColumn.Name = "bloodtypeDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            // 
            // lb_flat
            // 
            this.lb_flat.AutoSize = true;
            this.lb_flat.Location = new System.Drawing.Point(559, 17);
            this.lb_flat.Name = "lb_flat";
            this.lb_flat.Size = new System.Drawing.Size(58, 13);
            this.lb_flat.TabIndex = 11;
            this.lb_flat.Text = "Квартира:";
            // 
            // tb_med_card_number
            // 
            this.tb_med_card_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "medical_card", true));
            this.tb_med_card_number.Location = new System.Drawing.Point(674, 64);
            this.tb_med_card_number.Name = "tb_med_card_number";
            this.tb_med_card_number.Size = new System.Drawing.Size(104, 20);
            this.tb_med_card_number.TabIndex = 29;
            this.tb_med_card_number.TextChanged += new System.EventHandler(this.tb_med_card_number_TextChanged);
            // 
            // lb_phone_number
            // 
            this.lb_phone_number.AutoSize = true;
            this.lb_phone_number.Location = new System.Drawing.Point(337, 79);
            this.lb_phone_number.Name = "lb_phone_number";
            this.lb_phone_number.Size = new System.Drawing.Size(95, 13);
            this.lb_phone_number.TabIndex = 32;
            this.lb_phone_number.Text = "Номер телефону:";
            // 
            // tb_district_number
            // 
            this.tb_district_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "district_number", true));
            this.tb_district_number.Location = new System.Drawing.Point(674, 38);
            this.tb_district_number.Name = "tb_district_number";
            this.tb_district_number.Size = new System.Drawing.Size(104, 20);
            this.tb_district_number.TabIndex = 28;
            this.tb_district_number.TextChanged += new System.EventHandler(this.tb_district_number_TextChanged);
            // 
            // tb_surname
            // 
            this.tb_surname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "surname", true));
            this.tb_surname.Location = new System.Drawing.Point(223, 14);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(104, 20);
            this.tb_surname.TabIndex = 0;
            this.tb_surname.TextChanged += new System.EventHandler(this.tb_surname_TextChanged);
            // 
            // lb_surname
            // 
            this.lb_surname.AutoSize = true;
            this.lb_surname.Location = new System.Drawing.Point(123, 21);
            this.lb_surname.Name = "lb_surname";
            this.lb_surname.Size = new System.Drawing.Size(59, 13);
            this.lb_surname.TabIndex = 1;
            this.lb_surname.Text = "Прізвище:";
            // 
            // tb_house
            // 
            this.tb_house.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "house", true));
            this.tb_house.Location = new System.Drawing.Point(448, 125);
            this.tb_house.Name = "tb_house";
            this.tb_house.Size = new System.Drawing.Size(104, 20);
            this.tb_house.TabIndex = 26;
            this.tb_house.TextChanged += new System.EventHandler(this.tb_house_TextChanged);
            // 
            // lb_disease
            // 
            this.lb_disease.AutoSize = true;
            this.lb_disease.Location = new System.Drawing.Point(559, 94);
            this.lb_disease.Name = "lb_disease";
            this.lb_disease.Size = new System.Drawing.Size(50, 13);
            this.lb_disease.TabIndex = 14;
            this.lb_disease.Text = "Діагноз:";
            // 
            // lb_first_name
            // 
            this.lb_first_name.AutoSize = true;
            this.lb_first_name.Location = new System.Drawing.Point(123, 47);
            this.lb_first_name.Name = "lb_first_name";
            this.lb_first_name.Size = new System.Drawing.Size(29, 13);
            this.lb_first_name.TabIndex = 2;
            this.lb_first_name.Text = "Ім\'я:";
            // 
            // lb_med_card_number
            // 
            this.lb_med_card_number.AutoSize = true;
            this.lb_med_card_number.Location = new System.Drawing.Point(559, 67);
            this.lb_med_card_number.Name = "lb_med_card_number";
            this.lb_med_card_number.Size = new System.Drawing.Size(99, 13);
            this.lb_med_card_number.TabIndex = 13;
            this.lb_med_card_number.Text = "Номер мед карти:";
            // 
            // tb_street
            // 
            this.tb_street.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "street", true));
            this.tb_street.Location = new System.Drawing.Point(448, 98);
            this.tb_street.Name = "tb_street";
            this.tb_street.Size = new System.Drawing.Size(104, 20);
            this.tb_street.TabIndex = 32;
            this.tb_street.TextChanged += new System.EventHandler(this.tb_street_TextChanged);
            // 
            // lb_district_number
            // 
            this.lb_district_number.AutoSize = true;
            this.lb_district_number.Location = new System.Drawing.Point(559, 41);
            this.lb_district_number.Name = "lb_district_number";
            this.lb_district_number.Size = new System.Drawing.Size(87, 13);
            this.lb_district_number.TabIndex = 12;
            this.lb_district_number.Text = "Номер дільниці:";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.mtb_phone_number);
            this.panel.Controls.Add(this.tb_nationality);
            this.panel.Controls.Add(this.tb_patientsID);
            this.panel.Controls.Add(this.dateTimePicker);
            this.panel.Controls.Add(this.btn_choose);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.lb_patientID);
            this.panel.Controls.Add(this.tb_blood_type);
            this.panel.Controls.Add(this.lb_blood_type);
            this.panel.Controls.Add(this.tb_flat);
            this.panel.Controls.Add(this.tb_disease);
            this.panel.Controls.Add(this.lb_flat);
            this.panel.Controls.Add(this.tb_med_card_number);
            this.panel.Controls.Add(this.lb_phone_number);
            this.panel.Controls.Add(this.tb_district_number);
            this.panel.Controls.Add(this.tb_surname);
            this.panel.Controls.Add(this.lb_surname);
            this.panel.Controls.Add(this.tb_house);
            this.panel.Controls.Add(this.lb_disease);
            this.panel.Controls.Add(this.lb_first_name);
            this.panel.Controls.Add(this.lb_med_card_number);
            this.panel.Controls.Add(this.tb_street);
            this.panel.Controls.Add(this.lb_district_number);
            this.panel.Controls.Add(this.tb_first_name);
            this.panel.Controls.Add(this.lb_second_name);
            this.panel.Controls.Add(this.tb_second_name);
            this.panel.Controls.Add(this.lb_nationality);
            this.panel.Controls.Add(this.lb_house);
            this.panel.Controls.Add(this.lb_height);
            this.panel.Controls.Add(this.tb_weight);
            this.panel.Controls.Add(this.lb_street);
            this.panel.Controls.Add(this.lb_weight);
            this.panel.Controls.Add(this.tb_height);
            this.panel.Controls.Add(this.tb_gender);
            this.panel.Controls.Add(this.lb_birthday);
            this.panel.Controls.Add(this.lb_gender);
            this.panel.Location = new System.Drawing.Point(3, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(794, 194);
            this.panel.TabIndex = 0;
            // 
            // mtb_phone_number
            // 
            this.mtb_phone_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "phone_number", true));
            this.mtb_phone_number.Location = new System.Drawing.Point(448, 72);
            this.mtb_phone_number.Mask = "+38\\0 000000000";
            this.mtb_phone_number.Name = "mtb_phone_number";
            this.mtb_phone_number.Size = new System.Drawing.Size(104, 20);
            this.mtb_phone_number.TabIndex = 48;
            // 
            // tb_nationality
            // 
            this.tb_nationality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "nationality", true));
            this.tb_nationality.Location = new System.Drawing.Point(223, 94);
            this.tb_nationality.Name = "tb_nationality";
            this.tb_nationality.Size = new System.Drawing.Size(104, 20);
            this.tb_nationality.TabIndex = 47;
            this.tb_nationality.TextChanged += new System.EventHandler(this.tb_gender_TextChanged);
            // 
            // tb_patientsID
            // 
            this.tb_patientsID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "ID", true));
            this.tb_patientsID.Location = new System.Drawing.Point(17, 166);
            this.tb_patientsID.Name = "tb_patientsID";
            this.tb_patientsID.Size = new System.Drawing.Size(88, 20);
            this.tb_patientsID.TabIndex = 46;
            // 
            // tb_first_name
            // 
            this.tb_first_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "first_name", true));
            this.tb_first_name.Location = new System.Drawing.Point(223, 40);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(104, 20);
            this.tb_first_name.TabIndex = 1;
            this.tb_first_name.TextChanged += new System.EventHandler(this.tb_first_name_TextChanged);
            // 
            // lb_second_name
            // 
            this.lb_second_name.AutoSize = true;
            this.lb_second_name.Location = new System.Drawing.Point(123, 74);
            this.lb_second_name.Name = "lb_second_name";
            this.lb_second_name.Size = new System.Drawing.Size(70, 13);
            this.lb_second_name.TabIndex = 3;
            this.lb_second_name.Text = "По батькові:";
            // 
            // tb_second_name
            // 
            this.tb_second_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "second_name", true));
            this.tb_second_name.Location = new System.Drawing.Point(223, 67);
            this.tb_second_name.Name = "tb_second_name";
            this.tb_second_name.Size = new System.Drawing.Size(104, 20);
            this.tb_second_name.TabIndex = 2;
            this.tb_second_name.TextChanged += new System.EventHandler(this.tb_second_name_TextChanged);
            // 
            // lb_nationality
            // 
            this.lb_nationality.AutoSize = true;
            this.lb_nationality.Location = new System.Drawing.Point(123, 100);
            this.lb_nationality.Name = "lb_nationality";
            this.lb_nationality.Size = new System.Drawing.Size(87, 13);
            this.lb_nationality.TabIndex = 5;
            this.lb_nationality.Text = "Національність:";
            // 
            // lb_house
            // 
            this.lb_house.AutoSize = true;
            this.lb_house.Location = new System.Drawing.Point(337, 132);
            this.lb_house.Name = "lb_house";
            this.lb_house.Size = new System.Drawing.Size(52, 13);
            this.lb_house.TabIndex = 10;
            this.lb_house.Text = "Будинок:";
            // 
            // lb_height
            // 
            this.lb_height.AutoSize = true;
            this.lb_height.Location = new System.Drawing.Point(121, 150);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(36, 13);
            this.lb_height.TabIndex = 6;
            this.lb_height.Text = "Зріст:";
            // 
            // tb_weight
            // 
            this.tb_weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "weight", true));
            this.tb_weight.Location = new System.Drawing.Point(448, 18);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(104, 20);
            this.tb_weight.TabIndex = 5;
            this.tb_weight.TextChanged += new System.EventHandler(this.tb_weight_TextChanged);
            // 
            // lb_street
            // 
            this.lb_street.AutoSize = true;
            this.lb_street.Location = new System.Drawing.Point(337, 105);
            this.lb_street.Name = "lb_street";
            this.lb_street.Size = new System.Drawing.Size(46, 13);
            this.lb_street.TabIndex = 9;
            this.lb_street.Text = "Вулиця:";
            // 
            // lb_weight
            // 
            this.lb_weight.AutoSize = true;
            this.lb_weight.Location = new System.Drawing.Point(337, 21);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(34, 13);
            this.lb_weight.TabIndex = 7;
            this.lb_weight.Text = "Вага:";
            // 
            // tb_height
            // 
            this.tb_height.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "height", true));
            this.tb_height.Location = new System.Drawing.Point(223, 147);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(104, 20);
            this.tb_height.TabIndex = 4;
            this.tb_height.TextChanged += new System.EventHandler(this.tb_height_TextChanged);
            // 
            // tb_gender
            // 
            this.tb_gender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "gender", true));
            this.tb_gender.Location = new System.Drawing.Point(223, 121);
            this.tb_gender.Name = "tb_gender";
            this.tb_gender.Size = new System.Drawing.Size(104, 20);
            this.tb_gender.TabIndex = 3;
            this.tb_gender.TextChanged += new System.EventHandler(this.tb_nationality_TextChanged);
            // 
            // lb_birthday
            // 
            this.lb_birthday.AutoSize = true;
            this.lb_birthday.Location = new System.Drawing.Point(337, 48);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(101, 13);
            this.lb_birthday.TabIndex = 8;
            this.lb_birthday.Text = "Дата народження:";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Location = new System.Drawing.Point(123, 124);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(39, 13);
            this.lb_gender.TabIndex = 4;
            this.lb_gender.Text = "Стать:";
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.dGVPatients);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_delete_all);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 592);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 592);
            this.Name = "FormDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пацієнти";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_delete_all;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lb_patientID;
        private System.Windows.Forms.TextBox tb_blood_type;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lb_blood_type;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tb_flat;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_disease;
        private System.Windows.Forms.DataGridView dGVPatients;
        private System.Windows.Forms.Label lb_flat;
        private System.Windows.Forms.TextBox tb_med_card_number;
        private System.Windows.Forms.Label lb_phone_number;
        private System.Windows.Forms.TextBox tb_district_number;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label lb_surname;
        private System.Windows.Forms.TextBox tb_house;
        private System.Windows.Forms.Label lb_disease;
        private System.Windows.Forms.Label lb_first_name;
        private System.Windows.Forms.Label lb_med_card_number;
        private System.Windows.Forms.TextBox tb_street;
        private System.Windows.Forms.Label lb_district_number;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.Label lb_second_name;
        private System.Windows.Forms.TextBox tb_second_name;
        private System.Windows.Forms.Label lb_nationality;
        private System.Windows.Forms.Label lb_house;
        private System.Windows.Forms.Label lb_height;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.Label lb_street;
        private System.Windows.Forms.Label lb_weight;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.TextBox tb_gender;
        private System.Windows.Forms.Label lb_birthday;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private AppData appData;
        private System.Windows.Forms.TextBox tb_patientsID;
        private System.Windows.Forms.TextBox tb_nationality;
        private System.Windows.Forms.MaskedTextBox mtb_phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalcardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodtypeDataGridViewTextBoxColumn;
    }
}


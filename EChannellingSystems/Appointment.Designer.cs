namespace Neeroga_System
{
    partial class Appointment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.neeroga_SystemDataSet1 = new Neeroga_System.Neeroga_SystemDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.patient_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.doc_name = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBtime6_3 = new System.Windows.Forms.RadioButton();
            this.CBtime1_3 = new System.Windows.Forms.RadioButton();
            this.CBtime5_3 = new System.Windows.Forms.RadioButton();
            this.CBtime2_3 = new System.Windows.Forms.RadioButton();
            this.CBtime4_3 = new System.Windows.Forms.RadioButton();
            this.CBtime3_3 = new System.Windows.Forms.RadioButton();
            this.appointmentTableAdapter1 = new Neeroga_System.Neeroga_SystemDataSet1TableAdapters.AppointmentTableAdapter();
            this.appointmentTableAdapter = new Neeroga_System.Neeroga_SystemDataSetTableAdapters.AppointmentTableAdapter();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neeroga_SystemDataSet = new Neeroga_System.Neeroga_SystemDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.patient_id = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Pt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neeroga_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neeroga_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 245);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataMember = "Appointment";
            this.appointmentBindingSource1.DataSource = this.neeroga_SystemDataSet1;
            // 
            // neeroga_SystemDataSet1
            // 
            this.neeroga_SystemDataSet1.DataSetName = "Neeroga_SystemDataSet1";
            this.neeroga_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Seach";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(-4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 40);
            this.label1.TabIndex = 36;
            this.label1.Text = "Appointment Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Specialist :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Doctor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Patient ID :";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Indigo;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(514, 119);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(171, 39);
            this.btnupdate.TabIndex = 48;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.Indigo;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btninsert.ForeColor = System.Drawing.Color.White;
            this.btninsert.Location = new System.Drawing.Point(514, 188);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(171, 103);
            this.btninsert.TabIndex = 47;
            this.btninsert.Text = "Save";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Paitent Name";
            // 
            // patient_name
            // 
            this.patient_name.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.patient_name.Location = new System.Drawing.Point(282, 117);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(193, 32);
            this.patient_name.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(280, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Date  :";
            // 
            // doc_name
            // 
            this.doc_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.doc_name.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.doc_name.FormattingEnabled = true;
            this.doc_name.Location = new System.Drawing.Point(32, 189);
            this.doc_name.Name = "doc_name";
            this.doc_name.Size = new System.Drawing.Size(193, 31);
            this.doc_name.TabIndex = 60;
            this.doc_name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // category
            // 
            this.category.Enabled = false;
            this.category.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.category.Location = new System.Drawing.Point(32, 259);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(443, 32);
            this.category.TabIndex = 61;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CBtime6_3);
            this.groupBox1.Controls.Add(this.CBtime1_3);
            this.groupBox1.Controls.Add(this.CBtime5_3);
            this.groupBox1.Controls.Add(this.CBtime2_3);
            this.groupBox1.Controls.Add(this.CBtime4_3);
            this.groupBox1.Controls.Add(this.CBtime3_3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(32, 302);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(653, 63);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Management";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CBtime6_3
            // 
            this.CBtime6_3.AutoSize = true;
            this.CBtime6_3.Location = new System.Drawing.Point(452, 28);
            this.CBtime6_3.Name = "CBtime6_3";
            this.CBtime6_3.Size = new System.Drawing.Size(70, 17);
            this.CBtime6_3.TabIndex = 88;
            this.CBtime6_3.TabStop = true;
            this.CBtime6_3.Text = "6:00-6:30";
            this.CBtime6_3.UseVisualStyleBackColor = true;
            // 
            // CBtime1_3
            // 
            this.CBtime1_3.AutoSize = true;
            this.CBtime1_3.Location = new System.Drawing.Point(12, 28);
            this.CBtime1_3.Name = "CBtime1_3";
            this.CBtime1_3.Size = new System.Drawing.Size(70, 17);
            this.CBtime1_3.TabIndex = 83;
            this.CBtime1_3.TabStop = true;
            this.CBtime1_3.Text = "1:00-1:30";
            this.CBtime1_3.UseVisualStyleBackColor = true;
            // 
            // CBtime5_3
            // 
            this.CBtime5_3.AutoSize = true;
            this.CBtime5_3.Location = new System.Drawing.Point(363, 28);
            this.CBtime5_3.Name = "CBtime5_3";
            this.CBtime5_3.Size = new System.Drawing.Size(70, 17);
            this.CBtime5_3.TabIndex = 87;
            this.CBtime5_3.TabStop = true;
            this.CBtime5_3.Text = "5:00-5:30";
            this.CBtime5_3.UseVisualStyleBackColor = true;
            // 
            // CBtime2_3
            // 
            this.CBtime2_3.AutoSize = true;
            this.CBtime2_3.Location = new System.Drawing.Point(101, 28);
            this.CBtime2_3.Name = "CBtime2_3";
            this.CBtime2_3.Size = new System.Drawing.Size(70, 17);
            this.CBtime2_3.TabIndex = 84;
            this.CBtime2_3.TabStop = true;
            this.CBtime2_3.Text = "2:00-2:30";
            this.CBtime2_3.UseVisualStyleBackColor = true;
            // 
            // CBtime4_3
            // 
            this.CBtime4_3.AutoSize = true;
            this.CBtime4_3.Location = new System.Drawing.Point(276, 28);
            this.CBtime4_3.Name = "CBtime4_3";
            this.CBtime4_3.Size = new System.Drawing.Size(70, 17);
            this.CBtime4_3.TabIndex = 86;
            this.CBtime4_3.TabStop = true;
            this.CBtime4_3.Text = "4:00-4:30";
            this.CBtime4_3.UseVisualStyleBackColor = true;
            // 
            // CBtime3_3
            // 
            this.CBtime3_3.AutoSize = true;
            this.CBtime3_3.Location = new System.Drawing.Point(188, 28);
            this.CBtime3_3.Name = "CBtime3_3";
            this.CBtime3_3.Size = new System.Drawing.Size(70, 17);
            this.CBtime3_3.TabIndex = 85;
            this.CBtime3_3.TabStop = true;
            this.CBtime3_3.Text = "3:00-3:30";
            this.CBtime3_3.UseVisualStyleBackColor = true;
            // 
            // appointmentTableAdapter1
            // 
            this.appointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.neeroga_SystemDataSet;
            // 
            // neeroga_SystemDataSet
            // 
            this.neeroga_SystemDataSet.DataSetName = "Neeroga_SystemDataSet";
            this.neeroga_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(453, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Seach";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(514, 384);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(171, 31);
            this.textBox6.TabIndex = 79;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyUp);
            // 
            // patient_id
            // 
            this.patient_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.patient_id.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.patient_id.FormattingEnabled = true;
            this.patient_id.Location = new System.Drawing.Point(32, 119);
            this.patient_id.Name = "patient_id";
            this.patient_id.Size = new System.Drawing.Size(193, 31);
            this.patient_id.TabIndex = 62;
            this.patient_id.SelectedIndexChanged += new System.EventHandler(this.patient_id_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 32);
            this.dateTimePicker1.TabIndex = 81;
            // 
            // Pt_id
            // 
            this.Pt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pt_id.Location = new System.Drawing.Point(32, 378);
            this.Pt_id.Name = "Pt_id";
            this.Pt_id.Size = new System.Drawing.Size(132, 31);
            this.Pt_id.TabIndex = 82;
            this.Pt_id.Visible = false;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Neeroga_System.Properties.Resources.login_page_background_images_hd_9;
            this.ClientSize = new System.Drawing.Size(708, 691);
            this.Controls.Add(this.Pt_id);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.patient_id);
            this.Controls.Add(this.category);
            this.Controls.Add(this.doc_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patient_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neeroga_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neeroga_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patient_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox doc_name;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Neeroga_SystemDataSet1 neeroga_SystemDataSet1;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
        private Neeroga_SystemDataSet1TableAdapters.AppointmentTableAdapter appointmentTableAdapter1;
        private Neeroga_SystemDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private Neeroga_SystemDataSet neeroga_SystemDataSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox patient_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Pt_id;
        private System.Windows.Forms.RadioButton CBtime1_3;
        private System.Windows.Forms.RadioButton CBtime6_3;
        private System.Windows.Forms.RadioButton CBtime5_3;
        private System.Windows.Forms.RadioButton CBtime4_3;
        private System.Windows.Forms.RadioButton CBtime3_3;
        private System.Windows.Forms.RadioButton CBtime2_3;
    }
}
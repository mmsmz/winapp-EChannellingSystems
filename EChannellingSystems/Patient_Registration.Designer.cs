namespace Neeroga_System
{
    partial class Patient_Registration
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact_No = new System.Windows.Forms.TextBox();
            this.txtemailAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.patient_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(16, 314);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 32);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtAge.Location = new System.Drawing.Point(16, 436);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(171, 32);
            this.txtAge.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtAddress.Location = new System.Drawing.Point(255, 314);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 32);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtContact_No
            // 
            this.txtContact_No.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtContact_No.Location = new System.Drawing.Point(255, 375);
            this.txtContact_No.Name = "txtContact_No";
            this.txtContact_No.Size = new System.Drawing.Size(171, 32);
            this.txtContact_No.TabIndex = 5;
            // 
            // txtemailAddress
            // 
            this.txtemailAddress.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtemailAddress.Location = new System.Drawing.Point(255, 436);
            this.txtemailAddress.Name = "txtemailAddress";
            this.txtemailAddress.Size = new System.Drawing.Size(171, 32);
            this.txtemailAddress.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Contact_No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(254, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email_Address";
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.BackColor = System.Drawing.Color.Transparent;
            this.rad_male.ForeColor = System.Drawing.Color.White;
            this.rad_male.Location = new System.Drawing.Point(16, 385);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(48, 17);
            this.rad_male.TabIndex = 24;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "Male";
            this.rad_male.UseVisualStyleBackColor = false;
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.BackColor = System.Drawing.Color.Transparent;
            this.rad_female.ForeColor = System.Drawing.Color.White;
            this.rad_female.Location = new System.Drawing.Point(90, 385);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(59, 17);
            this.rad_female.TabIndex = 25;
            this.rad_female.TabStop = true;
            this.rad_female.Text = "Female";
            this.rad_female.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(635, 200);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Indigo;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(499, 307);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(152, 39);
            this.btnupdate.TabIndex = 28;
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
            this.btninsert.Location = new System.Drawing.Point(499, 388);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(152, 80);
            this.btninsert.TabIndex = 27;
            this.btninsert.Text = "Save";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(-8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 40);
            this.label1.TabIndex = 29;
            this.label1.Text = "Patient Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(480, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 31);
            this.textBox1.TabIndex = 30;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(422, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Seach";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(347, 23);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(47, 13);
            this.labeldate.TabIndex = 32;
            this.labeldate.Text = "datetime";
            this.labeldate.Visible = false;
            this.labeldate.Click += new System.EventHandler(this.labeldate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // patient_id
            // 
            this.patient_id.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.patient_id.Location = new System.Drawing.Point(480, 269);
            this.patient_id.Name = "patient_id";
            this.patient_id.Size = new System.Drawing.Size(171, 32);
            this.patient_id.TabIndex = 33;
            this.patient_id.Visible = false;
            this.patient_id.TextChanged += new System.EventHandler(this.patient_id_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(443, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 39);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ref";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Patient_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Neeroga_System.Properties.Resources.login_page_background_images_hd_9;
            this.ClientSize = new System.Drawing.Size(676, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patient_id);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rad_female);
            this.Controls.Add(this.rad_male);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemailAddress);
            this.Controls.Add(this.txtContact_No);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "Patient_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Registration";
            this.Load += new System.EventHandler(this.Patient_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact_No;
        private System.Windows.Forms.TextBox txtemailAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox patient_id;
        private System.Windows.Forms.Button button1;
    }
}
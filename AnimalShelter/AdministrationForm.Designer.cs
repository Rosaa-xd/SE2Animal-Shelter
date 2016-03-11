namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.gb_Animal = new System.Windows.Forms.GroupBox();
            this.lbl_AnimalLastWalkDate = new System.Windows.Forms.Label();
            this.lbl_AnimalBadHabit = new System.Windows.Forms.Label();
            this.dtp_LastWalkDate = new System.Windows.Forms.DateTimePicker();
            this.tb_BadHabit = new System.Windows.Forms.TextBox();
            this.lbl_AnimalReserveAt = new System.Windows.Forms.Label();
            this.lbl_AnimalReservedBy = new System.Windows.Forms.Label();
            this.lbl_AnimalReserved = new System.Windows.Forms.Label();
            this.lbl_AnimalGender = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_AnimalName = new System.Windows.Forms.Label();
            this.cb_AnimalGender = new System.Windows.Forms.ComboBox();
            this.tb_AnimalAge = new System.Windows.Forms.TextBox();
            this.tb_AnimalName = new System.Windows.Forms.TextBox();
            this.cb_AnimalType = new System.Windows.Forms.ComboBox();
            this.lbl_AnimalType = new System.Windows.Forms.Label();
            this.lb_Animals = new System.Windows.Forms.ListBox();
            this.btn_AddAnimal = new System.Windows.Forms.Button();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.btn_ShowInfo = new System.Windows.Forms.Button();
            this.gb_Animal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Animal
            // 
            this.gb_Animal.Controls.Add(this.lbl_AnimalLastWalkDate);
            this.gb_Animal.Controls.Add(this.lbl_AnimalBadHabit);
            this.gb_Animal.Controls.Add(this.dtp_LastWalkDate);
            this.gb_Animal.Controls.Add(this.tb_BadHabit);
            this.gb_Animal.Controls.Add(this.lbl_AnimalReserveAt);
            this.gb_Animal.Controls.Add(this.lbl_AnimalReservedBy);
            this.gb_Animal.Controls.Add(this.lbl_AnimalReserved);
            this.gb_Animal.Controls.Add(this.lbl_AnimalGender);
            this.gb_Animal.Controls.Add(this.lbl_Age);
            this.gb_Animal.Controls.Add(this.lbl_AnimalName);
            this.gb_Animal.Controls.Add(this.cb_AnimalGender);
            this.gb_Animal.Controls.Add(this.tb_AnimalAge);
            this.gb_Animal.Controls.Add(this.tb_AnimalName);
            this.gb_Animal.Controls.Add(this.cb_AnimalType);
            this.gb_Animal.Controls.Add(this.lbl_AnimalType);
            this.gb_Animal.Location = new System.Drawing.Point(13, 13);
            this.gb_Animal.Name = "gb_Animal";
            this.gb_Animal.Size = new System.Drawing.Size(215, 232);
            this.gb_Animal.TabIndex = 0;
            this.gb_Animal.TabStop = false;
            this.gb_Animal.Text = "Animal";
            // 
            // lbl_AnimalLastWalkDate
            // 
            this.lbl_AnimalLastWalkDate.AutoSize = true;
            this.lbl_AnimalLastWalkDate.Location = new System.Drawing.Point(9, 163);
            this.lbl_AnimalLastWalkDate.Name = "lbl_AnimalLastWalkDate";
            this.lbl_AnimalLastWalkDate.Size = new System.Drawing.Size(58, 13);
            this.lbl_AnimalLastWalkDate.TabIndex = 15;
            this.lbl_AnimalLastWalkDate.Text = "Last Walk:";
            // 
            // lbl_AnimalBadHabit
            // 
            this.lbl_AnimalBadHabit.AutoSize = true;
            this.lbl_AnimalBadHabit.Location = new System.Drawing.Point(9, 133);
            this.lbl_AnimalBadHabit.Name = "lbl_AnimalBadHabit";
            this.lbl_AnimalBadHabit.Size = new System.Drawing.Size(57, 13);
            this.lbl_AnimalBadHabit.TabIndex = 14;
            this.lbl_AnimalBadHabit.Text = "Bad Habit:";
            // 
            // dtp_LastWalkDate
            // 
            this.dtp_LastWalkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_LastWalkDate.Location = new System.Drawing.Point(88, 157);
            this.dtp_LastWalkDate.Name = "dtp_LastWalkDate";
            this.dtp_LastWalkDate.Size = new System.Drawing.Size(121, 20);
            this.dtp_LastWalkDate.TabIndex = 13;
            this.dtp_LastWalkDate.Value = new System.DateTime(2016, 3, 11, 0, 0, 0, 0);
            // 
            // tb_BadHabit
            // 
            this.tb_BadHabit.Location = new System.Drawing.Point(88, 130);
            this.tb_BadHabit.Name = "tb_BadHabit";
            this.tb_BadHabit.Size = new System.Drawing.Size(121, 20);
            this.tb_BadHabit.TabIndex = 12;
            // 
            // lbl_AnimalReserveAt
            // 
            this.lbl_AnimalReserveAt.AutoSize = true;
            this.lbl_AnimalReserveAt.Location = new System.Drawing.Point(88, 211);
            this.lbl_AnimalReserveAt.Name = "lbl_AnimalReserveAt";
            this.lbl_AnimalReserveAt.Size = new System.Drawing.Size(12, 13);
            this.lbl_AnimalReserveAt.TabIndex = 11;
            this.lbl_AnimalReserveAt.Text = "x";
            // 
            // lbl_AnimalReservedBy
            // 
            this.lbl_AnimalReservedBy.AutoSize = true;
            this.lbl_AnimalReservedBy.Location = new System.Drawing.Point(88, 189);
            this.lbl_AnimalReservedBy.Name = "lbl_AnimalReservedBy";
            this.lbl_AnimalReservedBy.Size = new System.Drawing.Size(12, 13);
            this.lbl_AnimalReservedBy.TabIndex = 10;
            this.lbl_AnimalReservedBy.Text = "x";
            // 
            // lbl_AnimalReserved
            // 
            this.lbl_AnimalReserved.AutoSize = true;
            this.lbl_AnimalReserved.Location = new System.Drawing.Point(9, 189);
            this.lbl_AnimalReserved.Name = "lbl_AnimalReserved";
            this.lbl_AnimalReserved.Size = new System.Drawing.Size(56, 13);
            this.lbl_AnimalReserved.TabIndex = 9;
            this.lbl_AnimalReserved.Text = "Reserved:";
            // 
            // lbl_AnimalGender
            // 
            this.lbl_AnimalGender.AutoSize = true;
            this.lbl_AnimalGender.Location = new System.Drawing.Point(9, 105);
            this.lbl_AnimalGender.Name = "lbl_AnimalGender";
            this.lbl_AnimalGender.Size = new System.Drawing.Size(45, 13);
            this.lbl_AnimalGender.TabIndex = 7;
            this.lbl_AnimalGender.Text = "Gender:";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(9, 79);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(29, 13);
            this.lbl_Age.TabIndex = 6;
            this.lbl_Age.Text = "Age:";
            // 
            // lbl_AnimalName
            // 
            this.lbl_AnimalName.AutoSize = true;
            this.lbl_AnimalName.Location = new System.Drawing.Point(9, 53);
            this.lbl_AnimalName.Name = "lbl_AnimalName";
            this.lbl_AnimalName.Size = new System.Drawing.Size(38, 13);
            this.lbl_AnimalName.TabIndex = 5;
            this.lbl_AnimalName.Text = "Name:";
            // 
            // cb_AnimalGender
            // 
            this.cb_AnimalGender.FormattingEnabled = true;
            this.cb_AnimalGender.Location = new System.Drawing.Point(88, 102);
            this.cb_AnimalGender.Name = "cb_AnimalGender";
            this.cb_AnimalGender.Size = new System.Drawing.Size(121, 21);
            this.cb_AnimalGender.TabIndex = 4;
            // 
            // tb_AnimalAge
            // 
            this.tb_AnimalAge.Location = new System.Drawing.Point(88, 76);
            this.tb_AnimalAge.Name = "tb_AnimalAge";
            this.tb_AnimalAge.Size = new System.Drawing.Size(121, 20);
            this.tb_AnimalAge.TabIndex = 3;
            // 
            // tb_AnimalName
            // 
            this.tb_AnimalName.Location = new System.Drawing.Point(88, 50);
            this.tb_AnimalName.Name = "tb_AnimalName";
            this.tb_AnimalName.Size = new System.Drawing.Size(121, 20);
            this.tb_AnimalName.TabIndex = 2;
            // 
            // cb_AnimalType
            // 
            this.cb_AnimalType.FormattingEnabled = true;
            this.cb_AnimalType.Location = new System.Drawing.Point(88, 23);
            this.cb_AnimalType.Name = "cb_AnimalType";
            this.cb_AnimalType.Size = new System.Drawing.Size(121, 21);
            this.cb_AnimalType.TabIndex = 1;
            // 
            // lbl_AnimalType
            // 
            this.lbl_AnimalType.AutoSize = true;
            this.lbl_AnimalType.Location = new System.Drawing.Point(9, 26);
            this.lbl_AnimalType.Name = "lbl_AnimalType";
            this.lbl_AnimalType.Size = new System.Drawing.Size(34, 13);
            this.lbl_AnimalType.TabIndex = 0;
            this.lbl_AnimalType.Text = "Type:";
            // 
            // lb_Animals
            // 
            this.lb_Animals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Animals.FormattingEnabled = true;
            this.lb_Animals.Location = new System.Drawing.Point(235, 13);
            this.lb_Animals.Name = "lb_Animals";
            this.lb_Animals.Size = new System.Drawing.Size(179, 277);
            this.lb_Animals.TabIndex = 1;
            // 
            // btn_AddAnimal
            // 
            this.btn_AddAnimal.Location = new System.Drawing.Point(13, 253);
            this.btn_AddAnimal.Name = "btn_AddAnimal";
            this.btn_AddAnimal.Size = new System.Drawing.Size(67, 39);
            this.btn_AddAnimal.TabIndex = 2;
            this.btn_AddAnimal.Text = "Add";
            this.btn_AddAnimal.UseVisualStyleBackColor = true;
            this.btn_AddAnimal.Click += new System.EventHandler(this.btn_AddAnimal_Click);
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Location = new System.Drawing.Point(161, 253);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(68, 39);
            this.btn_Reserve.TabIndex = 3;
            this.btn_Reserve.Text = "Reserve";
            this.btn_Reserve.UseVisualStyleBackColor = true;
            this.btn_Reserve.Click += new System.EventHandler(this.btn_Reserve_Click);
            // 
            // btn_ShowInfo
            // 
            this.btn_ShowInfo.Location = new System.Drawing.Point(88, 253);
            this.btn_ShowInfo.Name = "btn_ShowInfo";
            this.btn_ShowInfo.Size = new System.Drawing.Size(67, 39);
            this.btn_ShowInfo.TabIndex = 4;
            this.btn_ShowInfo.Text = "Show Info";
            this.btn_ShowInfo.UseVisualStyleBackColor = true;
            this.btn_ShowInfo.Click += new System.EventHandler(this.btn_ShowInfo_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 304);
            this.Controls.Add(this.btn_ShowInfo);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.btn_AddAnimal);
            this.Controls.Add(this.lb_Animals);
            this.Controls.Add(this.gb_Animal);
            this.Name = "AdministrationForm";
            this.Text = "The Doozies Administration";
            this.gb_Animal.ResumeLayout(false);
            this.gb_Animal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Animal;
        private System.Windows.Forms.Label lbl_AnimalReserveAt;
        private System.Windows.Forms.Label lbl_AnimalReservedBy;
        private System.Windows.Forms.Label lbl_AnimalReserved;
        private System.Windows.Forms.Label lbl_AnimalGender;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_AnimalName;
        private System.Windows.Forms.ComboBox cb_AnimalGender;
        private System.Windows.Forms.TextBox tb_AnimalAge;
        private System.Windows.Forms.TextBox tb_AnimalName;
        private System.Windows.Forms.ComboBox cb_AnimalType;
        private System.Windows.Forms.Label lbl_AnimalType;
        private System.Windows.Forms.ListBox lb_Animals;
        private System.Windows.Forms.Button btn_AddAnimal;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.Label lbl_AnimalLastWalkDate;
        private System.Windows.Forms.Label lbl_AnimalBadHabit;
        private System.Windows.Forms.DateTimePicker dtp_LastWalkDate;
        private System.Windows.Forms.TextBox tb_BadHabit;
        private System.Windows.Forms.Button btn_ShowInfo;
    }
}


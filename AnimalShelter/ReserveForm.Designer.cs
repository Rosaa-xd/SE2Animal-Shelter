namespace AnimalShelter
{
    partial class ReserveForm
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
            this.cb_Reservors = new System.Windows.Forms.ComboBox();
            this.tb_ReservorName = new System.Windows.Forms.TextBox();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.lbl_ExistingReservor = new System.Windows.Forms.Label();
            this.lbl_NewReservor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Reservors
            // 
            this.cb_Reservors.FormattingEnabled = true;
            this.cb_Reservors.Location = new System.Drawing.Point(90, 17);
            this.cb_Reservors.Name = "cb_Reservors";
            this.cb_Reservors.Size = new System.Drawing.Size(132, 21);
            this.cb_Reservors.TabIndex = 0;
            // 
            // tb_ReservorName
            // 
            this.tb_ReservorName.Location = new System.Drawing.Point(90, 44);
            this.tb_ReservorName.Name = "tb_ReservorName";
            this.tb_ReservorName.Size = new System.Drawing.Size(132, 20);
            this.tb_ReservorName.TabIndex = 1;
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Location = new System.Drawing.Point(90, 70);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(75, 23);
            this.btn_Reserve.TabIndex = 2;
            this.btn_Reserve.Text = "Reserve";
            this.btn_Reserve.UseVisualStyleBackColor = true;
            // 
            // lbl_ExistingReservor
            // 
            this.lbl_ExistingReservor.AutoSize = true;
            this.lbl_ExistingReservor.Location = new System.Drawing.Point(13, 20);
            this.lbl_ExistingReservor.Name = "lbl_ExistingReservor";
            this.lbl_ExistingReservor.Size = new System.Drawing.Size(38, 13);
            this.lbl_ExistingReservor.TabIndex = 3;
            this.lbl_ExistingReservor.Text = "Name:";
            // 
            // lbl_NewReservor
            // 
            this.lbl_NewReservor.AutoSize = true;
            this.lbl_NewReservor.Location = new System.Drawing.Point(13, 47);
            this.lbl_NewReservor.Name = "lbl_NewReservor";
            this.lbl_NewReservor.Size = new System.Drawing.Size(38, 13);
            this.lbl_NewReservor.TabIndex = 4;
            this.lbl_NewReservor.Text = "Name:";
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 109);
            this.Controls.Add(this.lbl_NewReservor);
            this.Controls.Add(this.lbl_ExistingReservor);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.tb_ReservorName);
            this.Controls.Add(this.cb_Reservors);
            this.Name = "Reserve";
            this.Text = "Reserve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Reservors;
        private System.Windows.Forms.TextBox tb_ReservorName;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.Label lbl_ExistingReservor;
        private System.Windows.Forms.Label lbl_NewReservor;
    }
}
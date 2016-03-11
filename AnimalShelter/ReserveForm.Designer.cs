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
            this.tb_ReservorName = new System.Windows.Forms.TextBox();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.lbl_NewReservor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_ReservorName
            // 
            this.tb_ReservorName.Location = new System.Drawing.Point(90, 12);
            this.tb_ReservorName.Name = "tb_ReservorName";
            this.tb_ReservorName.Size = new System.Drawing.Size(132, 20);
            this.tb_ReservorName.TabIndex = 1;
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Location = new System.Drawing.Point(90, 38);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(75, 23);
            this.btn_Reserve.TabIndex = 2;
            this.btn_Reserve.Text = "Reserve";
            this.btn_Reserve.UseVisualStyleBackColor = true;
            this.btn_Reserve.Click += new System.EventHandler(this.btn_Reserve_Click);
            // 
            // lbl_NewReservor
            // 
            this.lbl_NewReservor.AutoSize = true;
            this.lbl_NewReservor.Location = new System.Drawing.Point(13, 15);
            this.lbl_NewReservor.Name = "lbl_NewReservor";
            this.lbl_NewReservor.Size = new System.Drawing.Size(38, 13);
            this.lbl_NewReservor.TabIndex = 4;
            this.lbl_NewReservor.Text = "Name:";
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 68);
            this.Controls.Add(this.lbl_NewReservor);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.tb_ReservorName);
            this.Name = "ReserveForm";
            this.Text = "Reserve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_ReservorName;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.Label lbl_NewReservor;
    }
}
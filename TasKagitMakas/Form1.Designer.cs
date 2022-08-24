namespace TasKagitMakas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.bOyna = new System.Windows.Forms.Button();
            this.lKazanan = new System.Windows.Forms.Label();
            this.rbKagit = new System.Windows.Forms.RadioButton();
            this.rbTas = new System.Windows.Forms.RadioButton();
            this.rbMakas = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(258, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hareket Seç";
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(323, 234);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 23);
            this.cb1.TabIndex = 1;
            this.cb1.Visible = false;
            // 
            // bOyna
            // 
            this.bOyna.Location = new System.Drawing.Point(345, 263);
            this.bOyna.Name = "bOyna";
            this.bOyna.Size = new System.Drawing.Size(75, 23);
            this.bOyna.TabIndex = 2;
            this.bOyna.Text = "oyna";
            this.bOyna.UseVisualStyleBackColor = true;
            this.bOyna.Click += new System.EventHandler(this.bOyna_Click);
            // 
            // lKazanan
            // 
            this.lKazanan.AutoSize = true;
            this.lKazanan.Location = new System.Drawing.Point(273, 329);
            this.lKazanan.Name = "lKazanan";
            this.lKazanan.Size = new System.Drawing.Size(38, 15);
            this.lKazanan.TabIndex = 3;
            this.lKazanan.Text = "label2";
            // 
            // rbKagit
            // 
            this.rbKagit.AutoSize = true;
            this.rbKagit.Location = new System.Drawing.Point(234, 78);
            this.rbKagit.Name = "rbKagit";
            this.rbKagit.Size = new System.Drawing.Size(94, 19);
            this.rbKagit.TabIndex = 4;
            this.rbKagit.TabStop = true;
            this.rbKagit.Text = "radioButton1";
            this.rbKagit.UseVisualStyleBackColor = true;
            // 
            // rbTas
            // 
            this.rbTas.AutoSize = true;
            this.rbTas.Location = new System.Drawing.Point(334, 78);
            this.rbTas.Name = "rbTas";
            this.rbTas.Size = new System.Drawing.Size(94, 19);
            this.rbTas.TabIndex = 4;
            this.rbTas.TabStop = true;
            this.rbTas.Text = "radioButton1";
            this.rbTas.UseVisualStyleBackColor = true;
            // 
            // rbMakas
            // 
            this.rbMakas.AutoSize = true;
            this.rbMakas.Location = new System.Drawing.Point(434, 78);
            this.rbMakas.Name = "rbMakas";
            this.rbMakas.Size = new System.Drawing.Size(94, 19);
            this.rbMakas.TabIndex = 4;
            this.rbMakas.TabStop = true;
            this.rbMakas.Text = "radioButton1";
            this.rbMakas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbMakas);
            this.Controls.Add(this.rbTas);
            this.Controls.Add(this.rbKagit);
            this.Controls.Add(this.lKazanan);
            this.Controls.Add(this.bOyna);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Taş Kağıt Makas Ultra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cb1;
        private Button bOyna;
        private Label lKazanan;
        private RadioButton rbKagit;
        private RadioButton rbTas;
        private RadioButton rbMakas;
    }
}

namespace LaBancaQueBanca.GUI
{
    partial class Form1
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
            this.lstTipoPrest = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCuotaTotal = new System.Windows.Forms.TextBox();
            this.tbCuotaInt = new System.Windows.Forms.TextBox();
            this.tbCuotaCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.tbPlazo = new System.Windows.Forms.TextBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.tbTNA = new System.Windows.Forms.TextBox();
            this.tbLinea = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbComiTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTipoPrest
            // 
            this.lstTipoPrest.FormattingEnabled = true;
            this.lstTipoPrest.Location = new System.Drawing.Point(24, 34);
            this.lstTipoPrest.Name = "lstTipoPrest";
            this.lstTipoPrest.Size = new System.Drawing.Size(219, 264);
            this.lstTipoPrest.TabIndex = 0;
            this.lstTipoPrest.SelectedIndexChanged += new System.EventHandler(this.lstTipoPrest_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCuotaTotal);
            this.groupBox1.Controls.Add(this.tbCuotaInt);
            this.groupBox1.Controls.Add(this.tbCuotaCap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Controls.Add(this.tbPlazo);
            this.groupBox1.Controls.Add(this.tbMonto);
            this.groupBox1.Controls.Add(this.tbTNA);
            this.groupBox1.Controls.Add(this.tbLinea);
            this.groupBox1.Controls.Add(this.lstTipoPrest);
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 364);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "ALTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cuota Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cuota (Interés)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cuota (Capital)";
            // 
            // tbCuotaTotal
            // 
            this.tbCuotaTotal.Enabled = false;
            this.tbCuotaTotal.Location = new System.Drawing.Point(342, 254);
            this.tbCuotaTotal.Name = "tbCuotaTotal";
            this.tbCuotaTotal.Size = new System.Drawing.Size(89, 20);
            this.tbCuotaTotal.TabIndex = 12;
            // 
            // tbCuotaInt
            // 
            this.tbCuotaInt.Enabled = false;
            this.tbCuotaInt.Location = new System.Drawing.Point(342, 228);
            this.tbCuotaInt.Name = "tbCuotaInt";
            this.tbCuotaInt.Size = new System.Drawing.Size(89, 20);
            this.tbCuotaInt.TabIndex = 11;
            // 
            // tbCuotaCap
            // 
            this.tbCuotaCap.Enabled = false;
            this.tbCuotaCap.Location = new System.Drawing.Point(342, 202);
            this.tbCuotaCap.Name = "tbCuotaCap";
            this.tbCuotaCap.Size = new System.Drawing.Size(89, 20);
            this.tbCuotaCap.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Plazo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TNA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Linea";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(285, 153);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(146, 23);
            this.btnSimular.TabIndex = 5;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // tbPlazo
            // 
            this.tbPlazo.Location = new System.Drawing.Point(342, 112);
            this.tbPlazo.Name = "tbPlazo";
            this.tbPlazo.Size = new System.Drawing.Size(89, 20);
            this.tbPlazo.TabIndex = 4;
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(342, 86);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(89, 20);
            this.tbMonto.TabIndex = 3;
            // 
            // tbTNA
            // 
            this.tbTNA.Enabled = false;
            this.tbTNA.Location = new System.Drawing.Point(342, 60);
            this.tbTNA.Name = "tbTNA";
            this.tbTNA.Size = new System.Drawing.Size(89, 20);
            this.tbTNA.TabIndex = 2;
            // 
            // tbLinea
            // 
            this.tbLinea.Enabled = false;
            this.tbLinea.Location = new System.Drawing.Point(342, 34);
            this.tbLinea.Name = "tbLinea";
            this.tbLinea.Size = new System.Drawing.Size(89, 20);
            this.tbLinea.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstPrestamos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbComiTotal);
            this.groupBox2.Location = new System.Drawing.Point(509, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 354);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(24, 24);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(219, 264);
            this.lstPrestamos.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Comisión Total";
            // 
            // tbComiTotal
            // 
            this.tbComiTotal.Enabled = false;
            this.tbComiTotal.Location = new System.Drawing.Point(130, 317);
            this.tbComiTotal.Name = "tbComiTotal";
            this.tbComiTotal.Size = new System.Drawing.Size(89, 20);
            this.tbComiTotal.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTipoPrest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCuotaTotal;
        private System.Windows.Forms.TextBox tbCuotaInt;
        private System.Windows.Forms.TextBox tbCuotaCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox tbPlazo;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.TextBox tbTNA;
        private System.Windows.Forms.TextBox tbLinea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbComiTotal;
    }
}


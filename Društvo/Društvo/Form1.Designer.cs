
namespace Društvo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtZaŠt = new System.Windows.Forms.TextBox();
            this.TxtNamen = new System.Windows.Forms.TextBox();
            this.TxtZnesek = new System.Windows.Forms.TextBox();
            this.TxtOpombe = new System.Windows.Forms.TextBox();
            this.DtpDatum = new System.Windows.Forms.DateTimePicker();
            this.SbStatus = new System.Windows.Forms.StatusStrip();
            this.butVnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaporedna številka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Namen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Znesek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opombe";
            // 
            // TxtZaŠt
            // 
            this.TxtZaŠt.Location = new System.Drawing.Point(269, 26);
            this.TxtZaŠt.Name = "TxtZaŠt";
            this.TxtZaŠt.Size = new System.Drawing.Size(100, 20);
            this.TxtZaŠt.TabIndex = 5;
            // 
            // TxtNamen
            // 
            this.TxtNamen.Location = new System.Drawing.Point(269, 98);
            this.TxtNamen.Name = "TxtNamen";
            this.TxtNamen.Size = new System.Drawing.Size(400, 20);
            this.TxtNamen.TabIndex = 6;
            // 
            // TxtZnesek
            // 
            this.TxtZnesek.Location = new System.Drawing.Point(269, 134);
            this.TxtZnesek.Name = "TxtZnesek";
            this.TxtZnesek.Size = new System.Drawing.Size(100, 20);
            this.TxtZnesek.TabIndex = 7;
            // 
            // TxtOpombe
            // 
            this.TxtOpombe.Location = new System.Drawing.Point(269, 170);
            this.TxtOpombe.Multiline = true;
            this.TxtOpombe.Name = "TxtOpombe";
            this.TxtOpombe.Size = new System.Drawing.Size(400, 170);
            this.TxtOpombe.TabIndex = 8;
            // 
            // DtpDatum
            // 
            this.DtpDatum.Location = new System.Drawing.Point(269, 62);
            this.DtpDatum.Name = "DtpDatum";
            this.DtpDatum.Size = new System.Drawing.Size(200, 20);
            this.DtpDatum.TabIndex = 9;
            this.DtpDatum.Value = new System.DateTime(2021, 11, 16, 9, 59, 38, 0);
            // 
            // SbStatus
            // 
            this.SbStatus.Location = new System.Drawing.Point(0, 466);
            this.SbStatus.Name = "SbStatus";
            this.SbStatus.Size = new System.Drawing.Size(778, 22);
            this.SbStatus.TabIndex = 10;
            this.SbStatus.Text = "statusStrip1";
            // 
            // butVnesi
            // 
            this.butVnesi.Location = new System.Drawing.Point(269, 368);
            this.butVnesi.Name = "butVnesi";
            this.butVnesi.Size = new System.Drawing.Size(100, 33);
            this.butVnesi.TabIndex = 11;
            this.butVnesi.Text = "Vnesi";
            this.butVnesi.UseVisualStyleBackColor = true;
            this.butVnesi.Click += new System.EventHandler(this.butVnesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 488);
            this.Controls.Add(this.butVnesi);
            this.Controls.Add(this.SbStatus);
            this.Controls.Add(this.DtpDatum);
            this.Controls.Add(this.TxtOpombe);
            this.Controls.Add(this.TxtZnesek);
            this.Controls.Add(this.TxtNamen);
            this.Controls.Add(this.TxtZaŠt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtZaŠt;
        private System.Windows.Forms.TextBox TxtNamen;
        private System.Windows.Forms.TextBox TxtZnesek;
        private System.Windows.Forms.TextBox TxtOpombe;
        private System.Windows.Forms.DateTimePicker DtpDatum;
        private System.Windows.Forms.StatusStrip SbStatus;
        private System.Windows.Forms.Button butVnesi;
    }
}



namespace Innlevering3Klasser
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
            this.btnVisInfo = new System.Windows.Forms.Button();
            this.btnEndreNavn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboVelgPerson = new System.Windows.Forms.ComboBox();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.txtAlder = new System.Windows.Forms.TextBox();
            this.txtAntallPersoner = new System.Windows.Forms.TextBox();
            this.btnVisAntall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisInfo
            // 
            this.btnVisInfo.Location = new System.Drawing.Point(309, 62);
            this.btnVisInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisInfo.Name = "btnVisInfo";
            this.btnVisInfo.Size = new System.Drawing.Size(75, 23);
            this.btnVisInfo.TabIndex = 0;
            this.btnVisInfo.Text = "Vis Info";
            this.btnVisInfo.UseVisualStyleBackColor = true;
            this.btnVisInfo.Click += new System.EventHandler(this.btnVisInfo_Click);
            // 
            // btnEndreNavn
            // 
            this.btnEndreNavn.Location = new System.Drawing.Point(692, 66);
            this.btnEndreNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndreNavn.Name = "btnEndreNavn";
            this.btnEndreNavn.Size = new System.Drawing.Size(96, 23);
            this.btnEndreNavn.TabIndex = 2;
            this.btnEndreNavn.Text = "Endre Navn";
            this.btnEndreNavn.UseVisualStyleBackColor = true;
            this.btnEndreNavn.Click += new System.EventHandler(this.btnEndreNavn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velg Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Navn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Antall personer:";
            // 
            // cboVelgPerson
            // 
            this.cboVelgPerson.FormattingEnabled = true;
            this.cboVelgPerson.Location = new System.Drawing.Point(103, 63);
            this.cboVelgPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboVelgPerson.Name = "cboVelgPerson";
            this.cboVelgPerson.Size = new System.Drawing.Size(187, 24);
            this.cboVelgPerson.TabIndex = 7;
            this.cboVelgPerson.SelectedIndexChanged += new System.EventHandler(this.cboVelgPerson_SelectedIndexChanged);
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(484, 66);
            this.txtNavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.Size = new System.Drawing.Size(175, 22);
            this.txtNavn.TabIndex = 8;
            // 
            // txtAlder
            // 
            this.txtAlder.Location = new System.Drawing.Point(484, 106);
            this.txtAlder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlder.Name = "txtAlder";
            this.txtAlder.Size = new System.Drawing.Size(175, 22);
            this.txtAlder.TabIndex = 9;
            // 
            // txtAntallPersoner
            // 
            this.txtAntallPersoner.Location = new System.Drawing.Point(501, 148);
            this.txtAntallPersoner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAntallPersoner.Name = "txtAntallPersoner";
            this.txtAntallPersoner.ReadOnly = true;
            this.txtAntallPersoner.Size = new System.Drawing.Size(29, 22);
            this.txtAntallPersoner.TabIndex = 10;
            this.txtAntallPersoner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAntallPersoner.TextChanged += new System.EventHandler(this.btnVisAntall_Click_1);
            // 
            // btnVisAntall
            // 
            this.btnVisAntall.Location = new System.Drawing.Point(309, 148);
            this.btnVisAntall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisAntall.Name = "btnVisAntall";
            this.btnVisAntall.Size = new System.Drawing.Size(75, 23);
            this.btnVisAntall.TabIndex = 11;
            this.btnVisAntall.Text = "Vis tall";
            this.btnVisAntall.UseVisualStyleBackColor = true;
            this.btnVisAntall.Click += new System.EventHandler(this.btnVisAntall_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisAntall);
            this.Controls.Add(this.txtAntallPersoner);
            this.Controls.Add(this.txtAlder);
            this.Controls.Add(this.txtNavn);
            this.Controls.Add(this.cboVelgPerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndreNavn);
            this.Controls.Add(this.btnVisInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisInfo;
        private System.Windows.Forms.Button btnEndreNavn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboVelgPerson;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.TextBox txtAlder;
        private System.Windows.Forms.TextBox txtAntallPersoner;
        private System.Windows.Forms.Button btnVisAntall;
    }
}


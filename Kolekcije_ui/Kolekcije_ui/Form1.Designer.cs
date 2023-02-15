
namespace Kolekcije_ui
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
            this.marka = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.vrsta = new System.Windows.Forms.ComboBox();
            this.unos = new System.Windows.Forms.Button();
            this.ispis = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.obrada = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(96, 34);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(121, 20);
            this.marka.TabIndex = 0;
            this.marka.TextChanged += new System.EventHandler(this.marka_TextChanged);
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(96, 79);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(121, 20);
            this.model.TabIndex = 2;
            // 
            // vrsta
            // 
            this.vrsta.FormattingEnabled = true;
            this.vrsta.Items.AddRange(new object[] {
            "Avion",
            "Automobil",
            "Brod"});
            this.vrsta.Location = new System.Drawing.Point(96, 121);
            this.vrsta.Name = "vrsta";
            this.vrsta.Size = new System.Drawing.Size(121, 21);
            this.vrsta.TabIndex = 3;
            // 
            // unos
            // 
            this.unos.Location = new System.Drawing.Point(32, 363);
            this.unos.Name = "unos";
            this.unos.Size = new System.Drawing.Size(75, 23);
            this.unos.TabIndex = 4;
            this.unos.Text = "Unos";
            this.unos.UseVisualStyleBackColor = true;
            this.unos.Click += new System.EventHandler(this.unos_Click);
            // 
            // ispis
            // 
            this.ispis.Location = new System.Drawing.Point(554, 363);
            this.ispis.Name = "ispis";
            this.ispis.Size = new System.Drawing.Size(75, 23);
            this.ispis.TabIndex = 6;
            this.ispis.Text = "ispis";
            this.ispis.UseVisualStyleBackColor = true;
            this.ispis.Click += new System.EventHandler(this.ispis_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(405, 34);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(358, 256);
            this.txtIspis.TabIndex = 7;
            // 
            // obrada
            // 
            this.obrada.Location = new System.Drawing.Point(267, 363);
            this.obrada.Name = "obrada";
            this.obrada.Size = new System.Drawing.Size(75, 23);
            this.obrada.TabIndex = 5;
            this.obrada.Text = "obrada";
            this.obrada.UseVisualStyleBackColor = true;
            this.obrada.Click += new System.EventHandler(this.obrada_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(96, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Marka:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(96, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Model:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(96, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Vrsta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.obrada);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.ispis);
            this.Controls.Add(this.unos);
            this.Controls.Add(this.vrsta);
            this.Controls.Add(this.model);
            this.Controls.Add(this.marka);
            this.Name = "Form1";
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.ComboBox vrsta;
        private System.Windows.Forms.Button unos;
        private System.Windows.Forms.Button ispis;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button obrada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}


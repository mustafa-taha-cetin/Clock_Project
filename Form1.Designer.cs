namespace Saat_Uygulaması
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
            this.components = new System.ComponentModel.Container();
            this.labelSa = new System.Windows.Forms.Label();
            this.labelDk = new System.Windows.Forms.Label();
            this.labelSn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSa
            // 
            this.labelSa.AutoSize = true;
            this.labelSa.Font = new System.Drawing.Font("Britannic Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSa.ForeColor = System.Drawing.Color.White;
            this.labelSa.Location = new System.Drawing.Point(220, 212);
            this.labelSa.Name = "labelSa";
            this.labelSa.Size = new System.Drawing.Size(164, 133);
            this.labelSa.TabIndex = 0;
            this.labelSa.Text = "0.";
            // 
            // labelDk
            // 
            this.labelDk.AutoSize = true;
            this.labelDk.Font = new System.Drawing.Font("Britannic Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDk.ForeColor = System.Drawing.Color.White;
            this.labelDk.Location = new System.Drawing.Point(378, 212);
            this.labelDk.Name = "labelDk";
            this.labelDk.Size = new System.Drawing.Size(164, 133);
            this.labelDk.TabIndex = 1;
            this.labelDk.Text = "0.";
            // 
            // labelSn
            // 
            this.labelSn.AutoSize = true;
            this.labelSn.Font = new System.Drawing.Font("Britannic Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSn.ForeColor = System.Drawing.Color.White;
            this.labelSn.Location = new System.Drawing.Point(536, 212);
            this.labelSn.Name = "labelSn";
            this.labelSn.Size = new System.Drawing.Size(130, 133);
            this.labelSn.TabIndex = 2;
            this.labelSn.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(380, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(532, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Second";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(928, 560);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSn);
            this.Controls.Add(this.labelDk);
            this.Controls.Add(this.labelSa);
            this.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSa;
        private System.Windows.Forms.Label labelDk;
        private System.Windows.Forms.Label labelSn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


﻿namespace Principal
{
    partial class Exercicio1
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
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.cmbFim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbInicio
            // 
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbInicio.Location = new System.Drawing.Point(12, 49);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(338, 24);
            this.cmbInicio.TabIndex = 0;
            this.cmbInicio.SelectedIndexChanged += new System.EventHandler(this.cmbInicio_SelectedIndexChanged);
            // 
            // cmbFim
            // 
            this.cmbFim.FormattingEnabled = true;
            this.cmbFim.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbFim.Location = new System.Drawing.Point(450, 49);
            this.cmbFim.Name = "cmbFim";
            this.cmbFim.Size = new System.Drawing.Size(338, 24);
            this.cmbFim.TabIndex = 1;
            this.cmbFim.SelectedIndexChanged += new System.EventHandler(this.cmbFim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o valor de início e fim do laço de repetição: ";
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 16;
            this.lstNumeros.Location = new System.Drawing.Point(12, 108);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(776, 324);
            this.lstNumeros.TabIndex = 3;
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFim);
            this.Controls.Add(this.cmbInicio);
            this.Name = "Exercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInicio;
        private System.Windows.Forms.ComboBox cmbFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNumeros;
    }
}
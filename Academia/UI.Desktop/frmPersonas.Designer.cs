﻿namespace UI.Desktop
{
    partial class frmPersonas
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gbPersonas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.gbPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(491, 184);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 49);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(491, 129);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 49);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(491, 74);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 49);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(16, 74);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(431, 159);
            this.dgvPersonas.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Location = new System.Drawing.Point(491, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 49);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(16, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(431, 20);
            this.txtBuscar.TabIndex = 18;
            // 
            // gbPersonas
            // 
            this.gbPersonas.Controls.Add(this.btnEliminar);
            this.gbPersonas.Controls.Add(this.txtBuscar);
            this.gbPersonas.Controls.Add(this.btnEditar);
            this.gbPersonas.Controls.Add(this.btnBuscar);
            this.gbPersonas.Controls.Add(this.btnNuevo);
            this.gbPersonas.Controls.Add(this.dgvPersonas);
            this.gbPersonas.Location = new System.Drawing.Point(12, 4);
            this.gbPersonas.Name = "gbPersonas";
            this.gbPersonas.Size = new System.Drawing.Size(575, 245);
            this.gbPersonas.TabIndex = 24;
            this.gbPersonas.TabStop = false;
            this.gbPersonas.Text = "groupBox1";
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 261);
            this.Controls.Add(this.gbPersonas);
            this.Name = "frmPersonas";
            this.Text = "frmPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.gbPersonas.ResumeLayout(false);
            this.gbPersonas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gbPersonas;
    }
}
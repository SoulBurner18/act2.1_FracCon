namespace Facciones_Continuas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TablaDatos = new System.Windows.Forms.DataGridView();
            this.ColumnPaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(152, 66);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 20);
            this.TxtNum1.TabIndex = 1;
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(152, 127);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 20);
            this.TxtNum2.TabIndex = 2;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(399, 127);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TablaDatos
            // 
            this.TablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPaso,
            this.ColumnOp,
            this.ColumnEc});
            this.TablaDatos.Enabled = false;
            this.TablaDatos.Location = new System.Drawing.Point(97, 220);
            this.TablaDatos.Name = "TablaDatos";
            this.TablaDatos.Size = new System.Drawing.Size(628, 192);
            this.TablaDatos.TabIndex = 4;
            // 
            // ColumnPaso
            // 
            this.ColumnPaso.FillWeight = 30.45685F;
            this.ColumnPaso.HeaderText = "Paso";
            this.ColumnPaso.Name = "ColumnPaso";
            // 
            // ColumnOp
            // 
            this.ColumnOp.FillWeight = 134.7716F;
            this.ColumnOp.HeaderText = "Operacion";
            this.ColumnOp.Name = "ColumnOp";
            // 
            // ColumnEc
            // 
            this.ColumnEc.FillWeight = 134.7716F;
            this.ColumnEc.HeaderText = "Ecuacion";
            this.ColumnEc.Name = "ColumnEc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TablaDatos);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.DataGridView TablaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEc;
    }
}


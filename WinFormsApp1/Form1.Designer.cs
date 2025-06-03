namespace WinFormsApp1
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
            textmonto = new TextBox();
            textfecha = new TextBox();
            textmotivo = new TextBox();
            LBLmonto = new Label();
            LBLfecha = new Label();
            LBLmotivo = new Label();
            registrar = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            cmbtipo = new ComboBox();
            LBLTipo = new Label();
            conexion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textmonto
            // 
            textmonto.Location = new Point(57, 380);
            textmonto.Name = "textmonto";
            textmonto.Size = new Size(151, 27);
            textmonto.TabIndex = 0;
            // 
            // textfecha
            // 
            textfecha.Location = new Point(322, 331);
            textfecha.Name = "textfecha";
            textfecha.Size = new Size(151, 27);
            textfecha.TabIndex = 1;
            // 
            // textmotivo
            // 
            textmotivo.Location = new Point(322, 373);
            textmotivo.Name = "textmotivo";
            textmotivo.Size = new Size(151, 27);
            textmotivo.TabIndex = 2;
            // 
            // LBLmonto
            // 
            LBLmonto.AutoSize = true;
            LBLmonto.Location = new Point(-2, 380);
            LBLmonto.Name = "LBLmonto";
            LBLmonto.Size = new Size(53, 20);
            LBLmonto.TabIndex = 3;
            LBLmonto.Text = "monto";
            // 
            // LBLfecha
            // 
            LBLfecha.AutoSize = true;
            LBLfecha.Location = new Point(242, 331);
            LBLfecha.Name = "LBLfecha";
            LBLfecha.Size = new Size(45, 20);
            LBLfecha.TabIndex = 4;
            LBLfecha.Text = "fecha";
            // 
            // LBLmotivo
            // 
            LBLmotivo.AutoSize = true;
            LBLmotivo.Location = new Point(242, 380);
            LBLmotivo.Name = "LBLmotivo";
            LBLmotivo.Size = new Size(56, 20);
            LBLmotivo.TabIndex = 5;
            LBLmotivo.Text = "motivo";
            // 
            // registrar
            // 
            registrar.Location = new Point(559, 376);
            registrar.Name = "registrar";
            registrar.Size = new Size(94, 29);
            registrar.TabIndex = 6;
            registrar.Text = "registrar";
            registrar.UseVisualStyleBackColor = true;
            registrar.Click += registrar_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(748, 305);
            dataGridView1.TabIndex = 7;
            // 
            // cmbtipo
            // 
            cmbtipo.FormattingEnabled = true;
            cmbtipo.Items.AddRange(new object[] { "ingreso", "gasto" });
            cmbtipo.Location = new Point(57, 331);
            cmbtipo.Name = "cmbtipo";
            cmbtipo.Size = new Size(151, 28);
            cmbtipo.TabIndex = 8;
            cmbtipo.SelectedIndexChanged += cmbtipo_SelectedIndexChanged;
            // 
            // LBLTipo
            // 
            LBLTipo.AutoSize = true;
            LBLTipo.Location = new Point(12, 334);
            LBLTipo.Name = "LBLTipo";
            LBLTipo.Size = new Size(39, 20);
            LBLTipo.TabIndex = 9;
            LBLTipo.Text = "Tipo";
            // 
            // conexion
            // 
            conexion.Location = new Point(559, 325);
            conexion.Name = "conexion";
            conexion.Size = new Size(94, 29);
            conexion.TabIndex = 10;
            conexion.Text = "conexion";
            conexion.UseVisualStyleBackColor = true;
            conexion.Click += conexion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(conexion);
            Controls.Add(LBLTipo);
            Controls.Add(cmbtipo);
            Controls.Add(dataGridView1);
            Controls.Add(registrar);
            Controls.Add(LBLmotivo);
            Controls.Add(LBLfecha);
            Controls.Add(LBLmonto);
            Controls.Add(textmotivo);
            Controls.Add(textfecha);
            Controls.Add(textmonto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textmonto;
        private TextBox textfecha;
        private TextBox textmotivo;
        private Label LBLmonto;
        private Label LBLfecha;
        private Label LBLmotivo;
        private Button registrar;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private ComboBox cmbtipo;
        private Label LBLTipo;
        private Button probarconexion;
        private Button conexion;
    }
}

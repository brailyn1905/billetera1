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
            textmotivo = new TextBox();
            LBLmonto = new Label();
            LBLfecha = new Label();
            LBLmotivo = new Label();
            registrar = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            cmbtipo = new ComboBox();
            LBLTipo = new Label();
            btnlimpiar = new Button();
            LBLSaldoActual = new Label();
            textSaldoActual = new TextBox();
            dateTimefecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textmonto
            // 
            textmonto.Location = new Point(99, 382);
            textmonto.Name = "textmonto";
            textmonto.Size = new Size(151, 27);
            textmonto.TabIndex = 0;
            // 
            // textmotivo
            // 
            textmotivo.Location = new Point(402, 284);
            textmotivo.Name = "textmotivo";
            textmotivo.Size = new Size(151, 27);
            textmotivo.TabIndex = 2;
            // 
            // LBLmonto
            // 
            LBLmonto.AutoSize = true;
            LBLmonto.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLmonto.Location = new Point(12, 381);
            LBLmonto.Name = "LBLmonto";
            LBLmonto.Size = new Size(76, 25);
            LBLmonto.TabIndex = 3;
            LBLmonto.Text = "monto";
            // 
            // LBLfecha
            // 
            LBLfecha.AutoSize = true;
            LBLfecha.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLfecha.Location = new Point(272, 382);
            LBLfecha.Name = "LBLfecha";
            LBLfecha.Size = new Size(67, 25);
            LBLfecha.TabIndex = 4;
            LBLfecha.Text = "fecha";
            // 
            // LBLmotivo
            // 
            LBLmotivo.AutoSize = true;
            LBLmotivo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLmotivo.Location = new Point(272, 286);
            LBLmotivo.Name = "LBLmotivo";
            LBLmotivo.Size = new Size(79, 25);
            LBLmotivo.TabIndex = 5;
            LBLmotivo.Text = "motivo";
            // 
            // registrar
            // 
            registrar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrar.Location = new Point(665, 338);
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
            dataGridView1.Location = new Point(26, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(748, 165);
            dataGridView1.TabIndex = 7;
            // 
            // cmbtipo
            // 
            cmbtipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtipo.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbtipo.FormattingEnabled = true;
            cmbtipo.Items.AddRange(new object[] { "Ingreso", "gastos" });
            cmbtipo.Location = new Point(99, 288);
            cmbtipo.Name = "cmbtipo";
            cmbtipo.Size = new Size(151, 27);
            cmbtipo.TabIndex = 8;
            cmbtipo.SelectedIndexChanged += cmbtipo_SelectedIndexChanged;
            // 
            // LBLTipo
            // 
            LBLTipo.AutoSize = true;
            LBLTipo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLTipo.Location = new Point(12, 290);
            LBLTipo.Name = "LBLTipo";
            LBLTipo.Size = new Size(57, 25);
            LBLTipo.TabIndex = 9;
            LBLTipo.Text = "Tipo";
            // 
            // btnlimpiar
            // 
            btnlimpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpiar.Location = new Point(665, 271);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(94, 29);
            btnlimpiar.TabIndex = 11;
            btnlimpiar.Text = "limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // LBLSaldoActual
            // 
            LBLSaldoActual.AutoSize = true;
            LBLSaldoActual.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLSaldoActual.Location = new Point(184, 199);
            LBLSaldoActual.Name = "LBLSaldoActual";
            LBLSaldoActual.Size = new Size(111, 23);
            LBLSaldoActual.TabIndex = 12;
            LBLSaldoActual.Text = "SaldoActual";
            // 
            // textSaldoActual
            // 
            textSaldoActual.Location = new Point(322, 192);
            textSaldoActual.Name = "textSaldoActual";
            textSaldoActual.ReadOnly = true;
            textSaldoActual.Size = new Size(231, 27);
            textSaldoActual.TabIndex = 13;
            textSaldoActual.TextChanged += textSaldoActual_TextChanged;
            // 
            // dateTimefecha
            // 
            dateTimefecha.Location = new Point(388, 382);
            dateTimefecha.Name = "dateTimefecha";
            dateTimefecha.Size = new Size(250, 27);
            dateTimefecha.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimefecha);
            Controls.Add(textSaldoActual);
            Controls.Add(LBLSaldoActual);
            Controls.Add(btnlimpiar);
            Controls.Add(LBLTipo);
            Controls.Add(cmbtipo);
            Controls.Add(dataGridView1);
            Controls.Add(registrar);
            Controls.Add(LBLmotivo);
            Controls.Add(LBLfecha);
            Controls.Add(LBLmonto);
            Controls.Add(textmotivo);
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
        private Button btnlimpiar;
        private Label LBLSaldoActual;
        private TextBox textSaldoActual;
        private DateTimePicker dateTimefecha;
        //  private DateTimePicker textfecha;
    }
}

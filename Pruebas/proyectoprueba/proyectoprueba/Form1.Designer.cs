
namespace proyectoprueba
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fechaIToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechaIToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fechaFToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechaFToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.alquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentaDataSet = new proyectoprueba.RentaDataSet();
            this.alquilerTableAdapter = new proyectoprueba.RentaDataSetTableAdapters.AlquilerTableAdapter();
            this.rentaDataSet1 = new proyectoprueba.RentaDataSet();
            this.tableAdapterManager = new proyectoprueba.RentaDataSetTableAdapters.TableAdapterManager();
            this.alquilerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn = new System.Windows.Forms.Button();
            this.fechaIToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.fechaIToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fechaFToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.fechaFToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.filtroToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.filtroToolStrip = new System.Windows.Forms.ToolStrip();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerDataGridView)).BeginInit();
            this.filtroToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(759, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Punto 2.1 > 1.4.Realice una consulta así:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaIToolStripLabel,
            this.fechaIToolStripTextBox,
            this.fechaFToolStripLabel,
            this.fechaFToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(817, 25);
            this.fillByToolStrip.TabIndex = 7;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fechaIToolStripLabel
            // 
            this.fechaIToolStripLabel.Name = "fechaIToolStripLabel";
            this.fechaIToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.fechaIToolStripLabel.Text = "fechaI:";
            // 
            // fechaIToolStripTextBox
            // 
            this.fechaIToolStripTextBox.Name = "fechaIToolStripTextBox";
            this.fechaIToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fechaFToolStripLabel
            // 
            this.fechaFToolStripLabel.Name = "fechaFToolStripLabel";
            this.fechaFToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.fechaFToolStripLabel.Text = "fechaF:";
            // 
            // fechaFToolStripTextBox
            // 
            this.fechaFToolStripTextBox.Name = "fechaFToolStripTextBox";
            this.fechaFToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // alquilerBindingSource
            // 
            this.alquilerBindingSource.DataMember = "Alquiler";
            this.alquilerBindingSource.DataSource = this.rentaDataSet;
            // 
            // rentaDataSet
            // 
            this.rentaDataSet.DataSetName = "RentaDataSet";
            this.rentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alquilerTableAdapter
            // 
            this.alquilerTableAdapter.ClearBeforeFill = true;
            // 
            // rentaDataSet1
            // 
            this.rentaDataSet1.DataSetName = "RentaDataSet";
            this.rentaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlquilerTableAdapter = this.alquilerTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carroTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.pagosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proyectoprueba.RentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alquilerDataGridView
            // 
            this.alquilerDataGridView.AutoGenerateColumns = false;
            this.alquilerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alquilerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.alquilerDataGridView.DataSource = this.alquilerBindingSource;
            this.alquilerDataGridView.Location = new System.Drawing.Point(12, 71);
            this.alquilerDataGridView.Name = "alquilerDataGridView";
            this.alquilerDataGridView.Size = new System.Drawing.Size(759, 182);
            this.alquilerDataGridView.TabIndex = 8;
            this.alquilerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alquilerDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_alquiler";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_alquiler";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "placa";
            this.dataGridViewTextBoxColumn2.HeaderText = "placa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cedula";
            this.dataGridViewTextBoxColumn3.HeaderText = "cedula";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dias_alquiler";
            this.dataGridViewTextBoxColumn5.HeaderText = "dias_alquiler";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valortotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "valortotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "saldo";
            this.dataGridViewTextBoxColumn7.HeaderText = "saldo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "abono_inicial";
            this.dataGridViewTextBoxColumn8.HeaderText = "abono_inicial";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "devuelto";
            this.dataGridViewTextBoxColumn9.HeaderText = "devuelto";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Inicial";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 345);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Final";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(360, 345);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(591, 341);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 8;
            this.btn.Text = "Filtrar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechaIToolStripLabel1
            // 
            this.fechaIToolStripLabel1.Name = "fechaIToolStripLabel1";
            this.fechaIToolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.fechaIToolStripLabel1.Text = "fechaI:";
            // 
            // fechaIToolStripTextBox1
            // 
            this.fechaIToolStripTextBox1.Name = "fechaIToolStripTextBox1";
            this.fechaIToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fechaFToolStripLabel1
            // 
            this.fechaFToolStripLabel1.Name = "fechaFToolStripLabel1";
            this.fechaFToolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.fechaFToolStripLabel1.Text = "fechaF:";
            // 
            // fechaFToolStripTextBox1
            // 
            this.fechaFToolStripTextBox1.Name = "fechaFToolStripTextBox1";
            this.fechaFToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // filtroToolStripButton
            // 
            this.filtroToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filtroToolStripButton.Name = "filtroToolStripButton";
            this.filtroToolStripButton.Size = new System.Drawing.Size(38, 22);
            this.filtroToolStripButton.Text = "Filtro";
            this.filtroToolStripButton.Click += new System.EventHandler(this.filtroToolStripButton_Click);
            // 
            // filtroToolStrip
            // 
            this.filtroToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.filtroToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaIToolStripLabel1,
            this.fechaIToolStripTextBox1,
            this.fechaFToolStripLabel1,
            this.fechaFToolStripTextBox1,
            this.filtroToolStripButton});
            this.filtroToolStrip.Location = new System.Drawing.Point(0, 25);
            this.filtroToolStrip.Name = "filtroToolStrip";
            this.filtroToolStrip.Size = new System.Drawing.Size(817, 25);
            this.filtroToolStrip.TabIndex = 9;
            this.filtroToolStrip.Text = "filtroToolStrip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "1.4.Realice una consulta así:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filtroToolStrip);
            this.Controls.Add(this.alquilerDataGridView);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerDataGridView)).EndInit();
            this.filtroToolStrip.ResumeLayout(false);
            this.filtroToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RentaDataSet rentaDataSet;
        private System.Windows.Forms.BindingSource alquilerBindingSource;
        private RentaDataSetTableAdapters.AlquilerTableAdapter alquilerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private RentaDataSet rentaDataSet1;
        private RentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel fechaIToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechaIToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fechaFToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechaFToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView alquilerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ToolStripLabel fechaIToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox fechaIToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel fechaFToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox fechaFToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton filtroToolStripButton;
        private System.Windows.Forms.ToolStrip filtroToolStrip;
        private System.Windows.Forms.Label label4;
    }
}


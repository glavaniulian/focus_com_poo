namespace FOCUS_COMSTIINTIFICE_POO
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.jucatoriDataSet1 = new FOCUS_COMSTIINTIFICE_POO.jucatoriDataSet1();
            this.ev_jucatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ev_jucatoriTableAdapter = new FOCUS_COMSTIINTIFICE_POO.jucatoriDataSet1TableAdapters.ev_jucatoriTableAdapter();
            this.tableAdapterManager = new FOCUS_COMSTIINTIFICE_POO.jucatoriDataSet1TableAdapters.TableAdapterManager();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucatoriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ev_jucatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.scorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ev_jucatoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(128, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Algerian", 9.75F);
            this.button1.Location = new System.Drawing.Point(186, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "INAPOI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jucatoriDataSet1
            // 
            this.jucatoriDataSet1.DataSetName = "jucatoriDataSet1";
            this.jucatoriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ev_jucatoriBindingSource
            // 
            this.ev_jucatoriBindingSource.DataMember = "ev_jucatori";
            this.ev_jucatoriBindingSource.DataSource = this.jucatoriDataSet1;
            // 
            // ev_jucatoriTableAdapter
            // 
            this.ev_jucatoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ev_jucatoriTableAdapter = this.ev_jucatoriTableAdapter;
            this.tableAdapterManager.UpdateOrder = FOCUS_COMSTIINTIFICE_POO.jucatoriDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // scorDataGridViewTextBoxColumn
            // 
            this.scorDataGridViewTextBoxColumn.DataPropertyName = "scor";
            this.scorDataGridViewTextBoxColumn.HeaderText = "scor";
            this.scorDataGridViewTextBoxColumn.Name = "scorDataGridViewTextBoxColumn";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(494, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form11";
            this.Text = "FOCUS";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucatoriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ev_jucatoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private jucatoriDataSet1 jucatoriDataSet1;
        private System.Windows.Forms.BindingSource ev_jucatoriBindingSource;
        private jucatoriDataSet1TableAdapters.ev_jucatoriTableAdapter ev_jucatoriTableAdapter;
        private jucatoriDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scorDataGridViewTextBoxColumn;
    }
}
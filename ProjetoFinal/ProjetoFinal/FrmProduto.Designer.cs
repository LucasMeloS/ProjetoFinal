namespace ProjetoFinal
{
    partial class FrmProduto
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigo_categoriaLabel;
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.codigo_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigo_categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(ProjetoFinalDAL.Produto);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(431, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AllowUserToAddRows = false;
            this.produtoDataGridView.AllowUserToDeleteRows = false;
            this.produtoDataGridView.AutoGenerateColumns = false;
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.produtoDataGridView.DataSource = this.produtoBindingSource;
            this.produtoDataGridView.Location = new System.Drawing.Point(97, 272);
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.ReadOnly = true;
            this.produtoDataGridView.Size = new System.Drawing.Size(570, 228);
            this.produtoDataGridView.TabIndex = 5;
            this.produtoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtoDataGridView_CellContentClick);
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(35, 31);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 5;
            descricaoLabel.Text = "Descrição:";
            descricaoLabel.Click += new System.EventHandler(this.descricaoLabel_Click);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(97, 28);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(409, 20);
            this.descricaoTextBox.TabIndex = 6;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(49, 61);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 7;
            valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(97, 58);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 8;
            // 
            // codigo_categoriaLabel
            // 
            codigo_categoriaLabel.AutoSize = true;
            codigo_categoriaLabel.Location = new System.Drawing.Point(35, 87);
            codigo_categoriaLabel.Name = "codigo_categoriaLabel";
            codigo_categoriaLabel.Size = new System.Drawing.Size(55, 13);
            codigo_categoriaLabel.TabIndex = 9;
            codigo_categoriaLabel.Text = "Categoria:";
            codigo_categoriaLabel.Click += new System.EventHandler(this.codigo_categoriaLabel_Click);
            // 
            // codigo_categoriaComboBox
            // 
            this.codigo_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "codigo_categoria", true));
            this.codigo_categoriaComboBox.FormattingEnabled = true;
            this.codigo_categoriaComboBox.Location = new System.Drawing.Point(97, 84);
            this.codigo_categoriaComboBox.Name = "codigo_categoriaComboBox";
            this.codigo_categoriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.codigo_categoriaComboBox.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(codigo_categoriaLabel);
            this.Controls.Add(this.codigo_categoriaComboBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.produtoDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmProduto";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ComboBox codigo_categoriaComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
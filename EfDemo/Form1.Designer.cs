namespace EfDemo
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.tbxObtenerTodos = new System.Windows.Forms.TextBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxContactTittle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(13, 13);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(930, 346);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(715, 438);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(163, 40);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Cargar Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // tbxObtenerTodos
            // 
            this.tbxObtenerTodos.Location = new System.Drawing.Point(141, 387);
            this.tbxObtenerTodos.Name = "tbxObtenerTodos";
            this.tbxObtenerTodos.Size = new System.Drawing.Size(111, 26);
            this.tbxObtenerTodos.TabIndex = 2;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(281, 379);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(93, 30);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Obtener";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "CustomerID";
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(210, 445);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.Size = new System.Drawing.Size(111, 26);
            this.tbxCustomerID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Company Name";
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(210, 488);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(111, 26);
            this.tbxCompanyName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contact Name";
            // 
            // tbxContactName
            // 
            this.tbxContactName.Location = new System.Drawing.Point(210, 529);
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.Size = new System.Drawing.Size(111, 26);
            this.tbxContactName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contact Tittle";
            // 
            // tbxContactTittle
            // 
            this.tbxContactTittle.Location = new System.Drawing.Point(210, 574);
            this.tbxContactTittle.Name = "tbxContactTittle";
            this.tbxContactTittle.Size = new System.Drawing.Size(111, 26);
            this.tbxContactTittle.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(210, 617);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(111, 26);
            this.tbxAddress.TabIndex = 14;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(369, 524);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(93, 30);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 676);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxContactTittle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxContactName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.tbxObtenerTodos);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.TextBox tbxObtenerTodos;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxContactTittle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Button btnInsertar;
    }
}


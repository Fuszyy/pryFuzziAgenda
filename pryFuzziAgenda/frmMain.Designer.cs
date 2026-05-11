namespace pryFuzziAgenda
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnExp = new System.Windows.Forms.Button();
            this.gbxGestion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.gbxGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre(s):";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(24, 81);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(34, 109);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Correo:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(28, 53);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(47, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Apellido:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(81, 49);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(99, 20);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(80, 79);
            this.txtPhone.Mask = "000-000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(68, 20);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPhone_MaskInputRejected);
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(19, 133);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 13);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Categoría:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.Enabled = false;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "Familia",
            "Amigos",
            "Trabajo",
            "Otros.."});
            this.cbxCategory.Location = new System.Drawing.Point(80, 131);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(100, 21);
            this.cbxCategory.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(90, 204);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnSurname,
            this.columnPhone,
            this.columnMail,
            this.ColumnCategory});
            this.dgvContacts.Enabled = false;
            this.dgvContacts.Location = new System.Drawing.Point(253, 16);
            this.dgvContacts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersWidth = 51;
            this.dgvContacts.RowTemplate.Height = 24;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(635, 211);
            this.dgvContacts.TabIndex = 11;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Nombre(s)";
            this.columnName.MinimumWidth = 6;
            this.columnName.Name = "columnName";
            this.columnName.Width = 125;
            // 
            // columnSurname
            // 
            this.columnSurname.HeaderText = "Apellido";
            this.columnSurname.MinimumWidth = 6;
            this.columnSurname.Name = "columnSurname";
            this.columnSurname.Width = 125;
            // 
            // columnPhone
            // 
            this.columnPhone.HeaderText = "Teléfono";
            this.columnPhone.MinimumWidth = 6;
            this.columnPhone.Name = "columnPhone";
            this.columnPhone.Width = 125;
            // 
            // columnMail
            // 
            this.columnMail.HeaderText = "Correo";
            this.columnMail.MinimumWidth = 6;
            this.columnMail.Name = "columnMail";
            this.columnMail.Width = 125;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.HeaderText = "Categoría";
            this.ColumnCategory.MinimumWidth = 6;
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.Width = 125;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(79, 106);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(127, 20);
            this.txtMail.TabIndex = 15;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(9, 178);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(237, 23);
            this.btnExp.TabIndex = 16;
            this.btnExp.Text = "Mostrar contactos >>>";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // gbxGestion
            // 
            this.gbxGestion.Controls.Add(this.txtName);
            this.gbxGestion.Controls.Add(this.lblName);
            this.gbxGestion.Controls.Add(this.txtMail);
            this.gbxGestion.Controls.Add(this.lblPhone);
            this.gbxGestion.Controls.Add(this.lblMail);
            this.gbxGestion.Controls.Add(this.lblSurname);
            this.gbxGestion.Controls.Add(this.txtSurname);
            this.gbxGestion.Controls.Add(this.txtPhone);
            this.gbxGestion.Controls.Add(this.cbxCategory);
            this.gbxGestion.Controls.Add(this.lblCategory);
            this.gbxGestion.Location = new System.Drawing.Point(4, 8);
            this.gbxGestion.Name = "gbxGestion";
            this.gbxGestion.Size = new System.Drawing.Size(243, 167);
            this.gbxGestion.TabIndex = 17;
            this.gbxGestion.TabStop = false;
            this.gbxGestion.Text = "Agregar un contacto..";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 236);
            this.Controls.Add(this.gbxGestion);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.gbxGestion.ResumeLayout(false);
            this.gbxGestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.GroupBox gbxGestion;
    }
}


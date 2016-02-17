namespace SmartRename
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbx_folder = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.txtbx_regin = new System.Windows.Forms.TextBox();
            this.txtbx_regout = new System.Windows.Forms.TextBox();
            this.dtGrd_convert = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Original = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convert = new System.Windows.Forms.Button();
            this.folderBrowserDiag = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrd_convert)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_folder
            // 
            this.txtbx_folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_folder.Location = new System.Drawing.Point(3, 3);
            this.txtbx_folder.Name = "txtbx_folder";
            this.txtbx_folder.Size = new System.Drawing.Size(886, 22);
            this.txtbx_folder.TabIndex = 0;
            this.txtbx_folder.Leave += new System.EventHandler(this.txtbx_folder_Leave);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(895, 3);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(69, 23);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // txtbx_regin
            // 
            this.txtbx_regin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_regin.Location = new System.Drawing.Point(3, 48);
            this.txtbx_regin.Name = "txtbx_regin";
            this.txtbx_regin.Size = new System.Drawing.Size(967, 22);
            this.txtbx_regin.TabIndex = 2;
            this.txtbx_regin.TextChanged += new System.EventHandler(this.txtbx_regin_TextChanged);
            // 
            // txtbx_regout
            // 
            this.txtbx_regout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_regout.Location = new System.Drawing.Point(3, 76);
            this.txtbx_regout.Name = "txtbx_regout";
            this.txtbx_regout.Size = new System.Drawing.Size(967, 22);
            this.txtbx_regout.TabIndex = 3;
            this.txtbx_regout.TextChanged += new System.EventHandler(this.txtbx_regout_TextChanged);
            // 
            // dtGrd_convert
            // 
            this.dtGrd_convert.AllowUserToAddRows = false;
            this.dtGrd_convert.AllowUserToDeleteRows = false;
            this.dtGrd_convert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrd_convert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Original,
            this.Result});
            this.dtGrd_convert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrd_convert.Location = new System.Drawing.Point(3, 3);
            this.dtGrd_convert.Name = "dtGrd_convert";
            this.dtGrd_convert.RowTemplate.Height = 24;
            this.dtGrd_convert.Size = new System.Drawing.Size(886, 299);
            this.dtGrd_convert.TabIndex = 4;
            // 
            // Check
            // 
            this.Check.HeaderText = "C";
            this.Check.Name = "Check";
            this.Check.Width = 30;
            // 
            // Original
            // 
            this.Original.HeaderText = "Original";
            this.Original.Name = "Original";
            this.Original.Width = 200;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Result.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Result.Width = 200;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(895, 3);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(69, 23);
            this.convert.TabIndex = 5;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // folderBrowserDiag
            // 
            this.folderBrowserDiag.ShowNewFolderButton = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtbx_regin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtbx_regout, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 412);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.Controls.Add(this.txtbx_folder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.browse, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(967, 39);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.Controls.Add(this.dtGrd_convert, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.convert, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 104);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(967, 305);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 412);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrd_convert)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_folder;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox txtbx_regin;
        private System.Windows.Forms.TextBox txtbx_regout;
        private System.Windows.Forms.DataGridView dtGrd_convert;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDiag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Original;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}


namespace WindowsFormsApp1
{
    partial class Form2
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
            this.dgvPictograms = new System.Windows.Forms.DataGridView();
            this.btnAddToBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BoardToFill = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictograms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPictograms
            // 
            this.dgvPictograms.AllowUserToAddRows = false;
            this.dgvPictograms.AllowUserToDeleteRows = false;
            this.dgvPictograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPictograms.Location = new System.Drawing.Point(85, 29);
            this.dgvPictograms.Name = "dgvPictograms";
            this.dgvPictograms.ReadOnly = true;
            this.dgvPictograms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPictograms.Size = new System.Drawing.Size(398, 380);
            this.dgvPictograms.TabIndex = 11;
            // 
            // btnAddToBoard
            // 
            this.btnAddToBoard.Location = new System.Drawing.Point(669, 369);
            this.btnAddToBoard.Name = "btnAddToBoard";
            this.btnAddToBoard.Size = new System.Drawing.Size(75, 40);
            this.btnAddToBoard.TabIndex = 12;
            this.btnAddToBoard.Text = "Guardar";
            this.btnAddToBoard.UseVisualStyleBackColor = true;
            this.btnAddToBoard.Click += new System.EventHandler(this.btnAddToBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agregar al tablero:";
            // 
            // BoardToFill
            // 
            this.BoardToFill.Location = new System.Drawing.Point(669, 102);
            this.BoardToFill.Name = "BoardToFill";
            this.BoardToFill.Size = new System.Drawing.Size(43, 20);
            this.BoardToFill.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoardToFill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToBoard);
            this.Controls.Add(this.dgvPictograms);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictograms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPictograms;
        private System.Windows.Forms.Button btnAddToBoard;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox BoardToFill;
    }
}
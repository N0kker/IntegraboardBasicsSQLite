namespace WindowsFormsApp1
{
    partial class FormTablero
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
            this.dgvBoardContent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoardContent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoardContent
            // 
            this.dgvBoardContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoardContent.Location = new System.Drawing.Point(185, 76);
            this.dgvBoardContent.Name = "dgvBoardContent";
            this.dgvBoardContent.Size = new System.Drawing.Size(439, 310);
            this.dgvBoardContent.TabIndex = 0;
            // 
            // FormTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBoardContent);
            this.Name = "FormTablero";
            this.Text = "FormTablero";
            this.Load += new System.EventHandler(this.FormTablero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoardContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoardContent;
    }
}
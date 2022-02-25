namespace WindowsFormsApp1
{
    partial class Form1
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
            this.ID = new System.Windows.Forms.Label();
            this.imageName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.dgvPictograms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PictogramsPage = new System.Windows.Forms.TabPage();
            this.BoardsPage = new System.Windows.Forms.TabPage();
            this.BoardIDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoardNametxt = new System.Windows.Forms.TextBox();
            this.DeleteBoard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBoards = new System.Windows.Forms.DataGridView();
            this.EditBoard = new System.Windows.Forms.Button();
            this.BoardImagetxt = new System.Windows.Forms.TextBox();
            this.SaveBoard = new System.Windows.Forms.Button();
            this.DisplayBoard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictograms)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.PictogramsPage.SuspendLayout();
            this.BoardsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoards)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(256, 91);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // imageName
            // 
            this.imageName.AutoSize = true;
            this.imageName.Location = new System.Drawing.Point(614, 91);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(63, 13);
            this.imageName.TabIndex = 2;
            this.imageName.Text = "imageName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(598, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(59, 188);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(59, 241);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 8;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(59, 294);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 9;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // dgvPictograms
            // 
            this.dgvPictograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPictograms.Location = new System.Drawing.Point(219, 178);
            this.dgvPictograms.Name = "dgvPictograms";
            this.dgvPictograms.Size = new System.Drawing.Size(479, 150);
            this.dgvPictograms.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PictogramsPage);
            this.tabControl1.Controls.Add(this.BoardsPage);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 451);
            this.tabControl1.TabIndex = 12;
            // 
            // PictogramsPage
            // 
            this.PictogramsPage.Controls.Add(this.textBox1);
            this.PictogramsPage.Controls.Add(this.imageName);
            this.PictogramsPage.Controls.Add(this.label1);
            this.PictogramsPage.Controls.Add(this.textBox2);
            this.PictogramsPage.Controls.Add(this.Eliminar);
            this.PictogramsPage.Controls.Add(this.ID);
            this.PictogramsPage.Controls.Add(this.dgvPictograms);
            this.PictogramsPage.Controls.Add(this.Editar);
            this.PictogramsPage.Controls.Add(this.textBox3);
            this.PictogramsPage.Controls.Add(this.Guardar);
            this.PictogramsPage.Location = new System.Drawing.Point(4, 22);
            this.PictogramsPage.Name = "PictogramsPage";
            this.PictogramsPage.Padding = new System.Windows.Forms.Padding(3);
            this.PictogramsPage.Size = new System.Drawing.Size(793, 425);
            this.PictogramsPage.TabIndex = 0;
            this.PictogramsPage.Text = "PictogramsPage";
            this.PictogramsPage.UseVisualStyleBackColor = true;
            // 
            // BoardsPage
            // 
            this.BoardsPage.Controls.Add(this.DisplayBoard);
            this.BoardsPage.Controls.Add(this.BoardIDtxt);
            this.BoardsPage.Controls.Add(this.label2);
            this.BoardsPage.Controls.Add(this.label3);
            this.BoardsPage.Controls.Add(this.BoardNametxt);
            this.BoardsPage.Controls.Add(this.DeleteBoard);
            this.BoardsPage.Controls.Add(this.label4);
            this.BoardsPage.Controls.Add(this.dgvBoards);
            this.BoardsPage.Controls.Add(this.EditBoard);
            this.BoardsPage.Controls.Add(this.BoardImagetxt);
            this.BoardsPage.Controls.Add(this.SaveBoard);
            this.BoardsPage.Location = new System.Drawing.Point(4, 22);
            this.BoardsPage.Name = "BoardsPage";
            this.BoardsPage.Padding = new System.Windows.Forms.Padding(3);
            this.BoardsPage.Size = new System.Drawing.Size(793, 425);
            this.BoardsPage.TabIndex = 1;
            this.BoardsPage.Text = "BoardsPage";
            this.BoardsPage.UseVisualStyleBackColor = true;
            // 
            // BoardIDtxt
            // 
            this.BoardIDtxt.Location = new System.Drawing.Point(217, 127);
            this.BoardIDtxt.Name = "BoardIDtxt";
            this.BoardIDtxt.Size = new System.Drawing.Size(100, 20);
            this.BoardIDtxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "mainImage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name";
            // 
            // BoardNametxt
            // 
            this.BoardNametxt.Location = new System.Drawing.Point(409, 127);
            this.BoardNametxt.Name = "BoardNametxt";
            this.BoardNametxt.Size = new System.Drawing.Size(100, 20);
            this.BoardNametxt.TabIndex = 15;
            // 
            // DeleteBoard
            // 
            this.DeleteBoard.Location = new System.Drawing.Point(57, 293);
            this.DeleteBoard.Name = "DeleteBoard";
            this.DeleteBoard.Size = new System.Drawing.Size(75, 23);
            this.DeleteBoard.TabIndex = 19;
            this.DeleteBoard.Text = "Eliminar";
            this.DeleteBoard.UseVisualStyleBackColor = true;
            this.DeleteBoard.Click += new System.EventHandler(this.DeleteBoard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // dgvBoards
            // 
            this.dgvBoards.AllowUserToAddRows = false;
            this.dgvBoards.AllowUserToDeleteRows = false;
            this.dgvBoards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoards.Location = new System.Drawing.Point(217, 178);
            this.dgvBoards.MultiSelect = false;
            this.dgvBoards.Name = "dgvBoards";
            this.dgvBoards.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvBoards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoards.ShowEditingIcon = false;
            this.dgvBoards.Size = new System.Drawing.Size(479, 150);
            this.dgvBoards.TabIndex = 20;
            //this.dgvBoards.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoards_CellContentDoubleClick);
            this.dgvBoards.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoards_CellDoubleClick);
            // 
            // EditBoard
            // 
            this.EditBoard.Location = new System.Drawing.Point(57, 240);
            this.EditBoard.Name = "EditBoard";
            this.EditBoard.Size = new System.Drawing.Size(75, 23);
            this.EditBoard.TabIndex = 18;
            this.EditBoard.Text = "Editar";
            this.EditBoard.UseVisualStyleBackColor = true;
            this.EditBoard.Click += new System.EventHandler(this.EditBoard_Click);
            // 
            // BoardImagetxt
            // 
            this.BoardImagetxt.Location = new System.Drawing.Point(596, 127);
            this.BoardImagetxt.Name = "BoardImagetxt";
            this.BoardImagetxt.Size = new System.Drawing.Size(100, 20);
            this.BoardImagetxt.TabIndex = 16;
            // 
            // SaveBoard
            // 
            this.SaveBoard.Location = new System.Drawing.Point(57, 187);
            this.SaveBoard.Name = "SaveBoard";
            this.SaveBoard.Size = new System.Drawing.Size(75, 23);
            this.SaveBoard.TabIndex = 17;
            this.SaveBoard.Text = "Guardar";
            this.SaveBoard.UseVisualStyleBackColor = true;
            this.SaveBoard.Click += new System.EventHandler(this.SaveBoard_Click);
            // 
            // DisplayBoard
            // 
            this.DisplayBoard.Location = new System.Drawing.Point(409, 361);
            this.DisplayBoard.Name = "DisplayBoard";
            this.DisplayBoard.Size = new System.Drawing.Size(100, 23);
            this.DisplayBoard.TabIndex = 22;
            this.DisplayBoard.Text = "Ver";
            this.DisplayBoard.UseVisualStyleBackColor = true;
            this.DisplayBoard.Click += new System.EventHandler(this.DisplayBoard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictograms)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.PictogramsPage.ResumeLayout(false);
            this.PictogramsPage.PerformLayout();
            this.BoardsPage.ResumeLayout(false);
            this.BoardsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label imageName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridView dgvPictograms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PictogramsPage;
        private System.Windows.Forms.TabPage BoardsPage;
        private System.Windows.Forms.TextBox BoardIDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoardNametxt;
        private System.Windows.Forms.Button DeleteBoard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditBoard;
        private System.Windows.Forms.TextBox BoardImagetxt;
        private System.Windows.Forms.Button SaveBoard;
        private System.Windows.Forms.Button DisplayBoard;
        public System.Windows.Forms.DataGridView dgvBoards;
    }
}


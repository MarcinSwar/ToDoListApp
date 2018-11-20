namespace ToDoListApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakonczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapisywanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ZadaniaDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZadaniaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.zapisywanieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.zakonczToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // zakonczToolStripMenuItem
            // 
            this.zakonczToolStripMenuItem.Name = "zakonczToolStripMenuItem";
            this.zakonczToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.zakonczToolStripMenuItem.Text = "Zakończ";
            this.zakonczToolStripMenuItem.Click += new System.EventHandler(this.zakonczToolStripMenuItem_Click);
            // 
            // zapisywanieToolStripMenuItem
            // 
            this.zapisywanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszJakoJSONToolStripMenuItem});
            this.zapisywanieToolStripMenuItem.Name = "zapisywanieToolStripMenuItem";
            this.zapisywanieToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.zapisywanieToolStripMenuItem.Text = "Zapisywanie";
            // 
            // zapiszJakoJSONToolStripMenuItem
            // 
            this.zapiszJakoJSONToolStripMenuItem.Name = "zapiszJakoJSONToolStripMenuItem";
            this.zapiszJakoJSONToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.zapiszJakoJSONToolStripMenuItem.Text = "Zapisz jako JSON";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadania do zrobienia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZadaniaDataGridView
            // 
            this.ZadaniaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZadaniaDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.ZadaniaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZadaniaDataGridView.Location = new System.Drawing.Point(0, 72);
            this.ZadaniaDataGridView.Name = "ZadaniaDataGridView";
            this.ZadaniaDataGridView.Size = new System.Drawing.Size(470, 284);
            this.ZadaniaDataGridView.TabIndex = 3;
            this.ZadaniaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 48);
            this.panel1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajZadanieToolStripMenuItem,
            this.edytujZadanieToolStripMenuItem,
            this.usunZadanieToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 70);
            // 
            // dodajZadanieToolStripMenuItem
            // 
            this.dodajZadanieToolStripMenuItem.Name = "dodajZadanieToolStripMenuItem";
            this.dodajZadanieToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dodajZadanieToolStripMenuItem.Text = "Dodaj zadanie";
            this.dodajZadanieToolStripMenuItem.Click += new System.EventHandler(this.dodajZadanieToolStripMenuItem_Click);
            // 
            // edytujZadanieToolStripMenuItem
            // 
            this.edytujZadanieToolStripMenuItem.Name = "edytujZadanieToolStripMenuItem";
            this.edytujZadanieToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.edytujZadanieToolStripMenuItem.Text = "Edytuj zadanie";
            // 
            // usunZadanieToolStripMenuItem
            // 
            this.usunZadanieToolStripMenuItem.Name = "usunZadanieToolStripMenuItem";
            this.usunZadanieToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usunZadanieToolStripMenuItem.Text = "Usuń zadanie";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 356);
            this.Controls.Add(this.ZadaniaDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZadaniaDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakonczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapisywanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoJSONToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ZadaniaDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajZadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujZadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunZadanieToolStripMenuItem;
    }
}


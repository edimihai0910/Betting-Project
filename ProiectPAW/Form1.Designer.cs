
namespace ProiectPAW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderID = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOra = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPret = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCastig = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNrMeciuri = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemStergeBilet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdaugaBilet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModificaBilet = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAfisareBilet = new System.Windows.Forms.Button();
            this.buttonAdaugaBilet = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderOra,
            this.columnHeaderPret,
            this.columnHeaderCastig,
            this.columnHeaderNrMeciuri});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(412, 122);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(466, 427);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 40;
            // 
            // columnHeaderOra
            // 
            this.columnHeaderOra.Text = "Data Printare";
            this.columnHeaderOra.Width = 105;
            // 
            // columnHeaderPret
            // 
            this.columnHeaderPret.Text = "Pret";
            this.columnHeaderPret.Width = 80;
            // 
            // columnHeaderCastig
            // 
            this.columnHeaderCastig.Text = "Castig Potential";
            this.columnHeaderCastig.Width = 125;
            // 
            // columnHeaderNrMeciuri
            // 
            this.columnHeaderNrMeciuri.Text = "Numar Meciuri";
            this.columnHeaderNrMeciuri.Width = 110;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStergeBilet,
            this.toolStripMenuItemAdaugaBilet,
            this.toolStripMenuItemModificaBilet});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 76);
            // 
            // toolStripMenuItemStergeBilet
            // 
            this.toolStripMenuItemStergeBilet.Name = "toolStripMenuItemStergeBilet";
            this.toolStripMenuItemStergeBilet.Size = new System.Drawing.Size(181, 24);
            this.toolStripMenuItemStergeBilet.Text = "&Stergere Bilet";
            this.toolStripMenuItemStergeBilet.Click += new System.EventHandler(this.toolStripMenuItemStergeBilet_Click);
            // 
            // toolStripMenuItemAdaugaBilet
            // 
            this.toolStripMenuItemAdaugaBilet.Name = "toolStripMenuItemAdaugaBilet";
            this.toolStripMenuItemAdaugaBilet.Size = new System.Drawing.Size(181, 24);
            this.toolStripMenuItemAdaugaBilet.Text = "Adaugare Bilet ";
            this.toolStripMenuItemAdaugaBilet.Click += new System.EventHandler(this.toolStripMenuItemAdaugaBilet_Click);
            // 
            // toolStripMenuItemModificaBilet
            // 
            this.toolStripMenuItemModificaBilet.Name = "toolStripMenuItemModificaBilet";
            this.toolStripMenuItemModificaBilet.Size = new System.Drawing.Size(181, 24);
            this.toolStripMenuItemModificaBilet.Text = "Modifica Bilet";
            this.toolStripMenuItemModificaBilet.Click += new System.EventHandler(this.toolStripMenuItemModificaBilet_Click);
            // 
            // buttonAfisareBilet
            // 
            this.buttonAfisareBilet.BackgroundImage = global::ProiectPAW.Properties.Resources.TipsTricks_Sportsbonus_net_;
            this.buttonAfisareBilet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAfisareBilet.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonAfisareBilet.ForeColor = System.Drawing.Color.Black;
            this.buttonAfisareBilet.Location = new System.Drawing.Point(811, 592);
            this.buttonAfisareBilet.Name = "buttonAfisareBilet";
            this.buttonAfisareBilet.Size = new System.Drawing.Size(361, 179);
            this.buttonAfisareBilet.TabIndex = 3;
            this.buttonAfisareBilet.Text = "Afisare Bilet";
            this.buttonAfisareBilet.UseVisualStyleBackColor = true;
            this.buttonAfisareBilet.Click += new System.EventHandler(this.buttonAfisareBilet_Click);
            // 
            // buttonAdaugaBilet
            // 
            this.buttonAdaugaBilet.BackgroundImage = global::ProiectPAW.Properties.Resources.TipsTricks_Sportsbonus_net_;
            this.buttonAdaugaBilet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdaugaBilet.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonAdaugaBilet.Location = new System.Drawing.Point(26, 592);
            this.buttonAdaugaBilet.Name = "buttonAdaugaBilet";
            this.buttonAdaugaBilet.Size = new System.Drawing.Size(375, 179);
            this.buttonAdaugaBilet.TabIndex = 5;
            this.buttonAdaugaBilet.Text = "&Adauga Bilet";
            this.buttonAdaugaBilet.UseVisualStyleBackColor = true;
            this.buttonAdaugaBilet.Click += new System.EventHandler(this.buttonAdaugaBilet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProiectPAW.Properties.Resources.Awicons_Vista_Artistic_Chart1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1146, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 92);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(561, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "LISTA BILETE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1412, 851);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonAdaugaBilet);
            this.Controls.Add(this.buttonAfisareBilet);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.g);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderOra;
        private System.Windows.Forms.ColumnHeader columnHeaderPret;
        private System.Windows.Forms.ColumnHeader columnHeaderCastig;
        private System.Windows.Forms.ColumnHeader columnHeaderNrMeciuri;
        private System.Windows.Forms.Button buttonAfisareBilet;
        private System.Windows.Forms.Button buttonAdaugaBilet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStergeBilet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdaugaBilet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModificaBilet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}


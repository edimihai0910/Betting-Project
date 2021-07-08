
namespace ProiectPAW
{
    partial class Form3
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
            this.button13 = new System.Windows.Forms.Button();
            this.listViewPariuri = new System.Windows.Forms.ListView();
            this.columnHeaderPariuSimbol = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPariuNume = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(590, 376);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(8, 8);
            this.button13.TabIndex = 12;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // listViewPariuri
            // 
            this.listViewPariuri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPariuSimbol,
            this.columnHeaderPariuNume});
            this.listViewPariuri.FullRowSelect = true;
            this.listViewPariuri.GridLines = true;
            this.listViewPariuri.HideSelection = false;
            this.listViewPariuri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewPariuri.Location = new System.Drawing.Point(159, 74);
            this.listViewPariuri.Name = "listViewPariuri";
            this.listViewPariuri.Size = new System.Drawing.Size(244, 393);
            this.listViewPariuri.TabIndex = 13;
            this.listViewPariuri.UseCompatibleStateImageBehavior = false;
            this.listViewPariuri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPariuSimbol
            // 
            this.columnHeaderPariuSimbol.Text = "Simbol";
            this.columnHeaderPariuSimbol.Width = 80;
            // 
            // columnHeaderPariuNume
            // 
            this.columnHeaderPariuNume.Text = "Denumire Pariu";
            this.columnHeaderPariuNume.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "AJUTOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProiectPAW.Properties.Resources.help_icon;
            this.pictureBox1.Location = new System.Drawing.Point(456, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 125);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPariuri);
            this.Controls.Add(this.button13);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ListView listViewPariuri;
        private System.Windows.Forms.ColumnHeader columnHeaderPariuSimbol;
        private System.Windows.Forms.ColumnHeader columnHeaderPariuNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
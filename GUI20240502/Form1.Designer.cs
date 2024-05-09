
namespace GUI20240502
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
            this.dataGridView_adatmegjelenites = new System.Windows.Forms.DataGridView();
            this.button_orszag = new System.Windows.Forms.Button();
            this.label_orszag = new System.Windows.Forms.Label();
            this.button_osszemelet = new System.Windows.Forms.Button();
            this.label_osszemelet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adatmegjelenites)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_adatmegjelenites
            // 
            this.dataGridView_adatmegjelenites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_adatmegjelenites.Location = new System.Drawing.Point(380, 41);
            this.dataGridView_adatmegjelenites.Name = "dataGridView_adatmegjelenites";
            this.dataGridView_adatmegjelenites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_adatmegjelenites.Size = new System.Drawing.Size(408, 393);
            this.dataGridView_adatmegjelenites.TabIndex = 0;
            // 
            // button_orszag
            // 
            this.button_orszag.Location = new System.Drawing.Point(12, 41);
            this.button_orszag.Name = "button_orszag";
            this.button_orszag.Size = new System.Drawing.Size(321, 64);
            this.button_orszag.TabIndex = 1;
            this.button_orszag.Text = "Ország";
            this.button_orszag.UseVisualStyleBackColor = true;
            this.button_orszag.Click += new System.EventHandler(this.button_orszag_Click);
            // 
            // label_orszag
            // 
            this.label_orszag.AutoSize = true;
            this.label_orszag.Location = new System.Drawing.Point(9, 145);
            this.label_orszag.Name = "label_orszag";
            this.label_orszag.Size = new System.Drawing.Size(43, 13);
            this.label_orszag.TabIndex = 2;
            this.label_orszag.Text = "Ország:";
            // 
            // button_osszemelet
            // 
            this.button_osszemelet.Location = new System.Drawing.Point(12, 194);
            this.button_osszemelet.Name = "button_osszemelet";
            this.button_osszemelet.Size = new System.Drawing.Size(321, 64);
            this.button_osszemelet.TabIndex = 3;
            this.button_osszemelet.Text = "Összemelet";
            this.button_osszemelet.UseVisualStyleBackColor = true;
            this.button_osszemelet.Click += new System.EventHandler(this.button_osszemelet_Click);
            // 
            // label_osszemelet
            // 
            this.label_osszemelet.AutoSize = true;
            this.label_osszemelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_osszemelet.Location = new System.Drawing.Point(9, 307);
            this.label_osszemelet.Name = "label_osszemelet";
            this.label_osszemelet.Size = new System.Drawing.Size(353, 17);
            this.label_osszemelet.TabIndex = 4;
            this.label_osszemelet.Text = "A 400 m-nél magasabb épületek átlagos emeletszáma:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_osszemelet);
            this.Controls.Add(this.button_osszemelet);
            this.Controls.Add(this.label_orszag);
            this.Controls.Add(this.button_orszag);
            this.Controls.Add(this.dataGridView_adatmegjelenites);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adatmegjelenites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_adatmegjelenites;
        private System.Windows.Forms.Button button_orszag;
        private System.Windows.Forms.Label label_orszag;
        private System.Windows.Forms.Button button_osszemelet;
        private System.Windows.Forms.Label label_osszemelet;
    }
}


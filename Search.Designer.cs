namespace Mile_Stone_Inventory_Moving_List
{
    partial class Search
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
            this.roomNum1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seaButt = new System.Windows.Forms.Button();
            this.retButt4 = new System.Windows.Forms.Button();
            this.bdayPick1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.roomNum1)).BeginInit();
            this.SuspendLayout();
            // 
            // roomNum1
            // 
            this.roomNum1.Location = new System.Drawing.Point(12, 27);
            this.roomNum1.Name = "roomNum1";
            this.roomNum1.Size = new System.Drawing.Size(120, 23);
            this.roomNum1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(12, 71);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(120, 23);
            this.nameBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birthdate";
            // 
            // seaButt
            // 
            this.seaButt.Location = new System.Drawing.Point(153, 9);
            this.seaButt.Name = "seaButt";
            this.seaButt.Size = new System.Drawing.Size(63, 85);
            this.seaButt.TabIndex = 6;
            this.seaButt.Text = "Search";
            this.seaButt.UseVisualStyleBackColor = true;
            // 
            // retButt4
            // 
            this.retButt4.Location = new System.Drawing.Point(222, 9);
            this.retButt4.Name = "retButt4";
            this.retButt4.Size = new System.Drawing.Size(63, 85);
            this.retButt4.TabIndex = 7;
            this.retButt4.Text = "Return";
            this.retButt4.UseVisualStyleBackColor = true;
            this.retButt4.Click += new System.EventHandler(this.retButt4_Click);
            // 
            // bdayPick1
            // 
            this.bdayPick1.Location = new System.Drawing.Point(12, 116);
            this.bdayPick1.Name = "bdayPick1";
            this.bdayPick1.Size = new System.Drawing.Size(273, 23);
            this.bdayPick1.TabIndex = 8;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 151);
            this.Controls.Add(this.bdayPick1);
            this.Controls.Add(this.retButt4);
            this.Controls.Add(this.seaButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomNum1);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.roomNum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown roomNum1;
        private Label label1;
        private Label label2;
        private TextBox nameBox1;
        private Label label3;
        private Button seaButt;
        private Button retButt4;
        private DateTimePicker bdayPick1;
    }
}
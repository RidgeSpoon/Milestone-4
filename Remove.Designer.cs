namespace Mile_Stone_Inventory_Moving_List
{
    partial class Remove
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.remButt = new System.Windows.Forms.Button();
            this.retButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(205, 305);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // remButt
            // 
            this.remButt.Location = new System.Drawing.Point(12, 323);
            this.remButt.Name = "remButt";
            this.remButt.Size = new System.Drawing.Size(205, 23);
            this.remButt.TabIndex = 1;
            this.remButt.Text = "Remove Detainee";
            this.remButt.UseVisualStyleBackColor = true;
            this.remButt.Click += new System.EventHandler(this.remButt_Click);
            // 
            // retButt
            // 
            this.retButt.Location = new System.Drawing.Point(12, 352);
            this.retButt.Name = "retButt";
            this.retButt.Size = new System.Drawing.Size(205, 23);
            this.retButt.TabIndex = 2;
            this.retButt.Text = "Return";
            this.retButt.UseVisualStyleBackColor = true;
            this.retButt.Click += new System.EventHandler(this.retButt_Click);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 383);
            this.Controls.Add(this.retButt);
            this.Controls.Add(this.remButt);
            this.Controls.Add(this.listView1);
            this.Name = "Remove";
            this.Text = "Remove";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private Button remButt;
        private Button retButt;
    }
}
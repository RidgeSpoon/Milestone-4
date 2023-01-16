namespace Mile_Stone_Inventory_Moving_List
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.addInv = new System.Windows.Forms.Button();
            this.remInv = new System.Windows.Forms.Button();
            this.roomAvail = new System.Windows.Forms.Button();
            this.detList = new System.Windows.Forms.Button();
            this.roomSea = new System.Windows.Forms.Button();
            this.cancBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addInv
            // 
            this.addInv.Location = new System.Drawing.Point(49, 8);
            this.addInv.Name = "addInv";
            this.addInv.Size = new System.Drawing.Size(149, 44);
            this.addInv.TabIndex = 0;
            this.addInv.Text = "Add Detainee";
            this.addInv.UseVisualStyleBackColor = true;
            this.addInv.Click += new System.EventHandler(this.addInv_Click);
            // 
            // remInv
            // 
            this.remInv.Location = new System.Drawing.Point(49, 58);
            this.remInv.Name = "remInv";
            this.remInv.Size = new System.Drawing.Size(149, 44);
            this.remInv.TabIndex = 1;
            this.remInv.Text = "Remove Detainee";
            this.remInv.UseVisualStyleBackColor = true;
            this.remInv.Click += new System.EventHandler(this.remInv_Click);
            // 
            // roomAvail
            // 
            this.roomAvail.Location = new System.Drawing.Point(50, 108);
            this.roomAvail.Name = "roomAvail";
            this.roomAvail.Size = new System.Drawing.Size(149, 44);
            this.roomAvail.TabIndex = 2;
            this.roomAvail.Text = "Room Availability";
            this.roomAvail.UseVisualStyleBackColor = true;
            this.roomAvail.Click += new System.EventHandler(this.roomAvail_Click);
            // 
            // detList
            // 
            this.detList.Location = new System.Drawing.Point(49, 158);
            this.detList.Name = "detList";
            this.detList.Size = new System.Drawing.Size(149, 44);
            this.detList.TabIndex = 3;
            this.detList.Text = "Detainee List";
            this.detList.UseVisualStyleBackColor = true;
            this.detList.Click += new System.EventHandler(this.detList_Click);
            // 
            // roomSea
            // 
            this.roomSea.Location = new System.Drawing.Point(50, 208);
            this.roomSea.Name = "roomSea";
            this.roomSea.Size = new System.Drawing.Size(149, 44);
            this.roomSea.TabIndex = 4;
            this.roomSea.Text = "Room Search";
            this.roomSea.UseVisualStyleBackColor = true;
            this.roomSea.Click += new System.EventHandler(this.roomSea_Click);
            // 
            // cancBut
            // 
            this.cancBut.Location = new System.Drawing.Point(50, 258);
            this.cancBut.Name = "cancBut";
            this.cancBut.Size = new System.Drawing.Size(149, 44);
            this.cancBut.TabIndex = 5;
            this.cancBut.Text = "CANCEL";
            this.cancBut.UseVisualStyleBackColor = true;
            this.cancBut.Click += new System.EventHandler(this.cancBut_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(247, 312);
            this.Controls.Add(this.cancBut);
            this.Controls.Add(this.roomSea);
            this.Controls.Add(this.detList);
            this.Controls.Add(this.roomAvail);
            this.Controls.Add(this.remInv);
            this.Controls.Add(this.addInv);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.Text = "Directory";
            this.ResumeLayout(false);

        }

        #endregion

        private Button addInv;
        private Button remInv;
        private Button roomAvail;
        private Button detList;
        private Button roomSea;
        private Button cancBut;
    }
}
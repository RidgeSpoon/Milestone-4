namespace Mile_Stone_Inventory_Moving_List
{
    partial class RoomAvai
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
            this.label1 = new System.Windows.Forms.Label();
            this.numBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomList = new System.Windows.Forms.ListView();
            this.retButt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "There are ";
            // 
            // numBox2
            // 
            this.numBox2.Location = new System.Drawing.Point(76, 6);
            this.numBox2.Name = "numBox2";
            this.numBox2.Size = new System.Drawing.Size(38, 23);
            this.numBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "rooms available.";
            // 
            // roomList
            // 
            this.roomList.Location = new System.Drawing.Point(12, 35);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(200, 152);
            this.roomList.TabIndex = 3;
            this.roomList.UseCompatibleStateImageBehavior = false;
            // 
            // retButt2
            // 
            this.retButt2.Location = new System.Drawing.Point(12, 193);
            this.retButt2.Name = "retButt2";
            this.retButt2.Size = new System.Drawing.Size(201, 23);
            this.retButt2.TabIndex = 4;
            this.retButt2.Text = "Return";
            this.retButt2.UseVisualStyleBackColor = true;
            this.retButt2.Click += new System.EventHandler(this.retButt2_Click);
            // 
            // RoomAvai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 224);
            this.Controls.Add(this.retButt2);
            this.Controls.Add(this.roomList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numBox2);
            this.Controls.Add(this.label1);
            this.Name = "RoomAvai";
            this.Text = "RoomAvai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox numBox2;
        private Label label2;
        private ListView roomList;
        private Button retButt2;
    }
}
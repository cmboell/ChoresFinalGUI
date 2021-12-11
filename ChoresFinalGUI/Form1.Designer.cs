
namespace ChoresFinalGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChoreName = new System.Windows.Forms.TextBox();
            this.htcTxt = new System.Windows.Forms.TextBox();
            this.pTxt = new System.Windows.Forms.TextBox();
            this.ListOfChores = new System.Windows.Forms.ListBox();
            this.enterChore = new System.Windows.Forms.Button();
            this.hourButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours To Complete:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Priority:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ChoreName
            // 
            this.ChoreName.Location = new System.Drawing.Point(371, 55);
            this.ChoreName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChoreName.Name = "ChoreName";
            this.ChoreName.Size = new System.Drawing.Size(153, 35);
            this.ChoreName.TabIndex = 3;
            // 
            // htcTxt
            // 
            this.htcTxt.Location = new System.Drawing.Point(371, 187);
            this.htcTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.htcTxt.Name = "htcTxt";
            this.htcTxt.Size = new System.Drawing.Size(153, 35);
            this.htcTxt.TabIndex = 4;
            this.htcTxt.TextChanged += new System.EventHandler(this.htcTxt_TextChanged);
            // 
            // pTxt
            // 
            this.pTxt.Location = new System.Drawing.Point(371, 310);
            this.pTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pTxt.Name = "pTxt";
            this.pTxt.Size = new System.Drawing.Size(153, 35);
            this.pTxt.TabIndex = 5;
            // 
            // ListOfChores
            // 
            this.ListOfChores.FormattingEnabled = true;
            this.ListOfChores.ItemHeight = 29;
            this.ListOfChores.Location = new System.Drawing.Point(587, 45);
            this.ListOfChores.Margin = new System.Windows.Forms.Padding(2);
            this.ListOfChores.Name = "ListOfChores";
            this.ListOfChores.Size = new System.Drawing.Size(529, 410);
            this.ListOfChores.TabIndex = 6;
            // 
            // enterChore
            // 
            this.enterChore.Location = new System.Drawing.Point(131, 425);
            this.enterChore.Margin = new System.Windows.Forms.Padding(2);
            this.enterChore.Name = "enterChore";
            this.enterChore.Size = new System.Drawing.Size(125, 39);
            this.enterChore.TabIndex = 7;
            this.enterChore.Text = "Enter";
            this.enterChore.UseVisualStyleBackColor = true;
            this.enterChore.Click += new System.EventHandler(this.enterChore_Click);
            // 
            // hourButton
            // 
            this.hourButton.Location = new System.Drawing.Point(131, 487);
            this.hourButton.Name = "hourButton";
            this.hourButton.Size = new System.Drawing.Size(200, 39);
            this.hourButton.TabIndex = 10;
            this.hourButton.Text = "Sort By Hours";
            this.hourButton.UseVisualStyleBackColor = true;
            this.hourButton.Click += new System.EventHandler(this.hourButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sort By Priority";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(281, 425);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(111, 39);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 722);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hourButton);
            this.Controls.Add(this.enterChore);
            this.Controls.Add(this.ListOfChores);
            this.Controls.Add(this.pTxt);
            this.Controls.Add(this.htcTxt);
            this.Controls.Add(this.ChoreName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Chores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChoreName;
        private System.Windows.Forms.TextBox htcTxt;
        private System.Windows.Forms.TextBox pTxt;
        private System.Windows.Forms.ListBox ListOfChores;
        private System.Windows.Forms.Button enterChore;
        private System.Windows.Forms.Button hourButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeButton;
    }
}


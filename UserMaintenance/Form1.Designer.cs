
namespace UserMaintenance
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(38, 34);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(120, 95);
            this.listUsers.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(193, 34);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(35, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(252, 34);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(226, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "button2";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove_Click
            // 
            this.btnRemove_Click.Location = new System.Drawing.Point(82, 154);
            this.btnRemove_Click.Name = "btnRemove_Click";
            this.btnRemove_Click.Size = new System.Drawing.Size(75, 23);
            this.btnRemove_Click.TabIndex = 6;
            this.btnRemove_Click.Text = "button3";
            this.btnRemove_Click.UseVisualStyleBackColor = true;
            this.btnRemove_Click.Click += new System.EventHandler(this.btnRemove_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove_Click);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove_Click;
    }
}


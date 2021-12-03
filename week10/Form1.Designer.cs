
namespace week10
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.numericUpDownZaroev = new System.Windows.Forms.NumericUpDown();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.labelZaroev = new System.Windows.Forms.Label();
            this.labelNepessegFajl = new System.Windows.Forms.Label();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxNepessegFajl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZaroev)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(642, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numericUpDownZaroev
            // 
            this.numericUpDownZaroev.Location = new System.Drawing.Point(75, 21);
            this.numericUpDownZaroev.Name = "numericUpDownZaroev";
            this.numericUpDownZaroev.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownZaroev.TabIndex = 1;
            this.numericUpDownZaroev.ValueChanged += new System.EventHandler(this.numericUpDownZaroev_ValueChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(507, 21);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 30);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labelZaroev
            // 
            this.labelZaroev.AutoSize = true;
            this.labelZaroev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZaroev.Location = new System.Drawing.Point(28, 23);
            this.labelZaroev.Name = "labelZaroev";
            this.labelZaroev.Size = new System.Drawing.Size(47, 13);
            this.labelZaroev.TabIndex = 3;
            this.labelZaroev.Text = "Záróév";
            this.labelZaroev.Click += new System.EventHandler(this.labelZaroev_Click);
            // 
            // labelNepessegFajl
            // 
            this.labelNepessegFajl.AutoSize = true;
            this.labelNepessegFajl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNepessegFajl.Location = new System.Drawing.Point(175, 23);
            this.labelNepessegFajl.Name = "labelNepessegFajl";
            this.labelNepessegFajl.Size = new System.Drawing.Size(84, 13);
            this.labelNepessegFajl.TabIndex = 4;
            this.labelNepessegFajl.Text = "Népesség fájl";
            this.labelNepessegFajl.Click += new System.EventHandler(this.labelNepessegFajl_Click);
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Location = new System.Drawing.Point(31, 85);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(731, 353);
            this.richTextBoxResults.TabIndex = 5;
            this.richTextBoxResults.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBoxNepessegFajl
            // 
            this.textBoxNepessegFajl.Location = new System.Drawing.Point(278, 23);
            this.textBoxNepessegFajl.Name = "textBoxNepessegFajl";
            this.textBoxNepessegFajl.Size = new System.Drawing.Size(212, 20);
            this.textBoxNepessegFajl.TabIndex = 8;
            this.textBoxNepessegFajl.TextChanged += new System.EventHandler(this.textBoxNepessegFajl_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNepessegFajl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBoxResults);
            this.Controls.Add(this.labelNepessegFajl);
            this.Controls.Add(this.labelZaroev);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.numericUpDownZaroev);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZaroev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericUpDownZaroev;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label labelZaroev;
        private System.Windows.Forms.Label labelNepessegFajl;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxNepessegFajl;
    }
}


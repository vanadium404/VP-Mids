namespace Stored_Proedure
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
            this.label4 = new System.Windows.Forms.Label();
            this.idd = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "STORED PROCEDURE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.875F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(244, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.875F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(244, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.875F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(244, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // idd
            // 
            this.idd.Location = new System.Drawing.Point(494, 238);
            this.idd.Name = "idd";
            this.idd.Size = new System.Drawing.Size(327, 31);
            this.idd.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(484, 357);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(337, 31);
            this.name.TabIndex = 5;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(484, 484);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(337, 31);
            this.phone.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(862, 584);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 84);
            this.button3.TabIndex = 9;
            this.button3.Text = "VIEW";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(632, 584);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 84);
            this.button4.TabIndex = 10;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(377, 584);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 84);
            this.button5.TabIndex = 11;
            this.button5.Text = "UPDATE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(862, 118);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 82;
            this.grid.RowTemplate.Height = 33;
            this.grid.Size = new System.Drawing.Size(740, 434);
            this.grid.TabIndex = 12;
            // 
            // c1
            // 
            this.c1.FormattingEnabled = true;
            this.c1.Location = new System.Drawing.Point(1176, 34);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(121, 33);
            this.c1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 963);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.idd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idd;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox c1;
    }
}


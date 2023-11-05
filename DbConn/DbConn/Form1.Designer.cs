namespace DbConn
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
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.dep = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "DBCONN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 13.875F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(293, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 13.875F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(293, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(435, 179);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 31);
            this.id.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(435, 250);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 31);
            this.name.TabIndex = 5;
            // 
            // dep
            // 
            this.dep.Font = new System.Drawing.Font("MingLiU-ExtB", 13.875F, System.Drawing.FontStyle.Bold);
            this.dep.FormattingEnabled = true;
            this.dep.Location = new System.Drawing.Point(517, 331);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(121, 45);
            this.dep.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MingLiU-ExtB", 13.875F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(320, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list
            // 
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(907, 229);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(395, 342);
            this.list.TabIndex = 8;
            this.list.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MingLiU-ExtB", 13.875F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(516, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 61);
            this.button2.TabIndex = 9;
            this.button2.Text = "VIEW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MingLiU-ExtB", 13.875F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(320, 558);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 61);
            this.button3.TabIndex = 10;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MingLiU-ExtB", 13.875F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(505, 457);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 61);
            this.button4.TabIndex = 11;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(850, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Displaying Record";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 873);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox dep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
    }
}


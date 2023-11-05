namespace WindowsFormsApp2
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
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aid = new System.Windows.Forms.TextBox();
            this.acid = new System.Windows.Forms.TextBox();
            this.aname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entity Data Model";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(86, 335);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(187, 81);
            this.insert.TabIndex = 1;
            this.insert.Text = "INSERT";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.update.Location = new System.Drawing.Point(86, 465);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(187, 74);
            this.update.TabIndex = 2;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.delete.Location = new System.Drawing.Point(86, 576);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(187, 81);
            this.delete.TabIndex = 3;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.view.Location = new System.Drawing.Point(86, 201);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(187, 81);
            this.view.TabIndex = 4;
            this.view.Text = "VIEW";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(410, 201);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 82;
            this.gridview.RowTemplate.Height = 33;
            this.gridview.Size = new System.Drawing.Size(589, 456);
            this.gridview.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1013, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Area ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1005, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Area Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1013, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "City ID";
            // 
            // aid
            // 
            this.aid.Location = new System.Drawing.Point(1154, 290);
            this.aid.Name = "aid";
            this.aid.Size = new System.Drawing.Size(198, 31);
            this.aid.TabIndex = 9;
            // 
            // acid
            // 
            this.acid.Location = new System.Drawing.Point(1154, 533);
            this.acid.Name = "acid";
            this.acid.Size = new System.Drawing.Size(198, 31);
            this.acid.TabIndex = 10;
            // 
            // aname
            // 
            this.aname.Location = new System.Drawing.Point(1154, 405);
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(198, 31);
            this.aname.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 841);
            this.Controls.Add(this.aname);
            this.Controls.Add(this.acid);
            this.Controls.Add(this.aid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.view);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aid;
        private System.Windows.Forms.TextBox acid;
        private System.Windows.Forms.TextBox aname;
    }
}


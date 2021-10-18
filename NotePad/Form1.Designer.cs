
namespace NotePad
{
    partial class Note_Pad_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_label = new System.Windows.Forms.Label();
            this.Message_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.New_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Read_button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Title_textBox = new System.Windows.Forms.TextBox();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(30, 33);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(53, 21);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Title: ";
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Message_label.Location = new System.Drawing.Point(-4, 87);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(87, 21);
            this.Message_label.TabIndex = 1;
            this.Message_label.Text = "Message: ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(552, 87);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(236, 211);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // New_button
            // 
            this.New_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.New_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.New_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.New_button.Location = new System.Drawing.Point(73, 341);
            this.New_button.Name = "New_button";
            this.New_button.Size = new System.Drawing.Size(89, 34);
            this.New_button.TabIndex = 3;
            this.New_button.Text = "New";
            this.New_button.UseVisualStyleBackColor = false;
            this.New_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.Yellow;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_button.Location = new System.Drawing.Point(247, 341);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(89, 34);
            this.Save_button.TabIndex = 3;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Read_button
            // 
            this.Read_button.BackColor = System.Drawing.Color.Lime;
            this.Read_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Read_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Read_button.Location = new System.Drawing.Point(440, 341);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(89, 34);
            this.Read_button.TabIndex = 3;
            this.Read_button.Text = "Read";
            this.Read_button.UseVisualStyleBackColor = false;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete_Button.Location = new System.Drawing.Point(609, 341);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(89, 34);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Title_textBox
            // 
            this.Title_textBox.Location = new System.Drawing.Point(89, 31);
            this.Title_textBox.Name = "Title_textBox";
            this.Title_textBox.Size = new System.Drawing.Size(247, 23);
            this.Title_textBox.TabIndex = 4;
            // 
            // Message_textBox
            // 
            this.Message_textBox.Location = new System.Drawing.Point(89, 89);
            this.Message_textBox.Multiline = true;
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(386, 209);
            this.Message_textBox.TabIndex = 5;
            // 
            // Note_Pad_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Message_textBox);
            this.Controls.Add(this.Title_textBox);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.New_button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Message_label);
            this.Controls.Add(this.title_label);
            this.Name = "Note_Pad_Form";
            this.Text = "NotePad";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button New_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox Title_textBox;
        private System.Windows.Forms.TextBox Message_textBox;
    }
}


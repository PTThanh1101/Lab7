using System.Drawing;

namespace Lab7
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
            this.Titlelabel = new System.Windows.Forms.Label();
            this.InputInformationgroupBox = new System.Windows.Forms.GroupBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.InputCitycomboBox = new System.Windows.Forms.ComboBox();
            this.InputGendercomboBox = new System.Windows.Forms.ComboBox();
            this.InputAgetextBox = new System.Windows.Forms.TextBox();
            this.InputStudentNametextBox = new System.Windows.Forms.TextBox();
            this.InputGenderlabel = new System.Windows.Forms.Label();
            this.InputCitylabel = new System.Windows.Forms.Label();
            this.InputAgelabel = new System.Windows.Forms.Label();
            this.InputStudentNamelabel = new System.Windows.Forms.Label();
            this.ShowInformationgroupBox = new System.Windows.Forms.GroupBox();
            this.ShowInfordataGridView = new System.Windows.Forms.DataGridView();
            this.RemovetextBox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.InputInformationgroupBox.SuspendLayout();
            this.ShowInformationgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowInfordataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Titlelabel.Location = new System.Drawing.Point(481, 23);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(346, 54);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "STUDENT DETAIL";
            // 
            // InputInformationgroupBox
            // 
            this.InputInformationgroupBox.Controls.Add(this.Updatebutton);
            this.InputInformationgroupBox.Controls.Add(this.Deletebutton);
            this.InputInformationgroupBox.Controls.Add(this.Removebutton);
            this.InputInformationgroupBox.Controls.Add(this.InputCitycomboBox);
            this.InputInformationgroupBox.Controls.Add(this.InputGendercomboBox);
            this.InputInformationgroupBox.Controls.Add(this.InputAgetextBox);
            this.InputInformationgroupBox.Controls.Add(this.InputStudentNametextBox);
            this.InputInformationgroupBox.Controls.Add(this.InputGenderlabel);
            this.InputInformationgroupBox.Controls.Add(this.InputCitylabel);
            this.InputInformationgroupBox.Controls.Add(this.InputAgelabel);
            this.InputInformationgroupBox.Controls.Add(this.InputStudentNamelabel);
            this.InputInformationgroupBox.Location = new System.Drawing.Point(0, 69);
            this.InputInformationgroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputInformationgroupBox.Name = "InputInformationgroupBox";
            this.InputInformationgroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputInformationgroupBox.Size = new System.Drawing.Size(1399, 180);
            this.InputInformationgroupBox.TabIndex = 1;
            this.InputInformationgroupBox.TabStop = false;
            this.InputInformationgroupBox.Text = "Input Information";
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(952, 152);
            this.Updatebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(94, 23);
            this.Updatebutton.TabIndex = 10;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(1096, 152);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(94, 23);
            this.Deletebutton.TabIndex = 9;
            this.Deletebutton.Text = "DELETE";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.Location = new System.Drawing.Point(814, 152);
            this.Removebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(94, 23);
            this.Removebutton.TabIndex = 8;
            this.Removebutton.Text = "REMOVE";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // InputCitycomboBox
            // 
            this.InputCitycomboBox.FormattingEnabled = true;
            this.InputCitycomboBox.Location = new System.Drawing.Point(814, 105);
            this.InputCitycomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputCitycomboBox.Name = "InputCitycomboBox";
            this.InputCitycomboBox.Size = new System.Drawing.Size(376, 24);
            this.InputCitycomboBox.TabIndex = 7;
            // 
            // InputGendercomboBox
            // 
            this.InputGendercomboBox.FormattingEnabled = true;
            this.InputGendercomboBox.Location = new System.Drawing.Point(814, 49);
            this.InputGendercomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputGendercomboBox.Name = "InputGendercomboBox";
            this.InputGendercomboBox.Size = new System.Drawing.Size(376, 24);
            this.InputGendercomboBox.TabIndex = 6;
            // 
            // InputAgetextBox
            // 
            this.InputAgetextBox.Location = new System.Drawing.Point(256, 107);
            this.InputAgetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputAgetextBox.Name = "InputAgetextBox";
            this.InputAgetextBox.Size = new System.Drawing.Size(376, 22);
            this.InputAgetextBox.TabIndex = 5;
            // 
            // InputStudentNametextBox
            // 
            this.InputStudentNametextBox.Location = new System.Drawing.Point(256, 51);
            this.InputStudentNametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputStudentNametextBox.Name = "InputStudentNametextBox";
            this.InputStudentNametextBox.Size = new System.Drawing.Size(376, 22);
            this.InputStudentNametextBox.TabIndex = 4;
            // 
            // InputGenderlabel
            // 
            this.InputGenderlabel.AutoSize = true;
            this.InputGenderlabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.InputGenderlabel.Location = new System.Drawing.Point(678, 42);
            this.InputGenderlabel.Name = "InputGenderlabel";
            this.InputGenderlabel.Size = new System.Drawing.Size(89, 31);
            this.InputGenderlabel.TabIndex = 3;
            this.InputGenderlabel.Text = "Gender";
            // 
            // InputCitylabel
            // 
            this.InputCitylabel.AutoSize = true;
            this.InputCitylabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.InputCitylabel.Location = new System.Drawing.Point(678, 98);
            this.InputCitylabel.Name = "InputCitylabel";
            this.InputCitylabel.Size = new System.Drawing.Size(53, 31);
            this.InputCitylabel.TabIndex = 2;
            this.InputCitylabel.Text = "City";
            // 
            // InputAgelabel
            // 
            this.InputAgelabel.AutoSize = true;
            this.InputAgelabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.InputAgelabel.Location = new System.Drawing.Point(61, 98);
            this.InputAgelabel.Name = "InputAgelabel";
            this.InputAgelabel.Size = new System.Drawing.Size(55, 31);
            this.InputAgelabel.TabIndex = 1;
            this.InputAgelabel.Text = "Age";
            // 
            // InputStudentNamelabel
            // 
            this.InputStudentNamelabel.AutoSize = true;
            this.InputStudentNamelabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.InputStudentNamelabel.Location = new System.Drawing.Point(61, 42);
            this.InputStudentNamelabel.Name = "InputStudentNamelabel";
            this.InputStudentNamelabel.Size = new System.Drawing.Size(160, 31);
            this.InputStudentNamelabel.TabIndex = 0;
            this.InputStudentNamelabel.Text = "Student Name";
            // 
            // ShowInformationgroupBox
            // 
            this.ShowInformationgroupBox.Controls.Add(this.ShowInfordataGridView);
            this.ShowInformationgroupBox.Location = new System.Drawing.Point(0, 261);
            this.ShowInformationgroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowInformationgroupBox.Name = "ShowInformationgroupBox";
            this.ShowInformationgroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowInformationgroupBox.Size = new System.Drawing.Size(1399, 231);
            this.ShowInformationgroupBox.TabIndex = 2;
            this.ShowInformationgroupBox.TabStop = false;
            this.ShowInformationgroupBox.Text = "Student";
            // 
            // ShowInfordataGridView
            // 
            this.ShowInfordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowInfordataGridView.Location = new System.Drawing.Point(6, 14);
            this.ShowInfordataGridView.Name = "ShowInfordataGridView";
            this.ShowInfordataGridView.RowHeadersWidth = 51;
            this.ShowInfordataGridView.RowTemplate.Height = 24;
            this.ShowInfordataGridView.Size = new System.Drawing.Size(1393, 212);
            this.ShowInfordataGridView.TabIndex = 0;
            // 
            // RemovetextBox
            // 
            this.RemovetextBox.Location = new System.Drawing.Point(814, 247);
            this.RemovetextBox.Name = "RemovetextBox";
            this.RemovetextBox.Size = new System.Drawing.Size(94, 22);
            this.RemovetextBox.TabIndex = 3;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(780, 247);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(28, 20);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 513);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.RemovetextBox);
            this.Controls.Add(this.ShowInformationgroupBox);
            this.Controls.Add(this.InputInformationgroupBox);
            this.Controls.Add(this.Titlelabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputInformationgroupBox.ResumeLayout(false);
            this.InputInformationgroupBox.PerformLayout();
            this.ShowInformationgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowInfordataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.GroupBox InputInformationgroupBox;
        private System.Windows.Forms.TextBox InputStudentNametextBox;
        private System.Windows.Forms.Label InputGenderlabel;
        private System.Windows.Forms.Label InputCitylabel;
        private System.Windows.Forms.Label InputAgelabel;
        private System.Windows.Forms.Label InputStudentNamelabel;
        private System.Windows.Forms.TextBox InputAgetextBox;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.ComboBox InputCitycomboBox;
        private System.Windows.Forms.ComboBox InputGendercomboBox;
        private System.Windows.Forms.GroupBox ShowInformationgroupBox;
        private System.Windows.Forms.DataGridView ShowInfordataGridView;
        private System.Windows.Forms.TextBox RemovetextBox;
        private System.Windows.Forms.Label IDlabel;
    }
}

//this.label1 = new System.Windows.Forms.Label();
//System.Windows.Forms.Label label1;

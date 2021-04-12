
namespace SampleDatabaseWalkthrough
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnGetAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGetStudentsTable = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtGiven = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetAll
            // 
            this.BtnGetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetAll.Location = new System.Drawing.Point(340, 12);
            this.BtnGetAll.Name = "BtnGetAll";
            this.BtnGetAll.Size = new System.Drawing.Size(152, 45);
            this.BtnGetAll.TabIndex = 0;
            this.BtnGetAll.Text = "Get All Records";
            this.BtnGetAll.UseVisualStyleBackColor = true;
            this.BtnGetAll.Click += new System.EventHandler(this.BtnGetAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(49, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 213);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(160, 87);
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(411, 36);
            this.txtStudentID.TabIndex = 3;
            this.txtStudentID.Validated += new System.EventHandler(this.txtStudentID_Validated);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(594, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGetStudentsTable
            // 
            this.btnGetStudentsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStudentsTable.Location = new System.Drawing.Point(340, 358);
            this.btnGetStudentsTable.Name = "btnGetStudentsTable";
            this.btnGetStudentsTable.Size = new System.Drawing.Size(152, 36);
            this.btnGetStudentsTable.TabIndex = 5;
            this.btnGetStudentsTable.Text = "Get Students Table";
            this.btnGetStudentsTable.UseVisualStyleBackColor = true;
            this.btnGetStudentsTable.Click += new System.EventHandler(this.btnGetStudentsTable_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(49, 400);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(267, 400);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(100, 20);
            this.txtFamily.TabIndex = 7;
            // 
            // txtGiven
            // 
            this.txtGiven.Location = new System.Drawing.Point(491, 400);
            this.txtGiven.Name = "txtGiven";
            this.txtGiven.Size = new System.Drawing.Size(100, 20);
            this.txtGiven.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(691, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtGiven);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGetStudentsTable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGetAll);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGetStudentsTable;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtGiven;
        private System.Windows.Forms.Button btnUpdate;
    }
}


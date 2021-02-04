
namespace WinLinqToSql
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.btnEmpDetails = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSpInsert = new System.Windows.Forms.Button();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lbldeptno = new System.Windows.Forms.Label();
            this.txtdeptno = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteSp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(282, 148);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(81, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "EmployeeId";
            // 
            // btnEmpDetails
            // 
            this.btnEmpDetails.Location = new System.Drawing.Point(354, 26);
            this.btnEmpDetails.Name = "btnEmpDetails";
            this.btnEmpDetails.Size = new System.Drawing.Size(130, 23);
            this.btnEmpDetails.TabIndex = 3;
            this.btnEmpDetails.Text = "ShowEmpDetail";
            this.btnEmpDetails.UseVisualStyleBackColor = true;
            this.btnEmpDetails.Click += new System.EventHandler(this.btnEmpDetails_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(233, 110);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(122, 17);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "CountOfEmployee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "TotEmpsCount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(400, 148);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 22);
            this.txtEmpId.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DeleteEmployee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSpInsert
            // 
            this.btnSpInsert.Location = new System.Drawing.Point(378, 104);
            this.btnSpInsert.Name = "btnSpInsert";
            this.btnSpInsert.Size = new System.Drawing.Size(122, 23);
            this.btnSpInsert.TabIndex = 8;
            this.btnSpInsert.Text = "Insert with SP";
            this.btnSpInsert.UseVisualStyleBackColor = true;
            this.btnSpInsert.Click += new System.EventHandler(this.btnSpInsert_Click);
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Location = new System.Drawing.Point(293, 194);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(70, 17);
            this.lblempname.TabIndex = 9;
            this.lblempname.Text = "empname";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(293, 243);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 17);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Salary";
            // 
            // lbldeptno
            // 
            this.lbldeptno.AutoSize = true;
            this.lbldeptno.Location = new System.Drawing.Point(295, 304);
            this.lbldeptno.Name = "lbldeptno";
            this.lbldeptno.Size = new System.Drawing.Size(56, 17);
            this.lbldeptno.TabIndex = 11;
            this.lbldeptno.Text = "DeptNo";
            // 
            // txtdeptno
            // 
            this.txtdeptno.Location = new System.Drawing.Point(400, 299);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(100, 22);
            this.txtdeptno.TabIndex = 12;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(400, 240);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 13;
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(400, 194);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(100, 22);
            this.txtempname.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(519, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update With Sp";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteSp
            // 
            this.btnDeleteSp.Location = new System.Drawing.Point(646, 104);
            this.btnDeleteSp.Name = "btnDeleteSp";
            this.btnDeleteSp.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteSp.TabIndex = 16;
            this.btnDeleteSp.Text = "Delete With Sp";
            this.btnDeleteSp.UseVisualStyleBackColor = true;
            this.btnDeleteSp.Click += new System.EventHandler(this.btnDeleteSp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.btnDeleteSp);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtdeptno);
            this.Controls.Add(this.lbldeptno);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.btnSpInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnEmpDetails);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnEmpDetails;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSpInsert;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lbldeptno;
        private System.Windows.Forms.TextBox txtdeptno;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteSp;
    }
}


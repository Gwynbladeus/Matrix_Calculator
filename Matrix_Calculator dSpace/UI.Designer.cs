namespace Matrix_Calculator
{
    partial class UI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.TextBox();
            this.textBoxDll = new System.Windows.Forms.TextBox();
            this.randomMatrixName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.randomCreation = new System.Windows.Forms.GroupBox();
            this.randomMatrixType = new System.Windows.Forms.ComboBox();
            this.createRandomMatrix = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Rows = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Columns = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.calcMatAddButton = new System.Windows.Forms.Button();
            this.addMatComboBox = new System.Windows.Forms.ComboBox();
            this.addMatComboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.calcMatMultButton = new System.Windows.Forms.Button();
            this.multMatComboBox2 = new System.Windows.Forms.ComboBox();
            this.multMatComboBox = new System.Windows.Forms.ComboBox();
            this.openResultMat = new System.Windows.Forms.CheckBox();
            this.matrixPow = new System.Windows.Forms.NumericUpDown();
            this.matrixForPowComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.calcPowButton = new System.Windows.Forms.Button();
            this.resultMatrixName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.useStrassen = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.openMatrixButton = new System.Windows.Forms.Button();
            this.openMatComboBox = new System.Windows.Forms.ComboBox();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.randomCreation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPow)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDir
            // 
            this.textBoxDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDir.Location = new System.Drawing.Point(147, 12);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(542, 21);
            this.textBoxDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrix Folder Location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(542, 65);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(246, 372);
            this.console.TabIndex = 3;
            // 
            // textBoxDll
            // 
            this.textBoxDll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDll.Location = new System.Drawing.Point(147, 39);
            this.textBoxDll.Name = "textBoxDll";
            this.textBoxDll.Size = new System.Drawing.Size(542, 21);
            this.textBoxDll.TabIndex = 4;
            // 
            // randomMatrixName
            // 
            this.randomMatrixName.Location = new System.Drawing.Point(57, 19);
            this.randomMatrixName.Name = "randomMatrixName";
            this.randomMatrixName.Size = new System.Drawing.Size(127, 20);
            this.randomMatrixName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Matrix Types dll";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Load.CausesValidation = false;
            this.Load.Location = new System.Drawing.Point(695, 12);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(93, 47);
            this.Load.TabIndex = 7;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // randomCreation
            // 
            this.randomCreation.Controls.Add(this.randomMatrixType);
            this.randomCreation.Controls.Add(this.createRandomMatrix);
            this.randomCreation.Controls.Add(this.label6);
            this.randomCreation.Controls.Add(this.Rows);
            this.randomCreation.Controls.Add(this.label5);
            this.randomCreation.Controls.Add(this.Columns);
            this.randomCreation.Controls.Add(this.label4);
            this.randomCreation.Controls.Add(this.label3);
            this.randomCreation.Controls.Add(this.randomMatrixName);
            this.randomCreation.Location = new System.Drawing.Point(15, 65);
            this.randomCreation.Name = "randomCreation";
            this.randomCreation.Size = new System.Drawing.Size(197, 128);
            this.randomCreation.TabIndex = 8;
            this.randomCreation.TabStop = false;
            this.randomCreation.Text = "New random matrix";
            // 
            // randomMatrixType
            // 
            this.randomMatrixType.FormattingEnabled = true;
            this.randomMatrixType.Location = new System.Drawing.Point(57, 72);
            this.randomMatrixType.Name = "randomMatrixType";
            this.randomMatrixType.Size = new System.Drawing.Size(127, 21);
            this.randomMatrixType.TabIndex = 16;
            // 
            // createRandomMatrix
            // 
            this.createRandomMatrix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.createRandomMatrix.Enabled = false;
            this.createRandomMatrix.Location = new System.Drawing.Point(12, 97);
            this.createRandomMatrix.Name = "createRandomMatrix";
            this.createRandomMatrix.Size = new System.Drawing.Size(172, 23);
            this.createRandomMatrix.TabIndex = 15;
            this.createRandomMatrix.Text = "Create";
            this.createRandomMatrix.UseVisualStyleBackColor = false;
            this.createRandomMatrix.Click += new System.EventHandler(this.CreateRandomMatrix_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rows
            // 
            this.Rows.Location = new System.Drawing.Point(132, 45);
            this.Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(52, 20);
            this.Rows.TabIndex = 12;
            this.Rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(115, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Columns
            // 
            this.Columns.Location = new System.Drawing.Point(57, 45);
            this.Columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(52, 20);
            this.Columns.TabIndex = 10;
            this.Columns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Size";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.calcMatAddButton);
            this.groupBox1.Controls.Add(this.addMatComboBox);
            this.groupBox1.Controls.Add(this.addMatComboBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.calcMatMultButton);
            this.groupBox1.Controls.Add(this.multMatComboBox2);
            this.groupBox1.Controls.Add(this.multMatComboBox);
            this.groupBox1.Controls.Add(this.openResultMat);
            this.groupBox1.Controls.Add(this.matrixPow);
            this.groupBox1.Controls.Add(this.matrixForPowComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.calcPowButton);
            this.groupBox1.Controls.Add(this.resultMatrixName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.useStrassen);
            this.groupBox1.Location = new System.Drawing.Point(218, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 181);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix operations";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(111, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "+";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcMatAddButton
            // 
            this.calcMatAddButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calcMatAddButton.Enabled = false;
            this.calcMatAddButton.Location = new System.Drawing.Point(233, 150);
            this.calcMatAddButton.Name = "calcMatAddButton";
            this.calcMatAddButton.Size = new System.Drawing.Size(75, 23);
            this.calcMatAddButton.TabIndex = 30;
            this.calcMatAddButton.Text = "Calculate";
            this.calcMatAddButton.UseVisualStyleBackColor = false;
            this.calcMatAddButton.Click += new System.EventHandler(this.CalcMatAddButton_Click);
            // 
            // addMatComboBox
            // 
            this.addMatComboBox.FormattingEnabled = true;
            this.addMatComboBox.Location = new System.Drawing.Point(3, 152);
            this.addMatComboBox.Name = "addMatComboBox";
            this.addMatComboBox.Size = new System.Drawing.Size(100, 21);
            this.addMatComboBox.TabIndex = 29;
            // 
            // addMatComboBox2
            // 
            this.addMatComboBox2.FormattingEnabled = true;
            this.addMatComboBox2.Location = new System.Drawing.Point(128, 152);
            this.addMatComboBox2.Name = "addMatComboBox2";
            this.addMatComboBox2.Size = new System.Drawing.Size(99, 21);
            this.addMatComboBox2.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcMatMultButton
            // 
            this.calcMatMultButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calcMatMultButton.Enabled = false;
            this.calcMatMultButton.Location = new System.Drawing.Point(233, 121);
            this.calcMatMultButton.Name = "calcMatMultButton";
            this.calcMatMultButton.Size = new System.Drawing.Size(75, 23);
            this.calcMatMultButton.TabIndex = 25;
            this.calcMatMultButton.Text = "Calculate";
            this.calcMatMultButton.UseVisualStyleBackColor = false;
            this.calcMatMultButton.Click += new System.EventHandler(this.CalcMatMultButton_Click);
            // 
            // multMatComboBox2
            // 
            this.multMatComboBox2.FormattingEnabled = true;
            this.multMatComboBox2.Location = new System.Drawing.Point(128, 123);
            this.multMatComboBox2.Name = "multMatComboBox2";
            this.multMatComboBox2.Size = new System.Drawing.Size(99, 21);
            this.multMatComboBox2.TabIndex = 17;
            // 
            // multMatComboBox
            // 
            this.multMatComboBox.FormattingEnabled = true;
            this.multMatComboBox.Location = new System.Drawing.Point(3, 123);
            this.multMatComboBox.Name = "multMatComboBox";
            this.multMatComboBox.Size = new System.Drawing.Size(100, 21);
            this.multMatComboBox.TabIndex = 18;
            // 
            // openResultMat
            // 
            this.openResultMat.AutoSize = true;
            this.openResultMat.Location = new System.Drawing.Point(6, 41);
            this.openResultMat.Name = "openResultMat";
            this.openResultMat.Size = new System.Drawing.Size(110, 17);
            this.openResultMat.TabIndex = 24;
            this.openResultMat.Text = "Open result matrix";
            this.openResultMat.UseVisualStyleBackColor = true;
            // 
            // matrixPow
            // 
            this.matrixPow.Location = new System.Drawing.Point(156, 97);
            this.matrixPow.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixPow.Name = "matrixPow";
            this.matrixPow.Size = new System.Drawing.Size(71, 20);
            this.matrixPow.TabIndex = 23;
            this.matrixPow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // matrixForPowComboBox
            // 
            this.matrixForPowComboBox.FormattingEnabled = true;
            this.matrixForPowComboBox.Location = new System.Drawing.Point(3, 96);
            this.matrixForPowComboBox.Name = "matrixForPowComboBox";
            this.matrixForPowComboBox.Size = new System.Drawing.Size(122, 21);
            this.matrixForPowComboBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "^";
            // 
            // calcPowButton
            // 
            this.calcPowButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calcPowButton.Enabled = false;
            this.calcPowButton.Location = new System.Drawing.Point(233, 94);
            this.calcPowButton.Name = "calcPowButton";
            this.calcPowButton.Size = new System.Drawing.Size(77, 23);
            this.calcPowButton.TabIndex = 21;
            this.calcPowButton.Text = "Caluclate power";
            this.calcPowButton.UseVisualStyleBackColor = false;
            this.calcPowButton.Click += new System.EventHandler(this.CalcPowButton_Click);
            // 
            // resultMatrixName
            // 
            this.resultMatrixName.Location = new System.Drawing.Point(80, 71);
            this.resultMatrixName.Name = "resultMatrixName";
            this.resultMatrixName.Size = new System.Drawing.Size(230, 20);
            this.resultMatrixName.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Result name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // useStrassen
            // 
            this.useStrassen.AutoSize = true;
            this.useStrassen.Location = new System.Drawing.Point(6, 18);
            this.useStrassen.Name = "useStrassen";
            this.useStrassen.Size = new System.Drawing.Size(196, 17);
            this.useStrassen.TabIndex = 18;
            this.useStrassen.Text = "Use StrassenAlorithm when possible";
            this.useStrassen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.useStrassen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteAllButton);
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.openMatrixButton);
            this.groupBox3.Controls.Add(this.openMatComboBox);
            this.groupBox3.Location = new System.Drawing.Point(218, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 77);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Open/Update Matrix";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(233, 48);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(152, 48);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 21);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // openMatrixButton
            // 
            this.openMatrixButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.openMatrixButton.Enabled = false;
            this.openMatrixButton.Location = new System.Drawing.Point(152, 21);
            this.openMatrixButton.Name = "openMatrixButton";
            this.openMatrixButton.Size = new System.Drawing.Size(156, 21);
            this.openMatrixButton.TabIndex = 1;
            this.openMatrixButton.Text = "Open/Create";
            this.openMatrixButton.UseVisualStyleBackColor = false;
            this.openMatrixButton.Click += new System.EventHandler(this.OpenMatrixButton_Click);
            // 
            // openMatComboBox
            // 
            this.openMatComboBox.FormattingEnabled = true;
            this.openMatComboBox.Location = new System.Drawing.Point(6, 21);
            this.openMatComboBox.Name = "openMatComboBox";
            this.openMatComboBox.Size = new System.Drawing.Size(140, 21);
            this.openMatComboBox.TabIndex = 0;
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteAllButton.Location = new System.Drawing.Point(6, 48);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(140, 21);
            this.deleteAllButton.TabIndex = 4;
            this.deleteAllButton.Text = "Delete all";
            this.deleteAllButton.UseVisualStyleBackColor = false;
            this.deleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.randomCreation);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDll);
            this.Controls.Add(this.console);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDir);
            this.Name = "UI";
            this.Text = "Form1";
            this.randomCreation.ResumeLayout(false);
            this.randomCreation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPow)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox randomMatrixName;
        private System.Windows.Forms.TextBox textBoxDll;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.GroupBox randomCreation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Columns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Rows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createRandomMatrix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox matrixForPowComboBox;
        private System.Windows.Forms.NumericUpDown matrixPow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calcPowButton;
        private System.Windows.Forms.TextBox resultMatrixName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox useStrassen;
        private System.Windows.Forms.Button calcMatMultButton;
        private System.Windows.Forms.ComboBox multMatComboBox2;
        private System.Windows.Forms.ComboBox multMatComboBox;
        private System.Windows.Forms.CheckBox openResultMat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox randomMatrixType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calcMatAddButton;
        private System.Windows.Forms.ComboBox addMatComboBox;
        private System.Windows.Forms.ComboBox addMatComboBox2;
        private System.Windows.Forms.Button openMatrixButton;
        private System.Windows.Forms.ComboBox openMatComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteAllButton;
    }
}


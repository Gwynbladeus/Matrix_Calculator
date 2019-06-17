using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace Matrix_Calculator
{
    public partial class UI : Form 
    {
        public MatrixManager Manager;
        public UI()
        {
            InitializeComponent();
            textBoxDir.AppendText(@"C:\Users\Agri Technika\source\repos\Matrix_Calculator dSpace\mat Dateien");
            textBoxDll.AppendText(@"C:\Users\Agri Technika\source\repos\MyMatrixTypes\bin\Debug\MyMatrixTypes.dll");
        }
        private void Load_Click(object sender, EventArgs e)
        {
            Manager = new MatrixManager(textBoxDir.Text, textBoxDll.Text, this);
            EnableButtons();
            UpdateComboBoxes();
            PrintMessage(Manager.PrintMatrixNames());
        }
        public void PrintMessage(String message)
        {
            console.AppendText(">" + message + "\r\n");
        }
        public void PrintError(String error)
        {
            console.AppendText("[ERROR]>" + error + "\r\n");
        }
        public void EnableButtons() {
            calcMatAddButton.Enabled = true;
            calcMatMultButton.Enabled = true;
            calcPowButton.Enabled = true;
            openMatrixButton.Enabled = true;
            updateButton.Enabled = true;
            createRandomMatrix.Enabled = true;
            deleteButton.Enabled = true;
        }
        private void UpdateComboBoxes()
        {
            randomMatrixType.Items.Clear();
            matrixForPowComboBox.Items.Clear();
            multMatComboBox.Items.Clear();
            multMatComboBox2.Items.Clear();
            addMatComboBox.Items.Clear();
            addMatComboBox2.Items.Clear();
            openMatComboBox.Items.Clear();
            foreach (String ringName in Manager.GetRingNames()) {
                randomMatrixType.Items.Add(ringName);
            }
            foreach (String matrixName in Manager.GetMatrixNames())
            {
                matrixForPowComboBox.Items.Add(matrixName);
                multMatComboBox.Items.Add(matrixName);
                multMatComboBox2.Items.Add(matrixName);
                addMatComboBox.Items.Add(matrixName);
                addMatComboBox2.Items.Add(matrixName);
                openMatComboBox.Items.Add(matrixName);
            }

        }

        private void CreateRandomMatrix_Click(object sender, EventArgs e)
        {
            String fileStr = textBoxDir.Text + @"\" + randomMatrixName.Text;
            int colStr = Convert.ToInt32(Columns.Value);
            int rowStr = Convert.ToInt32(Rows.Value);
            String matrixStr = Manager.RandomMatrix(randomMatrixName.Text, colStr, rowStr, randomMatrixType.Text).printMatrix();
            File.WriteAllText(fileStr, matrixStr);
            Manager.AddMatrix(fileStr);
            PrintMessage(Manager.PrintMatrixNames());
            UpdateComboBoxes();
        }
        enum Operation{ Mult, Pow, Add };

        private bool CalculationErrorCheck(Matrix mat1, Matrix mat2, Operation operation) {
            if (!resultMatrixName.Text.Equals(""))
            {
                if (mat1 != null && mat2 != null)
                {
                    switch (operation)
                    {
                        case Operation.Mult:
                            if (mat1.IsMultipliable(mat2)){
                                return false;
                            }
                            break;
                        case Operation.Pow:
                            if (mat1.IsSquare())
                            {
                                return false;
                            }
                            break;
                        case Operation.Add:
                            if (mat1.IsAddable(mat2)) {
                                return false;
                            }
                            break;
                    }
                    PrintError("Wrong dimensions");
                }
                else
                {
                    PrintError("Matrix could not be loaded");
                }               
            }
            else
            {
                PrintError("Result name can not be empty");
            }
            return true;
        }
        private void CalcPowButton_Click(object sender, EventArgs e)
        {
            CalculateOperation(Manager.GetMatrix(matrixForPowComboBox.Text), Manager.GetMatrix(matrixForPowComboBox.Text), Operation.Pow);
        }
        private void CalcMatMultButton_Click(object sender, EventArgs e)
        {
            CalculateOperation(Manager.GetMatrix(multMatComboBox.Text), Manager.GetMatrix(multMatComboBox2.Text), Operation.Mult);
        }

        private void CalcMatAddButton_Click(object sender, EventArgs e)
        {
            CalculateOperation(Manager.GetMatrix(addMatComboBox.Text), Manager.GetMatrix(addMatComboBox2.Text), Operation.Add);
        }
        private void CalculateOperation(Matrix mat1, Matrix mat2, Operation operation)
        {
            if (!CalculationErrorCheck(mat1, mat2, operation))
            {
                String resultStr = "";
                int pow = Convert.ToInt32(Math.Round(matrixPow.Value, 0));
                String fileStr = textBoxDir.Text + @"\" + resultMatrixName.Text;
                switch (operation)
                {
                    case Operation.Mult:
                        resultStr = Manager.MultMatrixTimes(mat1, mat2, resultMatrixName.Text, 2).printMatrix();
                        break;
                    case Operation.Pow:
                        resultStr = Manager.MultMatrixTimes(mat1, mat2, resultMatrixName.Text, pow).printMatrix();
                        break;
                    case Operation.Add:
                        resultStr = Manager.AdditionMatrix(mat1, mat2, resultMatrixName.Text).printMatrix();
                        break;
                }

                File.WriteAllText(fileStr, resultStr);
                Manager.AddMatrix(fileStr);
                PrintMessage(Manager.PrintMatrixNames());
                UpdateComboBoxes();
                if (openResultMat.Checked)
                {
                    OpenFile(fileStr);
                }

            }
        }
        private void OpenFile(String path)
        {
            Thread thread = new Thread(delegate ()
            {
                Process.Start(path);
            });
            thread.Start();
        }
        private void OpenMatrixButton_Click(object sender, EventArgs e)
        {
            String path = textBoxDir.Text + @"\" + openMatComboBox.Text;
            if (!File.Exists(path)) {
                File.WriteAllText(path, "");
            }
            OpenFile(path);
            PrintMessage("Opened " + Manager.GetFileNameFromPath(path) + "succesfully");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            String path = textBoxDir.Text + @"\" + openMatComboBox.Text;
            if (File.Exists(path))
            {
                Manager.UpdateMatrix(path);
                PrintMessage("Updated " + Manager.GetFileNameFromPath(path) + "succesfully");
                PrintMessage(Manager.PrintMatrixNames());
                UpdateComboBoxes();
            }
            else
            {
                PrintError("File does not exist.");
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String path = textBoxDir.Text + @"\" + openMatComboBox.Text;
            Manager.DeleteMatrixFile(path);
            Manager.RemoveMatrix(Manager.GetFileNameFromPath(path));
            PrintMessage(Manager.PrintMatrixNames());
            UpdateComboBoxes();
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            Manager.DeleteAllMatrices(textBoxDir.Text);
            PrintMessage(Manager.PrintMatrixNames());
            UpdateComboBoxes();
        }
    }
}

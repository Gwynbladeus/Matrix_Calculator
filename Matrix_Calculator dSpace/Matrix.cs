using MyMatrixTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Calculator
{
    public class Matrix
    {
        private Type Ringtype;
        private int rows, columns;
        private Ring[,] matrix;
        private String name;
        private String RingtypeStr;
        public Matrix(int columns, int rows, String name, Type ringtype) {
            Ringtype = ringtype;
            this.name = name;
            this.rows = rows;
            this.columns = columns;
            matrix = new Ring[columns,rows];
        }
        public Matrix(String[,] data,String name, Type ringtype) {
            Ringtype = ringtype;
            this.name = name;
            rows = data.GetLength(1);
            columns = data.GetLength(0);
            matrix = new Ring[columns, rows];
            FillMatrix(data);
            
        }
        public void FillMatrix(String[,] data) {
            for (int column = 0; column < columns; column++) {
                for (int row = 0; row < rows; row++) {
                    matrix[column, row] = (Ring)Activator.CreateInstance(Ringtype, data[column, row]);
                }
            }
            RingtypeStr = matrix[0, 0].GetName();
        }
        public Ring GetElem(int column, int row) {
            return matrix[column, row].Copy(); 
        }
        public void SetElem(int column, int row, Ring elem) {
            matrix[column, row] = elem;
        }
        public int GetRows() {
            return rows;
        }
        public int GetColumns() {
            return columns;
        }
        public Matrix MultStandard(Matrix matrix2, String resultMatrixName) {
            Matrix newMat = new Matrix(columns, matrix2.GetRows(), resultMatrixName, Ringtype);
            for(int column = 0; column < columns; column++)
            {
                for (int row = 0; row < matrix2.GetRows(); row++) {
                    Ring productsum = GetElem(column,0);
                    productsum.Multiply(matrix2.GetElem(0, row));
                    Ring temp;
                    for (int i = 1; i < rows; i++) {
                        temp = GetElem(column, i);
                        temp.Multiply(matrix2.GetElem(i, row));
                        productsum.Add(temp);
                    }
                    newMat.SetElem(column,row, productsum);
                }
            }
            return newMat;
        }
        /* TODO   
        public Matrix MultStrassen(Matrix Mat) {

         }
        */
        public Matrix Add(Matrix matrix2, String resultMatrixName) {
            Matrix newMat = new Matrix(columns, rows, resultMatrixName, Ringtype);
            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < matrix2.rows; row++)
                {
                    Ring elem = GetElem(column, row);
                    elem.Add(matrix2.GetElem(column, row));
                    newMat.SetElem(column, row, elem);
                }
            }
            return newMat;
        }
        public String printMatrix() {
            String[] matrixStr = new String[columns];
            for(int i = 0; i< columns; i++)
            {
                matrixStr[i] = "";
            }
            int columnMaxLength = 0;
            for (int row = 0; row < rows; row++) {
                
                for (int column = 0; column < columns; column++) {
                    if (row != 0)
                    {
                        matrixStr[column] = matrixStr[column] + " | ";
                    }
                    matrixStr[column] = matrixStr[column] + matrix[column, row].AsString();
                    if (matrixStr[column].Length > columnMaxLength) {
                        columnMaxLength = matrixStr[column].Length;
                    }
                }
                for(int i = 0; i < matrixStr.Length; i++) {
                    matrixStr[i] = matrixStr[i].PadRight(columnMaxLength);
                }                
            }
            String finalStr = "";
            finalStr = finalStr + matrix[0, 0].GetName() + "\r\n";
            finalStr = finalStr + GetColumns() + "x" + GetRows() + "\r\n";
            for (int i = 0; i < matrixStr.Length; i++) {
                finalStr = finalStr + matrixStr[i] + "\r\n";
            }
            return finalStr;
        }
        public bool IsSquare() {
            return(columns == rows);
        }
        public bool IsMultipliable(Matrix mat) {
            return (columns == mat.GetRows());
        }
        public bool IsAddable(Matrix mat) {
            return (columns == mat.GetColumns() && rows == mat.GetRows());
        }
        public Matrix CopyMatrix()
        {
            return (Matrix)this.MemberwiseClone();
        }
        public String GetName() {
            return name;
        }
        public Type GetRingType() {
            return Ringtype;
        }
        public String GetRingName() {
            return RingtypeStr;
        }
    }
    
}

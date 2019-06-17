using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MyMatrixTypes;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Matrix_Calculator
{
    public class MatrixManager
    {
        private List<Matrix> MatricesList;
        private List<Type> TypeList;
        private UI Ui;
        public MatrixManager(String dirPath, String dllPath, UI ui)
        {
            Ui = ui;
            InitAllTypes(dllPath);
            InitAllMatrices(dirPath);
        }

        private void InitAllMatrices(String path)
        {
            MatricesList = new List<Matrix>();
            String[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                AddMatrix(files[i]);
            }
        }
        public void AddMatrix(String path)
        {
            Matrix newMat = LoadMatrix(path);
            if (newMat != null)
            {
                if (GetMatrix(newMat.GetName()) != null) {
                    RemoveMatrix(newMat.GetName());
                }
                MatricesList.Add(newMat);
            }
            else {
                Ui.PrintError("Matrix " + (GetFileNameFromPath(path) + " kann nicht geladen werden"));
            }
        }
        public void RemoveMatrix(String name) {
            for (int index = 0; index < MatricesList.Count; index++)
            {
                if (MatricesList.ElementAt(index).GetName().Equals(name))
                {
                    MatricesList.RemoveAt(index);
                    Ui.PrintMessage("Deleted " + name + " succesfully from List");
                    return;
                }
            }
            Ui.PrintMessage("Deleted " + name + " succesfully from List");
        }
        public void DeleteMatrixFile(String path) {
            if (File.Exists(path))
            {
                File.Delete(path);
                Ui.PrintMessage("Deleted File" + path + " succesfully ");
            }
            else
            {
                Ui.PrintError("File does not exist.");
            }
        }
        public void DeleteAllMatrices(String dirPath)
        {
            String[] list = Directory.GetFiles(dirPath);
            for(int i = 0; i < list.Length; i++)
            {
                DeleteMatrixFile(list[i]);
                RemoveMatrix(GetFileNameFromPath(list[i]));
            }
        }
        public void UpdateMatrix(String path) {
            DeleteMatrixFile(path);
            RemoveMatrix(GetFileNameFromPath(path));
            AddMatrix(path);
        }
        public void InitAllTypes(String DllPath) {
            TypeList = new List<Type>();
            var dll = Assembly.LoadFile(DllPath);
            Type[] types = dll.GetTypes();
            foreach (Type type in types) {
                if (type.IsSubclassOf(typeof(Ring))) {
                    TypeList.Add(type);
                }
            }
        }
        public List<String> GetRingNames() {
            List<String> ringNames = new List<String>();
            foreach (Type type in TypeList) {
                Ring ring = ((Ring)Activator.CreateInstance(type));
                ringNames.Add(ring.GetName());
            }
            return ringNames;
        }
        public List<String> GetMatrixNames() {
            List<String> matNames = new List<String>();
            foreach (Matrix matrix in MatricesList)
            {
                
                matNames.Add(matrix.GetName());
            }
            return matNames;
        }
        private Type GetMatchingType(String ringname) {
            foreach(Type type in TypeList) {
                Ring ring = ((Ring)Activator.CreateInstance(type));
                if (ring.GetName().Equals(ringname)) {
                    return type;
                }
            }
            return null;
        }
        public Matrix LoadMatrix(String path)
        {
            try
            {
                String[] rawMatrixData = File.ReadAllLines(path);
                String matrixRingStr = rawMatrixData[0];
                Type matrixType = GetMatchingType(matrixRingStr);

                String[,] data = new String[int.Parse(rawMatrixData[1][0].ToString()), int.Parse(rawMatrixData[1][2].ToString())];
                for (int columns = 2; columns < data.GetLength(0) + 2; columns++)
                {
                    String[] fullColumn = rawMatrixData[columns].Split('|');
                    for (int rows = 0; rows < data.GetLength(1); rows++)
                    {
                        data[columns - 2, rows] = fullColumn[rows].Trim();
                    }
                }
                return new Matrix(data, GetFileNameFromPath(path), matrixType);
            }
            catch {
                return null;
            }
        }
        public String GetFileNameFromPath(String path)
        {
            String name = "";
            for (int i = path.Length - 1; i >= 0; i--)
            {
                if (!path.ElementAt(i).Equals('\\'))
                {
                    name = path.ElementAt(i) + name;
                }
                else {
                    return name;
                }
            }
            return name;
        }
        public Matrix GetMatrix(String name)
        {
            foreach (Matrix m in MatricesList)
            {
                if (name.Equals(m.GetName()))
                {
                    return m;
                }
            }
            return null;
        }
        public String PrintMatrixNames() {
            String names = "Available matrices:";
            foreach (Matrix m in MatricesList)
            {
                names =  "" + names + "\r\n" + m.GetName() + " (" + m.GetRingName() + ")";
            }
            return names;
        }
        public List<Matrix>GetMatrixList() {
            return MatricesList;
        }
        public Matrix RandomMatrix(String name, int columns, int rows, String typeStr)
        {
            Matrix random = new Matrix(columns, rows, name, GetMatchingType(typeStr));
            Ring ring = (Ring)Activator.CreateInstance(GetMatchingType(typeStr));
            Random rand = new Random();
            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < rows; row++) {
                    random.SetElem(column,row,ring.GetRandomElem(rand));
                }
            }
            return random;
        }
        public Matrix MultMatrixTimes(Matrix matrix1, Matrix matrix2, String resultName, int times) {
            Stopwatch watch = new Stopwatch();
            Matrix result = matrix1;
            watch.Start();
            while (times > 1) {
                result = MultMatrix(result, matrix2, resultName);
                times--;
            }
            watch.Stop();
            Ui.PrintMessage("Operation time: " + watch.ElapsedMilliseconds + "ms");
            return result;
        }
        public Matrix MultMatrix(Matrix matrix1, Matrix matrix2, String resultName)
        {
            Matrix result;
            result = matrix1.MultStandard(matrix2, resultName);
            return result;
        }
        public Matrix AdditionMatrix(Matrix matrix1, Matrix matrix2, String resultName)
        {
            Matrix result;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            result = matrix1.Add(matrix2, resultName);
            watch.Stop(); 
            Ui.PrintMessage("Operation time: " + watch.ElapsedMilliseconds + "ms");
            return result;
        }
    }
}

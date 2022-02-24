﻿using iProg1.Model;
using Spectre.Console;

namespace iProg1.Repositories
{
    public interface IMatrixRepository
    {
        int GetCount();
        void AddMatrix(Matrix matrix, int index);
        void UpdateMatrix(int indexOfMatrix, int iIndex, int jIndex, double value);
        bool Compare(int fstInd, int secInd);
        void OutputMatrix(int index);
        void OutputAllMatrix();
        void RemoveAllMatrix();
        void RemoveMatrix(int uindex);
        void PrintMinMaxAbsMatrixWithLinq();
        void PrintMinMaxAbsMatrix();
        ValidationResult IsIndexInRange(int index);
    }
}
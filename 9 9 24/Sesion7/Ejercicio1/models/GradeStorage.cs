using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.models
{
    internal class GradeStorage
    {

        private int[] grades = new int[10];
        public void AddElement(int grade, int index)
        {
            grades[index] = grade;
        }

        public int[] GetGrades()
        {
            return grades; 
        } 

    }
}

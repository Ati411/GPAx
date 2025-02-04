using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAx
{
    internal class GPACalculator
    {
        private double gpa_sum;
        private int n;
        private double gpa_max = double.MaxValue;
        private double gpa_min = double.MinValue;

        public void setGPA(double gpa)
        {
            this.gpa_sum += gpa;
            this.n++;

            if (gpa > this.gpa_max)
            {
                this.gpa_max = gpa;
            }

            if (gpa < this.gpa_min)
            {
                this.gpa_min = gpa;
            }
        }

        public double getMaxGPA()
        {
            return this.n == 0 ? 0 : this.gpa_max;
        }

        public double getMinGPA()
        {
            return this.n == 0 ? 0 : this.gpa_min;
        }

        public int getStudentCount()
        {
            return this.n;
        }
        public double getGPAX()
        {
            return this.n == 0 ? 0 : this.gpa_sum / this.n;
        }
    }
}

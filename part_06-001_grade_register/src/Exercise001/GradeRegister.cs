namespace Exercise001
{
    using System.Collections.Generic;
    using System;
    public class GradeRegister
    {
        private List<int> grades;
        private List<int> examPoints;

        public GradeRegister()
        {
            this.grades = new List<int>();
            this.examPoints = new List<int>();
        }

        public void AddGradeBasedOnPoints(int points)
        {
            this.grades.Add(PointsToGrades(points));
            this.examPoints.Add(points);
        }

        public int NumberOfGrades(int grade)
        {
            int count = 0;
            foreach (int received in this.grades)
            {
                if (received == grade)
                {
                    count++;
                }
            }
            return count;
        }

        public static int PointsToGrades(int points)
        {
            int grade = 0;
            if (points < 50)
            {
                grade = 0;
            }
            else if (points < 60)
            {
                grade = 1;
            }
            else if (points < 70)
            {
                grade = 2;
            }
            else if (points < 80)
            {
                grade = 3;
            }
            else if (points < 90)
            {
                grade = 4;
            }
            else
            {
                grade = 5;
            }
            return grade;
        }

        public double AverageOfGrades()
        {
            // Hint! You don't need to round the -1, but you do need it for all the other results...
            if (this.grades.Count == 0)
            {
                return -1;
            }
            else
            {
                int sum = 0;
                int count = 0;
                foreach (var item in this.grades)
                {
                    sum = sum + item;
                    count++;
                }
                double res = Convert.ToDouble(sum) / count;
                return Math.Round(res, 2);
            }




        }

        public double AverageOfPoints()
        {
            if (this.examPoints.Count == 0)
            {
                return -1;
            }
            else
            {
                int sum = 0;
                int count = 0;
                foreach (var item in this.examPoints)
                {
                    sum = sum + item;
                    count++;
                }
                double res = Convert.ToDouble(sum) / count;
                return Math.Round(res, 2);
            }

        }
    }
}
using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double oldTotalQualityScore = Gpa * NumberOfCredits;
            double newTotalQualityScore = oldTotalQualityScore + courseCredits * grade;

            NumberOfCredits += courseCredits;
            Gpa = newTotalQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits

            // This method returns the student’s level based on the number of credits they have earned:
            // Freshman(0 - 29 credits), Sophomore(30 - 59 credits), Junior(60 - 89 credits), or Senior(90 + credits).

            if (credits < 30)
            {
                return "Freshman";
            }
            if (credits < 60)
            {
                return "Sophomore";
            }
            if (credits < 90)
            {
                return "Junior";
            }
            return "Senior";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId);
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return "Name: " + Name + "\nStudent ID: " + StudentId + "\GPA: " + Gpa + "\nCredits: " + NumberOfCredits;
        }

    }
}

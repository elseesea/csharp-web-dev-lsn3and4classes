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

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            /*
             * This method accepts two parameters—a number of course credits and a numerical grade (0.0-4.0). With this data, you need to update the student’s GPA.

                5.5.2.1. GPA Information
                    GPA is computed via the formula:

                    gpa = (total quality score) / (total number of credits)
                    The quality score for a class is found by multiplying the letter grade score (0.0-4.0) by the number of credits.
                    The total quality score is the sum of the quality scores for all classes.
                    For example, if a student received an “A” (worth 4 points) in a 3-credit course and a “B” (worth 3 points) in a 4-credit course,
                    their total quality score would be: 4.0 * 3 + 3.0 * 4 = 24. Their GPA would then be 24 / 7 = 3.43.

                5.5.2.2. Determine the New GPA
                    To update the student’s GPA:

                    Calculate their current total quality score by using the formula gpa * numberOfCredits.
                    Use the new course grade and course credits to update their total quality score.
                    Update the student’s total numberOfCredits.
                    Compute their new GPA.
             */
            double oldTotalQualityScore = Gpa * NumberOfCredits;
            double newTotalQualityScore = oldTotalQualityScore + courseCredits * grade;

            Gpa = newTotalQualityScore / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
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

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

    }
}

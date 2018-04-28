using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create student variables
            string student_firstName;
            string student_lastName;
            string student_birthDate;
            string student_addressLine1;
            string student_addressLine2;
            string student_city;
            string student_state;
            int student_zipCode;
            string student_country;

            // create teacher variables
            string teacher_firstName;
            string teacher_lastName;
            string teacher_birthDate;
            string teacher_addressLine1;
            string teacher_addressLine2;
            string teacher_city;
            string teacher_state;
            int teacher_zipCode;
            string teacher_country;

            // create UProgram variables
            string programName;
            string departmetHead;
            int degrees;

            // create Degree variables
            string degreeName;
            float creditsRequired;

            // create Course variables
            string courseName;
            float credits;
            int duration;
            string teacher;


            // create student variables
            student_firstName = "max";
            student_lastName = "smith";
            student_birthDate = "april 1, 1999";
            student_addressLine1 = "2 Main Street";
            student_addressLine2 = "#2";
            student_city = "Providence";
            student_state = "RI";
            student_zipCode = 02906;
            student_country = "USA";

            // create teacher variables
            teacher_firstName = "Don";
            teacher_lastName = "Johnson";
            teacher_birthDate = "January 1, 1998";
            teacher_addressLine1 = "203 Plum Lane";
            teacher_addressLine2 = "NA";
            teacher_city = "Providence";
            teacher_state = "RI";
            teacher_zipCode = 02903;
            teacher_country = "USA";

            // create UProgram variables
            programName = "History";
            departmetHead = "Dr. Smith;
            degrees = 3;

            // create Degree variables
            degreeName "History";
            creditsRequired = "12.5";

            // create Course variables
            courseName = "History of Rhode Island";
            credits = 1.5;
            duration = 10;
            teacher = "Dr. Murph";

            // output to the console window
            Console.WriteLine("Student: ");
            Console.WriteLine(student_firstName);
            Console.WriteLine(student_lastName);
            Console.WriteLine(student_birthDate);
            Console.WriteLine(student_addressLine1);
            Console.WriteLine(student_addressLine2);
            Console.WriteLine(student_city);
            Console.WriteLine(student_state);
            Console.WriteLine(student_zipCode);
            Console.WriteLine(student_country);

            Console.WriteLine("Teacher: ");
            Console.WriteLine(teacher_firstName);
            Console.WriteLine(teacher_lastName);
            Console.WriteLine(teacher_birthDate);
            Console.WriteLine(teacher_addressLine1);
            Console.WriteLine(teacher_addressLine2);
            Console.WriteLine(teacher_city);
            Console.WriteLine(teacher_state);
            Console.WriteLine(teacher_zipCode);
            Console.WriteLine(teacher_country);

            Console.WriteLine("UProgram Info: ");
            Console.WriteLine(programName);
            Console.WriteLine(departmetHead);
            Console.WriteLine(degrees);

            Console.WriteLine("Degree Info: ");
            Console.WriteLine(degreeName);
            Console.WriteLine(creditsRequired;

            Console.WriteLine("Course Info: ");
            Console.WriteLine(courseName);
            Console.WriteLine(credits);
            Console.WriteLine(duration);
            Console.WriteLine(teacher);           


        }
    }
}
using System;
using System.IO;

namespace EnrollmentPaper
{
    internal class FillUp
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome! Do you want to enroll in our UNIVERSITY?");
                Console.WriteLine("=====================================================================");
                Console.WriteLine("Press (1) to Continue\nPress (2) to Exit");
                Console.WriteLine("=====================================================================");
                Console.Write("Enter your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                string[] courses = {"BS in Tourism",
                           "BS in Information Technology",
                           "BS in Hospitality Management",
                           "BS in Computer Science",
                           "BS in Nursing"};

                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("PLEASE FILL UP THIS FORM. THANK YOU!");
                    Console.WriteLine("=====================================================================");
                    Console.Write("Last Name: ");
                    string lastName = Convert.ToString(Console.ReadLine());

                    Console.Write("First Name: ");
                    string firstName = Convert.ToString(Console.ReadLine());

                    Console.Write("Middle Name: ");
                    string middleName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("=====================================================================");
                    Console.Clear();

                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("The Tuition Fee in every courses available has the minimum of 32000");
                    Console.WriteLine("=====================================================================");
                    Console.Write("Please Enter your Payment: ");
                    int fee = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("=====================================================================");
                    Console.Clear();

                    if (fee >= 32000)
                    {

                        Console.WriteLine("Welcome " + lastName + "," + " " + firstName + " " + middleName + " " + "!");
                        Console.WriteLine("=====================================================================");
                        Console.WriteLine("Choose your preferred course below!");
                        Console.WriteLine("=====================================================================");

                        for (int i = 0; i < courses.Length; i++)
                        {
                            Console.WriteLine($"Course {i + 1}: {courses[i]}");
                        }

                        Console.WriteLine("=====================================================================");
                        Console.Write("Enter your Chosen Course: ");
                        int chosenChoice = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Submit the following requirements below: File Name (Document Type)");
                        Console.WriteLine("=====================================================================");
                        Console.WriteLine("1. Good_Moral (xps)\n2. Form_137 (xps)\n3. PSA (xps)\n4. SHS_Diploma (xps)");
                        Console.WriteLine("=====================================================================");

                        string directorPath = @"C:\Users\ASUS\chan\Required Documents";

                        string[] fileToCheck = {
                                "FORM_137.xps",
                                "PSA.xps",
                                "GOOD_MORAL.xps",
                                "GRADES.xps",
                              };

                        bool ifSubmitted = true;

                        foreach (string fileName in fileToCheck)
                        {
                            string filePath = Path.Combine(directorPath, fileName);
                            if (File.Exists(filePath))
                            {
                                Console.WriteLine($"File {fileName} is submitted!");
                            }
                            else
                            {
                                Console.WriteLine($"File {fileName} is not submitted yet!");
                                Console.WriteLine("=====================================================================");
                                Console.WriteLine("Please submit the required files.");
                                ifSubmitted = false;
                                break;
                            }
                        }

                        if (ifSubmitted)
                        {
                            switch (chosenChoice)
                            {
                                case 1:
                                    Console.WriteLine("You are enrolled for " + courses[0] + "!");
                                    break;
                                case 2:
                                    Console.WriteLine("You are enrolled for " + courses[1] + "!");
                                    break;
                                case 3:
                                    Console.WriteLine("You are enrolled for " + courses[2] + "!");
                                    break;
                                case 4:
                                    Console.WriteLine("You are enrolled for " + courses[3] + "!");
                                    break;
                                case 5:
                                    Console.WriteLine("You are enrolled for " + courses[4] + "!");
                                    break;
                                default:
                                    Console.WriteLine("Your Choice is not available.");
                                    ifSubmitted = false;
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your payment is not enough or the submitted files are incomplete...");
                        }

                        Console.WriteLine("Thank you for Enrolling to our University!");
                        Console.WriteLine("Press enter to close...");
                        Console.ReadLine();
                    }
                }
            }                      
        }
    }
}

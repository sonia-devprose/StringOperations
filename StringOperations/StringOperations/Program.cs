using System;

namespace StringOperations
{

    class Program
    {
        static void Main(string[] args)
        {

            // Take the sentence as an input
            Console.WriteLine("Enter a sentence: ");

            // Split the sentence into array and delimiter is a space
            string sentence = Console.ReadLine();
            string[] word = sentence.Split();//Assuming every word in the sentence will be separated by a space


            // Iterate over each array element, foreach is used for traversing array elements
           
            foreach(string part in word)
            {


                Console.WriteLine(part);
            }

            // Reverse the array of words

            Array.Reverse(word);

            // Join the reversed words into a new sentence

            string reverseSentence = string.Join(" ", word);

            Console.WriteLine(reverseSentence);

            // Input phone number in the format 'XXX-XXX-XXXX' (commonly used in the US and Canada)

            Console.WriteLine("Enter the phone number: ");

            // Split the phone number into an array using the hyphen ('-') as the delimiter
            string[] phone = Console.ReadLine().Split("-");


            // Reformat the phone number into the format '(XXX) XXX-XXXX'

            foreach(string part in phone)
            {

                Console.WriteLine(part);
            }

            Console.WriteLine($"({phone[0]}) {phone[1]}-{phone[2]}");

            // Team members
            // Define an array of team members
            Console.WriteLine("Enter the name of family members as a string with comma: ");

            string[] teamMembers = Console.ReadLine().Split(", ");

            // Join the team members into a single string with an ampersand (&) as the separator

            string joinTeam = string.Join(" & ", teamMembers);

            // The separator " & " is used to make the list readable like "Alice & Bob & Charlie & David"



            // Output the formatted string of team members
            Console.WriteLine(joinTeam);

            // Output: "Alice & Bob & Charlie & David"



        }


    }


}

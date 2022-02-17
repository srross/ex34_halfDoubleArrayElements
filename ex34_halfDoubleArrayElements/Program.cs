// ********************************Do excercise 34;
/*  Description
 *  Create an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256. 
 *  Prompt the user to enter a command, 'half' or 'double'.  
 *  If the user enters 'half', half all the elements in the array.  
 *  If the user enters 'double', double all the elements in the array.
 *  If the user enters 'double', double all the elements in the array.
 */
var command = "";
var ynContinue = "y";

int[] intArray = new int[5] { 16, 32, 64, 128, 256 };

while (ynContinue == "y")
{
    // Prompt the user to enter a command, 'half' or 'double'.
    Console.Write("Please enter a comman 'half' or 'double': ");
    var userInput = Console.ReadLine(); // remember

    // If the user enters 'half', half all the elements in the array. 

    // If the user enters 'double', double all the elements in the array.




    //Console.Write("Please enter a number 0 - 4 for the index: ");
    //var isValidInteger = int.TryParse(Console.ReadLine(), out index);
    //if (isValidInteger) // validate is in range
    //{
    //    Console.Write($"The value at index {index} is {intArray[index]}. Would you like to change it (y/n)? ");
    //    ynChange = Console.ReadLine(); // remember to validate user input

    //    while (ynChange == "y")
    //    {
    //        Console.Write("Please enter replacement number for index {index}: ");
    //        var isValidInteger2 = int.TryParse(Console.ReadLine(), out replacementNumber);
    //        intArray[index] = replacementNumber;

    //        break;
    //    }

    //    Console.Write($"The value at index {index} is {intArray[index]}. Would you like to continue (y/n)? ");
    //    ynContinue = Console.ReadLine();
    //}

    //Console.WriteLine("Bye-bye!");
}

using _180322_ProblemSolving._01Dices;


#region 01Dice Run Game
//Static class using the play method
//RunDice.PlayDice();
#endregion

#region 02BinarySearch
//// TODO: Create new folder named 02BinarySearch for the BinarySearch exercise

////1.Create an array of chars.
//char[] arr = { 'a', 'b', 'c', 'd', 'x', 'y', 'z' };

////2.Create the method for binary searching.
////  Parameters: The array, The target to find, Arrays start position & Arrays end position. 
//static string BinarySearch(char[] arr, char target, int start, int end)
//{
//    if (start > end)
//    {
//        return "Target was not found.";
//    }

//    //3.Finding the middle of the arry by adding start plus end and then dividing them by 2.
//    //  Using Math.Floor to get a whole number ex. 7 / 2 = 3.5 -> 3.0.
//    int middle = (int)Math.Floor((double)(start + end) / 2);

//    //4.If array index(middle) equals the target, binary search finished!
//    //  char.ToUpperInvariant() to ignoring case.
//    if (char.ToUpperInvariant(arr[middle]) == char.ToUpperInvariant(target))
//    {
//        return $"Target {target} was found at index arr[{middle}].";
//    }

//    //5.If array index(middle) is greater than the target, redo the method and
//    //  set the end parameter to middle value minus 1.
//    if (char.ToUpperInvariant(arr[middle]) > char.ToUpperInvariant(target))
//    {
//        return BinarySearch(arr, target, start, middle - 1);
//    }

//    //6.If array index(middle) is lesser than the target, redo the method and
//    //  set the start parameter to middle value plus 1.
//    if (char.ToUpperInvariant(arr[middle]) < char.ToUpperInvariant(target))
//    {
//        return BinarySearch(arr, target, middle + 1, end);
//    }

//    //Just in case.
//    return "Error";
//}

////Print out the method with the values from your array.
//Console.WriteLine(BinarySearch(arr, 'z', 0, arr.Length - 1));
////Console.ReadKey();
#endregion

#region 03AnagramChecker
// TODO: Create new folder named 03AnagramChecker for the anagram exercise
/*
 Anagram ett ord eller en fras som man har fått fram genom att
 kasta om bokstäverna i ett annat ord, fras eller namn.
 */
string wordOne = "Henrik Schyffert", wordTwo = "Fin tysk herrchef";

//Removes the white spaces & convert to lower case.
string trimOne = String.Concat(wordOne.Where(c => !Char.IsWhiteSpace(c))).ToLower();
string trimTwo = String.Concat(wordTwo.Where(c => !Char.IsWhiteSpace(c))).ToLower();

//Sorts the characters from a -> z.
string orderOne = String.Concat(trimOne.OrderBy(c => c));
string orderTwo = String.Concat(trimTwo.OrderBy(c => c));

//Checks that the words have the same length.
if (orderOne.Length == orderTwo.Length)
{
    //Returns true if both words "are the same".
    bool isAnagram = orderOne == orderTwo;
    Console.WriteLine($"Are the two words {wordOne} and {wordTwo} an Anagram? {(isAnagram ? "Yes, yes it is." : "No it's not.")}");
}
else
{
    Console.WriteLine($"Are the two words {wordOne} and {wordTwo} an Anagram? No it's not.");
}
Console.ReadKey(true);
#endregion

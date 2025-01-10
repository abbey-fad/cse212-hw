public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Create a new array of size 'length' to store the multiples.
        // 2. Use a loop to calculate each multiple by multiplying the 'number' by the index + 1.
        // 3. Store each calculated multiple in the array.
        // 4. Return the array containing the multiples.

        // Initialize an array to hold the multiples
        double[] multiples = new double[length];

        // Loop through and calculate multiples
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1); // Calculate multiple and store in array
        }
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Ensure 'amount' is within the bounds of the list size using modulo.
        // 2. Slice the last 'amount' elements of the list.
        // 3. Remove the sliced elements from the original list.
        // 4. Insert the sliced elements at the front of the list.

        // Ensure 'amount' is within bounds of the list size.
        int rotationAmount = amount % data.Count;

        // Extract the last 'rotationAmount' elements.
        List<int> tail = data.GetRange(data.Count - rotationAmount, rotationAmount);

        // Remove the extracted elements from the original list.
        data.RemoveRange(data.Count - rotationAmount, rotationAmount);

        // Insert the extracted elements at the front of the list.
        data.InsertRange(0, tail);
    }
}

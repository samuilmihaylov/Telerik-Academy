using System;

class RemoveElementsFromArray
{
    static void Main()
    {
        // Input
        int arraySize = int.Parse(Console.ReadLine());
        var array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSeqLength = 0;

        // helper array storing sequence length for each element
        var helperArray = new int[arraySize]; 

        // For each EndPoint access each subsequence in the array. Set an EndPoint 0 to Length     
        for (int endPoint = 0; endPoint < array.Length; endPoint++)
        {
            maxSeqLength = 0;

            // For each start point then set a Start Point 0 to EndPoint                              
            for (int startPoint = 0; startPoint < endPoint; startPoint++)
            {
                // If current Start Point element is smaller than the at End Point they are members of the same sequence
                if (array[endPoint] >= array[startPoint])
                {
                    if (helperArray[startPoint] > maxSeqLength)  // if the length for the element before is 
                    {                                            // larger than the current MaxSequenceLength
                        maxSeqLength = helperArray[startPoint];  // Max equals the length for the current 
                    }                                            // element
                }                                                // The Element at End Point Belogs to that
            }                                                    // sequence

            // Longest existing sequence
            // the current EndPoint element belogs to plus the current element sequence of at least 1 elements
            helperArray[endPoint] = maxSeqLength + 1;
        }

        maxSeqLength = 0;

        // Find the Max
        for (int i = 0; i < arraySize; i++)
        {
            // Length stored in the helper array                      
            if (helperArray[i] > maxSeqLength)
            {
                maxSeqLength = helperArray[i];
            }
        }

        Console.WriteLine(arraySize - maxSeqLength);
    }
}
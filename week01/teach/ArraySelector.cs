public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4 };
        var l2 = new[] { 10, 20, 30,40 };
        var select = new[] { 1, 1, 2, 2, 1, 1, 2, 2 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 10, 20, 3, 4, 30, 40}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var result = new int[select.Length];
        var l1Idx = 0;
        var l2Idx = 0;
        for (var i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
                result[i] = list1[l1Idx++];
            else
                result[i] = list2[l2Idx++];
        }
    
        return result;
    
    }
}
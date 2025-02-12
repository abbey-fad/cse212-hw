public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
        {
            return; // Do nothing if the value already exists
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
    {
        return true; // Value found
    }
    else if (value < Data)
    {
        // Search in the left subtree
        return Left is not null && Left.Contains(value);
    }
    else
    {
        // Search in the right subtree
        return Right is not null && Right.Contains(value);
    }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
       // If the node is a leaf (has no children), height is 1
        if (Left is null && Right is null)
            return 1;

       // Recursively get the height of the left and right subtrees
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        // The height of the current node is 1 + the maximum height of its subtrees
        return 1 + Math.Max(leftHeight, rightHeight); 
    }
}
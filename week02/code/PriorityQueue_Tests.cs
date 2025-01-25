using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue adds items to the queue correctly.
    // Expected Result: Items are added to the queue in the order they are enqueued, regardless of priority.
    // Defect(s) Found: None.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 2);
        Assert.AreEqual("[Task1 (Pri:1), Task2 (Pri:2)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Dequeue removes the highest priority item.
    // Expected Result: The item with the highest priority is removed and returned.
    // Defect(s) Found: None.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 2);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Task2", result);
        Assert.AreEqual("[Task1 (Pri:1)]", priorityQueue.ToString());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Dequeue removes the item closest to the front if priorities are equal.
    // Expected Result: The first item with the highest priority is removed and returned.
    // Defect(s) Found: None.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 3);
        priorityQueue.Enqueue("Task2", 3);
        priorityQueue.Enqueue("Task3", 2);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Task1", result);
        Assert.AreEqual("[Task2 (Pri:3), Task3 (Pri:2)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Dequeue throws an exception if the queue is empty.
    // Expected Result: An InvalidOperationException is thrown.
    // Defect(s) Found: None.
    public void TestPriorityQueue_4()

    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }    
    // Scenario: Multiple operations (enqueue and dequeue) maintain correct queue behavior.
    // Expected Result: The queue processes items correctly based on priority and FIFO.
    // Defect(s) Found: None.
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 3);
        priorityQueue.Enqueue("Task3", 2);

        Assert.AreEqual("Task2", priorityQueue.Dequeue()); // Highest priority
        Assert.AreEqual("Task3", priorityQueue.Dequeue()); // Next highest priority
        Assert.AreEqual("Task1", priorityQueue.Dequeue()); // Lowest priority
    }
}
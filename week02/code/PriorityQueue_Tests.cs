using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with differents priorities
    // Expected Result: The item with Highest priority is dequeued
    // Defect(s) Found: Highiest priority item was not always selected
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low",1);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("High", 10);

        var result = pq.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario:Multiple items with same priority
    // Expected Result: Fist inserted item is dequeued
    // Defect(s) The last inserted item was returned 
    public void TestPriorityQueue_2()
    {
        
         var pq = new PriorityQueue();
        pq.Enqueue("First",10);
        pq.Enqueue("Seconf", 10);
        pq.Enqueue("Third", 5);

        var result = pq.Dequeue();

        Assert.AreEqual("First", result);
    }

    // Add more test cases as needed below.
     [TestMethod]
    // Scenario: Dequeue removes items from queue
    // Expected Result: Second dequeue returns nexxt highest priority
    // Defect(s) Found: item was not removed from queue
      public void TestPriorityQueue_3()
    {
        
         var pq = new PriorityQueue();
        pq.Enqueue("A",1);
        pq.Enqueue("B", 5);
       
        var result = pq.Dequeue();


        Assert.AreEqual("B", result);
    }

      [TestMethod]
    // Scenario: Dequeue on empty queue
    // Expected Result: error message saying the queue is empty
    // Defect(s) Found: 
    public void TestPriorityQueue_4()
    {
        
        var pq = new PriorityQueue();
      
        var ex = Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
         } 
    

}
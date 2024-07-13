using System;

public class LinkedListNode
{
    public int data;
    public LinkedListNode next;

    public LinkedListNode(int value)
    {
        data = value;
        next = null;
    }
}
class Program
{
    static void Main(string[] args)
    {
        LinkedListNode head = new LinkedListNode(1);
        Console.WriteLine(head.data);
    }
}
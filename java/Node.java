public class Node {
    int data;
    Node next;

    public Node(int value) {
        data = value;
        next = null;
    }

    public static void main(String[] args) {
        Node head = new Node(1);
        System.out.println(head.data);
    }
}

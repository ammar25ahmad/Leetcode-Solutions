public class MyLinkedList {
    // Definition for the singly linked list node
    private class Node {
        public int Val;
        public Node Next;
        public Node(int val) {
            this.Val = val;
            this.Next = null;
        }
    }

    private Node dummyHead;
    private int size;

    /** Initializes the MyLinkedList object. */
    public MyLinkedList() {
        dummyHead = new Node(-1);
        size = 0;
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index) {
        if (index < 0 || index >= size) {
            return -1;
        }
        
        Node curr = dummyHead.Next;
        for (int i = 0; i < index; i++) {
            curr = curr.Next;
        }
        return curr.Val;
    }
    
    /** Add a node of value val before the first element of the linked list. */
    public void AddAtHead(int val) {
        AddAtIndex(0, val);
    }
    
    /** Append a node of value val as the last element of the linked list. */
    public void AddAtTail(int val) {
        AddAtIndex(size, val);
    }
    
    /** Add a node of value val before the index-th node. 
        If index equals the length of the linked list, the node will be appended to the end. 
        If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val) {
        if (index > size) {
            return;
        }
        if (index < 0) {
            index = 0;
        }
        
        Node prev = dummyHead;
        for (int i = 0; i < index; i++) {
            prev = prev.Next;
        }
        
        Node newNode = new Node(val);
        newNode.Next = prev.Next;
        prev.Next = newNode;
        size++;
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= size) {
            return;
        }
        
        Node prev = dummyHead;
        for (int i = 0; i < index; i++) {
            prev = prev.Next;
        }
        
        prev.Next = prev.Next.Next;
        size--;
    }
}

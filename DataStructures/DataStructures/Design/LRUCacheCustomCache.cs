using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Design
{
    class LRUCacheCustomCache
    {
        private Dictionary<int, DLinkedNode> cache = new Dictionary<int, DLinkedNode>();
        private int size;
        private int capacity;
        private DLinkedNode head, tail;

        public LRUCacheCustomCache(int capacity)
        {
            this.size = 0;
            this.capacity = capacity;

            head = new DLinkedNode();
            // head.prev = null;

            tail = new DLinkedNode();
            // tail.next = null;

            head.next = tail;
            tail.prev = head;
        }

        public int Get(int key)
        {
            DLinkedNode node = null;
            if (cache.ContainsKey(key))
                node = cache[key];
            if (node == null) return -1;

            // move the accessed node to the head;
            moveToHead(node);

            return node.value;
        }

        public void Put(int key, int value)
        {
            DLinkedNode node = null;
            if (cache.ContainsKey(key))
                node = cache[key];

            if (node == null)
            {
                DLinkedNode newNode = new DLinkedNode();
                newNode.key = key;
                newNode.value = value;

                cache.Add(key, newNode);
                addNode(newNode);

                ++size;

                if (size > capacity)
                {
                    // pop the tail
                    DLinkedNode tail = popTail();
                    cache.Remove(tail.key);
                    --size;
                }
            }
            else
            {
                // update the value.
                node.value = value;
                moveToHead(node);
            }
        }

        private void addNode(DLinkedNode node)
        {
            /**
             * Always add the new node right after head.
             */
            node.prev = head;
            node.next = head.next;

            head.next.prev = node;
            head.next = node;
        }

        private void removeNode(DLinkedNode node)
        {
            /**
             * Remove an existing node from the linked list.
             */
            DLinkedNode prev = node.prev;
            DLinkedNode next = node.next;

            prev.next = next;
            next.prev = prev;
        }


        private void moveToHead(DLinkedNode node)
        {
            /**
             * Move certain node in between to the head.
             */
            removeNode(node);
            addNode(node);
        }

        private DLinkedNode popTail()
        {
            /**
             * Pop the current tail.
             */
            DLinkedNode res = tail.prev;
            removeNode(res);
            return res;
        }
    }

    public class DLinkedNode
    {
        public int key;
        public int value;
        public DLinkedNode prev;
        public DLinkedNode next;

    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */


}


//public class LRUCache
//{

//    class DLinkedNode
//    {
//        int key;
//        int value;
//        DLinkedNode prev;
//        DLinkedNode next;
//    }

//    private void addNode(DLinkedNode node)
//    {
//        /**
//         * Always add the new node right after head.
//         */
//        node.prev = head;
//        node.next = head.next;

//        head.next.prev = node;
//        head.next = node;
//    }

//    private void removeNode(DLinkedNode node)
//    {
//        /**
//         * Remove an existing node from the linked list.
//         */
//        DLinkedNode prev = node.prev;
//        DLinkedNode next = node.next;

//        prev.next = next;
//        next.prev = prev;
//    }

//    private void moveToHead(DLinkedNode node)
//    {
//        /**
//         * Move certain node in between to the head.
//         */
//        removeNode(node);
//        addNode(node);
//    }

//    private DLinkedNode popTail()
//    {
//        /**
//         * Pop the current tail.
//         */
//        DLinkedNode res = tail.prev;
//        removeNode(res);
//        return res;
//    }

//    private Map<Integer, DLinkedNode> cache = new HashMap<>();
//    private int size;
//    private int capacity;
//    private DLinkedNode head, tail;

//    public LRUCache(int capacity)
//    {
//        this.size = 0;
//        this.capacity = capacity;

//        head = new DLinkedNode();
//        // head.prev = null;

//        tail = new DLinkedNode();
//        // tail.next = null;

//        head.next = tail;
//        tail.prev = head;
//    }

//    public int get(int key)
//    {
//        DLinkedNode node = cache.get(key);
//        if (node == null) return -1;

//        // move the accessed node to the head;
//        moveToHead(node);

//        return node.value;
//    }

//    public void put(int key, int value)
//    {
//        DLinkedNode node = cache.get(key);

//        if (node == null)
//        {
//            DLinkedNode newNode = new DLinkedNode();
//            newNode.key = key;
//            newNode.value = value;

//            cache.put(key, newNode);
//            addNode(newNode);

//            ++size;

//            if (size > capacity)
//            {
//                // pop the tail
//                DLinkedNode tail = popTail();
//                cache.remove(tail.key);
//                --size;
//            }
//        }
//        else
//        {
//            // update the value.
//            node.value = value;
//            moveToHead(node);
//        }
//    }
//}
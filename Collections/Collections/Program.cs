using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            

            //Value Type Array
            int[] valuetype = new int[3];

            //Reference Type Array
            string[] referencetype = new string[3];

            //Array of Objects
            Object[] objecttype = new Object[20];
            //Initialize the objects
            for (int i = 0; i < 20; i++)
                objecttype[i] = new Object();

            //JaggedArray
            int[][] jaggedarray = new int[3][];
            jaggedarray[0] = new int[4];
            jaggedarray[1] = new int[6];
            jaggedarray[2] = new int[3];

            //**********Non-Generic Collections*****************

            // Arraylist
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            //HashTable - Stores only Unique Key
            Hashtable ht = new Hashtable();
            ht.Add("txt", "notepad.exe");
            ht.Add("bmp", "paint.exe");
            ht.Add("dib", "paint.exe");
            ht.Add("rtf", "wordpad.exe");
            ht["add"] = "doc.exe";  //add the key value pair if not present
            if (!ht.ContainsKey("rtf"))
                ht.Add("rtf", "wordpad.exe");
            // To get the values alone, use the Values property.
            ICollection valueColl = ht.Values;
            // To get the keys alone, use the Keys property.
            ICollection keyColl = ht.Keys;
            ht.Remove("rtf");

            //Queue - FIFO - SEQUENTIAL PROCESSING
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            // Sorted List 
            SortedList mySL = new SortedList();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");

            //Stack - LIFO 
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");
            PrintValues(myStack);


            //*********GenericCollections***********************
            //Type Safe, Secure, reduced overhead of type conversions.

            //List<T> - Resizable - Slower than Array - Values Can be inserted at the middle - Faster compared to ArrayList
            List<string> list = new List<string>();
            list.Add("Second");
            list.Insert(0, "First");
            Console.WriteLine("\nCapacity: {0}", list.Capacity);
            Console.WriteLine("Count: {0}", list.Count);
            bool check = list.Contains("First");
            list.Remove("First");
            list.TrimExcess();
            list.Clear();

            List<Object> Objectlist = new List<Object>();
            Object obj = new Object();
            obj.FirstName = "Chandru";
            obj.LastName = "Vellingiri";
            Objectlist.Add(obj);

            //The HashSet< T > - List with no duplicate members - Perform Set Operations - Union/Intersection/IsSubsetOf - Cannot use indices with a HashSet, only enumerators.

            //Queue<T> - FIFO
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");
            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            // Create a copy of the queue, using the ToArray method and the 
            // constructor that accepts an IEnumerable<T>.
            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            // LinkedList<T> 
            string[] words = { "the", "fox", "jumped", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);

            //SortedDictionary and SortedList - Both uses Binary Search Algorithm  - SD has faster insertion and removal operations
            //SortedDictionary<string, string>
            //SortedList<string, string>

            //Stack<T> - LIFO




        }

        public class Object
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
    
}

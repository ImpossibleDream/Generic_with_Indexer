using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{

    //Generic with Indexer version-2
    public class myGenericIndexer<T>
    {
        //public static int size=9;
        //private T[] songName = new T[size+1];
        public int size;
        private T[] songName;
        public myGenericIndexer(int size)
        {
            this.size = size;
            songName = new T[size+1];
        }

        public T this[int index]
        {
            get
            {
                T tmp;
                if (index >= 0 && index <= size - 1)
                    tmp = songName[index];
                else
                    Console.WriteLine ("error");
                return songName[index];
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                    songName[index] = value;
            }
        }
    }

    class generic_with_index
    {
        static void Main(string[] args)
        {
            //myGenericIndexer<string> stringArray = new myGenericIndexer<string>();
            myGenericIndexer<string> stringArray = new myGenericIndexer<string>(9);
            //for (int i=0;i<myGenericIndexer<string>.size;i++)
            for (int i=0;i<stringArray.size;i++)
            {
                stringArray[i] = ":)-";
            }
            stringArray[0] = "It's";
            stringArray[1] = "okay";
            stringArray[2] = "not";
            stringArray[3] = "to";
            stringArray[4] = "be";
            stringArray[5] = "alright.  ";
            //for (int i=0;i< myGenericIndexer<string>.size;i++)
            for (int i=0;i<stringArray.size;i++)
            {
                Console.Write(stringArray[i]+" ");
            }
            Console.WriteLine("\nEverything is gonna be alright.");
            //Console.ReadKey();
        }
    }

}

/*
    //Generic
    /*public class myGeneric<T>
    {
        private T[] array;
        public myGeneric(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
*/
/*
    //Generic with Indexer version-1
    public class myGenericIndexer<T>
    {
        public static int size=9;
        private T[] songName = new T[size+1];

        public T this[int index]
        {
            get
            {
                T tmp;
                if (index >= 0 && index <= size - 1)
                    tmp = songName[index];
                else
                    Console.WriteLine("error");
                return songName[index];
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                    songName[index] = value;
            }
        }
    }

    class generic_with_index
    {
        static void Main(string[] args)
        {
            myGenericIndexer<string> stringArray = new myGenericIndexer<string>();
            for (int i=0;i<myGenericIndexer<string>.size;i++)
            {
                stringArray[i] = ":)-";
            }
            stringArray[0] = "It's";
            stringArray[1] = "okay";
            stringArray[2] = "not";
            stringArray[3] = "to";
            stringArray[4] = "be";
            stringArray[5] = "alright.  ";
            for (int i=0;i< myGenericIndexer<string>.size;i++)
            {
                Console.Write(stringArray[i] + " ");
            }
            Console.WriteLine("\nEverything is gonna be alright.");
            //Console.ReadKey();
        }
    }
*/

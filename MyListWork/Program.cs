using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Meslek", "Elektronik Mühendisliği");
            myDictionary.Add("Meslek", "Bigisayar Mühendisliği");
            myDictionary.Add("Meslek", "Makine Mühendisliği");
            myDictionary.Add("Meslek", "Mekatronik Mühendisliği");
            myDictionary.WriteDictionary();

        }
    }
}


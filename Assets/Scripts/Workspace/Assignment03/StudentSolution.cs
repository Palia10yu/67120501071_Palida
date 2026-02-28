using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AssignmentSystem.Services;
using NUnit.Framework;
using Unity.VisualScripting.YamlDotNet.Core.Tokens;
using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment03
{
    public class StudentSolutions : MonoBehaviour, IAssignment
    {
        #region Lecture

        public void LCT01_SyntaxLinkedList()
        {
            // 1. สร้าง LinkedList ของประเภท string
            LinkedList<string> linkedList = new LinkedList<string>();

            // 2. เพิ่มข้อมูลที่ท้ายของ LinkedList
            linkedList.AddLast("Node 1");
            linkedList.AddLast("Node 2");

            // 3. เพิ่มข้อมูลที่ต้นของ LinkedList
            linkedList.AddFirst("Node 0");

            // 4. แสดงเนื้อหาใน LinkedList
            LCT01_PrintLinkedList(linkedList);

            // 5. เช้าถึงข้อมูลใน LinkedList
            LinkedListNode<string> firstNode = linkedList.First;
            Debug.Log("first", firstNode.Value);
            LinkedListNode<string> lastNode = linkedList.Last;
            Debug.Log("last", lastNode.Value);
            LinkedListNode<string> node1 = linkedList.Find("Node 1");
            Debug.Log(node1.Previous.Value);
            Debug.Log(node1.Next.Value);
            if (firstNode.Previous == null)
            {
                Debug.Log("firstNode.Previous is null");
            }
            if (lastNode.Next == null)
            {
                Debug.Log("lastNode.Next is null");
            }

            // 6. add node ก่อน หรือ หลัง node ที่กำหนด
            linkedList.AddAfter(node1, "Node 1.5");
            linkedList.AddBefore(node1, "Node 0.5");
            LCT01_PrintLinkedList(linkedList);

            // 6. ลบ Node แรก
            linkedList.RemoveFirst();
            LCT01_PrintLinkedList(linkedList);

            // 7. ลบ Node ตามค่าที่กำหนด
            linkedList.Remove("Node 2");
            LCT01_PrintLinkedList(linkedList);
        }

        private void LCT01_PrintLinkedList(LinkedList<string> linkedList)
        {
            Debug.Log("LinkedList...");
            foreach (var node in linkedList)
            {
                Debug.Log(node);
            }
        }

        public void LCT02_SyntaxHashTable()
        {

            Hashtable hashtable = new Hashtable();
            //Key Value
            hashtable.Add(1, "Apple");
            hashtable.Add(2, "Banana");
            hashtable.Add("bad-fruit", "Rotten Tomato");

            string fruit1 = (string)hashtable[1];
            string fruit2 = (string)hashtable[2];
            string badFruit = (string)hashtable["bad-fruit"];

            Debug.Log($"fruit1: {fruit1}");
            Debug.Log($"fruit2: {fruit2}");
            Debug.Log($"badFruit: {badFruit}");

            LCT02_PrintHashTable(hashtable);

            int key = 2;
            if (hashtable.ContainsKey(key))
            {
                Debug.Log($"found {key}");
            }
            else
            {
                Debug.Log($"not found {key}");
            }

            int keyToRemove = 1;
            hashtable.Remove(keyToRemove);
            LCT02_PrintHashTable(hashtable);
        }
        public void LCT02_PrintHashTable(Hashtable hashtable)
        {
            Debug.Log("table ...");
            foreach (DictionaryEntry entry in hashtable)
            {
                Debug.Log($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        public void LCT03_SyntaxDictionary()
        {
            Dictionary<int, String> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary[3] = "Cherry";
            LCT03_Prindictionary(dictionary);

            int keyTocheck = 1;
            bool hasKey = dictionary.ContainsKey(keyTocheck);
            Debug.Log($"has key {keyTocheck} : {hasKey}");
            if (hasKey)
            {
                string value = dictionary[keyTocheck];
                Debug.Log($"value of key {keyTocheck} : {value}");
            }

            Debug.Log("All keys in dictionary:");
            foreach (int key in dictionary.Keys)
            {
                Debug.Log(key);
            }

            int keyToRemove = 1;
            dictionary.Remove(keyToRemove);
            LCT03_Prindictionary(dictionary);

            dictionary.Clear();
        }

        private void LCT03_Prindictionary(Dictionary<int, String> dictionary)
        {
            Debug.Log($"Dictionary has {dictionary.Count} keys");
            foreach (KeyValuePair<int, string> entry in dictionary)
            {
                Debug.Log($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
        #endregion

        #region Assignment

        public void AS01_CountWords(string[] words)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                if (dictionary.ContainsKey(currentWord))
                {
                    dictionary[currentWord]++;
                }
                else
                {
                    dictionary.Add(currentWord, 1);
                }
            }

            string[] keysArray = dictionary.Keys.ToArray();
            int[] valuesArray = dictionary.Values.ToArray();

            for (int i = 0; i < keysArray.Length; i++)
            {
                Debug.Log($"word: '{keysArray[i]}' count: {valuesArray[i]}");
            }
        }

        public void AS02_CountNumber(int[] numbers)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentnum = numbers[i];

                if (dictionary.ContainsKey(currentnum))
                {
                    dictionary[currentnum]++;
                }
                else
                {
                    dictionary.Add(currentnum, 1);
                }
            }

            int[] keysArray = dictionary.Keys.ToArray();
            int[] valuesArray = dictionary.Values.ToArray();

            for (int i = 0; i < keysArray.Length; i++)
            {
                Debug.Log($"number: {keysArray[i]} count: {valuesArray[i]}");
            }
        }

        public void AS03_CheckValidBrackets(string input)
        {
            Dictionary<char, char> dictionary = new Dictionary<char, char>();
            dictionary.Add('(', ')');
            dictionary.Add('[', ']');
            dictionary.Add('{', '}');

            LinkedList<char> stack = new LinkedList<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (dictionary.ContainsKey(currentChar))
                {
                    stack.AddLast(currentChar);
                }
                else if (dictionary.ContainsValue(currentChar))
                {
                    if (stack.Count == 0)
                    {
                        Debug.Log("Invalid");
                        return;
                    }

                    char lastOpenBracket = stack.Last.Value;
                    if (dictionary[lastOpenBracket] == currentChar)
                    {
                        stack.RemoveLast();
                    }
                    else
                    {
                        Debug.Log("Invalid");
                        return;
                    }
                }
            }

            if (stack.Count == 0)
            {
                Debug.Log("Valid");
            }
            else
            {
                Debug.Log("Invalid");
            }
        }

        public void AS04_PrintReverseLinkedList(LinkedList<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Debug.Log("List is empty");
                return;
            }

            LinkedListNode<int> currentNode = list.Last;

            while (currentNode != null)
            {
                Debug.Log(currentNode.Value);
                currentNode = currentNode.Previous;
            }
        }

        public void AS05_FindMiddleElement(LinkedList<string> list)
        {
            if (list == null || list.Count == 0)
            {
                Debug.Log("List is empty");
                return;
            }

            LinkedListNode<string> slow = list.First;
            LinkedListNode<string> fast = list.First;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            Debug.Log(slow.Value);
        }

        public void AS06_MergeDictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            Dictionary<string, int> mergedDict = new Dictionary<string, int>(dict1);

            foreach (KeyValuePair<string, int> kvp in dict2)
            {
                if (mergedDict.ContainsKey(kvp.Key))
                {
                    mergedDict[kvp.Key] += kvp.Value;
                }
                else
                {
                    mergedDict.Add(kvp.Key, kvp.Value);
                }
            }

            foreach (KeyValuePair<string, int> kvp in mergedDict)
            {
                Debug.Log($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }

        public void AS07_RemoveDuplicatesFromLinkedList(LinkedList<int> list)
        {
            if (list == null)
            {
                return;
            }

            if (list.Count > 1)
            {
                Dictionary<int, bool> check = new Dictionary<int, bool>();
                LinkedListNode<int> currentNode = list.First;

                while (currentNode != null)
                {
                    LinkedListNode<int> nextNode = currentNode.Next;

                    if (check.ContainsKey(currentNode.Value))
                    {
                        list.Remove(currentNode);
                    }
                    else
                    {
                        check.Add(currentNode.Value, true);
                    }

                    currentNode = nextNode;
                }
            }

            foreach (int item in list)
            {
                Debug.Log(item);
            }
        }

        public void AS08_TopFrequentNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Debug.Log("Input array is empty");
                return;
            }

            Dictionary<int, int> countDict = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (countDict.ContainsKey(currentNumber))
                {
                    countDict[currentNumber]++;
                }
                else
                {
                    countDict.Add(currentNumber, 1);
                }
            }

            int topNumber = 0;
            int maxCount = 0;

            foreach (KeyValuePair<int, int> kvp in countDict)
            {
                if (kvp.Value > maxCount)
                {
                    maxCount = kvp.Value;
                    topNumber = kvp.Key;
                }
            }

            Debug.Log($"{topNumber} count: {maxCount}");
        }

        public void AS09_PlayerInventory(Dictionary<string, int> inventory, string itemName, int quantity)
        {
            if (inventory == null)
            {
                Debug.Log("Inventory is null");
                return;
            }

            if (inventory.ContainsKey(itemName))
            {
                inventory[itemName] += quantity;
            }
            else
            {
                inventory.Add(itemName, quantity);
            }

            foreach (KeyValuePair<string, int> item in inventory)
            {
                Debug.Log($"{item.Key}: {item.Value}");
            }
        }

        #endregion

        #region Extra

        public void EX01_GameEventQueue(LinkedList<GameEvent> eventQueue)
        {
            throw new System.NotImplementedException();
        }

        public void EX02_PlayerStatsTracker(Dictionary<string, int> playerStats, string statName, int value)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
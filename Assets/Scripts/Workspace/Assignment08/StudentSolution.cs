using System;
using System.Collections.Generic;
using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment08
{
    public class StudentSolution : IAssignment
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public void LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Debug.Log($"Count: {stack.Count}");

            var popped = stack.Pop();
            Debug.Log($"Popped: {popped}");

            var top = stack.Peek();
            Debug.Log($"Peek: {top}");
            Debug.Log($"Count after peek: {stack.Count}");

            stack.Clear();
        }

        public void LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Debug.Log($"Count: {queue.Count}");

            var dequeueed = queue.Dequeue();
            Debug.Log($"Dequeue: {dequeueed}");

            var front = queue.Peek();
            Debug.Log($"Peek: {front}");
            Debug.Log($"Count after dequeue: {queue.Count}");
        }

        public void LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Stack<Action> actionStack = new Stack<Action>();
            actionStack.Push(action1);
            actionStack.Push(action2);
            actionStack.Push(action3);
            while (actionStack.Count > 0)
            {
                var action = actionStack.Pop();
                Debug.Log($"Executing {action.Name}");
            }
        }

        public void LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Queue<Action> actionQueue = new Queue<Action>();
            actionQueue.Enqueue(action1);
            actionQueue.Enqueue(action2);
            actionQueue.Enqueue(action3);
            while (actionQueue.Count > 0)
            {
                var action = actionQueue.Dequeue();
                Debug.Log($"Executing {action.Name}");
            }
        }

        #endregion

        #region Assignment

        public void ASN01_ReverseString(string str)
        {
            Stack<string> strings = new Stack<string>();

            for (int i = 0; i < str.Length; i++)
            {
                strings.Push(str[i].ToString());
            }
            string reversedStr = "";

            while (strings.Count > 0)
            {
                reversedStr += strings.Pop();
            }
            Debug.Log(reversedStr);
        }

        public void ASN02_StackPalindrome(string str)
        {
            Stack<string> strings = new Stack<string>();

            for (int i = 0; i < str.Length; i++)
            {
                strings.Push(str[i].ToString());
            }
            string reversedStr = "";

            while (strings.Count > 0)
            {
                reversedStr += strings.Pop();
            }

            if (str == reversedStr)
            {
                Debug.Log("is a palindrome");
            }
            else
            {
                Debug.Log("is not a palindrome");
            }
        }

        #endregion

        #region Extra

        public void EX01_ParenthesesChecker(string str)
        {
            Stack<char> chars = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c == '(' || c == '[' || c == '{')
                {
                    chars.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (chars.Count == 0)
                    {
                        Debug.Log("Unbalanced");
                        return; 
                    }
                    char top = chars.Pop();
                    bool isMatch = (c == ')' && top == '(') ||(c == ']' && top == '[') ||(c == '}' && top == '{');
                    
                    if (!isMatch)
                    {
                        Debug.Log("Unbalanced");
                        return;
                    }
                }
            }

            if (chars.Count == 0)
            {
                Debug.Log("Balanced");
            }
            else
            {
                Debug.Log("Unbalanced");
            }
        }

        #endregion
    }
}

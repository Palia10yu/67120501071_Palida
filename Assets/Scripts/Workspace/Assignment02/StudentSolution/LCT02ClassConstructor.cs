using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;


// SKIP Lecture ...
namespace Assignment02.StudentSolution.LCT02
{
    public class Dog
    {
        // properties including name, breed, age ...

        public string name;
        public string breed;
        public int age;

        // end of properties ...

        // ���ҧ constructor ����Ѻ parameter 3 ��� ��С�˹�������Ѻ properties �ͧ class
        // �·�� 3 parameter ��� name, breed, age ����ӴѺ
        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
             
        }

        /// behaviors ...

        public void Bark()
        {
            Debug.Log($"{name} is barking");
        }

        public void WagTail()
        {
            Debug.Log($"{name} is wagging tail");
        }

        public void StopBarking()
        {
            Debug.Log($"{name} stopped barking");
        }

        // end of behaviors ...
    }

    public class LCT02ClassConstructor
    {
        Dog dog1;

        public void Start()
        {
            // ���ҧ object dog1 �ͧ class Dog ���� constructor ����Ѻ parameter 3 ���
            // ��С�˹�������Ѻ properties �ͧ object ���
            // ��˹���� name = "Buddy", breed = "Golden Retriever", age = 3

            // Student code starts HERE ...
            // ...
            dog1 = new Dog("Buddy", "Samoyed", 1);
            // ...
            // Student code ends HERE ...

            // ���¡�� method �ͧ object ���

            dog1.Bark();
            dog1.WagTail();
            dog1.StopBarking();
        }
    }
}

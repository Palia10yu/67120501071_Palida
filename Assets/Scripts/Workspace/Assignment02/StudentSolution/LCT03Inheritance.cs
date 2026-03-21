using System.Globalization;
using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment02.StudentSolution.LCT03
{
    public class Animal
    {
        public string name;

        public void MakeSound()
        {
            Debug.Log($"Animal {name} is making sound");
        }
    }

    // class Dog inherits from Animal
    public class Dog: Animal
    {
        public void walkig()
        {
            Debug.Log($"Dog {name} is walking");
        }
    }

    // class Bird inherits from Animal
    public class Bird: Animal
    {
        public void flying()
        {
            Debug.Log($"Bird {name} is flying");
        }
    }

    public class LCT03Inheritance
    {

        public void Start()
        {
            // 1. ���ҧ instance �ͧ class Dog �¡�˹����͵������� dog
            // + ��˹����� (name) ��� "Buddy"
            // + ���¡�� method MakeSound() �ͧ dog
            // + ���¡�� method Walk() �ͧ dog
            Dog dog = new Dog();
            dog.name = "Buddy";
            dog.MakeSound();
            dog.walkig();

            // 2. ���ҧ instance �ͧ class Bird �¡�˹����͵������� bird
            // + ��˹����� (name) ��� "Twitty"
            // + ���¡�� method MakeSound() �ͧ bird
            // + ���¡�� method Fly() �ͧ bird
            Bird bird = new();
            bird.name = "Twitty";
            bird.MakeSound();
            bird.flying();

        }
    }
}

using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment02.StudentSolution.LCT04
{
    public class Animal
    {
        /// <summary>
        /// name �� public �֧����ö��Ҷ֧��ҡ��¹͡ class
        /// ����֧���� method �ͧ class ����׺�ʹ Animal 仴���
        /// </summary>
        public string name = "";

        /// <summary>
        /// specie �� protected �֧����ö��Ҷ֧��ҡ���� class ����׺�ʹ Animal
        /// �ҡ����͡Ẻ��� �з�����á�˹�������Ѻ specie �е�ͧ�Ӽ�ҹ class ����׺�ʹ Animal ��ҹ��
        /// �蹼�ҹ constructor �ͧ Dog ���͡�˹���� specie = "Dog"
        /// �������ö��˹�������Ѻ specie �ҡ��¹͡ class ��
        /// </summary>
        public string specie = "";

        /// <summary>
        /// health �� private �֧����ö��Ҷ֧��੾������ class ��� (Animal) ��ҹ��
        /// </summary>
        private int health = 10;

        public void Feed(int food)
        {
            health += food;
            Debug.Log($"{name} got {food} food");
        }

        /// <summary>
        /// MakeSound method �� Debug.Log ��ͤ����͡�Ҵ������͹�
        /// + ��� health > 50 �о���� "{name} happy!"
        /// + ��� health <= 50 �о���� "{name} weak!"
        /// </summary>
        public void MakeSound()
        {
            if (health > 50)
            {
                Debug.Log($"{name} happy!");
            }
            else
            {
                Debug.Log($"{name} weak!");
            }
        }
    }

    public class Dog : Animal
    {
        
        public Dog(string name)
        {
            // 1. ��˹� specie = "Dog"
            // ����ö��Ҷ֧ specie �����ͧ�ҡ specie �� protected
            // ���������ö��Ҷ֧��ҡ class ����׺�ʹ Animal ��
            this.specie = "Dog";

            // 2. �ӹ� this.name = name ����Ѻ�� parameter �ҡ constructor
            // ����ö��Ҷ֧ name �����ͧ�ҡ name �� public 
            // ���������ö��Ҷ֧��ҡ class ����� ���ͧ�ҡ class ����׺�ʹ Animal
            this.name = name;

            // �������ö��Ҷ֧ health �����ͧ�ҡ health �� private
            // �������ҹ����� class ����С�� health �����ҹ�� ��觡��� class Animal
            // this.health = 100; ==> COMPILE ERROR
        }
    }

    public class LCT04AccessModifier
    {
        public void Start()
        {
            Dog dog = new Dog("Buddy");

            // student code start HERE ...
            // 1. ����� dog.name �͡��㹢�ͤ��� $"my name is {dog.name}"
            // ...
            Debug.Log($"my name is {dog.name}");

            // student code ends HERE

            // NOTE #1
            // ���������ö��Ҷ֧ specie �����ͧ�ҡ specie �� protected
            // �֧���¡��ҹ��੾������ class ��ҹ��
            // �������ö��Ҷ֧��ҹ object ������ҧ�ҡ class ����׺�ʹ Animal ��
            // Debug.Log($"I am {dog.specie}");

            // NOTE #2
            // �������ö��Ҷ֧ health �����ͧ�ҡ health �� private �ͧ class Animal
            // ����� class ��� �ͧ Dog ������ͧ�ҡ�� private 
            // ����� health �֧���١�׺�ʹ����ҷ�� class Dog ��
            // �������ö���¡��ҹ����� health �ҡ dog ��
            // Debug.Log($"my health {dog.health}");

            dog.MakeSound();

            dog.Feed(50);

            dog.MakeSound();
        }
    }
}

using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment02.StudentSolution.LCT01
{
    public class Car
    {
        public void Move()
        {
            Debug.Log("Car is moving");
        }

        public void Turn()
        {
            Debug.Log("Car is turning");
        }

        public void Honk()
        {
            Debug.Log("Car is honking");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...
            Car myCar = new Car();
            
            myCar.Move();
            myCar.Turn();
            myCar.Honk();
            // Student code ends HERE 
        }
    }
}

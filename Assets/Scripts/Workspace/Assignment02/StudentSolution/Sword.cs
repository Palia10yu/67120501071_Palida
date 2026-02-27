using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Sword : Weapon
    {
        public int bladeLength;

        public void Slash()
        {
            
        }

        public override void Equip(Player player)
        {
            
        }

        public override void DealDamage(Entity Targat)
        {
            base.DealDamage(Targat);
        }
    }
}

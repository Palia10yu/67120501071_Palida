using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Staff : Weapon
    {
        public int magicPower;

        public void CastSpell()
        {
            
        }

        public override void Equip(Player player)
        {
            base.Equip(player);
        }
        public override void DealDamage(Entity Targat)
        {
            base.DealDamage(Targat);
        }
    }
}

using UnityEngine;

namespace Solution
{

    public class OOPWall : Identity
    {
        public int Damage;
        public bool IsIceWall;

        private void SetUP()
        {
            IsIceWall = Random.Range(0, 100) < 20 ? true : false;
            if (IsIceWall)
            {
                GetComponent<SpriteRenderer>().color = Color.blue;
            }
        }
        public override void Hit(Identity hitby)
        {
            base.Hit(hitby);
            if (hitby is OOPPlayer)
            {
                OOPPlayer p = hitby as OOPPlayer;
                p.TakeDamage(Damage);
                Debug.Log("Hit Wall");
            }
        }
    }
}
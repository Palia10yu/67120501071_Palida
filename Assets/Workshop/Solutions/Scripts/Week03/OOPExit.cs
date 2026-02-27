using UnityEngine;

namespace Solution
{
    public class OOPExit : Identity
    {
        public GameObject YouWin;
       public override void Hit(Identity hitby)
        {
            base.Hit(hitby);
            if (hitby is OOPPlayer)
            {
                mapGenerator.UpdatePositionIdentity(hitby,positionX,positionY);
                YouWin.gameObject.SetActive(true);
                hitby.enabled = false;
            }
        }
    }
}
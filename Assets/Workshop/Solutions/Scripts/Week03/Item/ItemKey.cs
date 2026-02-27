using UnityEngine;

namespace Solution
{
    [CreateAssetMenu(fileName = "ItemKey", menuName = "Item/ItemKey")]
    public class ItemKey : ItemData
    {
        public override void Use(Identity identity)
        {
            base.Use(identity);
            {
                base.Use(identity);
                OOPPlayer p = identity as OOPPlayer;
                Debug.Log("You got " + ItemName);
            }
        }
    }
}

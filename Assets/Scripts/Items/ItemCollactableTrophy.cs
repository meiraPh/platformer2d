using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableTrophy : ItemCollactableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddTrophy();
    }
}

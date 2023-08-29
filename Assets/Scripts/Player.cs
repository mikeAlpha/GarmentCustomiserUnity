using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private BoneCombiner _boneCombiner;
    public InventoryItem TestItem;

    void Start()
    {
        _boneCombiner = new BoneCombiner(this.gameObject);
        _boneCombiner.AddLimb(TestItem.DisplayObject, TestItem.boneNames);
    }

    public void Play()
    {
        GetComponent<Animator>().Play("Anim");
    }
}

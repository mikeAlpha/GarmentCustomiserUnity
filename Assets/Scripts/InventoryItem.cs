using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Assets/ClothItem")]
public class InventoryItem : ScriptableObject {
    public GameObject DisplayObject;
    public List<string> boneNames = new List<string>();

    private void OnValidate()
    {
        boneNames.Clear();

        if (DisplayObject.GetComponent<SkinnedMeshRenderer>() == null)
            return;

        var renderer = DisplayObject.GetComponent<SkinnedMeshRenderer>();
        var bones = renderer.bones;

        for(int i = 0; i < bones.Length; i++)
        {
            boneNames.Add(bones[i].name);
        }
    }
}

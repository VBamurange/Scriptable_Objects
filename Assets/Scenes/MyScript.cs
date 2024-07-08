using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewScriptableObject", menuName = "ScriptableObject/MyScript")]
public class MyScript : ScriptableObject
{
    public string name;
    public Texture pic;
}

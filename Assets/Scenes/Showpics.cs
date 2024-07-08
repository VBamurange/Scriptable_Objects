using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Showpics : MonoBehaviour
{
    public MyScript x;
    public RawImage obj_icon;
        
    public TMP_Text titleText;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPics()
    {
        obj_icon.texture = x.pic;
        titleText.text = x.name;
    }
}

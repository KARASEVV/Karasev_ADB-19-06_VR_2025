using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Touchch : MonoBehaviour
{
    public TMP_Text label;
    public int hp;
    void Start()
    {
        hp = 10;
        label.text = "HP: "+hp;
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Cube"){
            hp--;
            label.text = "HP: "+hp;
        }
    }
}

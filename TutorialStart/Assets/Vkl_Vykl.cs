using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vkl_Vykl : MonoBehaviour
{
    public GameObject Sphere;
    public TMP_Text label;
    void Start()
    {
        Sphere.SetActive(false);
    }
    public void Switch()
    {
        Sphere.SetActive(!Sphere.activeSelf);
        if(Sphere.activeSelf){
            label.text = "Включен";
        }
        else{
            label.text = "Выключен";
        }
    }
}

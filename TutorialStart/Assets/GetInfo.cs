using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class GetInfo : MonoBehaviour
{
    public string adress;
    public TMP_Text label;
    void Start()
    {
        StartCoroutine(GetRequest(adress));
    }
    IEnumerator GetRequest(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url)){
            yield return webRequest.SendWebRequest();
            if(webRequest.isNetworkError){
                print("Error" + webRequest.error);
            }
            else{
                print(webRequest.downloadHandler.text);
                label.text = webRequest.downloadHandler.text;
            }
        }
    }
}

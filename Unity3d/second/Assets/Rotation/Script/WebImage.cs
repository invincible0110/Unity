using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebImage : MonoBehaviour
{
    public RawImage webimage;

 
    void Start()
    {
        StartCoroutine(GetTexture(webimage));
    }

    IEnumerator GetTexture(RawImage rImage)
    {
        string url = "https://cdn.pixabay.com/photo/2016/11/29/13/14/full-moon-1869760_960_720.jpg";
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);

        yield return www.SendWebRequest();

        if(www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error); 
        }
        else
        {
            webimage.texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
        }
    }
}

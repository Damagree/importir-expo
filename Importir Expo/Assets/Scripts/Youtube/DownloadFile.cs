using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class DownloadFile : MonoBehaviour
{
    public void Get(string url, Action<string> onError, Action<string> onSuccess)
    {
        StartCoroutine(CoroutineGet(url, onError, onSuccess));
    }

    IEnumerator CoroutineGet(string url, Action<string> onError, Action<string> onSuccess)
    {
        using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(url))
        {
            yield return unityWebRequest.SendWebRequest();

            if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError)
            {
                onError(unityWebRequest.error);
            }
            else if (unityWebRequest.result == UnityWebRequest.Result.Success)
            {
                onSuccess(unityWebRequest.downloadHandler.text);
            }

            unityWebRequest.Dispose();
        }
    }
}

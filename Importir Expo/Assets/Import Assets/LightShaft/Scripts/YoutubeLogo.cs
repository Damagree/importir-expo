using UnityEngine;

public class YoutubeLogo : MonoBehaviour
{

    public string youtubeurl;

    private void OnMouseDown()
    {
        Application.OpenURL(youtubeurl);
    }

}

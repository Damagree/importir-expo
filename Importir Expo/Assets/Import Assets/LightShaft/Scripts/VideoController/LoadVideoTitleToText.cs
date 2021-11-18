using LightShaft.Scripts;
using UnityEngine;

public class LoadVideoTitleToText : MonoBehaviour
{

    public TextMesh textMesh;
    public YoutubePlayer player;

    public void SetVideoTitle()
    {
        textMesh.text = player.GetVideoTitle();
    }

}

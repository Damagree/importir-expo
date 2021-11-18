using LightShaft.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;

public class VideoProgressBar : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    public YoutubePlayer player;


    public void OnDrag(PointerEventData eventData)
    {
        player.TrySkip(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        player.TrySkip(eventData);
    }

}
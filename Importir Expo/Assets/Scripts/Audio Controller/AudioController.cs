using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float startVolume = 1f;
    [SerializeField] private AudioSource audioSource;

    private void Start()
    {
        audioSource.volume = startVolume;
        slider.value = audioSource.volume;
    }

    public void SetVolume()
    {
        audioSource.volume = slider.value;
    }
}

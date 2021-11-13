using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private AudioSource audioSource;

    private void Start()
    {
        slider.value = audioSource.volume;
    }

    public void SetVolume()
    {
        audioSource.volume = slider.value;
    }
}

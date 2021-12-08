using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    [SerializeField] bool pauseFromStart = false;
    [SerializeField] GameObject pauseMenuUi;
    [SerializeField] UnityEvent pauseFromStartEvent;
    [SerializeField] UnityEvent resumeEvent;
    [SerializeField] UnityEvent pauseEvent;

    private void Start()
    {
        if (pauseFromStart)
        {
            Pause();
            pauseFromStartEvent.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        resumeEvent.Invoke();
    }

    void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        pauseEvent.Invoke();
    }
}

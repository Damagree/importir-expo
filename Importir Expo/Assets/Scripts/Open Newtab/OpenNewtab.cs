using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(DownloadFile))]
public class OpenNewtab : MonoBehaviour
{

    [SerializeField] bool isChangeable = false;

    [Header("Changeable"), Space(5)]
    [SerializeField, TextArea(3, 4)] string csvUrl;
    [SerializeField] List<LinkFromCsv> listOfLink;
    [SerializeField] Button[] buttons;
    [SerializeField] DownloadFile downloadFile;


    [Header("Not Changeable"), Space(5)]
    [SerializeField] string url = "";

    private void Awake()
    {
        if (isChangeable)
        {
            downloadFile = GetComponent<DownloadFile>();

            downloadFile.Get(csvUrl, (string error) =>
            {
                Debug.Log("ERROR: " + error);
            }, (string text) =>
            {
                Debug.Log("Received: " + text);
                CsvToUrl(text);
                for (int i = 0; i < listOfLink.Count; i++)
                {
                    for (int j = 0; j < buttons.Length; j++)
                    {
                        if (buttons[j].gameObject.name == listOfLink[i].id)
                        {
                            url = listOfLink[i].url;
                            buttons[j].onClick.AddListener(OpenDefaultNewtab);
                        }
                    }
                }
            });
        }
        
    }

    public void OpenDefaultNewtab()
    {
#if !UNITY_EDITOR
		openWindow(url);
#endif
#if UNITY_EDITOR
        Debug.Log("Opening new tab: " + url);
#endif
    }

    public void CsvToUrl(string csvText)
    {
        string[] lines = csvText.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            if (i + 1 < lines.Length)
            {
                LinkFromCsv newLink = new LinkFromCsv();
                string[] data = lines[i + 1].Split(',');
                newLink.id = data[0];
                newLink.url = data[1];
                listOfLink.Add(newLink);
            }
        }
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);
}

using System.Runtime.InteropServices;
using UnityEngine;

public class LinkWhatsApp : MonoBehaviour
{

    public void WA1()
    {
#if !UNITY_EDITOR
		OpenNewTab("https://wa.me/6281312239464");
#endif
    }

    public void WA2()
    {
#if !UNITY_EDITOR
		OpenNewTab("");
#endif
    }

    public void WA3()
    {
#if !UNITY_EDITOR
		OpenNewTab("");
#endif
    }

    public void WA4()
    {
#if !UNITY_EDITOR
		OpenNewTab("");
#endif
    }

    public void WA5()
    {
#if !UNITY_EDITOR
		OpenNewTab("");
#endif
    }

    public void WA6()
    {
#if !UNITY_EDITOR
		OpenNewTab("");
#endif
    }

    public void WA7()
    {
#if !UNITY_EDITOR
		OpenNewTab("");
#endif
    }

    public void WA8()
    {
#if !UNITY_EDITOR
		OpenNewTab("");
#endif
    }

    public void WA9()
    {
#if !UNITY_EDITOR
		OpenNewTab("");
#endif
    }

    public void WA10()
    {
#if !UNITY_EDITOR
		OpenNewTab("");
#endif
    }


    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);
}

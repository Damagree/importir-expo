﻿using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class LinkWhatsApp : MonoBehaviour
{

    public void WA1()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/6281312239464");
		#endif
	}

       public void WA2()
	{
		#if !UNITY_EDITOR
		openWindow("");
		#endif
	}

       public void WA3()
	{
		#if !UNITY_EDITOR
		openWindow("");
		#endif
	}

       public void WA4()
	{
		#if !UNITY_EDITOR
		openWindow("");
		#endif
	}

       public void WA5()
	{
		#if !UNITY_EDITOR
		openWindow("");
		#endif
	}

       public void WA6()
	{
		#if !UNITY_EDITOR
		openWindow("");
		#endif
	}

       public void WA7()
	{
		#if !UNITY_EDITOR
		openWindow("");
		#endif
	}

       public void WA8()
	{
		#if !UNITY_EDITOR
		openWindow("");
		#endif
	}

       public void WA9()
	{
		#if !UNITY_EDITOR
		openWindow("");
		#endif
	}

       public void WA10()
	{
		#if !UNITY_EDITOR
		openWindow("");
		#endif
	}
    

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}

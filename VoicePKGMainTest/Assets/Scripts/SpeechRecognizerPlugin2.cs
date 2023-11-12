using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechRecognizerPlugin2 : MonoBehaviour
{
    private AndroidJavaObject speechRecognizerFragment = null;
    private AndroidJavaObject speechRecognizerFragmentInstance = null;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start VOICEPKG");
        speechRecognizerFragment = new AndroidJavaObject("com.example.speechrecognizerplugin.SpeechRecognizerFragment");
        speechRecognizerFragment.CallStatic("SetUp", this.gameObject.name);
        //speechRecognizerFragmentInstance = speechRecognizerFragment.GetStatic<AndroidJavaObject>("instance");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

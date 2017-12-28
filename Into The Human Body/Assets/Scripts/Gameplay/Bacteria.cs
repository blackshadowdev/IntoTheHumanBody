using UnityEngine;
using System.Collections;

public class Bacteria : Target
{
    public GameObject _focusMarker0;
    public GameObject _focusMarker1;
    public GameObject _focusMarker2;
    public bool isDestroyed = false;
    public bool isEnabled = false;
    public AnimatorControlScript controller;
    public AudioManager audio_manager;
    public bool isPing1 = false;
    public bool isPing2 = false;
    public bool isPing3 = false;
    public bool isPing4 = false;

    public void Start()
    {
       // _focusMarker0 = transform.Find("Focus Marker").gameObject;
       // _focusMarker1 = transform.Find("Focus Marker1").gameObject;
       // _focusMarker2 = transform.Find("Focus Marker2").gameObject;

    }
    private void Update()
    {

    }
    public override string GetTargetType()
    {
        return "bacteria";
    }

    public override void OnLookStart()
    {

    }

    public override void OnLookUpdate()
    {

    }

    public override void OnLookEnd()
    {

    }

    public void EnableFocusMarker0()
    {
        _focusMarker0.SetActive(true);
    }

    public void EnableFocusMarker1()
    {
        _focusMarker1.SetActive(true);
    }

    public void DisableFocusMarker2()
    {
        _focusMarker2.SetActive(true);
    }


    public void OnDisable()
    {
        isDestroyed = true;

       /* if (isPing1 == true)
        {
            audio_manager.Ping_1();
        }

        if (isPing2 == true)
        {
            audio_manager.Ping_2();
        }

        if (isPing3 == true)
        {
            audio_manager.Ping_3();
        }

        if (isPing4 == true)
        {
            audio_manager.Ping_4();
        }*/
    }

}

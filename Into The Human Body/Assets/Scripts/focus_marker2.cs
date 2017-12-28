using UnityEngine;
using System.Collections;

public class focus_marker2 : MonoBehaviour
{
    public AudioManager audio_manager;
    public AnimatorControlScript controller;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnEnable()
    {
        Debug.Log("Enabled focus marker2");
       

    }

    public void OnDisable()
    {
        audio_manager.NarrativeTwelve();
        controller.anim.SetTrigger("InfectionComplete");

    }
}

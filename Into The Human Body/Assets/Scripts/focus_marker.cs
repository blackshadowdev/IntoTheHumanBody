using UnityEngine;
using System.Collections;

public class focus_marker : MonoBehaviour
{
    public AudioManager audio_manager;

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
        Debug.Log("Enabled focus marker");
        audio_manager.NarrativeSeven();

        

    }

   /* public void OnDisable()
    {
        Debug.Log("Enabled focus marker");
    }*/
}

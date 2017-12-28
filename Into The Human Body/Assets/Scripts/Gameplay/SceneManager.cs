using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
    public WhiteBloodCell[] wbc;
    public AnimatorControlScript controller;
    public Bacteria[] bacteria;
    public AudioManager audio_manager;


    public bool isPlaying = false;
    public bool isDestroyedAll = false;
    public bool isDestroyed = false;
    
    public float speed;
    int count;
    int index = 0;
    float timer;
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        isPlaying = true;
        speed = 2.0f;
        count = bacteria.Length;
        //   StartCoroutine(Narration1());
        timer = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isReached == true)
        {
            wbc[0].EnableFocusMarker_0();
            if (wbc[0].isLookActivated == true )
            {
                
                wbc[0].DisableFocusMarker_0();
                bacteria[0].EnableFocusMarker0();
                wbc[0].MoveAndEat();
                
                StartCoroutine(OnTriggerEnter(bacteria[0].GetComponent<Collider>()));
            }
            
            if(bacteria[0].isDestroyed == true )
            {
                wbc[1].EnableFocusMarker_1();
                if (wbc[1].isLookActivated == true)
                {

                    wbc[1].DisableFocusMarker_1();
                    bacteria[1].EnableFocusMarker1();
                    wbc[1].MoveAndEat();

                    StartCoroutine(OnTriggerEnter(bacteria[1].GetComponent<Collider>()));
                }
            }

            if (bacteria[1].isDestroyed == true)
            {
                wbc[2].EnableFocusMarker_2();
                if (wbc[2].isLookActivated == true)
                {

                    wbc[2].DisableFocusMarker_2();
                    bacteria[2].DisableFocusMarker2();
                    wbc[2].MoveAndEat();

                    StartCoroutine(OnTriggerEnter(bacteria[2].GetComponent<Collider>()));
                }
            }

            if(bacteria[2].isDestroyed == true)
            {
                bacteria[2].DisableFocusMarker2();
            }
        }
    }


    public IEnumerator OnTriggerEnter(Collider other)
    {

        yield return new WaitForSeconds(8f);
        //Destroy(other.gameObject);   
        other.gameObject.SetActive(false);
    }
}

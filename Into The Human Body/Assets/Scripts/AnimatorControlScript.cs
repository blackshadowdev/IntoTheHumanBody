using UnityEngine;
using System.Collections;

public class AnimatorControlScript : MonoBehaviour
{
    public Animator anim;
    private GameObject endPoint;
    public SceneManager sceneManager;
    public bool isReached;
    public AudioManager audio_manager;

    void Start()
    {
        anim = GetComponent<Animator>();
        isReached = false;
        endPoint = GameObject.Find("EndPoint");
        //sceneManager = GetComponent<SceneManager>();
        StartCoroutine(OnTriggerEnter(GetComponent<Collider>()));
    }

    void Update()
    {
        /*if(transform.position == endPoint.position)
        {
            isReached = true;
        }*/

       /* if (sceneManager.isDestroyedAll == true)
        {
            anim.SetTrigger("InfectionComplete");
        }*/
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    public IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.name == "EndPoint")
        {
            Debug.Log("Reached to the site");
            isReached = true;
            audio_manager.NarrativeFour();
            yield return new WaitForSeconds(3f);
            audio_manager.NarrativeFive();
        }
    }
}


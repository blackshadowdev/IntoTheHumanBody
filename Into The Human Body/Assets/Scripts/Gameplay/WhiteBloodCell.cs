using UnityEngine;
using System.Collections;

public class WhiteBloodCell : Target
{
    
    public float speed = 0.2f;
    public GameObject target;
    public GameObject _focusMarker_0;
    public GameObject _focusMarker_1;
    public GameObject _focusMarker_2;
    public AnimatorControlScript controller;
    public AudioManager audio_manager;
    private Bacteria bacteria;
    public bool isLookActivated = false;
    public bool isEnabled = false;
    
   
    private GameObject fAT;

    public void Start()
    {
       
    }

    public void Update()
    {
        
    }

    public override string GetTargetType()
    {
        return "whiteBloodCell";
    }

    public override void OnLookStart()
    {
        if (controller.isReached == true)
        { 
            isLookActivated = true;

            
       
        }

    }

    public override void OnLookUpdate()
    {
        
        // StartCoroutine(OnTriggerEnter(GetComponent<Collider>()));
    }

    public override void OnLookEnd()
    {
        
    }

    public void EnableFocusMarker_0()
    {
        _focusMarker_0.SetActive(true);
        isEnabled = true;
    }

    public void DisableFocusMarker_0()
    {
        _focusMarker_0.SetActive(false);
        isEnabled = false;

    }

    public void EnableFocusMarker_1()
    {
        _focusMarker_1.SetActive(true);
        isEnabled = true;
    }

    public void DisableFocusMarker_1()
    {
        _focusMarker_1.SetActive(false);
        isEnabled = false;

    }

    public void EnableFocusMarker_2()
    {
        _focusMarker_2.SetActive(true);
        isEnabled = true;
    }

    public void DisableFocusMarker_2()
    {
        _focusMarker_2.SetActive(false);
        isEnabled = false;

    }

    public void MoveAndEat()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }

   

}
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public AudioClip[] narrative;
	public AudioSource audio;
	public AudioClip WarningBeep;
	public AudioClip Ping1;
	public AudioClip Ping2;
    public bool isPlaying = true;
	
	void Start () 
	{
		Invoke ("NarrativeOne", 2f);	
		Invoke ("NarrativeTwo", 7f);
		Invoke ("NarrativeThree", 15f);
		Invoke ("SoundFXBeep", 36f);
		//Invoke ("NarrativeFour", 38f);
		//Invoke ("NarrativeFive", 43f);
        Invoke ("NarrativeSix", 52f);
	}
	
	
	void Update () 
	{
	    
	}
	
	// FIRST NARRATIVE
	public void NarrativeOne()
	{
		AudioSource audio = GetComponent<AudioSource>();
		AudioClip SoundToPlay = narrative [0];
		audio.clip = SoundToPlay;
		AudioSource.PlayClipAtPoint (SoundToPlay, transform.position, 1.0f);
	}
	
	// SECOND NARRATIVE
	public void NarrativeTwo()
	{
		AudioSource audio = GetComponent<AudioSource>();
		AudioClip SoundToPlay = narrative [1];
		audio.clip = SoundToPlay;
		AudioSource.PlayClipAtPoint (SoundToPlay, transform.position, 1.0f);
	}
	
	// THIRD NARRATIVE
	public void NarrativeThree()
	{
		AudioSource audio = GetComponent<AudioSource>();
		AudioClip SoundToPlay = narrative [2];
		audio.clip = SoundToPlay;
		AudioSource.PlayClipAtPoint (SoundToPlay, transform.position, 1.0f);
	}
	
	// SOUNDFX
	
	public void SoundFXBeep()
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.PlayOneShot(WarningBeep, 2.5F);
	}
	
	// FOURTH NARRATIVE
	public void NarrativeFour()
	{
		AudioSource audio = GetComponent<AudioSource>();
		AudioClip SoundToPlay = narrative [3];
		audio.clip = SoundToPlay;
		AudioSource.PlayClipAtPoint (SoundToPlay, transform.position, 1.0f);
		
	}
	
	// FIFTH NARRATIVE
	public void NarrativeFive()
	{
		AudioSource audio = GetComponent<AudioSource>();
		AudioClip SoundToPlay = narrative [4];
		audio.clip = SoundToPlay;
		AudioSource.PlayClipAtPoint (SoundToPlay, transform.position, 1.0f);
	}

    public void NarrativeSix()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = narrative[5];
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);
       

    }

    public void NarrativeSeven()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = narrative[6];
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);
        // yield return new WaitForSeconds(8f);
        Invoke("NarrativeEight", 8f);
    }

    public void NarrativeEight()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = narrative[8];
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);

    }

    public void NarrativeNine()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = narrative[9];
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);

    }

    public void NarrativeTen()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = narrative[10];
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);

    }

    public void NarrativeEleven()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = narrative[11];
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);

    }

    public void NarrativeTwelve()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = narrative[12];
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);
        Invoke("NarrativeFourteen", 4f);

    }

    public void NarrativeThirteen()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = narrative[13];
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);

    }

    public void NarrativeFourteen()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = narrative[14];
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);

    }

    public void Ping_1()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = Ping2;
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);
        Invoke("NarrativeNine", 2f);
    }

    public void Ping_2()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = Ping2;
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);
        Invoke("NarrativeTen", 2f);
    }

    public void Ping_3()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = Ping2;
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);
        Invoke("NarrativeEleven", 2f);

    }

    public void Ping_4()
    {
        AudioSource audio = GetComponent<AudioSource>();
        AudioClip SoundToPlay = Ping2;
        audio.clip = SoundToPlay;
        AudioSource.PlayClipAtPoint(SoundToPlay, transform.position, 1.0f);
        Invoke("NarrativeTwelve", 2f);

    }


}

    
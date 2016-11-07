using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class blockSound : MonoBehaviour {

    

	// Use this for initialization
	void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "UnityChan2D")
        {
            
            GetComponent<AudioSource>().volume = 0;
        }


        AudioClip clip = gameObject.GetComponent<AudioSource>().clip;
        gameObject.GetComponent<AudioSource>().PlayOneShot(clip);
        


        
        

        





    }
}

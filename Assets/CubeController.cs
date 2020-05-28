using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubeController : MonoBehaviour {

    public AudioClip sound1;
    AudioSource audioSource;
    private float speed = -12;
    private float deadLine = -10;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
        
	}
    private void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.tag =="Cube" || other.gameObject.tag == "Ground")
        {
            audioSource.PlayOneShot(sound1);
        }
    }
}

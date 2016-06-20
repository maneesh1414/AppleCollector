using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class apple : MonoBehaviour {
	public int count;
	public int life;
	public Text score;
	private AudioSource coincollect;
	public AudioClip collectcoin;
	public AudioClip enemytouch;
	public Text Health;
	// Use this for initialization
	void Start () {
		count = 0;
		life = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (life <= 0) 
		{
			Application.LoadLevel (2);
		}

		if (count >= 7) 
		{
			Application.LoadLevel (3);
		}
	}
	void OnTriggerEnter (Collider apples)
	{
		if (apples.gameObject.CompareTag ("apple")) 
		{
			apples.gameObject.SetActive(false);
			count++;
			score.text = "Apples : " + count;
			coincollect.PlayOneShot (collectcoin);
		}

		if (apples.gameObject.CompareTag ("Cat")) 
		{
			coincollect.PlayOneShot (enemytouch);
			life--;
			Health.text = "Health : " + life;
		}



	}
	void Awake ()
	{
		coincollect = GetComponent<AudioSource> ();
	}
}

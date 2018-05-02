using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balljyousyou : MonoBehaviour {
	private string mode;
	bool hantei;
	// Use this for initialization
	GameObject director;
	GameObject obj;
	ParticleSystem ps;
	void OnTriggerEnter(Collider other) {


		Destroy(other.gameObject,0.5f);
		other.gameObject.GetComponent<ParticleSystem> ().Play ();
		other.gameObject.GetComponent<AudioSource> ().Play ();
		if (hantei == false) {
			this.director.GetComponent<GameDirector> ().Gettensu ();
		}
	}

	public void Fly()
	{
		//modeの値をflyで初期化します

		if(mode=="jet"){
		GetComponent<AudioSource> ().Play ();
			mode = "fly";
		}
	}
	void Start () {
		mode = "jet";
		hantei = false;
		this.director = GameObject.Find ("GameDirector");
		obj = GameObject.Find("Explosion loop mobile");
		ps = obj.GetComponent<ParticleSystem>();
		obj.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
			//Vector3 tmp = GameObject.Find ("Player").transform.position;
		if (this.transform.position.y >= 3.0f) {
			transform.localPosition = Vector3.zero;
			mode = "jet";
			obj.SetActive(false);
			ps.Stop();
		}

		if (mode == "fly")
		{
			//UFOが上に上がりながら回転します

			transform.Translate (0, 0.03f, 0);
			obj.SetActive(true);
			ps.Play();


		}
	}
}

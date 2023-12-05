using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class discMove : MonoBehaviour {

    // Use this for initialization
	public int m=0;
	public int c=0;
	public int d=0;
	public float accelerationTime = 0f;
    public float maxSpeed = 500f;
    private Vector2 movement;
    private float timeLeft;
    public Rigidbody2D rb;
    private Vector3 randomDirection;
	public GameObject hand;
    public float force = 20.0f;
	public GameObject canvas;
	public Camera camera;
	public GameObject canvas1;
	public GameObject gobject;
	public Image image1;
	public Image image2;
	public Image image3;
	public Image image4;
	public Image image5;
	public Image image6;
	public Ads ad;

	public AudioSource source;
    void Start () {
	this.gameObject.AddComponent<AudioSource>();
	source = this.GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
		//Time.timeScale=0;

		rb.velocity=new Vector3(0,-4,0);
    }
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "GameObject (2)") {
			canvas1.SetActive(true);
			gobject = GameObject.Find ("adds");
			ad = gobject.GetComponent<Ads> ();
			ad.OnBtnClick ();

			Destroy (this.gameObject);


			//UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		}
	}
	private void OnCollisionEnter2D(Collision2D col)
    {
        //randomDirection = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));

        //Drag is how fast object slowing down 
        //rb.drag = 0;
		//rb.velocity=new Vector3(Random.Range(3,-3),Random.Range(10,-10),0);
        //ForceMode.VelocityChange will ignore mass of object and apply velocity instantly
        //rb.AddForce(randomDirection * force, ForceMode2D.Force);
		//if (col.gameObject.name == "1 (1)" || col.gameObject.name == "1 (2)" || col.gameObject.name == "1 (3)" || col.gameObject.name == "1 (4)" || col.gameObject.name == "1 (5)" || col.gameObject.name == "1 (6)" || col.gameObject.name == "1 (7)") {
			
			//gameObject.transform.GetChild (0).gameObject.SetActive (true);
		//GameObject.Find("gem_tris_trail").SetActive(true);
		//GameObject x=GetComponent<ParticleSystem>();
	//	gameObject.transform.GetChild(2).gameObject.SetActive(true);
		//gameObject.transform.GetChild(2).gameObject.GetComponent<ParticleSystem>().Stop(true);
		if (col.gameObject.name == "spike") {
			//gameObject.transform.GetChild (1).gameObject.SetActive (true);

			//hand.SetActive (true);
			//hand.transform.parent = null;
			//string json = ResourceHelper.ReadFromPersistentData("lives.json");
			//PlayerLives data = ResourceHelper.DecodeObject<PlayerLives>(json);
			//data.lives -= 1;
			//PlayerLives pl = new PlayerLives{
			//	lives = data.lives,
			//	isLoaded = true
			//};
			//ResourceHelper.SaveToPersistentData("lives.json",pl);
            if(PlayerPrefs.GetInt("livesinfi") ==0)
            {
                PlayerPrefs.SetInt("lives", PlayerPrefs.GetInt("lives") - 1);
            }
			if(camera.GetComponent<CreateLine> ()!=null)
			camera.GetComponent<CreateLine> ().enabled = false;
			if(camera.GetComponent<CreateLinew34> ()!=null)
			camera.GetComponent<CreateLinew34> ().enabled = false;
			if(camera.GetComponent<CreateLinew5> ()!=null)
			camera.GetComponent<CreateLinew5> ().enabled = false;
			canvas.SetActive(true);
			//GameObject.Find ("adds").GetComponent<Ads> ().OnBtnClick ();
			gobject = GameObject.Find ("adds");
			ad = gobject.GetComponent<Ads> ();
			ad.OnBtnClick ();
			Destroy (this.gameObject);
		} 
		else if (col.gameObject.name == "end" || col.gameObject.name == "end1" || col.gameObject.name == "end2" || col.gameObject.name == "end3") {
			canvas1.SetActive(true);

			Destroy (this.gameObject);
			//GameObject.Find ("adds").GetComponent<Ads> ().OnBtnClick ();
			gobject = GameObject.Find ("adds");
			ad = gobject.GetComponent<Ads> ();
			ad.OnBtnClick ();
			//UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		}
		else{
			source.clip = Resources.Load("Sound/newsound") as AudioClip;
			source.Play();
			source.playOnAwake = false;
		}
    }
    // Update is called once per frame
    void Update () {
		
		//transform.Translate (Vector3.forward * Time.deltaTime * maxSpeed);
				//Destroy (this.gameObject);					
	
				
	//			if(m>=15)
	//			{
	//				m=0;
	//				gameObject.transform.GetChild(2).gameObject.SetActive(false);
	//			}
	//			m++;

        /*timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }*/
    }
    void FixedUpdate()
    {
        //rb.AddForce(movement * maxSpeed);
    }
}

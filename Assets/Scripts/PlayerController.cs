using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	internal GameObject Slide;
	internal GameObject Charged;
	internal GameObject[] Wall;
	internal bool destroiWall;

	public Animator anim;
	internal float moveSpeed = 2;
	public GameObject WallPrefab;
	public GameObject BirthPosition;

	// Use this for initialization
	void Start () {
		Slide = GameObject.Find("Slide");
		Charged = GameObject.Find("Charged");
		

		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Wall = GameObject.FindGameObjectsWithTag("Wall");

		if(transform.position.x < 0){
			transform.Translate(moveSpeed*Time.deltaTime, 0, 0);
		}
		
		
		if(Input.GetMouseButtonDown(0)){
			if( -0.2 < Slide.transform.position.x && Slide.transform.position.x > 0.2 ){
				destroiWall = true;
				Charged.GetComponent<MeshRenderer>().material.color = Color.red;
			}	
		}
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Wall" && destroiWall == true){
			
			Destroy(other.gameObject);
			Charged.GetComponent<MeshRenderer>().material.color = Color.blue;
			destroiWall = false;
				
			for(var i = 0; i < Wall.Length; i++){
				Wall[i].GetComponent<WallMovement>().speed = 3;
			}
			Instantiate(WallPrefab, BirthPosition.transform.position, Quaternion.identity);
			
		} else {

			for(var i = 0; i < Wall.Length; i++){
				Wall[i].GetComponent<WallMovement>().speed = 0;

			}

			anim.SetTrigger("Lose");
			
			moveSpeed = 0;

			print("You are not clicked ");
		}
	}

}

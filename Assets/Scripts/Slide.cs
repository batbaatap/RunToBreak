using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

 
     void Update () {

		/* ======================
		=========example 1=======
		=======================*/
		// private bool dirRight = true;
    	

        //  if (dirRight)
        //      transform.Translate (Vector2.right * speed * Time.deltaTime);
        //  else
        //      transform.Translate (-Vector2.right * speed * Time.deltaTime);
         
        //  if(transform.position.x >= 4.0f) {
        //      dirRight = false;
        //  }
         
        //  if(transform.position.x <= -4) {
        //      dirRight = true;
        //  }




		/* ======================
		=========example 2=======
		=======================*/
		//  transform.position = Vector3.Lerp (pos1, pos2, Mathf.PingPong(Time.time*speed, 1.0f));





		/* ======================
		=========example 3=======
		=======================*/
		Vector3 pos1 = new Vector3(-2.5f,-4,0);
   		Vector3 pos2 = new Vector3(2.5f,-4,0);
		float speed = 5.0f;

		// transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
		transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);

     }
	
	
    // IEnumerator Blabla() {

	// 	while(true){
	// 		StartCoroutine("Left");
	// 			yield return new WaitForSeconds(1F);
	// 		StopCoroutine("Left");

	// 		yield break;
	// 	}
    // }

	// IEnumerator Left() {
	// 	while (true){
	// 		transform.localPosition += new Vector3(0.15f, 0, 0);
	// 		yield return null;
	// 	}
	// }

	// IEnumerator Right() {
	// 	while (true){
	// 		transform.localPosition += new Vector3(-0.15f, 0, 0);
	// 		yield return null;
	// 	}
	// }
	
}


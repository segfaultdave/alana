﻿using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	Rigidbody2D rb;
	float speed = 0.5f;
	GameObject alana;

	Dialogue[] dialogues;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		alana = GameObject.Find("Alana");


		int numTexts = 7;
		dialogues = new Dialogue[numTexts];

		for (int i = 0; i < numTexts; i++) {
			dialogues[i] = GameObject.Find("Texts/Text " + i).GetComponent<Dialogue>();
		}


		float start = 0f;

		Invoke("MoveToStairs", start);
		Invoke("MoveUpStairs", start + 13f);
		Invoke("MoveToPimp", 	 start + 18f);
		Invoke("TalkToPimp1",  start + 20f);
		Invoke("TalkToPimp2",  start + 24f);
		Invoke("TalkToPimp3",  start + 28f);
		Invoke("TalkToPimp4",  start + 30f);
		Invoke("TalkToPimp5",  start + 34f);
		Invoke("TalkToPimp6",  start + 37f);

	}


	
	void MoveToStairs () {
		Vector2 v = new Vector2(speed, 0f);
		rb.velocity = v;
		alana.GetComponent<Rigidbody2D>().velocity = v;
		alana.GetComponent<Animator>().SetBool("walk", true);
	}

	void MoveUpStairs () {
		Vector2 v = new Vector2(0.67f, 0.224f);
		rb.velocity = new Vector2(0.1f, 0.1f);
		alana.GetComponent<Rigidbody2D>().velocity = v;


	}

	void MoveToPimp () {
		Vector2 v = new Vector2(speed, 0f);
		rb.velocity = v;
		alana.GetComponent<Rigidbody2D>().velocity = v;

		dialogues[0].Display(); // You're late.
	}

	void TalkToPimp1 () { 
		dialogues[1].Display(); // // sorry
	}

	void TalkToPimp2 () {
		Vector2 v = new Vector2(0f, 0f);
		rb.velocity = v;
		alana.GetComponent<Rigidbody2D>().velocity = v;
		alana.GetComponent<Animator>().SetBool("walk", false);
		dialogues[2].Display(); // is there any food left?
	}

	void TalkToPimp3 () {
		dialogues[3].Display(); // here
	}

	void TalkToPimp4 () {
		dialogues[4].Display(); // thanks
	}

	void TalkToPimp5 () {
		dialogues[5].Display(); // So, are you ready?
	}

	void TalkToPimp6 () {
		dialogues[6].Display(); // Don't mess up this time.
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}

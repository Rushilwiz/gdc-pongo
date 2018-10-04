using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColor : MonoBehaviour {

	[SerializeField]
	SpriteRenderer rend;

	[SerializeField]
	Text Title;

	void Start () {

		//Gets Renderer
		rend = GetComponent<SpriteRenderer>();
	}

	void FixedUpdate () {
		//Calls rainbowEffect
		rainbowEffect ();

	}

	void rainbowEffect() {

			Color rainbowColor = new Color (
				Random.value,
				Random.value,
				Random.value
			);

			if (rend != null) {
				rend.color = rainbowColor;
			}

			if (Title != null) {
				Title.color = rainbowColor;
			}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

	public Player player;

	// O método Start é executado uma única vez, quando o script é executado.
	void Start () {
	}

	// O médodo Update é executado a cada Frame
	void Update () {
		if(Input.GetKey ("w")){
			transform.Translate(0, 0, (player.speed * Time.deltaTime));
		}

		if(Input.GetKey ("s")){
			transform.Translate(0, 0, (-player.speed * Time.deltaTime));
		}

		if(Input.GetKey ("a")){
			transform.Translate((-player.speed * Time.deltaTime), 0, 0);
		}
		
		if(Input.GetKey ("d")){
			transform.Translate((player.speed * Time.deltaTime), 0, 0);
		}
	}
}

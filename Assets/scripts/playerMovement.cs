using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

	float _velocidade;

	// O método Start é executado uma única vez, quando o script é executado.
	void Start () {
		_velocidade = 8;
	}

	// O médodo Update é executado a cada Frame
	void Update () {
		if(Input.GetKey ("w")){
			transform.Translate(0, (_velocidade * Time.deltaTime),0);
		}

		if(Input.GetKey ("s")){
			transform.Translate(0, (-_velocidade * Time.deltaTime), 0);
		}

		if(Input.GetKey ("a")){
			transform.Translate((-_velocidade * Time.deltaTime), 0, 0);
		}
		
		if(Input.GetKey ("d")){
			transform.Translate((_velocidade * Time.deltaTime), 0, 0);
		}
	}
}

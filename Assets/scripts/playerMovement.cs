using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

	float _velocidadeFrente;
	float _velocidadeTras;
	float _velocidadeGirar;

	// O método Start e executado uma única vez, quando o script ú executado.
	void Start () {
		_velocidadeFrente = 10;
		_velocidadeTras = 5;
		_velocidadeGirar = 60;
	}

	// O médodo Update é executado a cada Frame
	void Update () {
		if(Input.GetKey ("w")){
			transform.Translate(0, 0, (_velocidadeFrente * Time.deltaTime));
		}

		if(Input.GetKey ("s")){
			transform.Translate(0, 0, (-_velocidadeTras * Time.deltaTime));
		}

		if(Input.GetKey ("a")){
			transform.Translate((_velocidadeGirar * Time.deltaTime), 0, 0);
		}
		
		if(Input.GetKey ("d")){
			transform.Translate((-_velocidadeGirar * Time.deltaTime), 0, 0);
		}
	}
}

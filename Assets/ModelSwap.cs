using UnityEngine;
using System.Collections;

public class ModelSwap : MonoBehaviour {

	public GameObject[] models;
	private int current = 0;

	public void Cycle (int step) {
		models [current].SetActive (false);
		current = (current + step + models.Length) % models.Length;
		models [current].SetActive (true);
		
	}
}

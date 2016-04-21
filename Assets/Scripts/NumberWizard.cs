using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	public Text GuessText;

	private int max;
	private int min;
	private int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame() {

		max = 1000;
		min = 0;
		NextGuess();
	}

	public void GuessHigher() {
		min = guess;
		NextGuess();
	}

	public void GuessLower() {
		max = guess;
		NextGuess();
	}

	void NextGuess() {
		guess = Random.Range (min, max);
		GuessText.text = guess.ToString ();
	}
}

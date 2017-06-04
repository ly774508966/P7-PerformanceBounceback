using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

  public GameManager gameManager;
  // CHANGES
  // Text component as reference added to remove it from the Update method
  public Text text;

  // Update is called once per frame
  void Update () {
    text.text = "Score: " + gameManager.score.ToString();
	}
}

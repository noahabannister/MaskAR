using UnityEngine;
using System.Collections;

public class Screencapture : MonoBehaviour {
	public Canvas canvas;
	public void TakePicture () {
		canvas.gameObject.SetActive (false);

		StartCoroutine (screenshotDelay());
	}
	IEnumerator screenshotDelay(){
		yield return new WaitForEndOfFrame ();
		yield return new WaitForEndOfFrame ();
		string time = System.DateTime.Now.ToString ("yyyy-MM-dd_HH-mm-ss");
		Application.CaptureScreenshot("MaskAR"+time+".png");
		canvas.gameObject.SetActive (true);
	}
}

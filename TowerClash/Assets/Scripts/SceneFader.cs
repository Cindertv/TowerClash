using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneFader : MonoBehaviour {

	public Image fadeImage;
	public AnimationCurve cruveOfTheAnimation;

	void Start ()
	{
		StartCoroutine(FadeInto());
	}

	public void Fadeinto (string scene)
	{
		StartCoroutine(Fadeoutof(scene));
	}

	IEnumerator FadeInto ()
	{
		float time = 1f;

		while (time > 0f)
		{
			time -= Time.deltaTime;
			float a = cruveOfTheAnimation.Evaluate(time);
			fadeImage.color = new Color (0f, 0f, 0f, a);
			yield return 0;
		}
	}

	IEnumerator Fadeoutof(string scene)
	{
		float _time = 0f;

		while (_time < 1f)
		{
			_time += Time.deltaTime;
			float a = cruveOfTheAnimation.Evaluate(_time);
			fadeImage.color = new Color(0f, 0f, 0f, a);
			yield return 0;
		}

		SceneManager.LoadScene(scene);
	}

}

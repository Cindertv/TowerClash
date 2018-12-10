using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LostGame : MonoBehaviour {

	public string menuSceneName = "Menu";
    public Text enemiesKilled;
    public SceneFader sceneFader;
    public int score = 0;
    public GameController controller;

	public void Retry ()
	{
		sceneFader.Fadeinto(SceneManager.GetActiveScene().name);
    }

	public void Menu ()
	{
		sceneFader.Fadeinto(menuSceneName);
	}


    public void Update()
    {
        enemiesKilled.text = score.ToString();
        score = controller.score;
    }
}

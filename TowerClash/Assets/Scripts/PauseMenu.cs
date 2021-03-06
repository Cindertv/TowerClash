using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public GameObject pauseMenu;

	public string menuSceneName = "Menu";

	public SceneFader sceneFader;

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Toggle();
		}
	}

	public void Toggle ()
	{
		pauseMenu.SetActive(!pauseMenu.activeSelf);

		if (pauseMenu.activeSelf)
		{
			Time.timeScale = 0f;
		} else
		{
			Time.timeScale = 1f;
		}
	}

	public void Retry ()
	{
		Toggle();
		sceneFader.Fadeinto(SceneManager.GetActiveScene().name);
    }

	public void Menu ()
	{
		Toggle();
		sceneFader.Fadeinto(menuSceneName);
	}

}

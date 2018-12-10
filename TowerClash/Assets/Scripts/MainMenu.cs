using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string levelToLoad = "Level01";
    public string options = "Options";
    public string back = "Menu";

	public SceneFader sceneFader;

	public void Play ()
	{
		sceneFader.Fadeinto(levelToLoad);
	}

	public void Quit ()
	{
		Debug.Log("Exciting...");
		Application.Quit();
	}

    public void Options ()
    {
        sceneFader.Fadeinto(options);
    }

    public void Back ()
    {

        sceneFader.Fadeinto(back);
    }

}

using UnityEngine;
using UnityEngine.SceneManager;
// https://www.mousawi.dev/codes by @AbdullaMousawi
public class SceneSwitcher : MonoBehaviour {

    //Switch scene by using the scene index number.
    public void SwitchByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
    
    //Switch scene by using the scene name.
    public void SwitchByName(string name)
    {
        SceneManager.LoadScene(name);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
public class endManager : MonoBehaviour {
    [SerializeField] private int mainMenuIndex;
    public void backToMainMenu(){
        SceneManager.LoadScene(mainMenuIndex);
    }
} // Compare this snippet from Assets/Scripts/UI/EndManager.cs:
// using UnityEngine;
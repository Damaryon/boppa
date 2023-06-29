using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _gameHasEnded;//True or false if player is alive or not

    // Start is called before the first frame update
    void Start()
    {



        _gameHasEnded = false;
    }
    public void Endgame() //called by the player when it dies
    {
        if (_gameHasEnded == false)
        {
            _gameHasEnded = true;
            Invoke("ReloadCurrentScene", 2f);

        }
    }
    private void ReloadCurrentScene()
    {
        // Reset the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Reloadsthecurrentscene
    }

}
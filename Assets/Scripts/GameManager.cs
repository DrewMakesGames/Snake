using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

	public bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject gameOverUI;

	public void GameOverShow(){
		gameOverUI.SetActive(true);
	}
	public void EndGame() {
		if (gameHasEnded == false){
			gameHasEnded = true;
			gameOverUI.SetActive(true);
			
			Debug.Log("Game over");
			Invoke("Restart", restartDelay);
		}		
	}
	
	void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}

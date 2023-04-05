using UnityEngine;
using UnityEngine.SceneManagement;

namespace Torn.Managers
{
    public class EndingManager : MonoBehaviour
    {
        [SerializeField] private int pointsNeededForGoodEnding = 5;
        // [SerializeField] private GameObject goodEnding;
        // [SerializeField] private GameObject badEnding;

        [SerializeField] private int playerScore = 0;

        // Making this public for debugging. It will be private in the future.
        public void ChooseEnding() {
            if (playerScore >= pointsNeededForGoodEnding) {
                SceneManager.LoadScene("GoodEnding");
                // goodEnding.SetActive(true);
                // badEnding.SetActive(false);
                // print("This is the good ending.");
            }
            else {
                SceneManager.LoadScene("BadEnding");
                // badEnding.SetActive(true);
                // goodEnding.SetActive(false);
                // print("This is the bad ending.");
            }
        }

        public int GetPlayerScore() {
            return playerScore;
        }

        public void IncreasePlayerScore() {
            playerScore++;
        }
    }
}
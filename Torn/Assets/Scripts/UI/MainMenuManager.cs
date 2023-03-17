using System.Collections;
using UnityEngine;
using Torn.Player;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Vector3 panTarget = new Vector3(0f, 0f, -10f);
    [SerializeField] private float panDuration = 3f;

    private GameObject player;

    private Camera cam;

    private void Start() {
        cam = Camera.main;
        player = GameObject.FindGameObjectWithTag("Player");

        player.GetComponent<PlayerMovement>().enabled = false;
    }

    public void StartGame() {
        StartCoroutine(PanCoroutine());
    }

    public void QuitGame() {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

    IEnumerator PanCoroutine() {
        float elapsed = 0f;
        Vector3 initialPos = cam.transform.position;

        while (elapsed < panDuration) {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / panDuration);
            cam.transform.position = Vector3.Lerp(initialPos, panTarget, t);
            yield return null;
        }

        cam.transform.position = panTarget;
        player.GetComponent<PlayerMovement>().enabled = true;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }
}
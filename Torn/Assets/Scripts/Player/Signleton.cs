using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signleton : MonoBehaviour
{
    public static Signleton instance;

    private void Awake() {

        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
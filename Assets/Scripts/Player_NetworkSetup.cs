using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;
public class Player_NetworkSetup : NetworkBehaviour {
    [SerializeField]
    Camera FPSCharacterCam;

    [SerializeField]
    AudioListener audioListener;

	// Use this for initialization
	void Start () {
        if (isLocalPlayer) {
            GameObject.Find("SceneCamera").SetActive(false);
            GetComponent<CharacterController>().enabled = true;

            GetComponent<FirstPersonController>().enabled = true;
            FPSCharacterCam.enabled = true;
            audioListener.enabled = true;
        }
	}
}

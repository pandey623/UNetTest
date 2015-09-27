using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;
public class Player_NetworkSetup : NetworkBehaviour {
    [SerializeField]
    Camera FPSCharacterCam;

    [SerializeField]
    AudioListener audioListener;

    [SerializeField]
    GameObject spawnedPlayer;

    Vector3 HMDPos;
    Vector3 HMDAngular;

	// Use this for initialization
	void Start () {
        if (isServer){
            // Real world camera initialization
            //TODO: fill here

            // Scene objects initialization
            //TODO: fill here
            // ダイアログオブジェクトを作る。
            // 空間のオブジェクトの生成はそいつに任せる
        } else if (isLocalPlayer) {
            GameObject.Find("SceneCamera").SetActive(false);
            GetComponent<CharacterController>().enabled = true;

            GetComponent<FirstPersonController>().enabled = true;
            FPSCharacterCam.enabled = true;
            audioListener.enabled = true;
        }
	}

}

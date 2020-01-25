using UnityEngine;
using System.Collections;

/// <summary>
/// 自動的に指定した時間後に消える
/// </summary>
public class AutoVanish : MonoBehaviour {

    [Tooltip("消える時間（秒）"), SerializeField]
    float VanishTime = 1.0f;

	// Use this for initialization
	void Start () {
        Invoke("Vanish", VanishTime);
	}

    void Vanish()
    {
        gameObject.SetActive(false);
    }
}

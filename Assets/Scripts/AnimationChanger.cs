using System.Collections.Generic;
using UnityEngine;

public class AnimationChanger : MonoBehaviour {
	
    [SerializeField]
    private Animator _animator;

	[SerializeField]
	private KeyCode _switchKey;

    [SerializeField]
    private string _ParamName = "";
	
    void Update()
    {

        if (Input.GetKeyDown(_switchKey))
        {
            _animator.SetTrigger(_ParamName);
        }
    }
}

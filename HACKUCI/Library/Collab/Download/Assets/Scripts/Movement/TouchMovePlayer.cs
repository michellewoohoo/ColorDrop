using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovePlayer : MonoBehaviour {

    private float speed = 0.1F;

    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Debug.Log("touchdown");
            Vector2 touchDeltaPos = Input.GetTouch(0).deltaPosition;

            transform.Translate(-touchDeltaPos.x * speed, -touchDeltaPos.y * speed, 0);
        }
    }

}

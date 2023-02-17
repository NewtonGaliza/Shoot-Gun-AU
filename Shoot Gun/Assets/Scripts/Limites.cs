using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{
    [SerializeField] Camera _mainCamera;
    Vector2 _screenBounds;
    float _objectWidth;
    float _objectHeight;

    // Start is called before the first frame update
    void Start()
    {
        _screenBounds = _mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, _mainCamera.transform.position.z));
        _objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        _objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 _viewPosition = transform.position;
        _viewPosition.x = Mathf.Clamp(_viewPosition.x, _screenBounds.x * -1 + _objectWidth, _screenBounds.x - _objectWidth);
        _viewPosition.y = Mathf.Clamp(_viewPosition.y, _screenBounds.y * -1 + _objectHeight, _screenBounds.y - _objectHeight);
        transform.position = _viewPosition;
    }
}

using UnityEngine;
using System.Collections;

public class DragMe : MonoBehaviour
{
    private bool isOver;
    private bool up;
    public Transform start;
    private Vector3 startPosition;
    public GameObject item;
    public Camera cam;

    void Awake()
    {
        startPosition = start.position;
    }

    void OnMouseEnter()
    {
        isOver = true;

    }

    void OnMouseExit()
    {
        isOver = false;
    }

    IEnumerator OnMouseDown()
    {
        up = false;
        while (up == false)
        {
            // item.transform.position = 
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 pos = ray.origin + (ray.direction * 4.7f);
            item.transform.position = pos + cam.transform.forward * 10.0f;
            yield return new WaitForEndOfFrame();
        }
    }

    void OnMouseUp()
    {
        up = true;
        Vector3 pos = new Vector3(item.transform.position.x, 1.5f, item.transform.position.z);
        item.transform.position = new Vector3(startPosition.x, startPosition.y, 0f);
    }

    public void Reset()
    {
        item.transform.position = new Vector3(startPosition.x, startPosition.y, 0f);
    }
}
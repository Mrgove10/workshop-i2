using UnityEngine;
using UnityEngine.EventSystems;

public class ClickManager : MonoBehaviour
{
    public Camera MainCamera;
    public GameManager GameManager;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = MainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                // if there is a click manager
                var cm = hit.collider.gameObject.GetComponent<ClickTarget>();
                if (cm !=  null)
                {
                  Debug.Log(cm.type);
                  GameManager.launchEffect(cm.type);
                }
            }
        }
    }
}

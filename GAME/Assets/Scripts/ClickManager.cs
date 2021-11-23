using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            //Debug.Log(hit);
            if (hit.collider != null)
            {
                //Debug.Log(hit.collider.gameObject.name);
                // if there is a click manager
                var cm = hit.collider.gameObject.GetComponent<ClickTarget>();
                //Debug.Log(cm);
                if (cm != null)
                {
                    Debug.Log(cm.type);
                    gameManager.LaunchEffect(cm.type);
                }
            }
        }
    }
}
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameManager gameManager;
    public Camera maincamera;
    // Update is called once per frame
    void Update()
    {
        // if button down and the popupisnot open
        if (Input.GetMouseButtonDown(0) && gameManager.popup.activeSelf == false)
        {
            // Debug.Log("click");
            Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            //Debug.Log(hit.collider.transform.name);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.transform.name);
                gameManager.LaunchEffect(hit.collider.GetComponent<ClickTarget>().type);
            }  
        } 
    }
}
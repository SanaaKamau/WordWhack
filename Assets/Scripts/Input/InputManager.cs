using UnityEngine;

public class InputManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clickedObject = GetClickedObject();

            if (clickedObject != null)
            {
                Debug.Log("Retrieved clicked object: " + clickedObject.name);
            }
        }
    }

    // This method handles the core logic and returns the GameObject
    public GameObject GetClickedObject()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {
            return hit.transform.gameObject;
        }
        return null;
    }
}
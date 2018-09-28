using UnityEngine;
using System.Collections.Generic;
public class cameraBox : MonoBehaviour
{
    public Texture marqueeGraphics;
    public moveGroup group;
    private Vector2 marqueeOrigin;
    private Vector2 marqueeSize;
    public Rect marqueeRect;
    public List<GameObject> SelectableUnits;
    private Rect backupRect;
    private void OnGUI()
    {
        marqueeRect = new Rect(marqueeOrigin.x, marqueeOrigin.y, marqueeSize.x, marqueeSize.y);
        GUI.color = new Color(0, 0, 0, .3f);
        GUI.DrawTexture(marqueeRect, marqueeGraphics);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Poppulate the selectableUnits array with all the selectable units that exist
            SelectableUnits = new List<GameObject>(GameObject.FindGameObjectsWithTag("Player"));

            float _invertedY = Screen.height - Input.mousePosition.y;
            marqueeOrigin = new Vector2(Input.mousePosition.x, _invertedY);

            //Check if the player just wants to select a single unit opposed to drawing a marquee and selecting a range of units
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                SelectableUnits.Remove(hit.transform.gameObject);
                hit.transform.gameObject.SendMessage("OnSelected", SendMessageOptions.DontRequireReceiver);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            //Reset the marquee so it no longer appears on the screen.
            marqueeRect.width = 0;
            marqueeRect.height = 0;
            backupRect.width = 0;
            backupRect.height = 0;
            marqueeSize = Vector2.zero;


        }
        if (Input.GetMouseButton(0))
        {
            float _invertedY = Screen.height - Input.mousePosition.y;
            marqueeSize = new Vector2(Input.mousePosition.x - marqueeOrigin.x, (marqueeOrigin.y - _invertedY) * -1);
            //FIX FOR RECT.CONTAINS NOT ACCEPTING NEGATIVE VALUES
            if (marqueeRect.width < 0)
            {
                backupRect = new Rect(marqueeRect.x - Mathf.Abs(marqueeRect.width), marqueeRect.y, Mathf.Abs(marqueeRect.width), marqueeRect.height);
            }
            else if (marqueeRect.height < 0)
            {
                backupRect = new Rect(marqueeRect.x, marqueeRect.y - Mathf.Abs(marqueeRect.height), marqueeRect.width, Mathf.Abs(marqueeRect.height));
            }
            if (marqueeRect.width < 0 && marqueeRect.height < 0)
            {
                backupRect = new Rect(marqueeRect.x - Mathf.Abs(marqueeRect.width), marqueeRect.y - Mathf.Abs(marqueeRect.height), Mathf.Abs(marqueeRect.width), Mathf.Abs(marqueeRect.height));
            }
            foreach (GameObject unit in SelectableUnits)
            {
                //Convert the world position of the unit to a screen position and then to a GUI point
                Vector3 _screenPos = Camera.main.WorldToScreenPoint(unit.transform.position);
                Vector2 _screenPoint = new Vector2(_screenPos.x, Screen.height - _screenPos.y);
                //Ensure that any units not within the marquee are currently unselected
                if (!marqueeRect.Contains(_screenPoint) || !backupRect.Contains(_screenPoint))
                {
                    unit.SendMessage("OnUnselected", SendMessageOptions.DontRequireReceiver);
                }
                if (marqueeRect.Contains(_screenPoint) || backupRect.Contains(_screenPoint))
                {
                    unit.SendMessage("OnSelected", SendMessageOptions.DontRequireReceiver);
                    GameObject[] a = new GameObject[group.units.Length + 1];
                    for (int i = 0; i < group.units.Length; i++)
                    {
                        a[i] = group.units[i];
                    }
                    a[a.Length] = unit;
                    group.units = a;

                }
                
            }
            
        }
    }
}
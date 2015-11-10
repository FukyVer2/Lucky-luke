using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    public PlayerController player;

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag" + eventData.position);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End" + eventData.position);
        player.Jump();
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        player.Jump();
    }
}

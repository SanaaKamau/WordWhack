using UnityEngine;
using UnityEngine.EventSystems;

public class LetterBox : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
{
    GameManager.Instance.MoveTileToOppositePanel(gameObject);
}
}
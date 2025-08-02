using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, ISelectHandler, IDeselectHandler, IEventSystemHandler
	{
		public bool isSelected;

		public void OnPointerClick(PointerEventData HMIFPEJKHHH)
		{
			Debug.Log("Scrollbar click...");
		}

		public void OnSelect(BaseEventData HMIFPEJKHHH)
		{
			Debug.Log("Scrollbar selected");
			isSelected = true;
		}

		public void OnDeselect(BaseEventData HMIFPEJKHHH)
		{
			Debug.Log("Scrollbar De-Selected");
			isSelected = false;
		}
	}
}

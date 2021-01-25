using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickController : MonoBehaviour, IPointerDownHandler
{
	[SerializeField] private MoveController _moveController;



	public void OnPointerDown(PointerEventData eventData)
	{

		_moveController.AddPoint();
	}

}

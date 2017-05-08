using UnityEngine;
using System.Collections;
using Vuforia;

public class ThornBox : MonoBehaviour, ITrackableEventHandler 
{
	private string infoTitle = "상자 고문 Box Torture";
	private string infoContent = "상자 안쪽에 날카로운 못을 박아 놓고, 사람을 상자 안에 집어넣어 마구 흔들어 못에 찔리게 하여 고통을 주었던 고문도구.";

	private TrackableBehaviour mTrackableBehaviour;

	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			Manage_Text_Information.infoText = infoContent;
			Manage_Text_Information.infoTitle = infoTitle;
			Manage_Text_Information.detected = true;
		}
		else
		{
			Manage_Text_Information.infoText = "";
			Manage_Text_Information.infoTitle = "";
			Manage_Text_Information.detected = false;
		}
	}
}
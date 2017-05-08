using UnityEngine;
using System.Collections;
using Vuforia;

public class PrisonText : MonoBehaviour , ITrackableEventHandler 
{
	private string infoTitle = "서대문형무소역사관 Seodaemun Prison History Museum";
	private string infoContent = "서대문형무소는 형무소이지만 죄인을 가둔 곳이 아니라 독립투사들을 잡아 가두고 고문하고 사형시킨 곳이다. 바로 일제가 우리를 억압하는 수단으로 사용되었던 곳인 것이다.\n 다음 애니메이션은 그 당시 서대문형무소를 순찰하는 일본순사의 모습이다.";

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
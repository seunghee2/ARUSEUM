using UnityEngine;
using System.Collections;
using Vuforia;

public class ToiletText : MonoBehaviour, ITrackableEventHandler 
{
	private string infoTitle = "제소자 화장실 Vestige of Prison Toilet";
	private string infoContent = "서대문형무소에는 일제강점기부터 1970년대 중반까지 재소자들을 위한 화장실이 별도로 존재하지 않았다.\n각 옥사마다 감방에 '똥통'이라 불리는 나무통을 두고 대소변을 보았다.\n재소자 화장실은 해방이후인 1970년대 각 옥사 벽면에 붙여서 외부로 돌출된 형태로 만들어졌다.\n이 화장실은 1987년 서대문형무소가 경기도 의왕시로 이전하면서 완전히 철거되었고 현재 그 흔적이 옥사 벽면에 남아있다.";

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
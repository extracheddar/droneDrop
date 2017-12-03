using UnityEngine;
using UnityEngine.UI;

public class Objectives : MonoBehaviour
{
	public GameObject deliveriesNumberObject;
	public GameObject landingZonesAnimation;
	public GameObject landingZonesNumberObject;
	public GameObject landingZoneCheckboxObject;

	// Use this for initialization
	void Start () {
		GameController gameController = CommonObjects.GetGameController();
		deliveriesNumberObject.GetComponent<Text>().text = gameController.deliveriesNeeded.ToString();

		int requiredLandingZones = gameController.bullseyesNeeded;

		if (requiredLandingZones < 1)
		{
			if (landingZoneCheckboxObject != null)
			{
				landingZoneCheckboxObject.SetActive(false);
			}
			landingZonesAnimation.SetActive(false);
			landingZonesNumberObject.SetActive(false);
		}
		else
		{
			landingZonesNumberObject.GetComponent<Text>().text = requiredLandingZones.ToString();
		}
	}
}

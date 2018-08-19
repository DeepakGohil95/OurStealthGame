using UnityEngine;

public class CameraOrbit : MonoBehaviour {
	public CursorLockMode cursorMode;

	private Transform _XForm_Camera;
	private Transform _Xform_Parent;

	private Vector3 _LocalRotation;
	protected float _CameraDistance = 10f;


	public float MouseSensitivity = 4f;
	public float ScrollSensitivity = 2f;
	public float OrbitDampening = 10f;
	public float ScrollDampening = 6f;

	public bool CameraDisabled = false;

	// Use this for initialization
	void Start () {

		this._XForm_Camera = this.transform;
		this._Xform_Parent = this.transform.parent;
		
	}
	
	// Late Update is called once per frame. after Update() on every game object in the scene
	void LateUpdate () {
		SetCursorState();
		
		if (Input.GetKeyDown(KeyCode.Alpha1))
			CameraDisabled = !CameraDisabled;


		if(!CameraDisabled)
		{
			//Rotation of the Camera based on Mouse Coordinates
			if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
			{
				_LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensitivity;
				_LocalRotation.y -= Input.GetAxis("Mouse Y") * MouseSensitivity;

				//Clamp the y Rotation to horizon and not flipping over at the top
				_LocalRotation.y = Mathf.Clamp(_LocalRotation.y, 0f, 90f);
			}

			//Zooming Input from our Mouse Scroll Wheel
			if(Input.GetAxis("Mouse ScrollWheel") != 0f)
			{

				float ScrollAmount = Input.GetAxis("Mouse ScrollWheel") * ScrollSensitivity;

				//Makes camera zoom faster the further it is from the target
				ScrollAmount *= (this._CameraDistance * 0.3f);

				this._CameraDistance += ScrollAmount * -1f;

				//This makes camera go no closer than 1.5 metres from target and no further than 100 metres
				this._CameraDistance = Mathf.Clamp(this._CameraDistance, 1.5f, 100f);
			}
		}


		//Actual Camera Rig Transformations
		Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0);
		this._Xform_Parent.rotation = Quaternion.Lerp(this._Xform_Parent.rotation, QT, Time.deltaTime * OrbitDampening);

		if(this._XForm_Camera.localPosition.z != this._CameraDistance * -1f)
		{

			this._XForm_Camera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this._XForm_Camera.localPosition.z, this._CameraDistance * -1f, Time.deltaTime * ScrollDampening));

		}
	}

	void SetCursorState() {
    Cursor.lockState = cursorMode;
    // Hide cursor when clicking
    Cursor.visible = (CursorLockMode.Locked != cursorMode);
	}
}

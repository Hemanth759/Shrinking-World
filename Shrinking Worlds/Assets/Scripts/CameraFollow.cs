using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public varaibles
    public Transform target;
    public float smoothness;
    public float rotationSmoothness;

    public Vector3 offset;

	private Vector3 velocity = Vector3.zero;
    
    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        if (target == null)
		{
			return;
		}
		
		Vector3 newPos = target.TransformDirection(offset);
		this.transform.position = Vector3.SmoothDamp(this.transform.position, newPos, ref velocity, smoothness);

		Quaternion targetRot = Quaternion.LookRotation(-this.transform.position.normalized, target.up);
		this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRot, Time.deltaTime * rotationSmoothness);
    }
}

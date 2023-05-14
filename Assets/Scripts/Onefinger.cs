using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace DigitalRubyShared
{
    public class Onefinger : MonoBehaviour
    {
        public GameObject RotateIcon;
        public GameObject ScaleIcon;
        public GameObject Earth;
        public FingersScript FingersScript;

        private OneTouchRotateGestureRecognizer rotationGesture = new OneTouchRotateGestureRecognizer();
        private OneTouchScaleGestureRecognizer scaleGesture = new OneTouchScaleGestureRecognizer();

        private bool GestureIntersectsSprite(GestureRecognizer g,GameObject obj)
        {
            Renderer r = obj.GetComponent<Renderer>();
            if (r == null)
            {
                return false;
            }
            Bounds b = r.bounds;
            Vector3 gesturePos = Camera.main.ScreenToWorldPoint(new Vector3(g.FocusX, g.FocusY, 0.0f));
            gesturePos.z = b.center.z;

            return b.Contains(gesturePos);
        }
        private void RotationGestureUpdated(GestureRecognizer gesture, ICollection<GestureTouch> touches)
        {
            if (gesture.state == GestureRecognizerState.Began && !GestureIntersectsSprite(gesture, RotateIcon))
            {
                gesture.Reset();
            }
            else if (gesture.State == GestureRecognizerState.Executing)
            {
                Earth.transform.Rotate(0.0f, 0.0f, rotationGesture.RotationDegreesDelta);
            }
        }
        private void ScaleGestureUpdated(GestureRecognizer gesture, ICollection<GestureTouch> touches)
        {
            if (gesture.state == GestureRecognizerState.Began && !GestureIntersectsSprite(gesture, ScaleIcon))
            {
                gesture.Reset();
            }
            else if (gesture.State == GestureRecognizerState.Executing)
            {
                Earth.transform.localScale *= scaleGesture.ScaleMultiplier;
            }
        }
        private void  Start()
        {
            FingersScript.AddGesture(rotationGesture);
            rotationGesture.Updated += RotationGestureUpdated;

            FingersScript.AddGesture(scaleGesture);
            scaleGesture.Updated += ScaleGestureUpdated;
        }

        // Update is called once per frame
        private void Update()
        {

        }
    }
}


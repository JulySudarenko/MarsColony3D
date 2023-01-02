using UnityEngine;


namespace Code.Configs
{
    [CreateAssetMenu(fileName = "InputSettings", menuName = "Data/InputSettings", order = 0)]
    public sealed class InputConfig : ScriptableObject
    {
        public string GoTo = KeyCode.Mouse0.ToString();
        // public string Horizontal = "Horizontal";
        // public string Vertical = "Vertical";
        // public string Jump = "Jump";
        // public string Work = "Work";
        
    }
}

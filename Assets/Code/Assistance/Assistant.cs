using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;


namespace Code.Assistance
{
    public static class Assistant
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var result = gameObject.GetComponent<T>();
            if (!result)
            {
                result = gameObject.AddComponent<T>();
            }

            return result;
        }

        public static T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));

        public static T[] LoadAll<T>(string resourcesPath) where T : Object =>
            Resources.LoadAll<T>(Path.ChangeExtension(resourcesPath, null));
    }
}

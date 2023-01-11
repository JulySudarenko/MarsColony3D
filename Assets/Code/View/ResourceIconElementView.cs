using Code.Configs;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Code.View
{
    internal class ResourceIconElementView : MonoBehaviour
    {
        [SerializeField] private Image _icon;
        [SerializeField] private Image _countCircle;
        [SerializeField] private TMP_Text _resourceCount;
        [SerializeField] private ResourcesType _type;

        public void Init()
        {
            
        }

        public ResourcesType Type => _type;
        
        private void SetIcons(Sprite icon, Sprite countIcon, int startCount)
        {
            _icon.sprite = icon;
            _countCircle.sprite = icon;
            _resourceCount.text = startCount.ToString();
        }

        private void ShowResourceCount(int count)
        {
            _resourceCount.text = count.ToString();
        }
    }
}

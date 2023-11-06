using System.Collections;
using UnityEngine;

namespace Ryocatusn.Characters
{
    public class SmokeGenerater : MonoBehaviour
    {
        [SerializeField]
        private GameObject smoke;
        [SerializeField]
        private float rate;

        private void Start()
        {
            StartCoroutine(GenerateSmokes());
        }

        private IEnumerator GenerateSmokes()
        {
            while (true)
            {
                yield return new WaitForSeconds(1 / rate);
                //��ԏ��Locomotives�̎q�̃I�u�W�F�N�g�Ƃ��Đ���
                GameObject newSmoke = Instantiate(smoke, transform.parent.parent.parent);
                newSmoke.transform.position = transform.position;
            }
        }
    }
}

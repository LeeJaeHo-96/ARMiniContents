using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MultiImageTracker : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager imageManager;

    [SerializeField] GameObject kingHeart;
    [SerializeField] GameObject aceSpade;

    [SerializeField] GameObject cardF;
    [SerializeField] GameObject cardS;

    private void OnEnable()
    {
        imageManager.trackedImagesChanged += OnImageChange;
    }

    private void OnDisable()
    {
        imageManager.trackedImagesChanged -= OnImageChange;
    }

    private void OnImageChange(ARTrackedImagesChangedEventArgs args)
    {
        // ���ο� �̹����� �߰ߵǾ��� ��
        foreach (ARTrackedImage trackedImage in args.added)
        {
            // �̹��� ���̺귯������ �̹����� �̸��� Ȯ��
            string imageName = trackedImage.referenceImage.name;

            // ���ο� ���ӿ�����Ʈ�� Ʈ��ŷ�� �̹����� �ڽ����� ����
            switch (imageName)
            {
                case "KingHeart":
                    GameObject kingHeartObj = Instantiate(kingHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    kingHeartObj.transform.parent = trackedImage.transform;
                    break;
                case "AceSpade":
                    GameObject aceSpadeObj = Instantiate(aceSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    aceSpadeObj.transform.parent = trackedImage.transform;
                    break;
            }
        }

        // ������ �̹����� ����(�̵�, ȸ��) �Ǿ��� ��
        foreach (ARTrackedImage trackedImage in args.updated)
        {
            // �̹����� ��������� �ִ� ��� �ڽ����� �ִ� ���ӿ�����Ʈ�� ��ġ�� ȸ���� ����
            trackedImage.transform.GetChild(0).position = trackedImage.transform.position;
            trackedImage.transform.GetChild(0).rotation = trackedImage.transform.rotation;
        }

        // ������ �̹����� ������� ��
        foreach (ARTrackedImage trackedImage in args.removed)
        {
            // �̹����� ����� ��� �ڽ����� �־��� ���ӿ�����Ʈ�� ����
            Destroy(trackedImage.transform.GetChild(0).gameObject);
        }
    }
}

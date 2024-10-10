using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MultiImageTracker : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager imageManager;

    [SerializeField] GameObject aceHeart;
    [SerializeField] GameObject kingHeart;
    [SerializeField] GameObject queenHeart;
    [SerializeField] GameObject jackHeart;
    [SerializeField] GameObject tenHeart;
    [SerializeField] GameObject nineHeart;
    [SerializeField] GameObject eightHeart;
    [SerializeField] GameObject sevenHeart;
    [SerializeField] GameObject sixHeart;
    [SerializeField] GameObject fiveHeart;
    [SerializeField] GameObject fourHeart;
    [SerializeField] GameObject threeHeart;
    [SerializeField] GameObject twoHeart;

    [SerializeField] GameObject aceDia;
    [SerializeField] GameObject kingDia;
    [SerializeField] GameObject queenDia;
    [SerializeField] GameObject jackDia;
    [SerializeField] GameObject tenDia;
    [SerializeField] GameObject nineDia;
    [SerializeField] GameObject eightDia;
    [SerializeField] GameObject sevenDia;
    [SerializeField] GameObject sixDia;
    [SerializeField] GameObject fiveDia;
    [SerializeField] GameObject fourDia;
    [SerializeField] GameObject threeDia;
    [SerializeField] GameObject twoDia;

    [SerializeField] GameObject aceClover;
    [SerializeField] GameObject kingClover;
    [SerializeField] GameObject queenClover;
    [SerializeField] GameObject jackClover;
    [SerializeField] GameObject tenClover;
    [SerializeField] GameObject nineClover;
    [SerializeField] GameObject eightClover;
    [SerializeField] GameObject sevenClover;
    [SerializeField] GameObject sixClover;
    [SerializeField] GameObject fiveClover;
    [SerializeField] GameObject fourClover;
    [SerializeField] GameObject threeClover;
    [SerializeField] GameObject twoClover;

    [SerializeField] GameObject aceSpade;
    [SerializeField] GameObject kingSpade;
    [SerializeField] GameObject queenSpade;
    [SerializeField] GameObject jackSpade;
    [SerializeField] GameObject tenSpade;
    [SerializeField] GameObject nineSpade;
    [SerializeField] GameObject eightSpade;
    [SerializeField] GameObject sevenSpade;
    [SerializeField] GameObject sixSpade;
    [SerializeField] GameObject fiveSpade;
    [SerializeField] GameObject fourSpade;
    [SerializeField] GameObject threeSpade;
    [SerializeField] GameObject twoSpade;

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
        // 새로운 이미지가 발견되었을 때
        foreach (ARTrackedImage trackedImage in args.added)
        {
            // 이미지 라이브러리에서 이미지의 이름을 확인
            string imageName = trackedImage.referenceImage.name;

            // 새로운 게임오브젝트를 트래킹한 이미지의 자식으로 생성
            switch (imageName)
            {
                case "AceHeart":
                    GameObject aceHeartObj = Instantiate(aceHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    aceHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "KingHeart":
                    GameObject kingHeartObj = Instantiate(kingHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    kingHeartObj.transform.parent = trackedImage.transform;
                    transform.LookAt(imageManager.transform.position);
                    break;

                case "QueenHeart":
                    GameObject queenHeartObj = Instantiate(queenHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    queenHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "JackHeart":
                    GameObject jackHeartObj = Instantiate(jackHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    jackHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "TenHeart":
                    GameObject tenHeartObj = Instantiate(tenHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    tenHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "NineHeart":
                    GameObject nineHeartObj = Instantiate(nineHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    nineHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "EightHeart":
                    GameObject eightHeartObj = Instantiate(eightHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    eightHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "SevenHeart":
                    GameObject sevenHeartObj = Instantiate(sevenHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    sevenHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "SixHeart":
                    GameObject sixHeartObj = Instantiate(sixHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    sixHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "FiveHeart":
                    GameObject fiveHeartObj = Instantiate(fiveHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    fiveHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "FourHeart":
                    GameObject fourHeartObj = Instantiate(fourHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    fourHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "ThreeHeart":
                    GameObject threeHeartObj = Instantiate(threeHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    threeHeartObj.transform.parent = trackedImage.transform;
                    break;

                case "TwoHeart":
                    GameObject twoHeartObj = Instantiate(twoHeart, trackedImage.transform.position, trackedImage.transform.rotation);
                    twoHeartObj.transform.parent = trackedImage.transform;
                    break;



                case "AceDia":
                    GameObject aceDiaObj = Instantiate(aceDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    aceDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "KingDia":
                    GameObject kingDiaObj = Instantiate(kingDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    kingDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "QueenDia":
                    GameObject queenDiaObj = Instantiate(queenDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    queenDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "JackDia":
                    GameObject jackDiaObj = Instantiate(jackDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    jackDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "TenDia":
                    GameObject tenDiaObj = Instantiate(tenDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    tenDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "NineDia":
                    GameObject nineDiaObj = Instantiate(nineDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    nineDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "EightDia":
                    GameObject eightDiaObj = Instantiate(eightDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    eightDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "SevenDia":
                    GameObject sevenDiaObj = Instantiate(sevenDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    sevenDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "SixDia":
                    GameObject sixDiaObj = Instantiate(sixDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    sixDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "FiveDia":
                    GameObject fiveDiaObj = Instantiate(fiveDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    fiveDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "FourDia":
                    GameObject fourDiaObj = Instantiate(fourDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    fourDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "ThreeDia":
                    GameObject threeDiaObj = Instantiate(threeDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    threeDiaObj.transform.parent = trackedImage.transform;
                    break;

                case "TwoDia":
                    GameObject twoDiaObj = Instantiate(twoDia, trackedImage.transform.position, trackedImage.transform.rotation);
                    twoDiaObj.transform.parent = trackedImage.transform;
                    break;


                case "AceClover":
                    GameObject aceCloverObj = Instantiate(aceClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    aceCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "KingClover":
                    GameObject kingCloverObj = Instantiate(kingClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    kingCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "QueenClover":
                    GameObject queenCloverObj = Instantiate(queenClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    queenCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "JackClover":
                    GameObject jackCloverObj = Instantiate(jackClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    jackCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "TenClover":
                    GameObject tenCloverObj = Instantiate(tenClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    tenCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "NineClover":
                    GameObject nineCloverObj = Instantiate(nineClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    nineCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "EightClover":
                    GameObject eightCloverObj = Instantiate(eightClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    eightCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "SevenClover":
                    GameObject sevenCloverObj = Instantiate(sevenClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    sevenCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "SixClover":
                    GameObject sixCloverObj = Instantiate(sixClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    sixCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "FiveClover":
                    GameObject fiveCloverObj = Instantiate(fiveClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    fiveCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "FourClover":
                    GameObject fourCloverObj = Instantiate(fourClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    fourCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "ThreeClover":
                    GameObject threeCloverObj = Instantiate(threeClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    threeCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "TwoClover":
                    GameObject twoCloverObj = Instantiate(twoClover, trackedImage.transform.position, trackedImage.transform.rotation);
                    twoCloverObj.transform.parent = trackedImage.transform;
                    break;

                case "AceSpade":
                    GameObject aceSpadeObj = Instantiate(aceSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    aceSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "KingSpade":
                    GameObject kingSpadeObj = Instantiate(kingSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    kingSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "QueenSpade":
                    GameObject queenSpadeObj = Instantiate(queenSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    queenSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "JackSpade":
                    GameObject jackSpadeObj = Instantiate(jackSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    jackSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "TenSpade":
                    GameObject tenSpadeObj = Instantiate(tenSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    tenSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "NineSpade":
                    GameObject nineSpadeObj = Instantiate(nineSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    nineSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "EightSpade":
                    GameObject eightSpadeObj = Instantiate(eightSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    eightSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "SevenSpade":
                    GameObject sevenSpadeObj = Instantiate(sevenSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    sevenSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "SixSpade":
                    GameObject sixSpadeObj = Instantiate(sixSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    sixSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "FiveSpade":
                    GameObject fiveSpadeObj = Instantiate(fiveSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    fiveSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "FourSpade":
                    GameObject fourSpadeObj = Instantiate(fourSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    fourSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "ThreeSpade":
                    GameObject threeSpadeObj = Instantiate(threeSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    threeSpadeObj.transform.parent = trackedImage.transform;
                    break;

                case "TwoSpade":
                    GameObject twoSpadeObj = Instantiate(twoSpade, trackedImage.transform.position, trackedImage.transform.rotation);
                    twoSpadeObj.transform.parent = trackedImage.transform;
                    break;
            }
        }

        // 기존의 이미지가 변경(이동, 회전) 되었을 때
        foreach (ARTrackedImage trackedImage in args.updated)
        {
            // 이미지의 변경사항이 있는 경우 자식으로 있던 게임오브젝트를 위치와 회전을 갱신
            trackedImage.transform.GetChild(0).position = trackedImage.transform.position;
            trackedImage.transform.GetChild(0).rotation = trackedImage.transform.rotation;
        }

        // 기존의 이미지가 사라졌을 때
        foreach (ARTrackedImage trackedImage in args.removed)
        {
            // 이미지가 사라진 경우 자식으로 있었던 게임오브젝트를 삭제
            Destroy(trackedImage.transform.GetChild(0).gameObject);
        }
    }
}

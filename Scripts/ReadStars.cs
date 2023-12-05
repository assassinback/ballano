using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.UI;
public class ReadStars : MonoBehaviour {

	// Use this for initialization
	public static level1 Level1;
	public level2 Level2;
	public level3 Level3;
	public level4 Level4;
	public level5 Level5;
	public level6 Level6;
	public level7 Level7;
	public level8 Level8;
	public level9 Level9;
	public level10 Level10;
	public level11 Level11;
	public level12 Level12;
	public level13 Level13;
	public level14 Level14;
	public level15 Level15;
	public level16 Level16;
	public level17 Level17;
	public level18 Level18;
	public level19 Level19;
	public level20 Level20;
	public level21 Level21;
	public level22 Level22;
	public level23 Level23;
	public level24 Level24;
	public level25 Level25;
	public level26 Level26;
	public level27 Level27;
	public level28 Level28;
	public level29 Level29;
	public level30 Level30;
	public level31 Level31;
	public level32 Level32;
	public level33 Level33;
	public level34 Level34;
	public level35 Level35;
	public level36 Level36;
	public level37 Level37;
	public level38 Level38;
	public level39 Level39;
	public level40 Level40;
	public level41 Level41;
	public level42 Level42;
	public level43 Level43;
	public level44 Level44;
	public level45 Level45;
	public level46 Level46;
	public level47 Level47;
	public level48 Level48;
	public level49 Level49;
	public level50 Level50;
	public level51 Level51;
	public level52 Level52;
	public level53 Level53;
	public level54 Level54;
	public level55 Level55;
	public level56 Level56;
	public level57 Level57;
	public level58 Level58;
	public level59 Level59;
	public level60 Level60;
	public GameObject l1;
	public GameObject l2;
	public GameObject l3;
	public GameObject l4;
	public GameObject l5;
	public GameObject l6;
	public GameObject l7;
	public GameObject l8;
	public GameObject l9;
	public GameObject l10;
	public GameObject l11;
	public GameObject l12;
	public GameObject l13;
	public GameObject l14;
	public GameObject l15;
	public GameObject l16;
	public GameObject l17;
	public GameObject l18;
	public GameObject l19;
	public GameObject l20;
	public GameObject l21;
	public GameObject l22;
	public GameObject l23;
	public GameObject l24;
	public GameObject l25;
	public GameObject l26;
	public GameObject l27;
	public GameObject l28;
	public GameObject l29;
	public GameObject l30;
	public GameObject l31;
	public GameObject l32;
	public GameObject l33;
	public GameObject l34;
	public GameObject l35;
	public GameObject l36;
	public GameObject l37;
	public GameObject l38;
	public GameObject l39;
	public GameObject l40;
	public GameObject l41;
	public GameObject l42;
	public GameObject l43;
	public GameObject l44;
	public GameObject l45;
	public GameObject l46;
	public GameObject l47;
	public GameObject l48;
	public GameObject l49;
	public GameObject l50;
	public GameObject l51;
	public GameObject l52;
	public GameObject l53;
	public GameObject l54;
	public GameObject l55;
	public GameObject l56;
	public GameObject l57;
	public GameObject l58;
	public GameObject l59;
	public GameObject l60;
	public Sprite Star1;
	public Sprite Star2;
	public Sprite Star3;

	public Image le1im1;
	public Image le1im2;
	public Image le1im3;
	public Image le2im1;
	public Image le2im2;
	public Image le2im3;
	public Image le3im1;
	public Image le3im2;
	public Image le3im3;
	public Image le4im1;
	public Image le4im2;
	public Image le4im3;
	public Image le5im1;
	public Image le5im2;
	public Image le5im3;
	public Image le6im1;
	public Image le6im2;
	public Image le6im3;
	public Image le7im1;
	public Image le7im2;
	public Image le7im3;
	public Image le8im1;
	public Image le8im2;
	public Image le8im3;
	public Image le9im1;
	public Image le9im2;
	public Image le9im3;
	public Image le10im1;
	public Image le10im2;
	public Image le10im3;
	public Image le11im1;
	public Image le11im2;
	public Image le11im3;
	public Image le12im1;
	public Image le12im2;
	public Image le12im3;
	public Image le13im1;
	public Image le13im2;
	public Image le13im3;
	public Image le14im1;
	public Image le14im2;
	public Image le14im3;
	public Image le15im1;
	public Image le15im2;
	public Image le15im3;
	public Image le16im1;
	public Image le16im2;
	public Image le16im3;
	public Image le17im1;
	public Image le17im2;
	public Image le17im3;
	public Image le18im1;
	public Image le18im2;
	public Image le18im3;
	public Image le19im1;
	public Image le19im2;
	public Image le19im3;
	public Image le20im1;
	public Image le20im2;
	public Image le20im3;
	public Image le21im1;
	public Image le21im2;
	public Image le21im3;
	public Image le22im1;
	public Image le22im2;
	public Image le22im3;
	public Image le23im1;
	public Image le23im2;
	public Image le23im3;
	public Image le24im1;
	public Image le24im2;
	public Image le24im3;
	public Image le25im1;
	public Image le25im2;
	public Image le25im3;
	public Image le26im1;
	public Image le26im2;
	public Image le26im3;
	public Image le27im1;
	public Image le27im2;
	public Image le27im3;
	public Image le28im1;
	public Image le28im2;
	public Image le28im3;
	public Image le29im1;
	public Image le29im2;
	public Image le29im3;
	public Image le30im1;
	public Image le30im2;
	public Image le30im3;
	public Image le31im1;
	public Image le31im2;
	public Image le31im3;
	public Image le32im1;
	public Image le32im2;
	public Image le32im3;
	public Image le33im1;
	public Image le33im2;
	public Image le33im3;
	public Image le34im1;
	public Image le34im2;
	public Image le34im3;
	public Image le35im1;
	public Image le35im2;
	public Image le35im3;
	public Image le36im1;
	public Image le36im2;
	public Image le36im3;
	public Image le37im1;
	public Image le37im2;
	public Image le37im3;
	public Image le38im1;
	public Image le38im2;
	public Image le38im3;
	public Image le39im1;
	public Image le39im2;
	public Image le39im3;
	public Image le40im1;
	public Image le40im2;
	public Image le40im3;
	public Image le41im1;
	public Image le41im2;
	public Image le41im3;
	public Image le42im1;
	public Image le42im2;
	public Image le42im3;
	public Image le43im1;
	public Image le43im2;
	public Image le43im3;
	public Image le44im1;
	public Image le44im2;
	public Image le44im3;
	public Image le45im1;
	public Image le45im2;
	public Image le45im3;
	public Image le46im1;
	public Image le46im2;
	public Image le46im3;
	public Image le47im1;
	public Image le47im2;
	public Image le47im3;
	public Image le48im1;
	public Image le48im2;
	public Image le48im3;
	public Image le49im1;
	public Image le49im2;
	public Image le49im3;
	public Image le50im1;
	public Image le50im2;
	public Image le50im3;
	public Image le51im1;
	public Image le51im2;
	public Image le51im3;
	public Image le52im1;
	public Image le52im2;
	public Image le52im3;
	public Image le53im1;
	public Image le53im2;
	public Image le53im3;
	public Image le54im1;
	public Image le54im2;
	public Image le54im3;
	public Image le55im1;
	public Image le55im2;
	public Image le55im3;
	public Image le56im1;
	public Image le56im2;
	public Image le56im3;
	public Image le57im1;
	public Image le57im2;
	public Image le57im3;
	public Image le58im1;
	public Image le58im2;
	public Image le58im3;
	public Image le59im1;
	public Image le59im2;
	public Image le59im3;
	public Image le60im1;
	public Image le60im2;
	public Image le60im3;
	public Image l1img;
	public Image l2img;
	public Image l3img;
	public Image l4img;
	public Image l5img;
	public Image l6img;
	public Image l7img;
	public Image l8img;
	public Image l9img;
	public Image l10img;
	public Image l11img;
	public Image l12img;
	public Image l13img;
	public Image l14img;
	public Image l15img;
	public Image l16img;
	public Image l17img;
	public Image l18img;
	public Image l19img;
	public Image l20img;
	public Image l21img;
	public Image l22img;
	public Image l23img;
	public Image l24img;
	public Image l25img;
	public Image l26img;
	public Image l27img;
	public Image l28img;
	public Image l29img;
	public Image l30img;
	public Image l31img;
	public Image l32img;
	public Image l33img;
	public Image l34img;
	public Image l35img;
	public Image l36img;
	public Image l37img;
	public Image l38img;
	public Image l39img;
	public Image l40img;
	public Image l41img;
	public Image l42img;
	public Image l43img;
	public Image l44img;
	public Image l45img;
	public Image l46img;
	public Image l47img;
	public Image l48img;
	public Image l49img;
	public Image l50img;
	public Image l51img;
	public Image l52img;
	public Image l53img;
	public Image l54img;
	public Image l55img;
	public Image l56img;
	public Image l57img;
	public Image l58img;
	public Image l59img;
	public Image l60img;
	public Sprite sp1;
	public Sprite sp2;
	public Sprite sp3;
	public Sprite sp4;
	public Sprite sp5;
	public Sprite sp6;
	public Sprite sp7;
	public Sprite sp8;
	public Sprite sp9;
	public Sprite sp10;
	public Sprite sp11;
	public Sprite sp12;
	public Sprite sp13;
	public Sprite sp14;
	public Sprite sp15;
	public Sprite sp16;
	public Sprite sp17;
	public Sprite sp18;
	public Sprite sp19;
	public Sprite sp20;
	public Sprite sp21;
	public Sprite sp22;
	public Sprite sp23;
	public Sprite sp24;
	public Sprite sp25;
	public Sprite sp26;
	public Sprite sp27;
	public Sprite sp28;
	public Sprite sp29;
	public Sprite sp30;
	public Sprite sp31;
	public Sprite sp32;
	public Sprite sp33;
	public Sprite sp34;
	public Sprite sp35;
	public Sprite sp36;
	public Sprite sp37;
	public Sprite sp38;
	public Sprite sp39;
	public Sprite sp40;
	public Sprite sp41;
	public Sprite sp42;
	public Sprite sp43;
	public Sprite sp44;
	public Sprite sp45;
	public Sprite sp46;
	public Sprite sp47;
	public Sprite sp48;
	public Sprite sp49;
	public Sprite sp50;
	public Sprite sp51;
	public Sprite sp52;
	public Sprite sp53;
	public Sprite sp54;
	public Sprite sp55;
	public Sprite sp56;
	public Sprite sp57;
	public Sprite sp58;
	public Sprite sp59;
	public Sprite sp60;

	public GameObject l1bimg;
	public GameObject l2bimg;
	public GameObject l3bimg;
	public GameObject l4bimg;
	public GameObject l5bimg;
	public GameObject l6bimg;
	public GameObject l7bimg;
	public GameObject l8bimg;
	public GameObject l9bimg;
	public GameObject l10bimg;
	public GameObject l11bimg;
	public GameObject l12bimg;
	
	void Awake(){
		
		StartCoroutine(readStuff());
	}
	void Start () {
		
		
		// string json;
		// //ResourceHelper.SaveToPersistentData ("level3.json", "");
		// if (ResourceHelper.ExistsInPersistentData ("level1.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level1.json");
		// 	Level1 = ResourceHelper.DecodeObject<level1> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level2.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level2.json");
		// 	Level2 = ResourceHelper.DecodeObject<level2> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level3.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level3.json");
		// 	Level3 = ResourceHelper.DecodeObject<level3> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level4.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level4.json");
		// 	Level4 = ResourceHelper.DecodeObject<level4> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level5.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level5.json");
		// 	Level5 = ResourceHelper.DecodeObject<level5> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level6.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level6.json");
		// 	Level6 = ResourceHelper.DecodeObject<level6> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level7.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level7.json");
		// 	Level7 = ResourceHelper.DecodeObject<level7> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level8.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level8.json");
		// 	Level8 = ResourceHelper.DecodeObject<level8> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level9.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level9.json");
		// 	Level9 = ResourceHelper.DecodeObject<level9> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level10.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level10.json");
		// 	Level10 = ResourceHelper.DecodeObject<level10> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level11.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level11.json");
		// 	Level11 = ResourceHelper.DecodeObject<level11> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level12.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level12.json");
		// 	Level12 = ResourceHelper.DecodeObject<level12> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level13.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level13.json");
		// 	Level13 = ResourceHelper.DecodeObject<level13> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level14.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level14.json");
		// 	Level14 = ResourceHelper.DecodeObject<level14> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level15.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level15.json");
		// 	Level15 = ResourceHelper.DecodeObject<level15> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level16.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level16.json");
		// 	Level16 = ResourceHelper.DecodeObject<level16> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level17.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level17.json");
		// 	Level17 = ResourceHelper.DecodeObject<level17> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level18.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level18.json");
		// 	Level18 = ResourceHelper.DecodeObject<level18> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level19.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level19.json");
		// 	Level19 = ResourceHelper.DecodeObject<level19> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level20.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level20.json");
		// 	Level20 = ResourceHelper.DecodeObject<level20> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level21.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level21.json");
		// 	Level21 = ResourceHelper.DecodeObject<level21> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level22.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level22.json");
		// 	Level22 = ResourceHelper.DecodeObject<level22> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level23.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level23.json");
		// 	Level23 = ResourceHelper.DecodeObject<level23> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level24.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level24.json");
		// 	Level24 = ResourceHelper.DecodeObject<level24> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level25.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level25.json");
		// 	Level25 = ResourceHelper.DecodeObject<level25> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level26.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level26.json");
		// 	Level26 = ResourceHelper.DecodeObject<level26> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level27.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level27.json");
		// 	Level27 = ResourceHelper.DecodeObject<level27> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level28.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level28.json");
		// 	Level28 = ResourceHelper.DecodeObject<level28> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level29.json")){
		// 	json = ResourceHelper.ReadFromPersistentData ("level29.json");
		// Level29 = ResourceHelper.DecodeObject<level29> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level30.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level30.json");
		// 	Level30 = ResourceHelper.DecodeObject<level30> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level31.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level31.json");
		// 	Level31 = ResourceHelper.DecodeObject<level31> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level32.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level32.json");
		// 	Level32 = ResourceHelper.DecodeObject<level32> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level33.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level33.json");
		// 	Level33 = ResourceHelper.DecodeObject<level33> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level34.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level34.json");
		// 	Level34 = ResourceHelper.DecodeObject<level34> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level35.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level35.json");
		// 	Level35 = ResourceHelper.DecodeObject<level35> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level36.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level36.json");
		// 	Level36 = ResourceHelper.DecodeObject<level36> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level37.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level37.json");
		// 	Level37 = ResourceHelper.DecodeObject<level37> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level38.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level38.json");
		// 	Level38 = ResourceHelper.DecodeObject<level38> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level39.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level39.json");
		// 	Level39 = ResourceHelper.DecodeObject<level39> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level40.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level40.json");
		// 	Level40 = ResourceHelper.DecodeObject<level40> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level41.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level41.json");
		// 	Level41 = ResourceHelper.DecodeObject<level41> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level42.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level42.json");
		// 	Level42 = ResourceHelper.DecodeObject<level42> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level43.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level43.json");
		// 	Level43 = ResourceHelper.DecodeObject<level43> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level44.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level44.json");
		// 	Level44 = ResourceHelper.DecodeObject<level44> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level45.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level45.json");
		// 	Level45 = ResourceHelper.DecodeObject<level45> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level46.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level46.json");
		// 	Level46 = ResourceHelper.DecodeObject<level46> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level47.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level47.json");
		// 	Level47 = ResourceHelper.DecodeObject<level47> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level48.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level48.json");
		// 	Level48 = ResourceHelper.DecodeObject<level48> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level49.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level49.json");
		// 	Level49 = ResourceHelper.DecodeObject<level49> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level50.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level50.json");
		// 	Level50 = ResourceHelper.DecodeObject<level50> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level51.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level51.json");
		// 	Level51 = ResourceHelper.DecodeObject<level51> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level52.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level52.json");
		// 	Level52 = ResourceHelper.DecodeObject<level52> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level53.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level53.json");
		// 	Level53 = ResourceHelper.DecodeObject<level53> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level54.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level54.json");
		// 	Level54 = ResourceHelper.DecodeObject<level54> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level55.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level55.json");
		// 	Level55 = ResourceHelper.DecodeObject<level55> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level56.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level56.json");
		// 	Level56 = ResourceHelper.DecodeObject<level56> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level57.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level57.json");
		// 	Level57 = ResourceHelper.DecodeObject<level57> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level58.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level58.json");
		// 	Level58 = ResourceHelper.DecodeObject<level58> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level59.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level59.json");
		// 	Level59 = ResourceHelper.DecodeObject<level59> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level60.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level60.json");
		// 	Level60 = ResourceHelper.DecodeObject<level60> (json);
		// }
		// if(ResourceHelper.ExistsInPersistentData("level1.json"))
		// {
		// 	l1img.sprite = sp1;
		// 	//l1img.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		// 	print ("lol");
		// 	l1.SetActive (true);
		// 	try{

		// 	print ("here");
		// 	if (Level1.completed == true) {
		// 		if (Level1.star == 3) {
				
		// 			le1im1.sprite = Star1;
		// 			le1im2.sprite = Star2;
		// 			le1im3.sprite = Star3;
		// 		} else if (Level1.star == 2) {
		// 			print ("1star");
		// 			le1im1.sprite = Star1;
		// 			le1im2.sprite = Star2;
		// 		} else if (Level1.star == 1) {
				
		// 			le1im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level2.json"))
		// {
			
		// 	l2img.sprite = sp2;
		// 	print ("lol");
		// 	l2.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level2.completed == true) {
		// 		if (Level2.star == 3) {

		// 			le2im1.sprite = Star1;
		// 			le2im2.sprite = Star2;
		// 			le2im3.sprite = Star3;
		// 		} else if (Level2.star == 2) {
		// 			print ("1star");
		// 			le2im1.sprite = Star1;
		// 			le2im2.sprite = Star2;
		// 		} else if (Level2.star == 1) {

		// 			le2im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level3.json"))
		// {
		// 	l3img.sprite = sp3;
		// 	print ("lol");
		// 	l3.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level3.completed == true) {
		// 		if (Level3.star == 3) {

		// 			le3im1.sprite = Star1;
		// 			le3im2.sprite = Star2;
		// 			le3im3.sprite = Star3;
		// 		} else if (Level3.star == 2) {
		// 			print ("1star");
		// 			le3im1.sprite = Star1;
		// 			le3im2.sprite = Star2;
		// 		} else if (Level3.star == 1) {

		// 			le3im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level4.json"))
		// {
		// 	l4img.sprite = sp4;
		// 	print ("lol");
		// 	l4.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level4.completed == true) {
		// 		if (Level4.star == 3) {

		// 			le4im1.sprite = Star1;
		// 			le4im2.sprite = Star2;
		// 			le4im3.sprite = Star3;
		// 		} else if (Level4.star == 2) {
		// 			print ("1star");
		// 			le4im1.sprite = Star1;
		// 			le4im2.sprite = Star2;
		// 		} else if (Level4.star == 1) {

		// 			le4im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level5.json"))
		// {
		// 	l5img.sprite = sp5;
		// 	print ("lol");
		// 	l5.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level5.completed == true) {
		// 		if (Level5.star == 3) {

		// 			le5im1.sprite = Star1;
		// 			le5im2.sprite = Star2;
		// 			le5im3.sprite = Star3;
		// 		} else if (Level5.star == 2) {
		// 			print ("1star");
		// 			le5im1.sprite = Star1;
		// 			le5im2.sprite = Star2;
		// 		} else if (Level5.star == 1) {

		// 			le5im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level6.json"))
		// {
		// 	l6img.sprite = sp6;
		// 	print ("lol");
		// 	l6.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level6.completed == true) {
		// 		if (Level6.star == 3) {

		// 			le6im1.sprite = Star1;
		// 			le6im2.sprite = Star2;
		// 			le6im3.sprite = Star3;
		// 		} else if (Level6.star == 2) {
		// 			print ("1star");
		// 			le6im1.sprite = Star1;
		// 			le6im2.sprite = Star2;
		// 		} else if (Level6.star == 1) {

		// 			le6im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level7.json")) {
		// 	l7img.sprite = sp7;
		// 	print ("lol");
		// 	l7.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level7.completed == true) {
		// 		if (Level7.star == 3) {

		// 			le7im1.sprite = Star1;
		// 			le7im2.sprite = Star2;
		// 			le7im3.sprite = Star3;
		// 		} else if (Level7.star == 2) {
		// 			print ("1star");
		// 			le7im1.sprite = Star1;
		// 			le7im2.sprite = Star2;
		// 		} else if (Level7.star == 1) {

		// 			le7im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception) {
		// 	}
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level8.json")) {
		// 	l8img.sprite = sp8;
		// 	print ("lol");
		// 	l8.SetActive (true);
		// 	print ("here");
		// 	try
		// 	{
		// 	if (Level8.completed == true) {
		// 		if (Level8.star == 3) {

		// 			le8im1.sprite = Star1;
		// 			le8im2.sprite = Star2;
		// 			le8im3.sprite = Star3;
		// 		} else if (Level8.star == 2) {
		// 			print ("1star");
		// 			le8im1.sprite = Star1;
		// 			le8im2.sprite = Star2;
		// 		} else if (Level8.star == 1) {

		// 			le8im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level9.json")) {
		// 	l9img.sprite = sp9;
		// 	print ("lol");
		// 	l9.SetActive (true);
		// 	print ("here");
		// 	try{if (Level9.completed == true) {
		// 		if (Level9.star == 3) {

		// 			le9im1.sprite = Star1;
		// 			le9im2.sprite = Star2;
		// 			le9im3.sprite = Star3;
		// 		} else if (Level9.star == 2) {
		// 			print ("1star");
		// 			le9im1.sprite = Star1;
		// 			le9im2.sprite = Star2;
		// 		} else if (Level9.star == 1) {

		// 			le9im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception) {
				
		// 	}
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level10.json")) {
		// 	try{
		// 	l10img.sprite = sp10;
		// 	print ("lol");
		// 	l10.SetActive (true);
		// 	print ("here");

		// 	if (Level10.completed == true) {
		// 		if (Level10.star == 3) {

		// 			le10im1.sprite = Star1;
		// 			le10im2.sprite = Star2;
		// 			le10im3.sprite = Star3;
		// 		} else if (Level10.star == 2) {
		// 			print ("1star");
		// 			le10im1.sprite = Star1;
		// 			le10im2.sprite = Star2;
		// 		} else if (Level10.star == 1) {

		// 			le10im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception)
		// 	{
		// 		Debug.Log ("thkdkh");
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level11.json"))
		// 	{
		// 		l11img.sprite = sp11;
		// 		print ("lol");
		// 		l11.SetActive (true);
		// 		print ("here");
		// 	try{
		// 	if (Level11.completed == true) {
		// 		if (Level11.star == 3) {

		// 			le11im1.sprite = Star1;
		// 			le11im2.sprite = Star2;
		// 			le11im3.sprite = Star3;
		// 		} else if (Level11.star == 2) {
		// 			print ("1star");
		// 			le11im1.sprite = Star1;
		// 			le11im2.sprite = Star2;
		// 		} else if (Level11.star == 1) {

		// 			le11im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// 	}
		// if(ResourceHelper.ExistsInPersistentData("level12.json"))
		// 	{
		// 		l12img.sprite = sp12;
		// 		l12.SetActive (true);

		// 		print ("here");
		// 	try{
		// 	if (Level12.completed == true) {
		// 		if (Level12.star == 3) {

		// 			le12im1.sprite = Star1;
		// 			le12im2.sprite = Star2;
		// 			le12im3.sprite = Star3;
		// 		} else if (Level12.star == 2) {
		// 			print ("1star");
		// 			le12im1.sprite = Star1;
		// 			le12im2.sprite = Star2;
		// 		} else if (Level12.star == 1) {

		// 			le12im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// 	}
		// if(ResourceHelper.ExistsInPersistentData("level13.json"))
		// {
		// 	l13img.sprite = sp13;
		// 	l13.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level13.completed == true) {
		// 		if (Level13.star == 3) {

		// 			le13im1.sprite = Star1;
		// 			le13im2.sprite = Star2;
		// 			le13im3.sprite = Star3;
		// 		} else if (Level13.star == 2) {
		// 			print ("1star");
		// 			le13im1.sprite = Star1;
		// 			le13im2.sprite = Star2;
		// 		} else if (Level13.star == 1) {

		// 			le13im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level14.json"))
		// {
		// 	l14img.sprite = sp14;
		// 	l14.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level14.completed == true) {
		// 		if (Level14.star == 3) {

		// 			le14im1.sprite = Star1;
		// 			le14im2.sprite = Star2;
		// 			le14im3.sprite = Star3;
		// 		} else if (Level14.star == 2) {
		// 			print ("1star");
		// 			le14im1.sprite = Star1;
		// 			le14im2.sprite = Star2;
		// 		} else if (Level14.star == 1) {

		// 			le14im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level15.json"))
		// {
		// 	l15img.sprite = sp15;
		// 	l15.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level15.completed == true) {
		// 		if (Level15.star == 3) {

		// 			le15im1.sprite = Star1;
		// 			le15im2.sprite = Star2;
		// 			le15im3.sprite = Star3;
		// 		} else if (Level15.star == 2) {
		// 			print ("1star");
		// 			le15im1.sprite = Star1;
		// 			le15im2.sprite = Star2;
		// 		} else if (Level15.star == 1) {

		// 			le15im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception) {
				
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level16.json"))
		// {
		// 	l16img.sprite = sp16;
		// 	l16.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level16.completed == true) {
		// 		if (Level16.star == 3) {

		// 			le16im1.sprite = Star1;
		// 			le16im2.sprite = Star2;
		// 			le16im3.sprite = Star3;
		// 		} else if (Level16.star == 2) {
		// 			print ("1star");
		// 			le16im1.sprite = Star1;
		// 			le16im2.sprite = Star2;
		// 		} else if (Level16.star == 1) {

		// 			le16im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level17.json"))
		// {
		// 	l17img.sprite = sp17;
		// 	l17.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level17.completed == true) {
		// 		if (Level17.star == 3) {

		// 			le17im1.sprite = Star1;
		// 			le17im2.sprite = Star2;
		// 			le17im3.sprite = Star3;
		// 		} else if (Level17.star == 2) {
		// 			print ("1star");
		// 			le17im1.sprite = Star1;
		// 			le17im2.sprite = Star2;
		// 		} else if (Level17.star == 1) {

		// 			le17im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level18.json"))
		// {
		// 	l18img.sprite = sp18;
		// 	l18.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level18.completed == true) {
		// 		if (Level18.star == 3) {

		// 			le18im1.sprite = Star1;
		// 			le18im2.sprite = Star2;
		// 			le18im3.sprite = Star3;
		// 		} else if (Level18.star == 2) {
		// 			print ("1star");
		// 			le18im1.sprite = Star1;
		// 			le18im2.sprite = Star2;
		// 		} else if (Level18.star == 1) {

		// 			le18im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level19.json"))
		// {
		// 	l19img.sprite = sp19;
		// 	l19.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level19.completed == true) {
		// 		if (Level19.star == 3) {

		// 			le19im1.sprite = Star1;
		// 			le19im2.sprite = Star2;
		// 			le19im3.sprite = Star3;
		// 		} else if (Level19.star == 2) {
		// 			print ("1star");
		// 			le19im1.sprite = Star1;
		// 			le19im2.sprite = Star2;
		// 		} else if (Level19.star == 1) {

		// 			le19im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level20.json"))
		// {
		// 	l20img.sprite = sp20;
		// 	l20.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level20.completed == true) {
		// 		if (Level20.star == 3) {

		// 			le20im1.sprite = Star1;
		// 			le20im2.sprite = Star2;
		// 			le20im3.sprite = Star3;
		// 		} else if (Level20.star == 2) {
		// 			print ("1star");
		// 			le20im1.sprite = Star1;
		// 			le20im2.sprite = Star2;
		// 		} else if (Level20.star == 1) {

		// 			le20im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level21.json"))
		// {
		// 	l21img.sprite = sp21;
		// 	l21.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level21.completed == true) {
		// 		if (Level21.star == 3) {

		// 			le21im1.sprite = Star1;
		// 			le21im2.sprite = Star2;
		// 			le21im3.sprite = Star3;
		// 		} else if (Level21.star == 2) {
		// 			print ("1star");
		// 			le21im1.sprite = Star1;
		// 			le21im2.sprite = Star2;
		// 		} else if (Level21.star == 1) {

		// 			le21im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level22.json"))
		// {
		// 	l22img.sprite = sp22;
		// 	l22.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level22.completed == true) {
		// 		if (Level22.star == 3) {

		// 			le22im1.sprite = Star1;
		// 			le22im2.sprite = Star2;
		// 			le22im3.sprite = Star3;
		// 		} else if (Level22.star == 2) {
		// 			print ("1star");
		// 			le22im1.sprite = Star1;
		// 			le22im2.sprite = Star2;
		// 		} else if (Level22.star == 1) {

		// 			le22im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception) {
				
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level23.json"))
		// {
		// 	l23img.sprite = sp23;
		// 	l23.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level23.completed == true) {
		// 		if (Level23.star == 3) {

		// 			le23im1.sprite = Star1;
		// 			le23im2.sprite = Star2;
		// 			le23im3.sprite = Star3;
		// 		} else if (Level23.star == 2) {
		// 			print ("1star");
		// 			le23im1.sprite = Star1;
		// 			le23im2.sprite = Star2;
		// 		} else if (Level23.star == 1) {

		// 			le23im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level24.json"))
		// {
		// 	l24img.sprite = sp24;
		// 	l24.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level24.completed == true) {
		// 		if (Level24.star == 3) {

		// 			le24im1.sprite = Star1;
		// 			le24im2.sprite = Star2;
		// 			le24im3.sprite = Star3;
		// 		} else if (Level24.star == 2) {
		// 			print ("1star");
		// 			le24im1.sprite = Star1;
		// 			le24im2.sprite = Star2;
		// 		} else if (Level24.star == 1) {

		// 			le24im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level25.json"))
		// {
		// 	l25img.sprite = sp25;
		// 	l25.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level25.completed == true) {
		// 		if (Level25.star == 3) {

		// 			le25im1.sprite = Star1;
		// 			le25im2.sprite = Star2;
		// 			le25im3.sprite = Star3;
		// 		} else if (Level25.star == 2) {
		// 			print ("1star");
		// 			le25im1.sprite = Star1;
		// 			le25im2.sprite = Star2;
		// 		} else if (Level25.star == 1) {

		// 			le25im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level26.json"))
		// {
		// 	l26img.sprite = sp26;
		// 	l26.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level26.completed == true) {
		// 		if (Level26.star == 3) {

		// 			le26im1.sprite = Star1;
		// 			le26im2.sprite = Star2;
		// 			le26im3.sprite = Star3;
		// 		} else if (Level26.star == 2) {
		// 			print ("1star");
		// 			le26im1.sprite = Star1;
		// 			le26im2.sprite = Star2;
		// 		} else if (Level26.star == 1) {

		// 			le26im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level27.json"))
		// {
		// 	l27img.sprite = sp27;
		// 	l27.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level27.completed == true) {
		// 		if (Level27.star == 3) {

		// 			le27im1.sprite = Star1;
		// 			le27im2.sprite = Star2;
		// 			le27im3.sprite = Star3;
		// 		} else if (Level27.star == 2) {
		// 			print ("1star");
		// 			le27im1.sprite = Star1;
		// 			le27im2.sprite = Star2;
		// 		} else if (Level27.star == 1) {

		// 			le27im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level28.json"))
		// {
		// 	l28img.sprite = sp28;
		// 	l28.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level28.completed == true) {
		// 		if (Level28.star == 3) {

		// 			le28im1.sprite = Star1;
		// 			le28im2.sprite = Star2;
		// 			le28im3.sprite = Star3;
		// 		} else if (Level28.star == 2) {
		// 			print ("1star");
		// 			le28im1.sprite = Star1;
		// 			le28im2.sprite = Star2;
		// 		} else if (Level28.star == 1) {

		// 			le28im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level29.json"))
		// {
		// 	l29img.sprite = sp29;
		// 	l29.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level29.completed == true) {
		// 		if (Level29.star == 3) {

		// 			le29im1.sprite = Star1;
		// 			le29im2.sprite = Star2;
		// 			le29im3.sprite = Star3;
		// 		} else if (Level29.star == 2) {
		// 			print ("1star");
		// 			le29im1.sprite = Star1;
		// 			le29im2.sprite = Star2;
		// 		} else if (Level29.star == 1) {

		// 			le29im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level30.json"))
		// {
		// 	l30img.sprite = sp30;
		// 	l30.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level30.completed == true) {
		// 		if (Level30.star == 3) {

		// 			le30im1.sprite = Star1;
		// 			le30im2.sprite = Star2;
		// 			le30im3.sprite = Star3;
		// 		} else if (Level30.star == 2) {
		// 			print ("1star");
		// 			le30im1.sprite = Star1;
		// 			le30im2.sprite = Star2;
		// 		} else if (Level30.star == 1) {

		// 			le30im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level31.json"))
		// {
		// 	l31img.sprite = sp31;
		// 	l31.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level31.completed == true) {
		// 		if (Level31.star == 3) {

		// 			le31im1.sprite = Star1;
		// 			le31im2.sprite = Star2;
		// 			le31im3.sprite = Star3;
		// 		} else if (Level31.star == 2) {
		// 			print ("1star");
		// 			le31im1.sprite = Star1;
		// 			le31im2.sprite = Star2;
		// 		} else if (Level31.star == 1) {

		// 			le31im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level32.json"))
		// {
		// 	l32img.sprite = sp32;
		// 	l32.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level32.completed == true) {
		// 		if (Level32.star == 3) {

		// 			le32im1.sprite = Star1;
		// 			le32im2.sprite = Star2;
		// 			le32im3.sprite = Star3;
		// 		} else if (Level32.star == 2) {
		// 			print ("1star");
		// 			le32im1.sprite = Star1;
		// 			le32im2.sprite = Star2;
		// 		} else if (Level32.star == 1) {

		// 			le32im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level33.json"))
		// {
		// 	l33img.sprite = sp33;
		// 	l33.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level33.completed == true) {
		// 		if (Level33.star == 3) {

		// 			le33im1.sprite = Star1;
		// 			le33im2.sprite = Star2;
		// 			le33im3.sprite = Star3;
		// 		} else if (Level33.star == 2) {
		// 			print ("1star");
		// 			le33im1.sprite = Star1;
		// 			le33im2.sprite = Star2;
		// 		} else if (Level33.star == 1) {

		// 			le33im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level34.json"))
		// {
		// 	l34img.sprite = sp34;
		// 	l34.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level34.completed == true) {
		// 		if (Level34.star == 3) {

		// 			le34im1.sprite = Star1;
		// 			le34im2.sprite = Star2;
		// 			le34im3.sprite = Star3;
		// 		} else if (Level34.star == 2) {
		// 			print ("1star");
		// 			le34im1.sprite = Star1;
		// 			le34im2.sprite = Star2;
		// 		} else if (Level34.star == 1) {

		// 			le34im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level35.json"))
		// {
		// 	l35img.sprite = sp35;
		// 	l35.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level35.completed == true) {
		// 		if (Level35.star == 3) {

		// 			le35im1.sprite = Star1;
		// 			le35im2.sprite = Star2;
		// 			le35im3.sprite = Star3;
		// 		} else if (Level35.star == 2) {
		// 			print ("1star");
		// 			le35im1.sprite = Star1;
		// 			le35im2.sprite = Star2;
		// 		} else if (Level35.star == 1) {

		// 			le35im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level36.json"))
		// {
		// 	l36img.sprite = sp36;
		// 	l36.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level36.completed == true) {
		// 		if (Level36.star == 3) {

		// 			le36im1.sprite = Star1;
		// 			le36im2.sprite = Star2;
		// 			le36im3.sprite = Star3;
		// 		} else if (Level36.star == 2) {
		// 			print ("1star");
		// 			le36im1.sprite = Star1;
		// 			le36im2.sprite = Star2;
		// 		} else if (Level36.star == 1) {

		// 			le36im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level37.json"))
		// {
		// 	l37img.sprite = sp37;
		// 	l37.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level37.completed == true) {
		// 		if (Level37.star == 3) {

		// 			le37im1.sprite = Star1;
		// 			le37im2.sprite = Star2;
		// 			le37im3.sprite = Star3;
		// 		} else if (Level37.star == 2) {
		// 			print ("1star");
		// 			le37im1.sprite = Star1;
		// 			le37im2.sprite = Star2;
		// 		} else if (Level37.star == 1) {

		// 			le37im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level38.json"))
		// {
		// 	l38img.sprite = sp38;
		// 	l38.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level38.completed == true) {
		// 		if (Level38.star == 3) {

		// 			le38im1.sprite = Star1;
		// 			le38im2.sprite = Star2;
		// 			le38im3.sprite = Star3;
		// 		} else if (Level38.star == 2) {
		// 			print ("1star");
		// 			le38im1.sprite = Star1;
		// 			le38im2.sprite = Star2;
		// 		} else if (Level38.star == 1) {

		// 			le38im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level39.json"))
		// {
		// 	l39img.sprite = sp39;
		// 	l39.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level39.completed == true) {
		// 		if (Level39.star == 3) {

		// 			le39im1.sprite = Star1;
		// 			le39im2.sprite = Star2;
		// 			le39im3.sprite = Star3;
		// 		} else if (Level39.star == 2) {
		// 			print ("1star");
		// 			le39im1.sprite = Star1;
		// 			le39im2.sprite = Star2;
		// 		} else if (Level39.star == 1) {

		// 			le39im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level40.json"))
		// {
		// 	l40img.sprite = sp40;
		// 	l40.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level40.completed == true) {
		// 		if (Level40.star == 3) {

		// 			le40im1.sprite = Star1;
		// 			le40im2.sprite = Star2;
		// 			le40im3.sprite = Star3;
		// 		} else if (Level40.star == 2) {
		// 			print ("1star");
		// 			le40im1.sprite = Star1;
		// 			le40im2.sprite = Star2;
		// 		} else if (Level40.star == 1) {

		// 			le40im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level41.json"))
		// {
		// 	l41img.sprite = sp41;
		// 	l41.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level41.completed == true) {
		// 		if (Level41.star == 3) {

		// 			le41im1.sprite = Star1;
		// 			le41im2.sprite = Star2;
		// 			le41im3.sprite = Star3;
		// 		} else if (Level41.star == 2) {
		// 			print ("1star");
		// 			le41im1.sprite = Star1;
		// 			le41im2.sprite = Star2;
		// 		} else if (Level41.star == 1) {

		// 			le41im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level42.json"))
		// {
		// 	l42img.sprite = sp42;
		// 	l42.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level42.completed == true) {
		// 		if (Level42.star == 3) {

		// 			le42im1.sprite = Star1;
		// 			le42im2.sprite = Star2;
		// 			le42im3.sprite = Star3;
		// 		} else if (Level42.star == 2) {
		// 			print ("1star");
		// 			le42im1.sprite = Star1;
		// 			le42im2.sprite = Star2;
		// 		} else if (Level42.star == 1) {

		// 			le42im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level43.json"))
		// {
		// 	l43img.sprite = sp43;
		// 	l43.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level43.completed == true) {
		// 		if (Level43.star == 3) {

		// 			le43im1.sprite = Star1;
		// 			le43im2.sprite = Star2;
		// 			le43im3.sprite = Star3;
		// 		} else if (Level43.star == 2) {
		// 			print ("1star");
		// 			le43im1.sprite = Star1;
		// 			le43im2.sprite = Star2;
		// 		} else if (Level43.star == 1) {

		// 			le43im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level44.json"))
		// {
		// 	l44img.sprite = sp44;
		// 	l44.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level44.completed == true) {
		// 		if (Level44.star == 3) {

		// 			le44im1.sprite = Star1;
		// 			le44im2.sprite = Star2;
		// 			le44im3.sprite = Star3;
		// 		} else if (Level44.star == 2) {
		// 			print ("1star");
		// 			le44im1.sprite = Star1;
		// 			le44im2.sprite = Star2;
		// 		} else if (Level44.star == 1) {

		// 			le44im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception) {
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level45.json"))
		// {
		// 	l45img.sprite = sp45;
		// 	l45.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level45.completed == true) {
		// 		if (Level45.star == 3) {

		// 			le45im1.sprite = Star1;
		// 			le45im2.sprite = Star2;
		// 			le45im3.sprite = Star3;
		// 		} else if (Level45.star == 2) {
		// 			print ("1star");
		// 			le45im1.sprite = Star1;
		// 			le45im2.sprite = Star2;
		// 		} else if (Level45.star == 1) {

		// 			le45im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level46.json"))
		// {
		// 	l46img.sprite = sp46;
		// 	l46.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level46.completed == true) {
		// 		if (Level46.star == 3) {

		// 			le46im1.sprite = Star1;
		// 			le46im2.sprite = Star2;
		// 			le46im3.sprite = Star3;
		// 		} else if (Level46.star == 2) {
		// 			print ("1star");
		// 			le46im1.sprite = Star1;
		// 			le46im2.sprite = Star2;
		// 		} else if (Level46.star == 1) {

		// 			le46im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level47.json"))
		// {
		// 	l47img.sprite = sp47;
		// 	l47.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level47.completed == true) {
		// 		if (Level47.star == 3) {

		// 			le47im1.sprite = Star1;
		// 			le47im2.sprite = Star2;
		// 			le47im3.sprite = Star3;
		// 		} else if (Level47.star == 2) {
		// 			print ("1star");
		// 			le47im1.sprite = Star1;
		// 			le47im2.sprite = Star2;
		// 		} else if (Level47.star == 1) {

		// 			le47im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level48.json"))
		// {
		// 	l48img.sprite = sp48;
		// 	l48.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level48.completed == true) {
		// 		if (Level48.star == 3) {

		// 			le48im1.sprite = Star1;
		// 			le48im2.sprite = Star2;
		// 			le48im3.sprite = Star3;
		// 		} else if (Level48.star == 2) {
		// 			print ("1star");
		// 			le48im1.sprite = Star1;
		// 			le48im2.sprite = Star2;
		// 		} else if (Level48.star == 1) {

		// 			le48im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level49.json"))
		// {
		// 	l49img.sprite = sp49;
		// 	l49.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level49.completed == true) {
		// 		if (Level49.star == 3) {

		// 			le49im1.sprite = Star1;
		// 			le49im2.sprite = Star2;
		// 			le49im3.sprite = Star3;
		// 		} else if (Level49.star == 2) {
		// 			print ("1star");
		// 			le49im1.sprite = Star1;
		// 			le49im2.sprite = Star2;
		// 		} else if (Level49.star == 1) {

		// 			le49im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level50.json"))
		// {
		// 	l50img.sprite = sp50;
		// 	l50.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level50.completed == true) {
		// 		if (Level50.star == 3) {

		// 			le50im1.sprite = Star1;
		// 			le50im2.sprite = Star2;
		// 			le50im3.sprite = Star3;
		// 		} else if (Level50.star == 2) {
		// 			print ("1star");
		// 			le50im1.sprite = Star1;
		// 			le50im2.sprite = Star2;
		// 		} else if (Level50.star == 1) {

		// 			le50im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level51.json"))
		// {
		// 	l51img.sprite = sp51;
		// 	l51.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level51.completed == true) {
		// 		if (Level51.star == 3) {

		// 			le51im1.sprite = Star1;
		// 			le51im2.sprite = Star2;
		// 			le51im3.sprite = Star3;
		// 		} else if (Level51.star == 2) {
		// 			print ("1star");
		// 			le51im1.sprite = Star1;
		// 			le51im2.sprite = Star2;
		// 		} else if (Level51.star == 1) {

		// 			le51im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level52.json"))
		// {
		// 	l52img.sprite = sp52;
		// 	l52.SetActive (true);
		
		// 	print ("here");
		// 	try{
		// 	if (Level52.completed == true) {
		// 		if (Level52.star == 3) {

		// 			le52im1.sprite = Star1;
		// 			le52im2.sprite = Star2;
		// 			le52im3.sprite = Star3;
		// 		} else if (Level52.star == 2) {
		// 			print ("1star");
		// 			le52im1.sprite = Star1;
		// 			le52im2.sprite = Star2;
		// 		} else if (Level52.star == 1) {

		// 			le52im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level53.json"))
		// {
		// 	l53img.sprite = sp53;
		// 	l53.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level53.completed == true) {
		// 		if (Level53.star == 3) {

		// 			le53im1.sprite = Star1;
		// 			le53im2.sprite = Star2;
		// 			le53im3.sprite = Star3;
		// 		} else if (Level53.star == 2) {
		// 			print ("1star");
		// 			le53im1.sprite = Star1;
		// 			le53im2.sprite = Star2;
		// 		} else if (Level53.star == 1) {

		// 			le53im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level54.json"))
		// {
		// 	l54img.sprite = sp54;
		// 	l54.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level54.completed == true) {
		// 		if (Level54.star == 3) {

		// 			le54im1.sprite = Star1;
		// 			le54im2.sprite = Star2;
		// 			le54im3.sprite = Star3;
		// 		} else if (Level54.star == 2) {
		// 			print ("1star");
		// 			le54im1.sprite = Star1;
		// 			le54im2.sprite = Star2;
		// 		} else if (Level54.star == 1) {

		// 			le54im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level55.json"))
		// {
		// 	l55img.sprite = sp55;
		// 	l55.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level55.completed == true) {
		// 		if (Level55.star == 3) {

		// 			le55im1.sprite = Star1;
		// 			le55im2.sprite = Star2;
		// 			le55im3.sprite = Star3;
		// 		} else if (Level55.star == 2) {
		// 			print ("1star");
		// 			le55im1.sprite = Star1;
		// 			le55im2.sprite = Star2;
		// 		} else if (Level55.star == 1) {

		// 			le55im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level56.json"))
		// {
		// 	l56img.sprite = sp56;
		// 	l56.SetActive (true);

		// 	print ("here");
		// 	try
		// 	{
		// 	if (Level56.completed == true) {
		// 		if (Level56.star == 3) {

		// 			le56im1.sprite = Star1;
		// 			le56im2.sprite = Star2;
		// 			le56im3.sprite = Star3;
		// 		} else if (Level56.star == 2) {
		// 			print ("1star");
		// 			le56im1.sprite = Star1;
		// 			le56im2.sprite = Star2;
		// 		} else if (Level56.star == 1) {

		// 			le56im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level57.json"))
		// {
		// 	l57img.sprite = sp57;
		// 	l57.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level57.completed == true) {
		// 		if (Level57.star == 3) {

		// 			le57im1.sprite = Star1;
		// 			le57im2.sprite = Star2;
		// 			le57im3.sprite = Star3;
		// 		} else if (Level57.star == 2) {
		// 			print ("1star");
		// 			le57im1.sprite = Star1;
		// 			le57im2.sprite = Star2;
		// 		} else if (Level57.star == 1) {

		// 			le57im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level58.json"))
		// {
		// 	l58img.sprite = sp58;
		// 	l58.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level58.completed == true) {
		// 		if (Level58.star == 3) {

		// 			le58im1.sprite = Star1;
		// 			le58im2.sprite = Star2;
		// 			le58im3.sprite = Star3;
		// 		} else if (Level58.star == 2) {
		// 			print ("1star");
		// 			le58im1.sprite = Star1;
		// 			le58im2.sprite = Star2;
		// 		} else if (Level58.star == 1) {

		// 			le58im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level59.json"))
		// {
		// 	l59img.sprite = sp59;
		// 	l59.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level59.completed == true) {
		// 		if (Level59.star == 3) {

		// 			le59im1.sprite = Star1;
		// 			le59im2.sprite = Star2;
		// 			le59im3.sprite = Star3;
		// 		} else if (Level59.star == 2) {
		// 			print ("1star");
		// 			le59im1.sprite = Star1;
		// 			le59im2.sprite = Star2;
		// 		} else if (Level59.star == 1) {

		// 			le59im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level60.json"))
		// {
		// 	l60img.sprite = sp60;
		// 	l60.SetActive (true);

		// 	print ("here");
		// 	try
		// 	{
		// 	if (Level60.completed == true) {
		// 		if (Level60.star == 3) {

		// 			le60im1.sprite = Star1;
		// 			le60im2.sprite = Star2;
		// 			le60im3.sprite = Star3;
		// 		} else if (Level60.star == 2) {
		// 			print ("1star");
		// 			le60im1.sprite = Star1;
		// 			le60im2.sprite = Star2;
		// 		} else if (Level60.star == 1) {

		// 			le60im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }




	}
	IEnumerator readStuff(){
		
		// string json;
		// //ResourceHelper.SaveToPersistentData ("level3.json", "");
		// if (FileReader.level1 == true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level1.json");
		// 	Level1 = ResourceHelper.DecodeObject<level1> (FileReader.json);
		// }
		// if (FileReader.level2==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level2.json");
		// 	Level2 = ResourceHelper.DecodeObject<level2> (FileReader.json);
		// }
		// if (FileReader.level3==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level3.json");
		// 	Level3 = ResourceHelper.DecodeObject<level3> (FileReader.json);
		// }
		// if (FileReader.level4==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level4.json");
		// 	Level4 = ResourceHelper.DecodeObject<level4> (FileReader.json);
		// }
		// if (FileReader.level5 == true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level5.json");
		// 	Level5 = ResourceHelper.DecodeObject<level5> (FileReader.json);
		// }
		// if (FileReader.level6 == true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level6.json");
		// 	Level6 = ResourceHelper.DecodeObject<level6> (FileReader.json);
		// }
		// if (FileReader.level7==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level7.json");
		// 	Level7 = ResourceHelper.DecodeObject<level7> (FileReader.json);
		// }
		// if (FileReader.level8==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level8.json");
		// 	Level8 = ResourceHelper.DecodeObject<level8> (FileReader.json);
		// }
		// if (FileReader.level9==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level9.json");
		// 	Level9 = ResourceHelper.DecodeObject<level9> (FileReader.json);
		// }
		// if (FileReader.level10 == true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level10.json");
		// 	Level10 = ResourceHelper.DecodeObject<level10> (FileReader.json);
		// }
		// if (FileReader.level11 == true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level11.json");
		// 	Level11 = ResourceHelper.DecodeObject<level11> (FileReader.json);
		// }
		// if (FileReader.level12==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level12.json");
		// 	Level12 = ResourceHelper.DecodeObject<level12> (FileReader.json);
		// }
		// if (FileReader.level13==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level13.json");
		// 	Level13 = ResourceHelper.DecodeObject<level13> (FileReader.json);
		// }
		// if (FileReader.level14==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level14.json");
		// 	Level14 = ResourceHelper.DecodeObject<level14> (FileReader.json);
		// }
		// if (FileReader.level15==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level15.json");
		// 	Level15 = ResourceHelper.DecodeObject<level15> (FileReader.json);
		// }
		// if (FileReader.level16==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level16.json");
		// 	Level16 = ResourceHelper.DecodeObject<level16> (FileReader.json);
		// }
		// if (FileReader.level17==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level17.json");
		// 	Level17 = ResourceHelper.DecodeObject<level17> (FileReader.json);
		// }
		// if (FileReader.level18==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level18.json");
		// 	Level18 = ResourceHelper.DecodeObject<level18> (FileReader.json);
		// }
		// if (FileReader.level19==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level19.json");
		// 	Level19 = ResourceHelper.DecodeObject<level19> (FileReader.json);
		// }
		// if (FileReader.level20==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level20.json");
		// 	Level20 = ResourceHelper.DecodeObject<level20> (FileReader.json);
		// }
		// if (FileReader.level21==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level21.json");
		// 	Level21 = ResourceHelper.DecodeObject<level21> (FileReader.json);
		// }
		// if (FileReader.level22==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level22.json");
		// 	Level22 = ResourceHelper.DecodeObject<level22> (FileReader.json);
		// }
		// if (FileReader.level23==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level23.json");
		// 	Level23 = ResourceHelper.DecodeObject<level23> (FileReader.json);
		// }
		// if (FileReader.level24==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level24.json");
		// 	Level24 = ResourceHelper.DecodeObject<level24> (FileReader.json);
		// }
		// if (FileReader.level25==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level25.json");
		// 	Level25 = ResourceHelper.DecodeObject<level25> (FileReader.json);
		// }
		// if (FileReader.level26==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level26.json");
		// 	Level26 = ResourceHelper.DecodeObject<level26> (FileReader.json);
		// }
		// if (FileReader.level27==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level27.json");
		// 	Level27 = ResourceHelper.DecodeObject<level27> (FileReader.json);
		// }
		// if (FileReader.level28==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level28.json");
		// 	Level28 = ResourceHelper.DecodeObject<level28> (FileReader.json);
		// }
		// if (FileReader.level29==true){
		// 	//json = ResourceHelper.ReadFromPersistentData ("level29.json");
		// 	Level29 = ResourceHelper.DecodeObject<level29> (FileReader.json);
		// }
		// if (FileReader.level30==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level30.json");
		// 	Level30 = ResourceHelper.DecodeObject<level30> (FileReader.json);
		// }
		// if (FileReader.level31==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level31.json");
		// 	Level31 = ResourceHelper.DecodeObject<level31> (FileReader.json);
		// }
		// if (FileReader.level32==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level32.json");
		// 	Level32 = ResourceHelper.DecodeObject<level32> (FileReader.json);
		// }
		// if (FileReader.level33==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level33.json");
		// 	Level33 = ResourceHelper.DecodeObject<level33> (FileReader.json);
		// }
		// if (FileReader.level34==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level34.json");
		// 	Level34 = ResourceHelper.DecodeObject<level34> (FileReader.json);
		// }
		// if (FileReader.level35==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level35.json");
		// 	Level35 = ResourceHelper.DecodeObject<level35> (FileReader.json);
		// }
		// if (FileReader.level36==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level36.json");
		// 	Level36 = ResourceHelper.DecodeObject<level36> (FileReader.json);
		// }
		// if (FileReader.level37==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level37.json");
		// 	Level37 = ResourceHelper.DecodeObject<level37> (FileReader.json);
		// }
		// if (FileReader.level38==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level38.json");
		// 	Level38 = ResourceHelper.DecodeObject<level38> (FileReader.json);
		// }
		// if (FileReader.level39==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level39.json");
		// 	Level39 = ResourceHelper.DecodeObject<level39> (FileReader.json);
		// }
		// if (FileReader.level40==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level40.json");
		// 	Level40 = ResourceHelper.DecodeObject<level40> (FileReader.json);
		// }
		// if (FileReader.level41==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level41.json");
		// 	Level41 = ResourceHelper.DecodeObject<level41> (FileReader.json);
		// }
		// if (FileReader.level42==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level42.json");
		// 	Level42 = ResourceHelper.DecodeObject<level42> (FileReader.json);
		// }
		// if (FileReader.level43==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level43.json");
		// 	Level43 = ResourceHelper.DecodeObject<level43> (FileReader.json);
		// }
		// if (FileReader.level44) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level44.json");
		// 	Level44 = ResourceHelper.DecodeObject<level44> (FileReader.json);
		// }
		// if (FileReader.level45==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level45.json");
		// 	Level45 = ResourceHelper.DecodeObject<level45> (FileReader.json);
		// }
		// if (FileReader.level46==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level46.json");
		// 	Level46 = ResourceHelper.DecodeObject<level46> (FileReader.json);
		// }
		// if (FileReader.level47==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level47.json");
		// 	Level47 = ResourceHelper.DecodeObject<level47> (FileReader.json);
		// }
		// if (FileReader.level48==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level48.json");
		// 	Level48 = ResourceHelper.DecodeObject<level48> (FileReader.json);
		// }
		// if (FileReader.level49==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level49.json");
		// 	Level49 = ResourceHelper.DecodeObject<level49> (FileReader.json);
		// }
		// if (FileReader.level50==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level50.json");
		// 	Level50 = ResourceHelper.DecodeObject<level50> (FileReader.json);
		// }
		// if (FileReader.level51==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level51.json");
		// 	Level51 = ResourceHelper.DecodeObject<level51> (FileReader.json);
		// }
		// if (FileReader.level52==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level52.json");
		// 	Level52 = ResourceHelper.DecodeObject<level52> (FileReader.json);
		// }
		// if (FileReader.level53==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level53.json");
		// 	Level53 = ResourceHelper.DecodeObject<level53> (FileReader.json);
		// }
		// if (FileReader.level54==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level54.json");
		// 	Level54 = ResourceHelper.DecodeObject<level54> (FileReader.json);
		// }
		// if (FileReader.level55==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level55.json");
		// 	Level55 = ResourceHelper.DecodeObject<level55> (FileReader.json);
		// }
		// if (FileReader.level56==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level56.json");
		// 	Level56 = ResourceHelper.DecodeObject<level56> (FileReader.json);
		// }
		// if (FileReader.level57==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level57.json");
		// 	Level57 = ResourceHelper.DecodeObject<level57> (FileReader.json);
		// }
		// if (FileReader.level58==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level58.json");
		// 	Level58 = ResourceHelper.DecodeObject<level58> (FileReader.json);
		// }
		// if (FileReader.level59==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level59.json");
		// 	Level59 = ResourceHelper.DecodeObject<level59> (FileReader.json);
		// }
		// if (FileReader.level60==true) {
		// 	//json = ResourceHelper.ReadFromPersistentData ("level60.json");
		// 	Level60 = ResourceHelper.DecodeObject<level60> (FileReader.json);
		// }
		// if(FileReader.level1 == true)
		// {
		// 	l1img.sprite = sp1;
		// 	//l1img.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		// 	print ("lol");
		// 	l1.SetActive (true);
		// 	try{

		// 	print ("here");
		// 	if (Level1.completed == true) {
		// 		if (Level1.star == 3) {
				
		// 			le1im1.sprite = Star1;
		// 			le1im2.sprite = Star2;
		// 			le1im3.sprite = Star3;
		// 		} else if (Level1.star == 2) {
		// 			print ("1star");
		// 			le1im1.sprite = Star1;
		// 			le1im2.sprite = Star2;
		// 		} else if (Level1.star == 1) {
				
		// 			le1im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level2 == true)
		// {
			
		// 	l2img.sprite = sp2;
		// 	print ("lol");
		// 	l2.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level2.completed == true) {
		// 		if (Level2.star == 3) {

		// 			le2im1.sprite = Star1;
		// 			le2im2.sprite = Star2;
		// 			le2im3.sprite = Star3;
		// 		} else if (Level2.star == 2) {
		// 			print ("1star");
		// 			le2im1.sprite = Star1;
		// 			le2im2.sprite = Star2;
		// 		} else if (Level2.star == 1) {

		// 			le2im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level3 == true)
		// {
		// 	l3img.sprite = sp3;
		// 	print ("lol");
		// 	l3.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level3.completed == true) {
		// 		if (Level3.star == 3) {

		// 			le3im1.sprite = Star1;
		// 			le3im2.sprite = Star2;
		// 			le3im3.sprite = Star3;
		// 		} else if (Level3.star == 2) {
		// 			print ("1star");
		// 			le3im1.sprite = Star1;
		// 			le3im2.sprite = Star2;
		// 		} else if (Level3.star == 1) {

		// 			le3im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level4 == true)
		// {
		// 	l4img.sprite = sp4;
		// 	print ("lol");
		// 	l4.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level4.completed == true) {
		// 		if (Level4.star == 3) {

		// 			le4im1.sprite = Star1;
		// 			le4im2.sprite = Star2;
		// 			le4im3.sprite = Star3;
		// 		} else if (Level4.star == 2) {
		// 			print ("1star");
		// 			le4im1.sprite = Star1;
		// 			le4im2.sprite = Star2;
		// 		} else if (Level4.star == 1) {

		// 			le4im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level5 == true)
		// {
		// 	l5img.sprite = sp5;
		// 	print ("lol");
		// 	l5.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level5.completed == true) {
		// 		if (Level5.star == 3) {

		// 			le5im1.sprite = Star1;
		// 			le5im2.sprite = Star2;
		// 			le5im3.sprite = Star3;
		// 		} else if (Level5.star == 2) {
		// 			print ("1star");
		// 			le5im1.sprite = Star1;
		// 			le5im2.sprite = Star2;
		// 		} else if (Level5.star == 1) {

		// 			le5im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level6 == true)
		// {
		// 	l6img.sprite = sp6;
		// 	print ("lol");
		// 	l6.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level6.completed == true) {
		// 		if (Level6.star == 3) {

		// 			le6im1.sprite = Star1;
		// 			le6im2.sprite = Star2;
		// 			le6im3.sprite = Star3;
		// 		} else if (Level6.star == 2) {
		// 			print ("1star");
		// 			le6im1.sprite = Star1;
		// 			le6im2.sprite = Star2;
		// 		} else if (Level6.star == 1) {

		// 			le6im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if (FileReader.level7 == true) {
		// 	l7img.sprite = sp7;
		// 	print ("lol");
		// 	l7.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level7.completed == true) {
		// 		if (Level7.star == 3) {

		// 			le7im1.sprite = Star1;
		// 			le7im2.sprite = Star2;
		// 			le7im3.sprite = Star3;
		// 		} else if (Level7.star == 2) {
		// 			print ("1star");
		// 			le7im1.sprite = Star1;
		// 			le7im2.sprite = Star2;
		// 		} else if (Level7.star == 1) {

		// 			le7im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception) {
		// 	}
		// }
		// if (FileReader.level8 == true) {
		// 	l8img.sprite = sp8;
		// 	print ("lol");
		// 	l8.SetActive (true);
		// 	print ("here");
		// 	try
		// 	{
		// 	if (Level8.completed == true) {
		// 		if (Level8.star == 3) {

		// 			le8im1.sprite = Star1;
		// 			le8im2.sprite = Star2;
		// 			le8im3.sprite = Star3;
		// 		} else if (Level8.star == 2) {
		// 			print ("1star");
		// 			le8im1.sprite = Star1;
		// 			le8im2.sprite = Star2;
		// 		} else if (Level8.star == 1) {

		// 			le8im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if (FileReader.level9 == true) {
		// 	l9img.sprite = sp9;
		// 	print ("lol");
		// 	l9.SetActive (true);
		// 	print ("here");
		// 	try{if (Level9.completed == true) {
		// 		if (Level9.star == 3) {

		// 			le9im1.sprite = Star1;
		// 			le9im2.sprite = Star2;
		// 			le9im3.sprite = Star3;
		// 		} else if (Level9.star == 2) {
		// 			print ("1star");
		// 			le9im1.sprite = Star1;
		// 			le9im2.sprite = Star2;
		// 		} else if (Level9.star == 1) {

		// 			le9im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception) {
				
		// 	}
		// }
		// if (FileReader.level10 == true) {
		// 	try{
		// 	l10img.sprite = sp10;
		// 	print ("lol");
		// 	l10.SetActive (true);
		// 	print ("here");

		// 	if (Level10.completed == true) {
		// 		if (Level10.star == 3) {

		// 			le10im1.sprite = Star1;
		// 			le10im2.sprite = Star2;
		// 			le10im3.sprite = Star3;
		// 		} else if (Level10.star == 2) {
		// 			print ("1star");
		// 			le10im1.sprite = Star1;
		// 			le10im2.sprite = Star2;
		// 		} else if (Level10.star == 1) {

		// 			le10im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception)
		// 	{
		// 		Debug.Log ("thkdkh");
		// 	}
		// }
		// if(FileReader.level11 == true)
		// 	{
		// 		l11img.sprite = sp11;
		// 		print ("lol");
		// 		l11.SetActive (true);
		// 		print ("here");
		// 	try{
		// 	if (Level11.completed == true) {
		// 		if (Level11.star == 3) {

		// 			le11im1.sprite = Star1;
		// 			le11im2.sprite = Star2;
		// 			le11im3.sprite = Star3;
		// 		} else if (Level11.star == 2) {
		// 			print ("1star");
		// 			le11im1.sprite = Star1;
		// 			le11im2.sprite = Star2;
		// 		} else if (Level11.star == 1) {

		// 			le11im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// 	}
		// if(FileReader.level12 == true)
		// 	{
		// 		l12img.sprite = sp12;
		// 		l12.SetActive (true);

		// 		print ("here");
		// 	try{
		// 	if (Level12.completed == true) {
		// 		if (Level12.star == 3) {

		// 			le12im1.sprite = Star1;
		// 			le12im2.sprite = Star2;
		// 			le12im3.sprite = Star3;
		// 		} else if (Level12.star == 2) {
		// 			print ("1star");
		// 			le12im1.sprite = Star1;
		// 			le12im2.sprite = Star2;
		// 		} else if (Level12.star == 1) {

		// 			le12im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// 	}
		// if(FileReader.level13 == true)
		// {
		// 	l13img.sprite = sp13;
		// 	l13.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level13.completed == true) {
		// 		if (Level13.star == 3) {

		// 			le13im1.sprite = Star1;
		// 			le13im2.sprite = Star2;
		// 			le13im3.sprite = Star3;
		// 		} else if (Level13.star == 2) {
		// 			print ("1star");
		// 			le13im1.sprite = Star1;
		// 			le13im2.sprite = Star2;
		// 		} else if (Level13.star == 1) {

		// 			le13im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level14 == true)
		// {
		// 	l14img.sprite = sp14;
		// 	l14.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level14.completed == true) {
		// 		if (Level14.star == 3) {

		// 			le14im1.sprite = Star1;
		// 			le14im2.sprite = Star2;
		// 			le14im3.sprite = Star3;
		// 		} else if (Level14.star == 2) {
		// 			print ("1star");
		// 			le14im1.sprite = Star1;
		// 			le14im2.sprite = Star2;
		// 		} else if (Level14.star == 1) {

		// 			le14im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level15 == true)
		// {
		// 	l15img.sprite = sp15;
		// 	l15.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level15.completed == true) {
		// 		if (Level15.star == 3) {

		// 			le15im1.sprite = Star1;
		// 			le15im2.sprite = Star2;
		// 			le15im3.sprite = Star3;
		// 		} else if (Level15.star == 2) {
		// 			print ("1star");
		// 			le15im1.sprite = Star1;
		// 			le15im2.sprite = Star2;
		// 		} else if (Level15.star == 1) {

		// 			le15im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception) {
				
		// 	}
		// }
		// if(FileReader.level16 == true)
		// {
		// 	l16img.sprite = sp16;
		// 	l16.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level16.completed == true) {
		// 		if (Level16.star == 3) {

		// 			le16im1.sprite = Star1;
		// 			le16im2.sprite = Star2;
		// 			le16im3.sprite = Star3;
		// 		} else if (Level16.star == 2) {
		// 			print ("1star");
		// 			le16im1.sprite = Star1;
		// 			le16im2.sprite = Star2;
		// 		} else if (Level16.star == 1) {

		// 			le16im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level17 == true)
		// {
		// 	l17img.sprite = sp17;
		// 	l17.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level17.completed == true) {
		// 		if (Level17.star == 3) {

		// 			le17im1.sprite = Star1;
		// 			le17im2.sprite = Star2;
		// 			le17im3.sprite = Star3;
		// 		} else if (Level17.star == 2) {
		// 			print ("1star");
		// 			le17im1.sprite = Star1;
		// 			le17im2.sprite = Star2;
		// 		} else if (Level17.star == 1) {

		// 			le17im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level18 == true)
		// {
		// 	l18img.sprite = sp18;
		// 	l18.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level18.completed == true) {
		// 		if (Level18.star == 3) {

		// 			le18im1.sprite = Star1;
		// 			le18im2.sprite = Star2;
		// 			le18im3.sprite = Star3;
		// 		} else if (Level18.star == 2) {
		// 			print ("1star");
		// 			le18im1.sprite = Star1;
		// 			le18im2.sprite = Star2;
		// 		} else if (Level18.star == 1) {

		// 			le18im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level19 == true)
		// {
		// 	l19img.sprite = sp19;
		// 	l19.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level19.completed == true) {
		// 		if (Level19.star == 3) {

		// 			le19im1.sprite = Star1;
		// 			le19im2.sprite = Star2;
		// 			le19im3.sprite = Star3;
		// 		} else if (Level19.star == 2) {
		// 			print ("1star");
		// 			le19im1.sprite = Star1;
		// 			le19im2.sprite = Star2;
		// 		} else if (Level19.star == 1) {

		// 			le19im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level20 == true)
		// {
		// 	l20img.sprite = sp20;
		// 	l20.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level20.completed == true) {
		// 		if (Level20.star == 3) {

		// 			le20im1.sprite = Star1;
		// 			le20im2.sprite = Star2;
		// 			le20im3.sprite = Star3;
		// 		} else if (Level20.star == 2) {
		// 			print ("1star");
		// 			le20im1.sprite = Star1;
		// 			le20im2.sprite = Star2;
		// 		} else if (Level20.star == 1) {

		// 			le20im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level21 == true)
		// {
		// 	l21img.sprite = sp21;
		// 	l21.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level21.completed == true) {
		// 		if (Level21.star == 3) {

		// 			le21im1.sprite = Star1;
		// 			le21im2.sprite = Star2;
		// 			le21im3.sprite = Star3;
		// 		} else if (Level21.star == 2) {
		// 			print ("1star");
		// 			le21im1.sprite = Star1;
		// 			le21im2.sprite = Star2;
		// 		} else if (Level21.star == 1) {

		// 			le21im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level22 == true)
		// {
		// 	l22img.sprite = sp22;
		// 	l22.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level22.completed == true) {
		// 		if (Level22.star == 3) {

		// 			le22im1.sprite = Star1;
		// 			le22im2.sprite = Star2;
		// 			le22im3.sprite = Star3;
		// 		} else if (Level22.star == 2) {
		// 			print ("1star");
		// 			le22im1.sprite = Star1;
		// 			le22im2.sprite = Star2;
		// 		} else if (Level22.star == 1) {

		// 			le22im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception) {
				
		// 	}
		// }
		// if(FileReader.level23 == true)
		// {
		// 	l23img.sprite = sp23;
		// 	l23.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level23.completed == true) {
		// 		if (Level23.star == 3) {

		// 			le23im1.sprite = Star1;
		// 			le23im2.sprite = Star2;
		// 			le23im3.sprite = Star3;
		// 		} else if (Level23.star == 2) {
		// 			print ("1star");
		// 			le23im1.sprite = Star1;
		// 			le23im2.sprite = Star2;
		// 		} else if (Level23.star == 1) {

		// 			le23im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level24 == true)
		// {
		// 	l24img.sprite = sp24;
		// 	l24.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level24.completed == true) {
		// 		if (Level24.star == 3) {

		// 			le24im1.sprite = Star1;
		// 			le24im2.sprite = Star2;
		// 			le24im3.sprite = Star3;
		// 		} else if (Level24.star == 2) {
		// 			print ("1star");
		// 			le24im1.sprite = Star1;
		// 			le24im2.sprite = Star2;
		// 		} else if (Level24.star == 1) {

		// 			le24im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level25 == true)
		// {
		// 	l25img.sprite = sp25;
		// 	l25.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level25.completed == true) {
		// 		if (Level25.star == 3) {

		// 			le25im1.sprite = Star1;
		// 			le25im2.sprite = Star2;
		// 			le25im3.sprite = Star3;
		// 		} else if (Level25.star == 2) {
		// 			print ("1star");
		// 			le25im1.sprite = Star1;
		// 			le25im2.sprite = Star2;
		// 		} else if (Level25.star == 1) {

		// 			le25im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level26 == true)
		// {
		// 	l26img.sprite = sp26;
		// 	l26.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level26.completed == true) {
		// 		if (Level26.star == 3) {

		// 			le26im1.sprite = Star1;
		// 			le26im2.sprite = Star2;
		// 			le26im3.sprite = Star3;
		// 		} else if (Level26.star == 2) {
		// 			print ("1star");
		// 			le26im1.sprite = Star1;
		// 			le26im2.sprite = Star2;
		// 		} else if (Level26.star == 1) {

		// 			le26im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level27 == true)
		// {
		// 	l27img.sprite = sp27;
		// 	l27.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level27.completed == true) {
		// 		if (Level27.star == 3) {

		// 			le27im1.sprite = Star1;
		// 			le27im2.sprite = Star2;
		// 			le27im3.sprite = Star3;
		// 		} else if (Level27.star == 2) {
		// 			print ("1star");
		// 			le27im1.sprite = Star1;
		// 			le27im2.sprite = Star2;
		// 		} else if (Level27.star == 1) {

		// 			le27im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level28 == true)
		// {
		// 	l28img.sprite = sp28;
		// 	l28.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level28.completed == true) {
		// 		if (Level28.star == 3) {

		// 			le28im1.sprite = Star1;
		// 			le28im2.sprite = Star2;
		// 			le28im3.sprite = Star3;
		// 		} else if (Level28.star == 2) {
		// 			print ("1star");
		// 			le28im1.sprite = Star1;
		// 			le28im2.sprite = Star2;
		// 		} else if (Level28.star == 1) {

		// 			le28im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level29 == true)
		// {
		// 	l29img.sprite = sp29;
		// 	l29.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level29.completed == true) {
		// 		if (Level29.star == 3) {

		// 			le29im1.sprite = Star1;
		// 			le29im2.sprite = Star2;
		// 			le29im3.sprite = Star3;
		// 		} else if (Level29.star == 2) {
		// 			print ("1star");
		// 			le29im1.sprite = Star1;
		// 			le29im2.sprite = Star2;
		// 		} else if (Level29.star == 1) {

		// 			le29im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level30 == true)
		// {
		// 	l30img.sprite = sp30;
		// 	l30.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level30.completed == true) {
		// 		if (Level30.star == 3) {

		// 			le30im1.sprite = Star1;
		// 			le30im2.sprite = Star2;
		// 			le30im3.sprite = Star3;
		// 		} else if (Level30.star == 2) {
		// 			print ("1star");
		// 			le30im1.sprite = Star1;
		// 			le30im2.sprite = Star2;
		// 		} else if (Level30.star == 1) {

		// 			le30im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level31 == true)
		// {
		// 	l31img.sprite = sp31;
		// 	l31.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level31.completed == true) {
		// 		if (Level31.star == 3) {

		// 			le31im1.sprite = Star1;
		// 			le31im2.sprite = Star2;
		// 			le31im3.sprite = Star3;
		// 		} else if (Level31.star == 2) {
		// 			print ("1star");
		// 			le31im1.sprite = Star1;
		// 			le31im2.sprite = Star2;
		// 		} else if (Level31.star == 1) {

		// 			le31im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level32 == true)
		// {
		// 	l32img.sprite = sp32;
		// 	l32.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level32.completed == true) {
		// 		if (Level32.star == 3) {

		// 			le32im1.sprite = Star1;
		// 			le32im2.sprite = Star2;
		// 			le32im3.sprite = Star3;
		// 		} else if (Level32.star == 2) {
		// 			print ("1star");
		// 			le32im1.sprite = Star1;
		// 			le32im2.sprite = Star2;
		// 		} else if (Level32.star == 1) {

		// 			le32im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level33 == true)
		// {
		// 	l33img.sprite = sp33;
		// 	l33.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level33.completed == true) {
		// 		if (Level33.star == 3) {

		// 			le33im1.sprite = Star1;
		// 			le33im2.sprite = Star2;
		// 			le33im3.sprite = Star3;
		// 		} else if (Level33.star == 2) {
		// 			print ("1star");
		// 			le33im1.sprite = Star1;
		// 			le33im2.sprite = Star2;
		// 		} else if (Level33.star == 1) {

		// 			le33im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level34 == true)
		// {
		// 	l34img.sprite = sp34;
		// 	l34.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level34.completed == true) {
		// 		if (Level34.star == 3) {

		// 			le34im1.sprite = Star1;
		// 			le34im2.sprite = Star2;
		// 			le34im3.sprite = Star3;
		// 		} else if (Level34.star == 2) {
		// 			print ("1star");
		// 			le34im1.sprite = Star1;
		// 			le34im2.sprite = Star2;
		// 		} else if (Level34.star == 1) {

		// 			le34im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level35 == true)
		// {
		// 	l35img.sprite = sp35;
		// 	l35.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level35.completed == true) {
		// 		if (Level35.star == 3) {

		// 			le35im1.sprite = Star1;
		// 			le35im2.sprite = Star2;
		// 			le35im3.sprite = Star3;
		// 		} else if (Level35.star == 2) {
		// 			print ("1star");
		// 			le35im1.sprite = Star1;
		// 			le35im2.sprite = Star2;
		// 		} else if (Level35.star == 1) {

		// 			le35im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level36 == true)
		// {
		// 	l36img.sprite = sp36;
		// 	l36.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level36.completed == true) {
		// 		if (Level36.star == 3) {

		// 			le36im1.sprite = Star1;
		// 			le36im2.sprite = Star2;
		// 			le36im3.sprite = Star3;
		// 		} else if (Level36.star == 2) {
		// 			print ("1star");
		// 			le36im1.sprite = Star1;
		// 			le36im2.sprite = Star2;
		// 		} else if (Level36.star == 1) {

		// 			le36im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level37 == true)
		// {
		// 	l37img.sprite = sp37;
		// 	l37.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level37.completed == true) {
		// 		if (Level37.star == 3) {

		// 			le37im1.sprite = Star1;
		// 			le37im2.sprite = Star2;
		// 			le37im3.sprite = Star3;
		// 		} else if (Level37.star == 2) {
		// 			print ("1star");
		// 			le37im1.sprite = Star1;
		// 			le37im2.sprite = Star2;
		// 		} else if (Level37.star == 1) {

		// 			le37im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level38 == true)
		// {
		// 	l38img.sprite = sp38;
		// 	l38.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level38.completed == true) {
		// 		if (Level38.star == 3) {

		// 			le38im1.sprite = Star1;
		// 			le38im2.sprite = Star2;
		// 			le38im3.sprite = Star3;
		// 		} else if (Level38.star == 2) {
		// 			print ("1star");
		// 			le38im1.sprite = Star1;
		// 			le38im2.sprite = Star2;
		// 		} else if (Level38.star == 1) {

		// 			le38im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level39 == true)
		// {
		// 	l39img.sprite = sp39;
		// 	l39.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level39.completed == true) {
		// 		if (Level39.star == 3) {

		// 			le39im1.sprite = Star1;
		// 			le39im2.sprite = Star2;
		// 			le39im3.sprite = Star3;
		// 		} else if (Level39.star == 2) {
		// 			print ("1star");
		// 			le39im1.sprite = Star1;
		// 			le39im2.sprite = Star2;
		// 		} else if (Level39.star == 1) {

		// 			le39im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level40 == true)
		// {
		// 	l40img.sprite = sp40;
		// 	l40.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level40.completed == true) {
		// 		if (Level40.star == 3) {

		// 			le40im1.sprite = Star1;
		// 			le40im2.sprite = Star2;
		// 			le40im3.sprite = Star3;
		// 		} else if (Level40.star == 2) {
		// 			print ("1star");
		// 			le40im1.sprite = Star1;
		// 			le40im2.sprite = Star2;
		// 		} else if (Level40.star == 1) {

		// 			le40im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level41 == true)
		// {
		// 	l41img.sprite = sp41;
		// 	l41.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level41.completed == true) {
		// 		if (Level41.star == 3) {

		// 			le41im1.sprite = Star1;
		// 			le41im2.sprite = Star2;
		// 			le41im3.sprite = Star3;
		// 		} else if (Level41.star == 2) {
		// 			print ("1star");
		// 			le41im1.sprite = Star1;
		// 			le41im2.sprite = Star2;
		// 		} else if (Level41.star == 1) {

		// 			le41im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level42 == true)
		// {
		// 	l42img.sprite = sp42;
		// 	l42.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level42.completed == true) {
		// 		if (Level42.star == 3) {

		// 			le42im1.sprite = Star1;
		// 			le42im2.sprite = Star2;
		// 			le42im3.sprite = Star3;
		// 		} else if (Level42.star == 2) {
		// 			print ("1star");
		// 			le42im1.sprite = Star1;
		// 			le42im2.sprite = Star2;
		// 		} else if (Level42.star == 1) {

		// 			le42im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level43 == true)
		// {
		// 	l43img.sprite = sp43;
		// 	l43.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level43.completed == true) {
		// 		if (Level43.star == 3) {

		// 			le43im1.sprite = Star1;
		// 			le43im2.sprite = Star2;
		// 			le43im3.sprite = Star3;
		// 		} else if (Level43.star == 2) {
		// 			print ("1star");
		// 			le43im1.sprite = Star1;
		// 			le43im2.sprite = Star2;
		// 		} else if (Level43.star == 1) {

		// 			le43im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level44 == true)
		// {
		// 	l44img.sprite = sp44;
		// 	l44.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level44.completed == true) {
		// 		if (Level44.star == 3) {

		// 			le44im1.sprite = Star1;
		// 			le44im2.sprite = Star2;
		// 			le44im3.sprite = Star3;
		// 		} else if (Level44.star == 2) {
		// 			print ("1star");
		// 			le44im1.sprite = Star1;
		// 			le44im2.sprite = Star2;
		// 		} else if (Level44.star == 1) {

		// 			le44im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception) {
		// 	}
		// }
		// if(FileReader.level45 == true)
		// {
		// 	l45img.sprite = sp45;
		// 	l45.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level45.completed == true) {
		// 		if (Level45.star == 3) {

		// 			le45im1.sprite = Star1;
		// 			le45im2.sprite = Star2;
		// 			le45im3.sprite = Star3;
		// 		} else if (Level45.star == 2) {
		// 			print ("1star");
		// 			le45im1.sprite = Star1;
		// 			le45im2.sprite = Star2;
		// 		} else if (Level45.star == 1) {

		// 			le45im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level46 == true)
		// {
		// 	l46img.sprite = sp46;
		// 	l46.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level46.completed == true) {
		// 		if (Level46.star == 3) {

		// 			le46im1.sprite = Star1;
		// 			le46im2.sprite = Star2;
		// 			le46im3.sprite = Star3;
		// 		} else if (Level46.star == 2) {
		// 			print ("1star");
		// 			le46im1.sprite = Star1;
		// 			le46im2.sprite = Star2;
		// 		} else if (Level46.star == 1) {

		// 			le46im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level47 == true)
		// {
		// 	l47img.sprite = sp47;
		// 	l47.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level47.completed == true) {
		// 		if (Level47.star == 3) {

		// 			le47im1.sprite = Star1;
		// 			le47im2.sprite = Star2;
		// 			le47im3.sprite = Star3;
		// 		} else if (Level47.star == 2) {
		// 			print ("1star");
		// 			le47im1.sprite = Star1;
		// 			le47im2.sprite = Star2;
		// 		} else if (Level47.star == 1) {

		// 			le47im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level48 == true)
		// {
		// 	l48img.sprite = sp48;
		// 	l48.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level48.completed == true) {
		// 		if (Level48.star == 3) {

		// 			le48im1.sprite = Star1;
		// 			le48im2.sprite = Star2;
		// 			le48im3.sprite = Star3;
		// 		} else if (Level48.star == 2) {
		// 			print ("1star");
		// 			le48im1.sprite = Star1;
		// 			le48im2.sprite = Star2;
		// 		} else if (Level48.star == 1) {

		// 			le48im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level49 == true)
		// {
		// 	l49img.sprite = sp49;
		// 	l49.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level49.completed == true) {
		// 		if (Level49.star == 3) {

		// 			le49im1.sprite = Star1;
		// 			le49im2.sprite = Star2;
		// 			le49im3.sprite = Star3;
		// 		} else if (Level49.star == 2) {
		// 			print ("1star");
		// 			le49im1.sprite = Star1;
		// 			le49im2.sprite = Star2;
		// 		} else if (Level49.star == 1) {

		// 			le49im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level50 == true)
		// {
		// 	l50img.sprite = sp50;
		// 	l50.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level50.completed == true) {
		// 		if (Level50.star == 3) {

		// 			le50im1.sprite = Star1;
		// 			le50im2.sprite = Star2;
		// 			le50im3.sprite = Star3;
		// 		} else if (Level50.star == 2) {
		// 			print ("1star");
		// 			le50im1.sprite = Star1;
		// 			le50im2.sprite = Star2;
		// 		} else if (Level50.star == 1) {

		// 			le50im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level51 == true)
		// {
		// 	l51img.sprite = sp51;
		// 	l51.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level51.completed == true) {
		// 		if (Level51.star == 3) {

		// 			le51im1.sprite = Star1;
		// 			le51im2.sprite = Star2;
		// 			le51im3.sprite = Star3;
		// 		} else if (Level51.star == 2) {
		// 			print ("1star");
		// 			le51im1.sprite = Star1;
		// 			le51im2.sprite = Star2;
		// 		} else if (Level51.star == 1) {

		// 			le51im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level52 == true)
		// {
		// 	l52img.sprite = sp52;
		// 	l52.SetActive (true);
		
		// 	print ("here");
		// 	try{
		// 	if (Level52.completed == true) {
		// 		if (Level52.star == 3) {

		// 			le52im1.sprite = Star1;
		// 			le52im2.sprite = Star2;
		// 			le52im3.sprite = Star3;
		// 		} else if (Level52.star == 2) {
		// 			print ("1star");
		// 			le52im1.sprite = Star1;
		// 			le52im2.sprite = Star2;
		// 		} else if (Level52.star == 1) {

		// 			le52im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level53 == true)
		// {
		// 	l53img.sprite = sp53;
		// 	l53.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level53.completed == true) {
		// 		if (Level53.star == 3) {

		// 			le53im1.sprite = Star1;
		// 			le53im2.sprite = Star2;
		// 			le53im3.sprite = Star3;
		// 		} else if (Level53.star == 2) {
		// 			print ("1star");
		// 			le53im1.sprite = Star1;
		// 			le53im2.sprite = Star2;
		// 		} else if (Level53.star == 1) {

		// 			le53im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level54 == true)
		// {
		// 	l54img.sprite = sp54;
		// 	l54.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level54.completed == true) {
		// 		if (Level54.star == 3) {

		// 			le54im1.sprite = Star1;
		// 			le54im2.sprite = Star2;
		// 			le54im3.sprite = Star3;
		// 		} else if (Level54.star == 2) {
		// 			print ("1star");
		// 			le54im1.sprite = Star1;
		// 			le54im2.sprite = Star2;
		// 		} else if (Level54.star == 1) {

		// 			le54im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level55 == true)
		// {
		// 	l55img.sprite = sp55;
		// 	l55.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level55.completed == true) {
		// 		if (Level55.star == 3) {

		// 			le55im1.sprite = Star1;
		// 			le55im2.sprite = Star2;
		// 			le55im3.sprite = Star3;
		// 		} else if (Level55.star == 2) {
		// 			print ("1star");
		// 			le55im1.sprite = Star1;
		// 			le55im2.sprite = Star2;
		// 		} else if (Level55.star == 1) {

		// 			le55im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level56 == true)
		// {
		// 	l56img.sprite = sp56;
		// 	l56.SetActive (true);

		// 	print ("here");
		// 	try
		// 	{
		// 	if (Level56.completed == true) {
		// 		if (Level56.star == 3) {

		// 			le56im1.sprite = Star1;
		// 			le56im2.sprite = Star2;
		// 			le56im3.sprite = Star3;
		// 		} else if (Level56.star == 2) {
		// 			print ("1star");
		// 			le56im1.sprite = Star1;
		// 			le56im2.sprite = Star2;
		// 		} else if (Level56.star == 1) {

		// 			le56im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level57 == true)
		// {
		// 	l57img.sprite = sp57;
		// 	l57.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level57.completed == true) {
		// 		if (Level57.star == 3) {

		// 			le57im1.sprite = Star1;
		// 			le57im2.sprite = Star2;
		// 			le57im3.sprite = Star3;
		// 		} else if (Level57.star == 2) {
		// 			print ("1star");
		// 			le57im1.sprite = Star1;
		// 			le57im2.sprite = Star2;
		// 		} else if (Level57.star == 1) {

		// 			le57im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level58 == true)
		// {
		// 	l58img.sprite = sp58;
		// 	l58.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level58.completed == true) {
		// 		if (Level58.star == 3) {

		// 			le58im1.sprite = Star1;
		// 			le58im2.sprite = Star2;
		// 			le58im3.sprite = Star3;
		// 		} else if (Level58.star == 2) {
		// 			print ("1star");
		// 			le58im1.sprite = Star1;
		// 			le58im2.sprite = Star2;
		// 		} else if (Level58.star == 1) {

		// 			le58im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level59 == true)
		// {
		// 	l59img.sprite = sp59;
		// 	l59.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level59.completed == true) {
		// 		if (Level59.star == 3) {

		// 			le59im1.sprite = Star1;
		// 			le59im2.sprite = Star2;
		// 			le59im3.sprite = Star3;
		// 		} else if (Level59.star == 2) {
		// 			print ("1star");
		// 			le59im1.sprite = Star1;
		// 			le59im2.sprite = Star2;
		// 		} else if (Level59.star == 1) {

		// 			le59im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(FileReader.level60 == true)
		// {
		// 	l60img.sprite = sp60;
		// 	l60.SetActive (true);

		// 	print ("here");
		// 	try
		// 	{
		// 	if (Level60.completed == true) {
		// 		if (Level60.star == 3) {

		// 			le60im1.sprite = Star1;
		// 			le60im2.sprite = Star2;
		// 			le60im3.sprite = Star3;
		// 		} else if (Level60.star == 2) {
		// 			print ("1star");
		// 			le60im1.sprite = Star1;
		// 			le60im2.sprite = Star2;
		// 		} else if (Level60.star == 1) {

		// 			le60im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// //PlayedFirstTime.playedFirstTime = true;
		// yield return new WaitForSeconds(1f);

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// string json;
		// //ResourceHelper.SaveToPersistentData ("level3.json", "");
		// if (ResourceHelper.ExistsInPersistentData ("level1.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level1.json");
		// 	Level1 = ResourceHelper.DecodeObject<level1> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level2.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level2.json");
		// 	Level2 = ResourceHelper.DecodeObject<level2> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level3.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level3.json");
		// 	Level3 = ResourceHelper.DecodeObject<level3> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level4.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level4.json");
		// 	Level4 = ResourceHelper.DecodeObject<level4> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level5.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level5.json");
		// 	Level5 = ResourceHelper.DecodeObject<level5> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level6.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level6.json");
		// 	Level6 = ResourceHelper.DecodeObject<level6> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level7.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level7.json");
		// 	Level7 = ResourceHelper.DecodeObject<level7> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level8.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level8.json");
		// 	Level8 = ResourceHelper.DecodeObject<level8> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level9.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level9.json");
		// 	Level9 = ResourceHelper.DecodeObject<level9> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level10.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level10.json");
		// 	Level10 = ResourceHelper.DecodeObject<level10> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level11.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level11.json");
		// 	Level11 = ResourceHelper.DecodeObject<level11> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level12.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level12.json");
		// 	Level12 = ResourceHelper.DecodeObject<level12> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level13.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level13.json");
		// 	Level13 = ResourceHelper.DecodeObject<level13> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level14.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level14.json");
		// 	Level14 = ResourceHelper.DecodeObject<level14> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level15.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level15.json");
		// 	Level15 = ResourceHelper.DecodeObject<level15> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level16.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level16.json");
		// 	Level16 = ResourceHelper.DecodeObject<level16> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level17.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level17.json");
		// 	Level17 = ResourceHelper.DecodeObject<level17> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level18.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level18.json");
		// 	Level18 = ResourceHelper.DecodeObject<level18> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level19.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level19.json");
		// 	Level19 = ResourceHelper.DecodeObject<level19> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level20.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level20.json");
		// 	Level20 = ResourceHelper.DecodeObject<level20> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level21.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level21.json");
		// 	Level21 = ResourceHelper.DecodeObject<level21> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level22.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level22.json");
		// 	Level22 = ResourceHelper.DecodeObject<level22> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level23.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level23.json");
		// 	Level23 = ResourceHelper.DecodeObject<level23> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level24.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level24.json");
		// 	Level24 = ResourceHelper.DecodeObject<level24> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level25.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level25.json");
		// 	Level25 = ResourceHelper.DecodeObject<level25> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level26.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level26.json");
		// 	Level26 = ResourceHelper.DecodeObject<level26> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level27.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level27.json");
		// 	Level27 = ResourceHelper.DecodeObject<level27> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level28.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level28.json");
		// 	Level28 = ResourceHelper.DecodeObject<level28> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level29.json")){
		// 	json = ResourceHelper.ReadFromPersistentData ("level29.json");
		// Level29 = ResourceHelper.DecodeObject<level29> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level30.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level30.json");
		// 	Level30 = ResourceHelper.DecodeObject<level30> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level31.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level31.json");
		// 	Level31 = ResourceHelper.DecodeObject<level31> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level32.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level32.json");
		// 	Level32 = ResourceHelper.DecodeObject<level32> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level33.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level33.json");
		// 	Level33 = ResourceHelper.DecodeObject<level33> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level34.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level34.json");
		// 	Level34 = ResourceHelper.DecodeObject<level34> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level35.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level35.json");
		// 	Level35 = ResourceHelper.DecodeObject<level35> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level36.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level36.json");
		// 	Level36 = ResourceHelper.DecodeObject<level36> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level37.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level37.json");
		// 	Level37 = ResourceHelper.DecodeObject<level37> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level38.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level38.json");
		// 	Level38 = ResourceHelper.DecodeObject<level38> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level39.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level39.json");
		// 	Level39 = ResourceHelper.DecodeObject<level39> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level40.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level40.json");
		// 	Level40 = ResourceHelper.DecodeObject<level40> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level41.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level41.json");
		// 	Level41 = ResourceHelper.DecodeObject<level41> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level42.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level42.json");
		// 	Level42 = ResourceHelper.DecodeObject<level42> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level43.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level43.json");
		// 	Level43 = ResourceHelper.DecodeObject<level43> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level44.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level44.json");
		// 	Level44 = ResourceHelper.DecodeObject<level44> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level45.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level45.json");
		// 	Level45 = ResourceHelper.DecodeObject<level45> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level46.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level46.json");
		// 	Level46 = ResourceHelper.DecodeObject<level46> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level47.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level47.json");
		// 	Level47 = ResourceHelper.DecodeObject<level47> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level48.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level48.json");
		// 	Level48 = ResourceHelper.DecodeObject<level48> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level49.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level49.json");
		// 	Level49 = ResourceHelper.DecodeObject<level49> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level50.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level50.json");
		// 	Level50 = ResourceHelper.DecodeObject<level50> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level51.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level51.json");
		// 	Level51 = ResourceHelper.DecodeObject<level51> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level52.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level52.json");
		// 	Level52 = ResourceHelper.DecodeObject<level52> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level53.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level53.json");
		// 	Level53 = ResourceHelper.DecodeObject<level53> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level54.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level54.json");
		// 	Level54 = ResourceHelper.DecodeObject<level54> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level55.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level55.json");
		// 	Level55 = ResourceHelper.DecodeObject<level55> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level56.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level56.json");
		// 	Level56 = ResourceHelper.DecodeObject<level56> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level57.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level57.json");
		// 	Level57 = ResourceHelper.DecodeObject<level57> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level58.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level58.json");
		// 	Level58 = ResourceHelper.DecodeObject<level58> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level59.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level59.json");
		// 	Level59 = ResourceHelper.DecodeObject<level59> (json);
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level60.json")) {
		// 	json = ResourceHelper.ReadFromPersistentData ("level60.json");
		// 	Level60 = ResourceHelper.DecodeObject<level60> (json);
		// }
		// if(ResourceHelper.ExistsInPersistentData("level1.json"))
		for(int i=1;i<=60;i++){
			if(PlayerPrefs.GetInt("level"+i)==1)
		{
			Image b=(Image)this.GetType().GetField("l"+i+"img").GetValue(this);
			Sprite c=(Sprite)this.GetType().GetField("sp"+i).GetValue(this);
			b.sprite = c;
			//l1img.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
			print ("lol");
			GameObject a=(GameObject)this.GetType().GetField("l"+i).GetValue(this);
			a.SetActive (true);
			try{

			print ("here");
			if (PlayerPrefs.GetInt("level"+i) == 1) {
				if (PlayerPrefs.GetInt("stars"+i) == 3) {
				
					Image x=(Image)this.GetType().GetField("le"+i+"im1").GetValue(this);
					Image y=(Image)this.GetType().GetField("le"+i+"im2").GetValue(this);
					Image z=(Image)this.GetType().GetField("le"+i+"im3").GetValue(this);
					x.sprite = Star1;
					y.sprite = Star2;
					z.sprite = Star3;
				} else if (PlayerPrefs.GetInt("stars"+i) == 2) {
					print ("1star");
					Image x=(Image)this.GetType().GetField("le"+i+"im1").GetValue(this);
					Image y=(Image)this.GetType().GetField("le"+i+"im2").GetValue(this);
					x.sprite = Star1;
					y.sprite = Star2;
				} else if (PlayerPrefs.GetInt("stars"+i) == 1) {
					Image x=(Image)this.GetType().GetField("le"+i+"im1").GetValue(this);
					x.sprite = Star1;
				}
			}
			}
			catch(System.Exception){
			}
		}
		}
		
		// if(ResourceHelper.ExistsInPersistentData("level2.json"))
		// {
			
		// 	l2img.sprite = sp2;
		// 	print ("lol");
		// 	l2.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level2.completed == true) {
		// 		if (Level2.star == 3) {

		// 			le2im1.sprite = Star1;
		// 			le2im2.sprite = Star2;
		// 			le2im3.sprite = Star3;
		// 		} else if (Level2.star == 2) {
		// 			print ("1star");
		// 			le2im1.sprite = Star1;
		// 			le2im2.sprite = Star2;
		// 		} else if (Level2.star == 1) {

		// 			le2im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level3.json"))
		// {
		// 	l3img.sprite = sp3;
		// 	print ("lol");
		// 	l3.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level3.completed == true) {
		// 		if (Level3.star == 3) {

		// 			le3im1.sprite = Star1;
		// 			le3im2.sprite = Star2;
		// 			le3im3.sprite = Star3;
		// 		} else if (Level3.star == 2) {
		// 			print ("1star");
		// 			le3im1.sprite = Star1;
		// 			le3im2.sprite = Star2;
		// 		} else if (Level3.star == 1) {

		// 			le3im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level4.json"))
		// {
		// 	l4img.sprite = sp4;
		// 	print ("lol");
		// 	l4.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level4.completed == true) {
		// 		if (Level4.star == 3) {

		// 			le4im1.sprite = Star1;
		// 			le4im2.sprite = Star2;
		// 			le4im3.sprite = Star3;
		// 		} else if (Level4.star == 2) {
		// 			print ("1star");
		// 			le4im1.sprite = Star1;
		// 			le4im2.sprite = Star2;
		// 		} else if (Level4.star == 1) {

		// 			le4im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level5.json"))
		// {
		// 	l5img.sprite = sp5;
		// 	print ("lol");
		// 	l5.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level5.completed == true) {
		// 		if (Level5.star == 3) {

		// 			le5im1.sprite = Star1;
		// 			le5im2.sprite = Star2;
		// 			le5im3.sprite = Star3;
		// 		} else if (Level5.star == 2) {
		// 			print ("1star");
		// 			le5im1.sprite = Star1;
		// 			le5im2.sprite = Star2;
		// 		} else if (Level5.star == 1) {

		// 			le5im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level6.json"))
		// {
		// 	l6img.sprite = sp6;
		// 	print ("lol");
		// 	l6.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level6.completed == true) {
		// 		if (Level6.star == 3) {

		// 			le6im1.sprite = Star1;
		// 			le6im2.sprite = Star2;
		// 			le6im3.sprite = Star3;
		// 		} else if (Level6.star == 2) {
		// 			print ("1star");
		// 			le6im1.sprite = Star1;
		// 			le6im2.sprite = Star2;
		// 		} else if (Level6.star == 1) {

		// 			le6im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level7.json")) {
		// 	l7img.sprite = sp7;
		// 	print ("lol");
		// 	l7.SetActive (true);
		// 	print ("here");
		// 	try{
		// 	if (Level7.completed == true) {
		// 		if (Level7.star == 3) {

		// 			le7im1.sprite = Star1;
		// 			le7im2.sprite = Star2;
		// 			le7im3.sprite = Star3;
		// 		} else if (Level7.star == 2) {
		// 			print ("1star");
		// 			le7im1.sprite = Star1;
		// 			le7im2.sprite = Star2;
		// 		} else if (Level7.star == 1) {

		// 			le7im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception) {
		// 	}
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level8.json")) {
		// 	l8img.sprite = sp8;
		// 	print ("lol");
		// 	l8.SetActive (true);
		// 	print ("here");
		// 	try
		// 	{
		// 	if (Level8.completed == true) {
		// 		if (Level8.star == 3) {

		// 			le8im1.sprite = Star1;
		// 			le8im2.sprite = Star2;
		// 			le8im3.sprite = Star3;
		// 		} else if (Level8.star == 2) {
		// 			print ("1star");
		// 			le8im1.sprite = Star1;
		// 			le8im2.sprite = Star2;
		// 		} else if (Level8.star == 1) {

		// 			le8im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level9.json")) {
		// 	l9img.sprite = sp9;
		// 	print ("lol");
		// 	l9.SetActive (true);
		// 	print ("here");
		// 	try{if (Level9.completed == true) {
		// 		if (Level9.star == 3) {

		// 			le9im1.sprite = Star1;
		// 			le9im2.sprite = Star2;
		// 			le9im3.sprite = Star3;
		// 		} else if (Level9.star == 2) {
		// 			print ("1star");
		// 			le9im1.sprite = Star1;
		// 			le9im2.sprite = Star2;
		// 		} else if (Level9.star == 1) {

		// 			le9im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception) {
				
		// 	}
		// }
		// if (ResourceHelper.ExistsInPersistentData ("level10.json")) {
		// 	try{
		// 	l10img.sprite = sp10;
		// 	print ("lol");
		// 	l10.SetActive (true);
		// 	print ("here");

		// 	if (Level10.completed == true) {
		// 		if (Level10.star == 3) {

		// 			le10im1.sprite = Star1;
		// 			le10im2.sprite = Star2;
		// 			le10im3.sprite = Star3;
		// 		} else if (Level10.star == 2) {
		// 			print ("1star");
		// 			le10im1.sprite = Star1;
		// 			le10im2.sprite = Star2;
		// 		} else if (Level10.star == 1) {

		// 			le10im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception)
		// 	{
		// 		Debug.Log ("thkdkh");
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level11.json"))
		// 	{
		// 		l11img.sprite = sp11;
		// 		print ("lol");
		// 		l11.SetActive (true);
		// 		print ("here");
		// 	try{
		// 	if (Level11.completed == true) {
		// 		if (Level11.star == 3) {

		// 			le11im1.sprite = Star1;
		// 			le11im2.sprite = Star2;
		// 			le11im3.sprite = Star3;
		// 		} else if (Level11.star == 2) {
		// 			print ("1star");
		// 			le11im1.sprite = Star1;
		// 			le11im2.sprite = Star2;
		// 		} else if (Level11.star == 1) {

		// 			le11im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// 	}
		// if(ResourceHelper.ExistsInPersistentData("level12.json"))
		// 	{
		// 		l12img.sprite = sp12;
		// 		l12.SetActive (true);

		// 		print ("here");
		// 	try{
		// 	if (Level12.completed == true) {
		// 		if (Level12.star == 3) {

		// 			le12im1.sprite = Star1;
		// 			le12im2.sprite = Star2;
		// 			le12im3.sprite = Star3;
		// 		} else if (Level12.star == 2) {
		// 			print ("1star");
		// 			le12im1.sprite = Star1;
		// 			le12im2.sprite = Star2;
		// 		} else if (Level12.star == 1) {

		// 			le12im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// 	}
		// if(ResourceHelper.ExistsInPersistentData("level13.json"))
		// {
		// 	l13img.sprite = sp13;
		// 	l13.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level13.completed == true) {
		// 		if (Level13.star == 3) {

		// 			le13im1.sprite = Star1;
		// 			le13im2.sprite = Star2;
		// 			le13im3.sprite = Star3;
		// 		} else if (Level13.star == 2) {
		// 			print ("1star");
		// 			le13im1.sprite = Star1;
		// 			le13im2.sprite = Star2;
		// 		} else if (Level13.star == 1) {

		// 			le13im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level14.json"))
		// {
		// 	l14img.sprite = sp14;
		// 	l14.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level14.completed == true) {
		// 		if (Level14.star == 3) {

		// 			le14im1.sprite = Star1;
		// 			le14im2.sprite = Star2;
		// 			le14im3.sprite = Star3;
		// 		} else if (Level14.star == 2) {
		// 			print ("1star");
		// 			le14im1.sprite = Star1;
		// 			le14im2.sprite = Star2;
		// 		} else if (Level14.star == 1) {

		// 			le14im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level15.json"))
		// {
		// 	l15img.sprite = sp15;
		// 	l15.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level15.completed == true) {
		// 		if (Level15.star == 3) {

		// 			le15im1.sprite = Star1;
		// 			le15im2.sprite = Star2;
		// 			le15im3.sprite = Star3;
		// 		} else if (Level15.star == 2) {
		// 			print ("1star");
		// 			le15im1.sprite = Star1;
		// 			le15im2.sprite = Star2;
		// 		} else if (Level15.star == 1) {

		// 			le15im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception) {
				
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level16.json"))
		// {
		// 	l16img.sprite = sp16;
		// 	l16.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level16.completed == true) {
		// 		if (Level16.star == 3) {

		// 			le16im1.sprite = Star1;
		// 			le16im2.sprite = Star2;
		// 			le16im3.sprite = Star3;
		// 		} else if (Level16.star == 2) {
		// 			print ("1star");
		// 			le16im1.sprite = Star1;
		// 			le16im2.sprite = Star2;
		// 		} else if (Level16.star == 1) {

		// 			le16im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level17.json"))
		// {
		// 	l17img.sprite = sp17;
		// 	l17.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level17.completed == true) {
		// 		if (Level17.star == 3) {

		// 			le17im1.sprite = Star1;
		// 			le17im2.sprite = Star2;
		// 			le17im3.sprite = Star3;
		// 		} else if (Level17.star == 2) {
		// 			print ("1star");
		// 			le17im1.sprite = Star1;
		// 			le17im2.sprite = Star2;
		// 		} else if (Level17.star == 1) {

		// 			le17im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level18.json"))
		// {
		// 	l18img.sprite = sp18;
		// 	l18.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level18.completed == true) {
		// 		if (Level18.star == 3) {

		// 			le18im1.sprite = Star1;
		// 			le18im2.sprite = Star2;
		// 			le18im3.sprite = Star3;
		// 		} else if (Level18.star == 2) {
		// 			print ("1star");
		// 			le18im1.sprite = Star1;
		// 			le18im2.sprite = Star2;
		// 		} else if (Level18.star == 1) {

		// 			le18im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level19.json"))
		// {
		// 	l19img.sprite = sp19;
		// 	l19.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level19.completed == true) {
		// 		if (Level19.star == 3) {

		// 			le19im1.sprite = Star1;
		// 			le19im2.sprite = Star2;
		// 			le19im3.sprite = Star3;
		// 		} else if (Level19.star == 2) {
		// 			print ("1star");
		// 			le19im1.sprite = Star1;
		// 			le19im2.sprite = Star2;
		// 		} else if (Level19.star == 1) {

		// 			le19im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level20.json"))
		// {
		// 	l20img.sprite = sp20;
		// 	l20.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level20.completed == true) {
		// 		if (Level20.star == 3) {

		// 			le20im1.sprite = Star1;
		// 			le20im2.sprite = Star2;
		// 			le20im3.sprite = Star3;
		// 		} else if (Level20.star == 2) {
		// 			print ("1star");
		// 			le20im1.sprite = Star1;
		// 			le20im2.sprite = Star2;
		// 		} else if (Level20.star == 1) {

		// 			le20im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level21.json"))
		// {
		// 	l21img.sprite = sp21;
		// 	l21.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level21.completed == true) {
		// 		if (Level21.star == 3) {

		// 			le21im1.sprite = Star1;
		// 			le21im2.sprite = Star2;
		// 			le21im3.sprite = Star3;
		// 		} else if (Level21.star == 2) {
		// 			print ("1star");
		// 			le21im1.sprite = Star1;
		// 			le21im2.sprite = Star2;
		// 		} else if (Level21.star == 1) {

		// 			le21im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level22.json"))
		// {
		// 	l22img.sprite = sp22;
		// 	l22.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level22.completed == true) {
		// 		if (Level22.star == 3) {

		// 			le22im1.sprite = Star1;
		// 			le22im2.sprite = Star2;
		// 			le22im3.sprite = Star3;
		// 		} else if (Level22.star == 2) {
		// 			print ("1star");
		// 			le22im1.sprite = Star1;
		// 			le22im2.sprite = Star2;
		// 		} else if (Level22.star == 1) {

		// 			le22im1.sprite = Star1;
		// 		}
		// 		}}
		// 	catch(System.Exception) {
				
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level23.json"))
		// {
		// 	l23img.sprite = sp23;
		// 	l23.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level23.completed == true) {
		// 		if (Level23.star == 3) {

		// 			le23im1.sprite = Star1;
		// 			le23im2.sprite = Star2;
		// 			le23im3.sprite = Star3;
		// 		} else if (Level23.star == 2) {
		// 			print ("1star");
		// 			le23im1.sprite = Star1;
		// 			le23im2.sprite = Star2;
		// 		} else if (Level23.star == 1) {

		// 			le23im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level24.json"))
		// {
		// 	l24img.sprite = sp24;
		// 	l24.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level24.completed == true) {
		// 		if (Level24.star == 3) {

		// 			le24im1.sprite = Star1;
		// 			le24im2.sprite = Star2;
		// 			le24im3.sprite = Star3;
		// 		} else if (Level24.star == 2) {
		// 			print ("1star");
		// 			le24im1.sprite = Star1;
		// 			le24im2.sprite = Star2;
		// 		} else if (Level24.star == 1) {

		// 			le24im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level25.json"))
		// {
		// 	l25img.sprite = sp25;
		// 	l25.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level25.completed == true) {
		// 		if (Level25.star == 3) {

		// 			le25im1.sprite = Star1;
		// 			le25im2.sprite = Star2;
		// 			le25im3.sprite = Star3;
		// 		} else if (Level25.star == 2) {
		// 			print ("1star");
		// 			le25im1.sprite = Star1;
		// 			le25im2.sprite = Star2;
		// 		} else if (Level25.star == 1) {

		// 			le25im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level26.json"))
		// {
		// 	l26img.sprite = sp26;
		// 	l26.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level26.completed == true) {
		// 		if (Level26.star == 3) {

		// 			le26im1.sprite = Star1;
		// 			le26im2.sprite = Star2;
		// 			le26im3.sprite = Star3;
		// 		} else if (Level26.star == 2) {
		// 			print ("1star");
		// 			le26im1.sprite = Star1;
		// 			le26im2.sprite = Star2;
		// 		} else if (Level26.star == 1) {

		// 			le26im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level27.json"))
		// {
		// 	l27img.sprite = sp27;
		// 	l27.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level27.completed == true) {
		// 		if (Level27.star == 3) {

		// 			le27im1.sprite = Star1;
		// 			le27im2.sprite = Star2;
		// 			le27im3.sprite = Star3;
		// 		} else if (Level27.star == 2) {
		// 			print ("1star");
		// 			le27im1.sprite = Star1;
		// 			le27im2.sprite = Star2;
		// 		} else if (Level27.star == 1) {

		// 			le27im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level28.json"))
		// {
		// 	l28img.sprite = sp28;
		// 	l28.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level28.completed == true) {
		// 		if (Level28.star == 3) {

		// 			le28im1.sprite = Star1;
		// 			le28im2.sprite = Star2;
		// 			le28im3.sprite = Star3;
		// 		} else if (Level28.star == 2) {
		// 			print ("1star");
		// 			le28im1.sprite = Star1;
		// 			le28im2.sprite = Star2;
		// 		} else if (Level28.star == 1) {

		// 			le28im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level29.json"))
		// {
		// 	l29img.sprite = sp29;
		// 	l29.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level29.completed == true) {
		// 		if (Level29.star == 3) {

		// 			le29im1.sprite = Star1;
		// 			le29im2.sprite = Star2;
		// 			le29im3.sprite = Star3;
		// 		} else if (Level29.star == 2) {
		// 			print ("1star");
		// 			le29im1.sprite = Star1;
		// 			le29im2.sprite = Star2;
		// 		} else if (Level29.star == 1) {

		// 			le29im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level30.json"))
		// {
		// 	l30img.sprite = sp30;
		// 	l30.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level30.completed == true) {
		// 		if (Level30.star == 3) {

		// 			le30im1.sprite = Star1;
		// 			le30im2.sprite = Star2;
		// 			le30im3.sprite = Star3;
		// 		} else if (Level30.star == 2) {
		// 			print ("1star");
		// 			le30im1.sprite = Star1;
		// 			le30im2.sprite = Star2;
		// 		} else if (Level30.star == 1) {

		// 			le30im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level31.json"))
		// {
		// 	l31img.sprite = sp31;
		// 	l31.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level31.completed == true) {
		// 		if (Level31.star == 3) {

		// 			le31im1.sprite = Star1;
		// 			le31im2.sprite = Star2;
		// 			le31im3.sprite = Star3;
		// 		} else if (Level31.star == 2) {
		// 			print ("1star");
		// 			le31im1.sprite = Star1;
		// 			le31im2.sprite = Star2;
		// 		} else if (Level31.star == 1) {

		// 			le31im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level32.json"))
		// {
		// 	l32img.sprite = sp32;
		// 	l32.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level32.completed == true) {
		// 		if (Level32.star == 3) {

		// 			le32im1.sprite = Star1;
		// 			le32im2.sprite = Star2;
		// 			le32im3.sprite = Star3;
		// 		} else if (Level32.star == 2) {
		// 			print ("1star");
		// 			le32im1.sprite = Star1;
		// 			le32im2.sprite = Star2;
		// 		} else if (Level32.star == 1) {

		// 			le32im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level33.json"))
		// {
		// 	l33img.sprite = sp33;
		// 	l33.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level33.completed == true) {
		// 		if (Level33.star == 3) {

		// 			le33im1.sprite = Star1;
		// 			le33im2.sprite = Star2;
		// 			le33im3.sprite = Star3;
		// 		} else if (Level33.star == 2) {
		// 			print ("1star");
		// 			le33im1.sprite = Star1;
		// 			le33im2.sprite = Star2;
		// 		} else if (Level33.star == 1) {

		// 			le33im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level34.json"))
		// {
		// 	l34img.sprite = sp34;
		// 	l34.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level34.completed == true) {
		// 		if (Level34.star == 3) {

		// 			le34im1.sprite = Star1;
		// 			le34im2.sprite = Star2;
		// 			le34im3.sprite = Star3;
		// 		} else if (Level34.star == 2) {
		// 			print ("1star");
		// 			le34im1.sprite = Star1;
		// 			le34im2.sprite = Star2;
		// 		} else if (Level34.star == 1) {

		// 			le34im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level35.json"))
		// {
		// 	l35img.sprite = sp35;
		// 	l35.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level35.completed == true) {
		// 		if (Level35.star == 3) {

		// 			le35im1.sprite = Star1;
		// 			le35im2.sprite = Star2;
		// 			le35im3.sprite = Star3;
		// 		} else if (Level35.star == 2) {
		// 			print ("1star");
		// 			le35im1.sprite = Star1;
		// 			le35im2.sprite = Star2;
		// 		} else if (Level35.star == 1) {

		// 			le35im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level36.json"))
		// {
		// 	l36img.sprite = sp36;
		// 	l36.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level36.completed == true) {
		// 		if (Level36.star == 3) {

		// 			le36im1.sprite = Star1;
		// 			le36im2.sprite = Star2;
		// 			le36im3.sprite = Star3;
		// 		} else if (Level36.star == 2) {
		// 			print ("1star");
		// 			le36im1.sprite = Star1;
		// 			le36im2.sprite = Star2;
		// 		} else if (Level36.star == 1) {

		// 			le36im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level37.json"))
		// {
		// 	l37img.sprite = sp37;
		// 	l37.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level37.completed == true) {
		// 		if (Level37.star == 3) {

		// 			le37im1.sprite = Star1;
		// 			le37im2.sprite = Star2;
		// 			le37im3.sprite = Star3;
		// 		} else if (Level37.star == 2) {
		// 			print ("1star");
		// 			le37im1.sprite = Star1;
		// 			le37im2.sprite = Star2;
		// 		} else if (Level37.star == 1) {

		// 			le37im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level38.json"))
		// {
		// 	l38img.sprite = sp38;
		// 	l38.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level38.completed == true) {
		// 		if (Level38.star == 3) {

		// 			le38im1.sprite = Star1;
		// 			le38im2.sprite = Star2;
		// 			le38im3.sprite = Star3;
		// 		} else if (Level38.star == 2) {
		// 			print ("1star");
		// 			le38im1.sprite = Star1;
		// 			le38im2.sprite = Star2;
		// 		} else if (Level38.star == 1) {

		// 			le38im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level39.json"))
		// {
		// 	l39img.sprite = sp39;
		// 	l39.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level39.completed == true) {
		// 		if (Level39.star == 3) {

		// 			le39im1.sprite = Star1;
		// 			le39im2.sprite = Star2;
		// 			le39im3.sprite = Star3;
		// 		} else if (Level39.star == 2) {
		// 			print ("1star");
		// 			le39im1.sprite = Star1;
		// 			le39im2.sprite = Star2;
		// 		} else if (Level39.star == 1) {

		// 			le39im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level40.json"))
		// {
		// 	l40img.sprite = sp40;
		// 	l40.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level40.completed == true) {
		// 		if (Level40.star == 3) {

		// 			le40im1.sprite = Star1;
		// 			le40im2.sprite = Star2;
		// 			le40im3.sprite = Star3;
		// 		} else if (Level40.star == 2) {
		// 			print ("1star");
		// 			le40im1.sprite = Star1;
		// 			le40im2.sprite = Star2;
		// 		} else if (Level40.star == 1) {

		// 			le40im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level41.json"))
		// {
		// 	l41img.sprite = sp41;
		// 	l41.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level41.completed == true) {
		// 		if (Level41.star == 3) {

		// 			le41im1.sprite = Star1;
		// 			le41im2.sprite = Star2;
		// 			le41im3.sprite = Star3;
		// 		} else if (Level41.star == 2) {
		// 			print ("1star");
		// 			le41im1.sprite = Star1;
		// 			le41im2.sprite = Star2;
		// 		} else if (Level41.star == 1) {

		// 			le41im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level42.json"))
		// {
		// 	l42img.sprite = sp42;
		// 	l42.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level42.completed == true) {
		// 		if (Level42.star == 3) {

		// 			le42im1.sprite = Star1;
		// 			le42im2.sprite = Star2;
		// 			le42im3.sprite = Star3;
		// 		} else if (Level42.star == 2) {
		// 			print ("1star");
		// 			le42im1.sprite = Star1;
		// 			le42im2.sprite = Star2;
		// 		} else if (Level42.star == 1) {

		// 			le42im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level43.json"))
		// {
		// 	l43img.sprite = sp43;
		// 	l43.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level43.completed == true) {
		// 		if (Level43.star == 3) {

		// 			le43im1.sprite = Star1;
		// 			le43im2.sprite = Star2;
		// 			le43im3.sprite = Star3;
		// 		} else if (Level43.star == 2) {
		// 			print ("1star");
		// 			le43im1.sprite = Star1;
		// 			le43im2.sprite = Star2;
		// 		} else if (Level43.star == 1) {

		// 			le43im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level44.json"))
		// {
		// 	l44img.sprite = sp44;
		// 	l44.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level44.completed == true) {
		// 		if (Level44.star == 3) {

		// 			le44im1.sprite = Star1;
		// 			le44im2.sprite = Star2;
		// 			le44im3.sprite = Star3;
		// 		} else if (Level44.star == 2) {
		// 			print ("1star");
		// 			le44im1.sprite = Star1;
		// 			le44im2.sprite = Star2;
		// 		} else if (Level44.star == 1) {

		// 			le44im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception) {
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level45.json"))
		// {
		// 	l45img.sprite = sp45;
		// 	l45.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level45.completed == true) {
		// 		if (Level45.star == 3) {

		// 			le45im1.sprite = Star1;
		// 			le45im2.sprite = Star2;
		// 			le45im3.sprite = Star3;
		// 		} else if (Level45.star == 2) {
		// 			print ("1star");
		// 			le45im1.sprite = Star1;
		// 			le45im2.sprite = Star2;
		// 		} else if (Level45.star == 1) {

		// 			le45im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level46.json"))
		// {
		// 	l46img.sprite = sp46;
		// 	l46.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level46.completed == true) {
		// 		if (Level46.star == 3) {

		// 			le46im1.sprite = Star1;
		// 			le46im2.sprite = Star2;
		// 			le46im3.sprite = Star3;
		// 		} else if (Level46.star == 2) {
		// 			print ("1star");
		// 			le46im1.sprite = Star1;
		// 			le46im2.sprite = Star2;
		// 		} else if (Level46.star == 1) {

		// 			le46im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level47.json"))
		// {
		// 	l47img.sprite = sp47;
		// 	l47.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level47.completed == true) {
		// 		if (Level47.star == 3) {

		// 			le47im1.sprite = Star1;
		// 			le47im2.sprite = Star2;
		// 			le47im3.sprite = Star3;
		// 		} else if (Level47.star == 2) {
		// 			print ("1star");
		// 			le47im1.sprite = Star1;
		// 			le47im2.sprite = Star2;
		// 		} else if (Level47.star == 1) {

		// 			le47im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level48.json"))
		// {
		// 	l48img.sprite = sp48;
		// 	l48.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level48.completed == true) {
		// 		if (Level48.star == 3) {

		// 			le48im1.sprite = Star1;
		// 			le48im2.sprite = Star2;
		// 			le48im3.sprite = Star3;
		// 		} else if (Level48.star == 2) {
		// 			print ("1star");
		// 			le48im1.sprite = Star1;
		// 			le48im2.sprite = Star2;
		// 		} else if (Level48.star == 1) {

		// 			le48im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level49.json"))
		// {
		// 	l49img.sprite = sp49;
		// 	l49.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level49.completed == true) {
		// 		if (Level49.star == 3) {

		// 			le49im1.sprite = Star1;
		// 			le49im2.sprite = Star2;
		// 			le49im3.sprite = Star3;
		// 		} else if (Level49.star == 2) {
		// 			print ("1star");
		// 			le49im1.sprite = Star1;
		// 			le49im2.sprite = Star2;
		// 		} else if (Level49.star == 1) {

		// 			le49im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level50.json"))
		// {
		// 	l50img.sprite = sp50;
		// 	l50.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level50.completed == true) {
		// 		if (Level50.star == 3) {

		// 			le50im1.sprite = Star1;
		// 			le50im2.sprite = Star2;
		// 			le50im3.sprite = Star3;
		// 		} else if (Level50.star == 2) {
		// 			print ("1star");
		// 			le50im1.sprite = Star1;
		// 			le50im2.sprite = Star2;
		// 		} else if (Level50.star == 1) {

		// 			le50im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level51.json"))
		// {
		// 	l51img.sprite = sp51;
		// 	l51.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level51.completed == true) {
		// 		if (Level51.star == 3) {

		// 			le51im1.sprite = Star1;
		// 			le51im2.sprite = Star2;
		// 			le51im3.sprite = Star3;
		// 		} else if (Level51.star == 2) {
		// 			print ("1star");
		// 			le51im1.sprite = Star1;
		// 			le51im2.sprite = Star2;
		// 		} else if (Level51.star == 1) {

		// 			le51im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level52.json"))
		// {
		// 	l52img.sprite = sp52;
		// 	l52.SetActive (true);
		
		// 	print ("here");
		// 	try{
		// 	if (Level52.completed == true) {
		// 		if (Level52.star == 3) {

		// 			le52im1.sprite = Star1;
		// 			le52im2.sprite = Star2;
		// 			le52im3.sprite = Star3;
		// 		} else if (Level52.star == 2) {
		// 			print ("1star");
		// 			le52im1.sprite = Star1;
		// 			le52im2.sprite = Star2;
		// 		} else if (Level52.star == 1) {

		// 			le52im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level53.json"))
		// {
		// 	l53img.sprite = sp53;
		// 	l53.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level53.completed == true) {
		// 		if (Level53.star == 3) {

		// 			le53im1.sprite = Star1;
		// 			le53im2.sprite = Star2;
		// 			le53im3.sprite = Star3;
		// 		} else if (Level53.star == 2) {
		// 			print ("1star");
		// 			le53im1.sprite = Star1;
		// 			le53im2.sprite = Star2;
		// 		} else if (Level53.star == 1) {

		// 			le53im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level54.json"))
		// {
		// 	l54img.sprite = sp54;
		// 	l54.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level54.completed == true) {
		// 		if (Level54.star == 3) {

		// 			le54im1.sprite = Star1;
		// 			le54im2.sprite = Star2;
		// 			le54im3.sprite = Star3;
		// 		} else if (Level54.star == 2) {
		// 			print ("1star");
		// 			le54im1.sprite = Star1;
		// 			le54im2.sprite = Star2;
		// 		} else if (Level54.star == 1) {

		// 			le54im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level55.json"))
		// {
		// 	l55img.sprite = sp55;
		// 	l55.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level55.completed == true) {
		// 		if (Level55.star == 3) {

		// 			le55im1.sprite = Star1;
		// 			le55im2.sprite = Star2;
		// 			le55im3.sprite = Star3;
		// 		} else if (Level55.star == 2) {
		// 			print ("1star");
		// 			le55im1.sprite = Star1;
		// 			le55im2.sprite = Star2;
		// 		} else if (Level55.star == 1) {

		// 			le55im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level56.json"))
		// {
		// 	l56img.sprite = sp56;
		// 	l56.SetActive (true);

		// 	print ("here");
		// 	try
		// 	{
		// 	if (Level56.completed == true) {
		// 		if (Level56.star == 3) {

		// 			le56im1.sprite = Star1;
		// 			le56im2.sprite = Star2;
		// 			le56im3.sprite = Star3;
		// 		} else if (Level56.star == 2) {
		// 			print ("1star");
		// 			le56im1.sprite = Star1;
		// 			le56im2.sprite = Star2;
		// 		} else if (Level56.star == 1) {

		// 			le56im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level57.json"))
		// {
		// 	l57img.sprite = sp57;
		// 	l57.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level57.completed == true) {
		// 		if (Level57.star == 3) {

		// 			le57im1.sprite = Star1;
		// 			le57im2.sprite = Star2;
		// 			le57im3.sprite = Star3;
		// 		} else if (Level57.star == 2) {
		// 			print ("1star");
		// 			le57im1.sprite = Star1;
		// 			le57im2.sprite = Star2;
		// 		} else if (Level57.star == 1) {

		// 			le57im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level58.json"))
		// {
		// 	l58img.sprite = sp58;
		// 	l58.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level58.completed == true) {
		// 		if (Level58.star == 3) {

		// 			le58im1.sprite = Star1;
		// 			le58im2.sprite = Star2;
		// 			le58im3.sprite = Star3;
		// 		} else if (Level58.star == 2) {
		// 			print ("1star");
		// 			le58im1.sprite = Star1;
		// 			le58im2.sprite = Star2;
		// 		} else if (Level58.star == 1) {

		// 			le58im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level59.json"))
		// {
		// 	l59img.sprite = sp59;
		// 	l59.SetActive (true);

		// 	print ("here");
		// 	try{
		// 	if (Level59.completed == true) {
		// 		if (Level59.star == 3) {

		// 			le59im1.sprite = Star1;
		// 			le59im2.sprite = Star2;
		// 			le59im3.sprite = Star3;
		// 		} else if (Level59.star == 2) {
		// 			print ("1star");
		// 			le59im1.sprite = Star1;
		// 			le59im2.sprite = Star2;
		// 		} else if (Level59.star == 1) {

		// 			le59im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		// if(ResourceHelper.ExistsInPersistentData("level60.json"))
		// {
		// 	l60img.sprite = sp60;
		// 	l60.SetActive (true);

		// 	print ("here");
		// 	try
		// 	{
		// 	if (Level60.completed == true) {
		// 		if (Level60.star == 3) {

		// 			le60im1.sprite = Star1;
		// 			le60im2.sprite = Star2;
		// 			le60im3.sprite = Star3;
		// 		} else if (Level60.star == 2) {
		// 			print ("1star");
		// 			le60im1.sprite = Star1;
		// 			le60im2.sprite = Star2;
		// 		} else if (Level60.star == 1) {

		// 			le60im1.sprite = Star1;
		// 		}
		// 	}
		// 	}
		// 	catch(System.Exception){
		// 	}
		// }
		yield return new WaitForSeconds(1f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

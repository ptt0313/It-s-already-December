# 나홀로 크리스마스!


익숙한 고전게임인 **타워디펜스**와 고전영화 **나홀로집에**라는 컨셉으로 **벌써 12월이조** 라는 조이름과 걸맞게 새로 리메이크했습니다. 

그래서 유저들이 옛날 추억을 다시 느낄 수 있게 해주고 색다른 재미를 주기 위해 노력했습니다. 


##  개발 환경
(깃 main에 프리팹이 깨지는현상이 있어서 2st_main에서 확인가능합니다.)
![Unity](https://img.shields.io/badge/-Unity-%23000000?style=flat-square&logo=Unity)
![C#](https://img.shields.io/badge/-C%23-%7ED321?logo=Csharp&style=flat)


## 팀원 : 신용욱(팀장), 황선범, 조두희, 전수현, 장영준

Unity로 개발한 타워디펜스게임입니다. 

충돌 및 scriptable object, object pool과 같은 오브젝트 생성 관련 로직에 집중하여 Unity 숙달을 위해 진행한 5인 프로젝트입니다.

총 개발기간은 6일이며 구현된 내용은 아래와 같습니다.


## 주요기능 

### **1. 게임 정지 기능**


   ![image](https://github.com/ptt0313/It-s-already-December/assets/89771577/aa1195a0-a127-47ff-b355-b2b557aa3c3d)

   게임화면 오른쪽 상단에 "정지 아이콘"이 있다. 이 버튼을 클릭하면 위 이미지와 같은 팝업창과 함께 게임을 잠깐 정지시킬 수 있다.
   게임을 다시 시작하려면 **계속하기**, 팝업창 오른쪽 상단의 **X버튼**, 또는 **정지 아이콘**을 다시 한번더 클릭하면 된다. 

   또한 게임의 오디오 소리를 여기서 조절할 수 있으며 **그만하기** 버튼을 눌렀을 때는 타이틀 화면으로 돌아간다. 
   


### **2. 타워 설치 및 재화**



![image](https://github.com/ptt0313/It-s-already-December/assets/89771577/fefa017e-ef20-4e06-963f-a6003ea1f3ab)


![image](https://github.com/ptt0313/It-s-already-December/assets/89771577/87b15d8f-21c8-4baa-b9a1-4ff6428afac9)


게임 화면의 제일 상단에 **Tower Menu** 버튼을 클릭하면 설치할 수 있는 타워의 종류와 제일 하단에 현재 플레이어가 가지고 있는 재화 (코인) 을 보여준다. 
타워를 설치할 동안에는 게임은 일시중지. 다 설치한 뒤에 **Back Game**버튼을 통해 다시 플레이를 할 수 있다. 

타워의 이미지를 클릭하여 원하는 타워를 설치할 수 있고, 지금 선택하고 있는 타워 이외, 다른 타워를 설치하고 싶을때는 X버튼으로 선택되어있는 타워를 초기화. 설치하고 싶은 타워를 다시 선택하여 설치해주면 된다.  

눈길 이외의 자갈밭. 그리고 마지막 목적지인 집을 제외하고는 어디든 설치할 수 있으며 타워 하나당 200코인의 재화가 들어간다. 



### **3. 플레이어의 생명 표시 및 게임오버** 

![image](https://github.com/ptt0313/It-s-already-December/assets/89771577/7b4c10b7-99f5-4b3c-a236-bc6fede5da8c)


왼쪽 상단에 플레이어의 현재 생명력 상태를 보여준다. 처음에 총 3개의 생명이 주어지며 집으로 들어오는 도둑(적)을 막지 못할때마다 생명이 하나씩 사라진다.
플레이어의 생명력이 0이 되었을때 위와 같은 팝업창을 띄우며 **다시하기**와 **타이틀(로 돌아가기)** 라는 선택지를 유저에게 준다. 

https://github.com/dayoonkang/1_TrashFlight/assets/150164152/818fa4a2-ac5a-4ded-8865-02fa5f761d24

# 🎮 TrashFlight_2D_Mouseplay
유니티 2D 미사일 발사 게임 "Trash Flight"

## 💻 프로젝트 소개
나의 캐릭터가 걸어갑니다! 뚜벅뚜벅 🚶‍♂️🚶‍♀️ 마우스와 키보드로 그를 움직여 보세요.

나의 캐릭터의 앞을 가로막는 외계인 적들이 등장합니다. 👽👽💨

그들은 각기 다른 hp를 가지고 있어요! ✨💥

미사일로 적들의 hp를 소모시키세요. :rage1::rage2::rage3:

적들이 소멸되면서, 동전을 던져줄거예요! 👻💎

동전을 모으면 내 캐릭터의 무기가 강해진답니다. ⚪⚪⚪🔫

점점 강해지는 적들을 모두 잡으면, 최종 보스가 등장할거예요.

모든 적들을 물리치고, 게임의 엔딩을 보세요! 🏁🏆


## 🏃‍♀️ 개발 기간
23.11.08 - 23.11.13

## ⚙️ 개발 환경 및 사용 언어
- Window x64
- Unity 2022.3.12f1
- Visual Studio 2022 C#

## 🌟 주요 기능


## 🛠️ 이 프로젝트는 어떤 문제를 해결했나요?
기본 게임 (copy project) 이외 개인적으로 추가한 수정 사항은 다음과 같습니다. 문제점은 베타 테스트를 통해 사용자 의견을 수렴하여 작성되었습니다.


안녕하십니까, TrashFlight를 사랑해주시는 모든 고객님.

**님께서 문의하신 TrashFlight 2.0 업데이트가 완료되었습니다.

이번 업데이트에서는 전반적인 게임 난이도 조절이 있었습니다.

이번 업데이트에서 변경된 사항은 다음과 같습니다.

<버전 2.0>

1. Enemies hp 향상
   
- enemy 1 hp 3 (동일)
- enemy 2 hp 4
- enemy 3 hp 5
- enemy 4 hp 6
- enemy 5 hp 7
- enemy 6 hp 8
- enemy 7 hp 9

2. Enemies spawn interval 조절
- 2.5s ➡️ 4s로 변경

3. Enemies move speed 변경
- 5s ➡️ 2.5s로 변경 

4. weapon upgrade 기준 향상
- 기존 : coin을 10개 먹어야 weapon upgrade
 
     ➡️ coin을 30개 먹어야 weapon upgrade

5. Weapon3 Damage 너프
- 기존 : weapon3 damage : 4

     ➡️ weapon3 damage 3

6. Enemy Level Up Speed 조절
- 기존: Ememy 10개 지나면 다음 Enemy level로 넘어감

    ➡️ Ememy 3개 지나면 다음 Enemy level로 넘어감

7. Enemy Speed 증가
- 기존: Ememy level 오를 시 enemy 속도 2 증가
   
     ➡️ Ememy level 오를 시 enemy 속도 1 증가

이상입니다. 저희 게임을 항상 사랑해주셔서 감사합니다. 즐거운 플레이 시간 되십시오.


## 💪 이 프로젝트를 통해 무엇을 배우셨나요?
1. 이미지 에셋 다운로드, 배경 설정
- Sprites에 이미지 저장, hierarchy view에 끌어와서 이미지 사용
- Pixels per Unit을 통해 이미지 크기 조정

2. 움직이는 배경 설정
- Background class script 생성, Update method 안에서 transform.position, Vector3.down*moveSpeed 함수 이용하여 구현
- if문 사용, y<-10 이면 new transform Vector3 생성하여 위치 변경

3. 플레이어 생성과 애니메이션
- Offset과 Padding을 이용하여 이미지 Slice
- 여러개의 Sprites를 선택하여 create run animation, window-animation에서 frame per sec 속도 조절

4. 키보드로 캐릭터 움직임
- Player script에서 Input.GetKey 함수를 이용하여 키보드의 좌우값을 입력받음.
- input값에 moveSpeed 변수와 deltaTime 변수를 곱하고 transform.position에 입력값을 더해주어 위치 계산
- 캐릭터가 창 밖으로 나가지 못하게 Box Collider2D로 벽을 만듦

5. 마우스로 캐릭터 움직임
-  mousePos라는 변수 설정하여 Camera.main.ScreenToWorlPoint 함수를 활용하여 입력받은 값을 넣어줌
-  캐릭터의 위치를 new Vector3 함수를 사용하여 mousePos.x를 연결해줌

6. 미사일 만들기
- 초급, 중급, 고급 무기 에셋을 준비하여 슬라이스
- Weapon Script를 생성한 후 위로 이동하도록 Vector3.up 함수를 이용하여 로직 작성
- Weapon Prefabs 생성, Instantiate() 함수를 사용하여 생성되는 미사일 로직 작성, [SerializeField]에서 shootInterval과 lastShotTime 변수 생성
- if 문을 통해 lastShotTime을 갱신해주고 미사일 발사 간격의 텀 생성
- Destroy 함수를 통해 발사된 미사일 delay 되었다가 사라지게 설정

7. Enemy 만들기
- sprites를 slice 하여 asset 준비
- Enemy Script에서 enemy가 화면 아래로 내려올 경우 destroy 되게끔 Destroy 함수, transform.position, Vector3.down 변수를 사용하여 설정
- Prefabs의 box collider 충돌 영역 크기 맞춤 설정하여 위치 배열
- moveSpeed의 값이 enemyIndex가 증가할때마다 증가시켜 난이도 증가. SetMoveSpeed 함수를 작성

8. Enemy Spawner 적 무한 생성 시스템 
- EnemySpawner Script를 작성, arrPos 라는 enum을 생성하여 하여 random으로 enemy를 5개의 위치 중 골라 배치
- Start Method에 StardEnemyRoutine을 실행시키고, StartCoroutine 반복문을 작성하여 enemy가 무한 생성되도록 로직 작성
- SpawnCount라는 변수를 만들어 몇번째 Spawn인지 카운트하게 작성, spawn count가 10이면 enemyIndex, 즉 적 레벨이 +1되도록 작성
- GetComponent<Enemy>를 통해 형변환하여 enemy의 movespeed 조절

9. 충돌 처리
- weapon의 collider 2D 의 설정하여 damage 변수 값을 설정
- Enemy Script에서 충돌한 대상이 Weapon일 경우 hp 변수 값을 -1시키고, GameObject 즉 enemy Destroy
- Weapon에 Circle Collider 2d 설정, OnTriggerEnter2D 함수 생성, other.gameObject.tag == "Enemy"일 경우 Destroy
- 마찬가지로 캐릭터와 Enemy 충돌 시에도 Character Destroy Event 생성
- enemy마다 hp[SerializeField] 값 조절해주어 enemy level system implement

10. 코인 만들기
- 코인 에셋 slice 하여 회전하는 것처럼 animation 만들기. Frame per second 조절하여 속도 설정
- Circle Collider 2D 설정
- Coin Script 생성, Jump 함수를 설정하여 GetComponent<Rigidbody2D> 함수를 통해 coin이 아래로 떨어지는 힘을 받도록 제작
- 모든 prefabs에 대해 coin이라는 [SerializeField]값을 생성하여 coin prefabs 넣어주기 -> enemy destroy 되면 coin 생성되는 로직 작성
- 코인이 화면 바깥으로 떨어지면 destroy 되게끔 위치 설정
- player와 coin의 collider 이벤트 발생 시 player의 coin 변수 값 +1되도록 작성

11. 점수 출력
- 좌측 상단에 획득한 코인 갯수 창 생성
- GameManager Script 작성하여 IncreaseCoin 함수 생성, coin 값이 증가되는 함수.
- Player Script에서 IncreaseCoin 함수 호출
- 코인 갯수 Text와 연결할 수 있도록 TextMeshProUGUI 변수를 생성

12. 무기 업그레이드
- Coin 변수의 값이 30개씩 증가할수록( Coin %30==0) Player의 Weapon Index가 증가하도록 Player Script에 로직 작성
- GameManager Script에서 weapons의 index를 [SerializeField]로 작성하여 unity 내에서 weapon level 설정

13. 보스 만들기
- new tag에 boss 추가
- enemyIndex > enemies(적 종류 갯수)일 경우에, 보스 등장.
- SpawnBoss 함수 생성, hp는 증가, transform은 중간, moveSpeed는 감소시킴. 
- Boss 가 등장하면 타 enemy 등장하지 않도록 다른 enemyIndex=0으로 바꿔줌

14. 게임 오버 처리
- GameManager 에서 SetGameOver 함수 추가, StopEnemyRoutine 메소드 호출.
- Boss를 Player가 무찔렀거나, player가 enemy와 충돌했을때 SetGameOver 함수 호출하도록 메소드 작성
- enemy script에서 Boss가 destroy 되었을 경우 IsWin 변수의 값이 true가 되도록, player가 enemy와 collide 됐을 경우 false 되도록 작성

15. 결과 화면 출력
- Canvas 내 "Game Over"라는 Text와 캐릭터 이미지 삽입.
- Play Again Button 생성, game manager에서 SetGameOver 함수가 호출 되었을 때 소환되도록 GameOverPannel을 GameObject로 정의하고 호출.


## 💭 나중에 추가하고 싶은 기능
- Game Start Canvas 생성
- Game Play background sound, missile launch sound 삽입
- Game Settings 설정: Stop Game, End Game, Goto Lobby, Reset Resolution 등 여러 세팅 창 만들기
- 움직이는 적 만들기 : 지금은 가만히만 있으면 무조건 생존 가능
- enemy missile system
- 쏘면 안되는 enemy 만들기 : bomb!

## ✔️ 참고자료
Youtube - 나도코딩 "유니티 무료 강의(Crash Course) - 5시간 만에 게임 만드는 법 배우기"

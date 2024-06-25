- 책 추천
>- 클린코드
>https://www.yes24.com/Product/Goods/11681152   
>아키텍처의 가시화를 위한 책, 유지보수 관련

>- 실용주의 프로그래머
>https://www.yes24.com/Product/Goods/107077663  
>             "

>- 객체지향의 사실과 오해 
>https://www.yes24.com/Product/Goods/11681152  
>한국인 개발자의 입장에서 위의 내용을 서술.
-------------------
- 여러여러 기억할점

  - 기초
  자료구조, 알고리즘 중요  
  -그리드, 백트래킹, 다이나믹, 순열, 조합, 트리, 그래프, 다익스트라...
시간복잡도..ㅠㅠㅠ 
C#으로 공부하자

  - 중급, 고급  
객체지향, 애자일 (켄트벡, 마틴파울러, 로버트C마틴...)

  - 프로그램코드란? : 동작하게 명세하는 상세적인 명세
확실하게 자료구조와, 목적을 이해하고 코딩을 하자.

----------------------------------------------------------
>__필기__

1.비주얼 스튜디오와 c#
-
- 비주얼 스튜디오 초기설정에 관한 정보
  - 닷넷 프레임워크는 윈도우에서만 쓸수있다. (24년 기준 현재는 닷넷 코어 이용(다양한 플랫폼 지원)
  - C:\Users\Admin\source\repos 내 프로젝트 디렉토리 링크 기억하기.
  - 레포지토리 만들때 체크 하면 main생성.(디폴트)  
체크 안하면 자바스크립트처럼 생성.

- C#의 클래스 형식  
```
namespace ConsoleApp2
{
    class MainClass
    {
        void Main() {
        }
    }
}
```

- 요것이 바로 매개변수...
```
(string[] args)
```

- 스태틱이란..?  
코딩은 상세언어. 적은대로 나온다.  
->콘솔에.적어라.("헬로월드")를.;끝 
```
static void Main(string[] args)
{
    Console.WriteLine("Hello World");
}
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/a09fb3c0-0953-411e-a522-79a6e106b535)

2.다양한 출력 연습하기
-

- 요것도 두줄  
```
static void Main(string[] args)
{
    Console.WriteLine("안녕하세요");
    Console.WriteLine("나는 장창훈입니다.");
}
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/dcd69f5c-230e-4de1-b113-4fb062a6cd1a)

- 요것도 또한 두줄
```
static void Main(string[] args)
{
    Console.WriteLine("안녕하세요\n나는 장창훈입니다.");
}
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/dcd69f5c-230e-4de1-b113-4fb062a6cd1a)

- 또한...
__$을 이용하면 C#에서 변수를 이용할수있다!!__
```
static void Main(string[] args)
{
    string name = "장창훈";
    Console.WriteLine("안녕하세요");
    Console.WriteLine($"저는 {name} 입니다.");
}
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/dcd69f5c-230e-4de1-b113-4fb062a6cd1a)

-------------------
>퀴즈!  
조건)변수를 두개 사용하라.  
string greet;  
string name  

```
반갑습니다.
저는 장창훈입니다.
```
```
static void Main(string[] args)
{
    string greet = "반갑습니다.";
    string name = "장창훈";
    Console.WriteLine($"{greet}");
    Console.WriteLine($"저는 {name} 입니다.");
}
```

- 여러개 쓰려면 이런방식도 있다.
```
static void Main(string[] args)
{
    string greet = "반갑습니다";
    string greet2 = "안녕하세요";
    string name = "장창훈";
    int age = 25;
    Console.WriteLine("{0} {1}", greet, greet2);
    Console.WriteLine($"저는 {name} {age}살 입니다.");
}
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/1184ec33-29af-4a0b-8838-92db1ee417ce)

-------------------
- 3+5는?
```
static void Main(string[] args)
{
    // 3 + 5를 변수를 이용하여 결과를 출력해보자.
    int value1 = 3;
    int value2 = 5;
    int result = value1 + value2;

    Console.WriteLine(value1+value2);   //8
    Console.WriteLine(result);   //8
    Console.WriteLine($"{value1} + {value2} = {result}");   //3 + 5 = 8
}
```
![image](https://github.com/sound2862/SFDiary/assets/62818790/3d6f66f6-5795-4503-a710-67aac8bb6709)

- 숫자 받아오는 방법. (닷넷 프레임워크 기준)  
이렇게 해야 숫자 여러번 받아올때 버그 안난당
```
static void Main(string[] args)
{
    Console.Write("숫자를 입력해주세요");  // Write는 한줄 안띄움. WriteLine은 띄움
    int a = int.Parse(Console.ReadLine()); // 콘솔에서 한줄 읽고, int로 변환!(Parse)
    Console.WriteLine(a);
}
```

3.잡다한 팁?
-
- .cs파일은 csharp파일. (소스코드 파일)  
bin/exe에는 실행파일이 있다
- exe파일 cmd창에 잡아끌면 경로가 뜨고, 실행도 된다!
![image](https://github.com/sound2862/SFDiary/assets/62818790/468a073b-2051-405d-b123-1bbb563e9620)
- kafka : 분산형 데이터 스트리밍 플랫폼  
오픈소스 이용할수있는곳.  
https://kafka.apache.org/
- 사진 못찍었는데,,, import안되면 설치하면 되는경우가 많다.

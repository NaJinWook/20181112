# [29CM] 백엔드 포지션 과제 (Java / Spring)
29CM 상품 주문 프로그램

## 🖥 프로젝트 소개
CSV 파일로 된 상품 정보를 등록하고 상품을 주문하고 결제하는 `Java` 콘솔 기반 프로그램입니다.

## 🕰 개발 기간
- 2023년 09월 27일 ~ 2023년 10월 04일

## ⚙ 개발 환경
- `Java 15`
- `JDK 15.0.2`
- **IDE** : `Eclipse 4.29.0`
- **라이브러리** : `opencsv`, `JUnit5`
- **프로젝트 유형** : `Maven Project`

## 📁 프로젝트 구조
📦src  
 ┣ 📂main  
 ┃ ┣ 📂java  
 ┃ ┃ ┗ 📂kr.co._29cm.homework.project  
 ┃ ┃ ┃ ┣ 📂model  
 ┃ ┃ ┃ ┃ ┣ 📜Item.java  
 ┃ ┃ ┃ ┃ ┗ 📜Order.java  
 ┃ ┃ ┃ ┣ 📂service  
 ┃ ┃ ┃ ┃ ┗ 📜OrderService.java  
 ┃ ┃ ┃ ┣ 📂util  
 ┃ ┃ ┃ ┃ ┗ 📜CommonUtils.java  
 ┃ ┃ ┃ ┗ 📜Main.java  
 ┃ ┗ 📂resources  
 ┃ ┃ ┗ 📂files  
 ┃ ┃ ┃ ┣ 📜29CM 백엔드 과제 (java _ Spring).pdf  
 ┃ ┃ ┃ ┗ 📜items_백엔드 과제.csv  
 ┗ 📂test  
 ┃ ┣ 📂java  
 ┃ ┃ ┗ 📂kr.co._29cm.homework.project.service  
 ┃ ┃ ┃ ┗ 📜OrderServiceTest.java  
 ┃ ┗ 📂resources  
 ┗ ━ ┗ 📜junit-platform.properties  

## 🎈 구현 방향
- `Item` : 상품 정보를 나타내는 클래스로 상품번호, 상품명, 판매가격, 재고수량을 포함하고 있습니다.
- `Order` : 주문 정보를 나타내는 클래스로 상품번호, 주문수량을 포함하고 있습니다.
- `CommonUtils` : CSV 파일을 Map으로 변환하고 숫자를 콤마로 구분된 문자열로 변환하는 등의 공통적인 유틸 클래스입니다.
- `OrderService` : 상품주문과 결제 프로세스를 관리하는 핵심 클래스입니다. 상품주문, 결제, 재고확인, 주문내역 관리와 같은 다양한 기능을 포함합니다. 프로그램 시작 시 인스턴스를 생성하고 주문 및 결제 프로세스를 시작합니다.
- `Main` : 프로그램의 진입점으로, CSV 파일에서 상품정보를 읽어와서 주문 서비스를 시작하는 역할을 합니다.

## 📝 Test
`JUnit5` 테스트 병렬 실행으로 임의의 상품 정보를 입력해주고 동시에 주문하도록 테스트하였습니다. `Java`의 기본 `Syncronized` 키워드를 사용하여 여러 스레드가 동시에 접근하지 못하도록 하였고 한 개의 스레드만 접근할 수 있게 처리하였습니다.

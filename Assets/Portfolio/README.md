# Unity Portfolio

## 조작 방법

* WASD 키를 이용하여 플레이어를 이동합니다.
* Input System을 사용하여 입력을 처리하였습니다.
* 이동 방향 계산 시 Vector3와 정규화를 사용하였습니다.

## 구현 기능

### 1. 플레이어 이동

* Input System 기반 이동 구현
* Vector3 정규화 적용

### 2. 몬스터 감지 및 회전

* Vector3.Dot을 이용한 시야각 판정
* Quaternion.RotateTowards를 이용한 부드러운 회전 구현

### 3. 거리 기반 상태 판정

* sqrMagnitude를 사용하여 거리 계산
* 거리 조건에 따라 Idle, Chase, Attack 상태 전이 구현

### 4. 자료구조 활용

* List를 사용하여 몬스터 데이터를 관리
* 몬스터 추가, 순회, 제거 기능 구현

#### List 선택 이유

현재 프로젝트는 몬스터를 순차적으로 탐색하고 관리하는 기능이 주 목적이므로 List를 선택하였습니다.
Dictionary는 빠른 검색에 유리하지만 현재 구현 범위에서는 순회가 많아 List가 더 적합하다고 판단하였습니다.

### 5. FSM 상태 전이

* Idle → Chase → Attack 상태 전이 구현
* 플레이어와의 거리 및 시야 판정 결과에 따라 상태 변경

namespace ALGORITHM.PathfindingAlgorithms;

public class PathfindingAlgorithms
{
   /*****************************
    Finite State Machine (FSM)
    애니매이션 상태를 전환하는데 많이 사용됨
    상태들: 초기(init), 대기(Idle), 오류(Error), 복구(Recovery)
      
      초기 상태: 대기
      
      이벤트 "Move" 발생 시:
          현재 상태가 대기이면:
              이동 상태로 전이
      
      이벤트 "Attack" 발생 시:
          현재 상태가 대기 또는 이동이면:
              공격 상태로 전이
      
      이벤트 "Stop" 발생 시:
          현재 상태가 이동 또는 공격이면:
              대기 상태로 전이
   *****************************/
}
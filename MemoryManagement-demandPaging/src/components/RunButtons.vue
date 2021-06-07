<template>
  <div>
    <button @click="oneStepRun()" class="one-step transform hover:scale-110 motion-reduce:transform-none border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">单步执行</button>
    <button @click="continuouslyRun()" class="sequential-steps transform hover:scale-110 motion-reduce:transform-none border-black border-2 rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">连续执行</button>
    <button @click="reset()" class="reset transform hover:scale-110 motion-reduce:transform-none border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">暂停/重置</button>
  </div>
</template>

<script>
import Global from "./Global";
import SideBar from "./SideBar";
import Words from "./Words";
import Logs from "./Logs";
export default {
  name: "RunButtons",
  methods : {
    oneStepRun(){
      if(Global.currentStatus===Global.Stop) {  //需要额外启动
        console.log(1);   //先做简单测试再加Timer
      }
      else if (Global.currentStatus ===Global.OneStepRun){
        console.log(2);
      }
      else if (Global.currentSatus ===Global.ContinuouslyRun){
        console.log(3);
      }
      else if(Global.currentStatus ===Global.Reset){
        console.log(4);
      }
    },
    continuouslyRun(){
      if(Global.currentStatus===Global.Stop) {  //需要额外启动
        console.log(1);
      }
      else if (Global.currentStatus ===Global.OneStepRun){
        console.log(2);
      }
      else if (Global.currentSatus ===Global.ContinuouslyRun){
        console.log(3);
      }
      else if(Global.currentStatus ===Global.Reset){
        console.log(4);
      }
    },
    reset(){
      //停止值
      if(Global.currentStatus === Global.ContinuouslyRun){
        Global.currentStatus = Global.Stop;
        console.log("Stop");
      }
      //重置值
      else {
        Global.currentSatus = Global.Reset;  //恢复初始状态
        SideBar.data().lackPageNumber = Global.lackPageNumber;
        SideBar.data().lackPagePercentage = Global.lackPagePercentage;
        Logs.currentPageNumber = Global.currentPageNumber;
        Logs.currentOffset = Global.currentOffset;
        Logs.currentLocation = Global.currentLocation;
        Logs.nextPageNumber = Global.nextPageNumber;
        Logs.nextOffset = Global.nextOffset;
        Logs.nextLocation = Global.nextLocation;
        Logs.needDispatch = Global.needDispatch;
        Logs.inPage = Global.inPage;
        Logs.outPage = Global.outPage;
        Logs.finishedNumber = Global.finishedNumber;
        Logs.notFinishedNumber = Global.notFinishedNumber;
        Words.pageOne = Global.pageOne;
        Words.pageTwo =  Global.pageTwo;
        Words.pageThree = Global.pageThree;
        Words.pageFour = Global.pageFour;
        console.log("Reset");
      }
    },
    FIFO(){   //执行FIFO算法

    },
    LRU(){  //执行LRU算法

    }
  }
}
</script>

<style scoped>
.one-step{
  position: fixed;
  top:650px;
  left:525px;
}
.sequential-steps{
  position: fixed;
  top:650px;
  left:725px;
}
.reset{
  position: fixed;
  top:650px;
  left:950px;
}
</style>
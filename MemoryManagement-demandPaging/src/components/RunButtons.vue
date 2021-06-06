<template>
  <div>
    <button @click="oneStepRun()" class="one-step transform hover:scale-110 motion-reduce:transform-none border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">单步执行</button>
    <button @click="continuouslyRun()" class="sequential-steps transform hover:scale-110 motion-reduce:transform-none border-black border-2 rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">连续执行</button>
    <button @click="reset()" class="reset transform hover:scale-110 motion-reduce:transform-none border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">重置</button>
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
      console.log(1);
    },
    continuouslyRun(){
      console.log(2);
    },
    reset(){
      //重置值
      Global.currentSatus = Global.Stop;
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
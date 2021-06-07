<template>
  <div>
    <button @click="oneStepRun()" class="one-step transform hover:scale-110 motion-reduce:transform-none border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">单步执行</button>
    <button @click="continuouslyRun()" class="sequential-steps transform hover:scale-110 motion-reduce:transform-none border-black border-2 rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">连续执行</button>
    <button @click="reset()" class="reset transform hover:scale-110 motion-reduce:transform-none border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">暂停/重置</button>
  </div>
</template>

<script>
import Global from "./Global";
export default {
  name: "RunButtons",
  methods : {
    oneStepRun(){
      Global.currentStatus = Global.OneStepRun;
      if(Global.currentAlgorithm === Global.LRU){
        this.LRU();
      }
      else{
        this.FIFO();
      }
    },
    continuouslyRun(){
      Global.currentStatus = Global.ContinuouslyRun;
      if(Global.currentAlgorithm === Global.LRU){
        this.LRU();
      }
      else{
        this.FIFO();
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
        Global.currentStatus = Global.Reset;  //恢复初始状态
        Global.lackPageNumber = 0;   //缺页数
        Global.lackPagePercentage = "0%" ; //缺页率
        Global.pageOne = "--";  //一号内存块
        Global.pageTwo = "--";  //二号内存块
        Global.pageThree = "--"; //三号内存块
        Global.pageFour = "--";  //四号内存块
        Global.currentPageNumber = "--" //当前页号
        Global.currentOffset = "--"; //当前页内偏移量
        Global.currentLocation = "--"; //当前指令地址
        Global.nextPageNumber = "--";//下一条页号
        Global.nextOffset = "--";  //下一条页面偏移量
        Global.nextLocation = "--";  //下一条指令的地址
        Global.needDispatch = "否"; //是否需要调度
        Global.inPage = "--"; //需要调进的页
        Global.outPage = "--"; //需要调出的页
        Global.finishedNumber = 0;  //已经完成的指令数
        Global.notFinishedNumber = 320; //未完成的指令数
        console.log("Reset");
      }
    },
    FIFO(){   //执行FIFO算法
    console.log(" FIFO");
    },
    LRU(){  //执行LRU算法
    console.log(" LRU");
    },
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
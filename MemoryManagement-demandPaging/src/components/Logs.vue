<template>
  <div>
    <!--这是一个侧边栏 -->
    <div>
      <ul  class="log-bar bg-gray-100">
        <li class="font-bold font-serif text-center">当前即将执行的指令</li>
        <li class="font-serif">页号:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">{{currentPageNumber}}</li>
        <li class="font-serif">页内偏移:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">{{currentOffset}}</li>
        <li class="font-serif">物理地址:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">{{currentLocation}}</li>
        <li class="font-serif font-bold text-center">下一条指令</li>
        <li class="font-serif">页号:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">{{nextPageNumber}}</li>
        <li class="font-serif">页内偏移量:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">{{nextOffset}}</li>
        <li class="font-serif">物理地址:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">{{nextLocation}}</li>
        <li class="font-serif font-bold">是否需要调页:</li>
        <li class="font-mono text-red-400 font-bold font-bold text-center">{{needDispatch}}</li>
        <li class="font-serif font-bold ">需要调进的页:</li>
        <li class="font-mono text-red-400 text-2xl font-bold text-center">{{inPage}}</li>
        <li class="font-serif font-bold ">需要调出的页:</li>
        <li class="font-mono text-red-400 text-2xl font-bold text-center">{{outPage}}</li>
        <li class="font-serif font-bold">指令总数:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">320</li>
        <li class="font-serif font-bold">已执行指令数:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">{{finishedNumber}}</li>
        <li class="font-serif font-bold">剩余指令数:</li>
        <li id="test" class="font-mono text-purple-400 text-2xl font-bold text-center">{{notFinishedNumber}}</li>
      </ul>
    </div>
  </div>

</template>

<script>
import Global from "./Global";
export default {
  name: "Logs",
  data:()=>{
    return {
      currentPageNumber : Global.currentPageNumber,
      currentOffset : Global.currentOffset,
      currentLocation : Global.currentLocation,
      nextPageNumber : Global.nextPageNumber,
      nextOffset : Global.nextOffset,
      nextLocation : Global.nextLocation,
      needDispatch : Global.needDispatch,
      inPage :Global.inPage,
      outPage : Global.outPage,
      finishedNumber : Global.finishedNumber,
      notFinishedNumber : Global.notFinishedNumber,
      timer:""
    }
  },
  methods:{
    initLogs(){
      this.currentPageNumber = "--";
      this.currentOffset = "--";
      this.currentLocation = "--";
      this.nextPageNumber = "--";
      this.nextOffset = "--";
      this.nextLocation = "--";
      this.needDispatch = "否";
      this.inPage = "--";
      this.outPage = "--";
      this.finishedNumber = 0;
      this.notFinishedNumber = 320;
      for(let i=0;i<Global.TotalOrdersNumber;i++) {   //执行总数初始化
        Global.isChecked[i] = false;
      }
      for(let i=0;i<Global.TotalMemoryBlocks;i++){ //FIFO队列初始化
        Global.OrderQueue[i] = -1;
      }
      for(let i=0;i<Global.TotalMemoryBlocks;i++){ //FIFO队列初始化
        Global.offsetQueue[i] = -1;
      }
    },
    updateLogs(){
      this.currentPageNumber = Global.currentPageNumber;
      this.currentOffset = Global.currentOffset;
      this.currentLocation = Global.currentOrder;

      this.nextPageNumber =(Global.finishedNumber === Global.TotalOrdersNumber)? "--": Global.nextPageNumber;
      this.nextOffset = (Global.finishedNumber === Global.TotalOrdersNumber)? "--": Global.nextOffset;
      this.nextLocation = (Global.finishedNumber === Global.TotalOrdersNumber)? "--": Global.nextOrder;

      this.needDispatch = Global.needDispatch;
      this.inPage = Global.inPage;
      this.outPage = Global.outPage;
      this.finishedNumber = Global.finishedNumber;
      this.notFinishedNumber = (Global.TotalOrdersNumber - Global.finishedNumber);
    },
    setLog(){   //监听并更新Logs区域的值
      if(Global.currentStatus === Global.Reset) {
        this.initLogs();
      }
      else{
        this.updateLogs();
      }
    }
  },
  mounted(){
    this.timer = setInterval(this.setLog,200);
  },
  beforeDestroy() {
    clearInterval(this.timer)
  }
}
</script>

<style scoped>
.log-bar{
  position: fixed;
  right: 0;
  width: 250px;
  height :100%;
}

</style>
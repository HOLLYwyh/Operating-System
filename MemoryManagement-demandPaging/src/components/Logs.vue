<template>
  <div>
    <!--这是一个侧边栏 -->
    <div>
      <ul  class="log-bar bg-gray-100">
        <li class="font-bold font-serif text-center">当前执行的指令</li>
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
    setLog(){
    }
  },
  mounted(){
    this.timer = setInterval(this.setLog,100);
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
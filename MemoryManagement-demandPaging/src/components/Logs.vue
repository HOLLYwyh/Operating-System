<template>
  <div>
    <!--这是一个侧边栏 -->
    <div>
      <ul  class="log-bar bg-gray-100">
        <li class="font-bold font-serif text-center">当前执行的指令</li>
        <li class="font-serif">页号:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">1</li>
        <li class="font-serif">页内偏移:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">1</li>
        <li class="font-serif">物理地址:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">1</li>
        <li class="font-serif font-bold text-center">下一条指令</li>
        <li class="font-serif">页号:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">1</li>
        <li class="font-serif">页内偏移量:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">5</li>
        <li class="font-serif">物理地址:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">5</li>
        <li class="font-serif font-bold">是否需要调页:</li>
        <li class="font-mono text-red-400 font-bold font-bold text-center">是</li>
        <li class="font-serif font-bold ">需要调进的页:</li>
        <li class="font-mono text-red-400 text-2xl font-bold text-center">12</li>
        <li class="font-serif font-bold ">需要调出的页:</li>
        <li class="font-mono text-red-400 text-2xl font-bold text-center">5</li>
        <li class="font-serif font-bold">指令总数:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">320</li>
        <li class="font-serif font-bold">已执行指令数:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold text-center">1</li>
        <li class="font-serif font-bold">剩余指令数:</li>
        <li id="test" class="font-mono text-purple-400 text-2xl font-bold text-center">{{number1}}</li>
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
      number1:Global.currentAlgorithm,
      timer:""
    }
  },
  methods:{
    setLog(){
      this.number1 = Global.currentAlgorithm
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
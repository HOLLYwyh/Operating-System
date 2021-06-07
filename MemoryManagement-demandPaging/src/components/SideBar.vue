<template>
  <div>
      <!--这是一个侧边栏 -->
    <div>
      <ul  class="sidebar bg-gray-100">
        <li class="project-name text-center font-serif font-bold">
          请求调页存储管理模拟
        </li>
        <li class="author-name text-center font-sans">
          1953608 吴英豪
        </li>
        <li class="word-1">
          请选择置换算法：
        </li>
        <li class="word-2 font-mono font-bold">
            缺页总数：
        </li>
        <li class="number font-mono font-bold text-purple-400 text-2xl">
          {{lackPageNumber}}
        </li>
        <li class="word-3 font-mono font-bold">
            缺页率：
        </li>
        <li class="percentage font-mono font-bold text-purple-400 text-2xl">
          {{lackPagePercentage}}
        </li>
      </ul>
      <button id="button1" @click="setAlgorithm(1)" class="button-1  border-2 border-black transform hover:scale-110 motion-reduce:transform-none p-4 border-r-4 border-purple-400 font-bold hover:border-purple-700">
      LRU算法
      </button>
      <button id="button2" @click="setAlgorithm(2)" class="button-2  border-2 border-black transform hover:scale-110 motion-reduce:transform-none p-4 border-r-4 border-purple-400 font-bold hover:border-purple-700">
      FIFO算法
      </button>
    </div>
  </div>
</template>

<script>
import Global from "./Global";

export default {
  name: 'SideBar',
  data:()=>{
    return {
      lackPageNumber : Global.lackPageNumber,
      lackPagePercentage: Global.lackPagePercentage,
      timer:""
    }
  },
  methods:{
    setAlgorithm(method){
      if(method===Global.LRU){  //是LRU算法
        document.getElementById("button1").style.backgroundColor="#6D28D9";
        document.getElementById("button2").style.backgroundColor="#F3F4F6";
        Global.currentAlgorithm=Global.LRU;
      }
      else if(method===Global.FIFO){   //是FIFO算法
        document.getElementById("button1").style.backgroundColor="#F3F4F6";
        document.getElementById("button2").style.backgroundColor="#6D28D9";
        Global.currentAlgorithm=Global.FIFO;
      }
    },
    initSideBar(){
      this.lackPagePercentage = "0%";
      this.lackPageNumber = 0;
    },
    updateSideBar(){
      this.lackPagePercentage = Global.lackPagePercentage;
      this.lackPageNumber = Global.lackPageNumber;
    },
    setSideBar(){
      if(Global.currentStatus === Global.Reset){
        this.initSideBar();
      }
      else{
        this.updateSideBar();
      }
    }
  },
  mounted(){
    this.timer = setInterval(this.setSideBar,200);
  },
  beforeDestroy() {
    clearInterval(this.timer)
  }
}
</script>

<style scoped>
.sidebar{
    position: fixed;
    width: 250px;
    height :100%;
}
button{
  width : 250px;
}
.button-1{
  position: fixed;
  top:200px;
  background-color: #F3F4F6;
}
.button-2{
  position: fixed;
  top:260px;
  background-color:#6D28D9;
}
.project-name{
  position: fixed;
  left:50px;
  top:20px;
}
.author-name{
  position: fixed;
  left:50px;
  top:70px;
}
.word-1{
  position: fixed;
  top:170px;
}
.word-2{
  position: fixed;
  left:50px;
  top:400px;
}
.word-3{
  position: fixed;
  left:50px;
  top:500px;
}
.number{
  position: fixed;
  left:50px;
  top:450px;
}
.percentage{
  position: fixed;
  left:50px;
  top:550px;
}
</style>
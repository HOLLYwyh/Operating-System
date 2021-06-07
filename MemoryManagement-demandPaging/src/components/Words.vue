<template>
  <div>
    <div class="word1 font-bold font-serif">内存块1</div>
    <div class="word2 font-bold font-serif">内存块2</div>
    <div class="word3 font-bold font-serif">内存块3</div>
    <div class="word4 font-bold font-serif">内存块4</div>
    <div class="font-bold font-serif page1">页号:</div>
    <div class="order1 font-mono text-purple-400 text-2xl font-bold">{{pageOne}}</div>
    <div class="font-bold font-serif page2">页号:</div>
    <div class="order2 font-mono text-purple-400 text-2xl font-bold">{{pageTwo}}</div>
    <div class="font-bold font-serif page3 ">页号:</div>
    <div class="order3 font-mono text-purple-400 text-2xl font-bold">{{pageThree}}</div>
    <div class="font-bold font-serif page4">页号:</div>
    <div class="order4 font-mono text-purple-400 text-2xl font-bold">{{pageFour}}</div>
  </div>
</template>

<script>
import Global from "./Global";
export default {
  name: "Words",
  data:()=>{
    return{
      pageOne : Global.pageOne,
      pageTwo : Global.pageTwo,
      pageThree : Global.pageThree,
      pageFour : Global.pageFour,
      timer : ""
    }
  },
  methods:{
    initWords(){
      this.pageOne = "--";
      this.pageTwo = "--";
      this.pageThree = "--";
      this.pageFour = "--";
    },
    updateWords(){
      this.pageOne = Global.pageOne;
      this.pageTwo = Global.pageTwo;
      this.pageThree = Global.pageThree;
      this.pageFour = Global.pageFour;
    },
    setWords(){
    if(Global.currentStatus === Global.Reset){
      this.initWords();
      }
    else{
      this.updateWords();
      }
    }
  },
  mounted(){
    this.timer = setInterval(this.setWords,200);
  },
  beforeDestroy() {
    clearInterval(this.timer)
  }
}
</script>

<style scoped>
.word1{
  position: fixed;
  top:20px;
  left:450px;
}
.word2{
  position: fixed;
  top:20px;
  left:650px;
}
.word3{
  position: fixed;
  top:20px;
  left:850px;
}
.word4{
  position: fixed;
  top:20px;
  left:1050px;
}
.page1{
  position: fixed;
  top:575px;
  left:450px;
}
.page2{
  position: fixed;
  top:575px;
  left:650px;
}
.page3{
  position: fixed;
  top:575px;
  left:850px;
}
.page4{
  position: fixed;
  top:575px;
  left:1050px;
}
.order1{
  position: fixed;
  top:570px;
  left:500px;
}
.order2{
  position: fixed;
  top:570px;
  left:700px;
}
.order3{
  position: fixed;
  top:570px;
  left:900px;
}
.order4{
  position: fixed;
  top:570px;
  left:1100px;
}
</style>
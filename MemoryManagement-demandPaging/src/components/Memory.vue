<template>
  <div>
    <MemoryBlock  class="memory-block-1"/>
    <MemoryBlock  class="memory-block-2"/>
    <MemoryBlock  class="memory-block-3"/>
    <MemoryBlock  class="memory-block-4"/>
  </div>
</template>

<script>
import MemoryBlock from "./MemoryBlock";
import Global from "./Global";
export default {
  name: "Memory",
  data:()=>{
    return{
      firstBlock:26,
      lastBlock:65,
      liArray :document.getElementsByTagName("li"),
      timer : ""
    }
  },
  components:{
    MemoryBlock
  },
  methods:{
    initMemory(){
      //测试
      for(let i = this.firstBlock;i<=this.lastBlock;i++){
        this.liArray[i].style.backgroundColor = "#F3F4F6";
      }
    },
    updateMemory(){
      this.initMemory();
      this.liArray = document.getElementsByTagName("li");
      for(let i=0;i<Global.TotalMemoryBlocks;i++){
        if(Global.offsetQueue[i]!==-1){
            this.liArray[this.firstBlock+i*10+Global.offsetQueue[i]].style.backgroundColor = "#EF4444";
        }
      }
    },
    setMemory(){
      if(Global.currentStatus === Global.Reset){
        this.initMemory();
      }
      else{
        this.updateMemory();
      }
    }
  },
  mounted(){
    this.timer = setInterval(this.setMemory,200);
  },
  beforeDestroy() {
    clearInterval(this.timer)
  }
}
</script>

<style scoped>
.memory-block-1{
  position: fixed;
  top:100px;
  left:405px;
}
.memory-block-2{
  position: fixed;
  top:100px;
  left:605px;
}
.memory-block-3{
  position: fixed;
  top:100px;
  left:805px;
}
.memory-block-4{
  position: fixed;
  top:100px;
  left:1005px;
}
</style>
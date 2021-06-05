<template>
  <div>
    <MemoryBlock class="first-block"></MemoryBlock>
    <MemoryBlock class="second-block"></MemoryBlock>
    <MemoryBlock class="third-block"></MemoryBlock>
    <MemoryBlock class="fourth-block"></MemoryBlock>
  </div>
</template>

<script>
import MemoryBlock from "./MemoryBlock";
export default {
  name: "Memory",
  components:{
    MemoryBlock
  }
}
</script>

<style scoped>
.first-block{
  position: fixed;
  top:100px;
  left:405px;
}
.second-block{
  position: fixed;
  top:100px;
  left:605px;
}
.third-block{
  position: fixed;
  top:100px;
  left:805px;
}
.fourth-block{
  position: fixed;
  top:100px;
  left:1005px;
}
</style>
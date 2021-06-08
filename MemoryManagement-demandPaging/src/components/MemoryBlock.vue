<template>
  <div>
    <ul class="memory-block">
      <li id="block-1" class="text-center border-2 border-black rounded-lg"></li>
      <li id="block-2" class="text-center border-2 border-black rounded-lg"></li>
      <li id="block-3" class="text-center border-2 border-black rounded-lg"></li>
      <li id="block-4" class="text-center border-2 border-black rounded-lg"></li>
      <li id="block-5" class="text-center border-2 border-black rounded-lg"></li>
      <li id="block-6" class="text-center border-2 border-black rounded-lg"></li>
      <li id="block-7" class="text-center border-2 border-black rounded-lg"></li>
      <li id="block-8" class="text-center border-2 border-black rounded-lg"></li>
      <li id="block-9" class="text-center border-2 border-black rounded-lg"></li>
      <li id="block-10" class="text-center border-2 border-black rounded-lg"></li>
    </ul>
  </div>
</template>

<script>
export default {
name: "MemoryBlock"
}
</script>

<style scoped>
.memory-block{
  position: fixed;
  top:50px;
  width: 150px;
  height :500px;
}
li{
  height:50px;
}
</style>
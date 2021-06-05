<template>
  <div>
    <ul class="memory-block bg-gray-100">
      <li class="bg-red-500 text-center border-2 border-black rounded-lg">1</li>
      <li class="text-center border-2 border-black rounded-lg"></li>
      <li class="text-center border-2 border-black rounded-lg"></li>
      <li class="text-center border-2 border-black rounded-lg"></li>
      <li class="text-center border-2 border-black rounded-lg"></li>
      <li class="text-center border-2 border-black rounded-lg"></li>
      <li class="text-center border-2 border-black rounded-lg"></li>
      <li class="text-center border-2 border-black rounded-lg"></li>
      <li class="text-center border-2 border-black rounded-lg"></li>
      <li class="text-center border-2 border-black rounded-lg"></li>
    </ul>
  </div>
</template>

<script>
export default {
name: "MemoryBlock",

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
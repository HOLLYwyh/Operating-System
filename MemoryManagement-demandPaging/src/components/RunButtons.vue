<template>
  <div>
    <button class="one-step border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">单步执行</button>
    <button class="sequential-steps border-black border-2 rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">连续执行</button>
    <button class="reset border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">重置</button>
  </div>
</template>

<script>
export default {
  name: "RunButtons"
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
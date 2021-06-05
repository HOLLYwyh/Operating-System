<template>
  <div>
    <button class="one-step">单步执行</button>
    <button class="sequential-steps">连续执行</button>
    <button class="reset">重置</button>
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
  left:550px;
}
.sequential-steps{
  position: fixed;
  top:650px;
  left:750px;
}
.reset{
  position: fixed;
  top:650px;
  left:950px;
}
</style>
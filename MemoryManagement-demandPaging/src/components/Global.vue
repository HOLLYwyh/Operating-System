<template>
  <div></div>
</template>

<script>
import Logs from "./Logs";
//这里将是所有的全局变量的注册地址
const LRU = 1;
const FIFO = 2;
let currentAlgorithm = FIFO;
//
function changeData() {
  Logs.data().number1 = currentAlgorithm;
}

export default {
  name: "Global",
  LRU,
  FIFO,
  currentAlgorithm,
  changeData
}
</script>

<style scoped>

</style>
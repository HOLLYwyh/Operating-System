<template>
  <div>
    <!--这是一个侧边栏 -->
    <div>
      <ul  class="log-bar bg-gray-100">
        <li class="font-bold font-serif">当前执行的指令</li>
        <li class="font-serif">页号:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold">1</li>
        <li class="font-serif">页内偏移:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold">1</li>
        <li class="font-serif">物理地址:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold">1</li><br>
        <li class="font-serif font-bold">下一条指令:</li>
        <li class="font-serif">页号:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold">1</li>
        <li class="font-serif">页内偏移量:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold">5</li>
        <li class="font-serif">物理地址:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold">5</li><br>
        <li class="font-serif font-bold">指令总数:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold">320</li>
        <li class="font-serif font-bold">已执行指令数:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold">1</li>
        <li class="font-serif font-bold">剩余指令数:</li>
        <li class="font-mono text-purple-400 text-2xl font-bold">319 </li>
      </ul>
    </div>
  </div>

</template>

<script>
export default {
  name: "Logs"
}
</script>

<style scoped>
.log-bar{
  position: fixed;
  right:0px;
  width: 250px;
  height :100%;
}

</style>
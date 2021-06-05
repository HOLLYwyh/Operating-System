<template>
  <div>
    <!--这是一个侧边栏 -->
    <div>
      <ul  class="log-bar bg-gray-100">
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
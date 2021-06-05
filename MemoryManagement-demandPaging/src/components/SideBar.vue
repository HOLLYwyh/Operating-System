<template>
  <div>
      <!--这是一个侧边栏 -->
    <div>
      <ul  class="sidebar bg-gray-100">
        <li class="project-name text-center font-serif font-bold">
          请求调页存储管理模拟
        </li>
        <li class="author-name text-center font-sans">
          1953608 吴英豪
        </li>
        <li class="word-1">
          请选择置换算法：
        </li>
        <button class="button-1 p-4 border-r-4 border-purple-400 font-bold hover:border-purple-700 hover:bg-purple-200">
          LRU算法
        </button>
        <button class="button-2 p-4 border-r-4 border-purple-400 font-bold hover:border-purple-700 hover:bg-purple-200">
          FIFO算法
        </button>
        <li class="word-2 font-mono font-bold">
            缺页总数：
        </li>
        <li class="number font-mono font-bold">
          50
        </li>
        <li class="word-3 font-mono font-bold">
            缺页率：
        </li>
        <li class="percentage font-mono font-bold">
          100%
        </li>
      </ul>
    </div>
  </div>
</template>

<script>
export default {
  name: 'SideBar'
}
</script>

<style scoped>
.sidebar{
    position: fixed;
    width: 250px;
    height :100%;
}
button{
  width : 250px;
}
.button-1{
  position: fixed;
  top:200px;
}
.button-2{
  position: fixed;
  top:255px;
}
.project-name{
  position: fixed;
  left:50px;
  top:20px;
}
.author-name{
  position: fixed;
  left:50px;
  top:70px;
}
.word-1{
  position: fixed;
  top:170px;
}
.word-2{
  position: fixed;
  left:50px;
  top:400px;
}
.word-3{
  position: fixed;
  left:50px;
  top:500px;
}
.number{
  position: fixed;
  left:50px;
  top:450px;
}
.percentage{
  position: fixed;
  left:50px;
  top:550px;
}
</style>
<template>
  <div id="app">
    <Logs/>
    <Global/>
    <Memory/>
    <RunButtons/>
    <SideBar/>
    <Words/>
  </div>
</template>

<script>

import Logs from "./components/Logs.vue";
import Global from "./components/Global";
import Memory from "./components/Memory";
import RunButtons from "./components/RunButtons";
import SideBar from './components/SideBar.vue';
import Words from "./components/Words";

export default {
  name: 'App',
  components: {
    Global,
    Logs,
    Memory,
    RunButtons,
    SideBar,
    Words
  }
}
</script>

<style scoped>

</style>

<template>
  <div id="app">
    <Logs/>
    <Memory/>
    <RunButtons/>
    <SideBar/>
  </div>
</template>

<script>

import Logs from "./components/Logs.vue";
import Memory from "./components/Memory";
import RunButtons from "./components/RunButtons";
import SideBar from './components/SideBar.vue';

export default {
  name: 'App',
  components: {
    Logs,
    Memory,
    RunButtons,
    SideBar
  }
}
</script>

<style scoped>

</style>

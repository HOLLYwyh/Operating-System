<template>
  <div></div>
</template>

<script>
//这里将是所有的全局变量的注册地址
const LRU = 1;   //LRU算法
const FIFO = 2;  // FIFO算法
const Stop = 3;  //当前停止状态
const OneStepRun = 4;   //当前为运行状态
const ContinuouslyRun = 5;  //连续运行
const Reset = 6;       //重置/初始状态
const SequenceOne = 79;
const SequenceTwo = 239;
const TotalOrdersNumber = 320; //总指令数
const Threshold = 300; //阈值
let currentStatus = Reset;   //当前状态为停止
let currentAlgorithm = FIFO;  //当前算法
let currentOrder = -1;
let lackPageNumber = 0;   //缺页数
let lackPagePercentage = "0%" ; //缺页率
let pageOne = "--";  //一号内存块
let pageTwo = "--";  //二号内存块
let pageThree = "--"; //三号内存块
let pageFour = "--";  //四号内存块
let currentPageNumber = "--" //当前页号
let currentOffset = "--"; //当前页内偏移量
let currentLocation = "--"; //当前指令地址
let nextPageNumber = "--";//下一条页号
let nextOffset = "--";  //下一条页面偏移量
let nextLocation = "--";  //下一条指令的地址
let needDispatch = "否"; //是否需要调度
let inPage = "--"; //需要调进的页
let outPage = "--"; //需要调出的页
let finishedNumber = 0;  //已经完成的指令数
let notFinishedNumber = 320; //未完成的指令数
let isChecked = new Array(320);  //访问指令




export default {
  name: "Global",
  LRU,
  FIFO,
  Stop,
  Reset,
  OneStepRun,
  ContinuouslyRun,
  SequenceOne,
  SequenceTwo,
  TotalOrdersNumber,
  Threshold,
  currentStatus,
  currentAlgorithm,
  currentOrder,
  lackPageNumber,
  lackPagePercentage,
  pageOne,
  pageTwo,
  pageThree,
  pageFour,
  currentPageNumber,
  currentOffset,
  currentLocation,
  nextPageNumber,
  nextOffset,
  nextLocation,
  needDispatch,
  inPage,
  outPage,
  finishedNumber,
  notFinishedNumber,
  isChecked
}
</script>

<style scoped>

</style>
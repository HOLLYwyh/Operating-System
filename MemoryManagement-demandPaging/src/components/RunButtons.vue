<template>
  <div>
    <button @click="oneStepRun()" class="one-step transform hover:scale-110 motion-reduce:transform-none border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">单步执行</button>
    <button @click="setContinue()" class="sequential-steps transform hover:scale-110 motion-reduce:transform-none border-black border-2 rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">连续执行</button>
    <button @click="reset()" class="reset transform hover:scale-110 motion-reduce:transform-none border-2 border-black rounded-sm bg-blue-300 py-3 px-6 hover:bg-red-500 font-serif font-bold">暂停/重置</button>
  </div>
</template>

<script>
import Global from "./Global";
export default {
  name: "RunButtons",
  data:()=>{
    return {
      isContinuouslyRun : false,
      timer : ""
    }
  },
  methods : {
    oneStepRun(){
      Global.currentStatus = Global.OneStepRun;
      if(Global.currentAlgorithm === Global.LRU){
        this.LRU();
      }
      else{
        this.FIFO();
      }
    },
    setContinue(){
      this.isContinuouslyRun = true;
      Global.currentStatus = Global.ContinuouslyRun;
    },
    continuouslyRun(){
    if(this.isContinuouslyRun){
        if(Global.currentAlgorithm === Global.LRU){
          this.LRU();
        }
        else{
          this.FIFO();
        }
      }
    },
    reset(){
      //停止值
      if(Global.currentStatus === Global.ContinuouslyRun){
        Global.currentStatus = Global.Stop;
        this.isContinuouslyRun = false;
      }
      //重置值
      else {
        Global.currentStatus = Global.Reset;  //恢复初始状态
        Global.lackPageNumber = 0;   //缺页数
        Global.lackPagePercentage = "0%" ; //缺页率
        Global.pageOne = "--";  //一号内存块
        Global.pageTwo = "--";  //二号内存块
        Global.pageThree = "--"; //三号内存块
        Global.pageFour = "--";  //四号内存块
        Global.currentPageNumber = "--" //当前页号
        Global.currentOffset = "--"; //当前页内偏移量
        Global.currentLocation = "--"; //当前指令地址
        Global.nextPageNumber = "--";//下一条页号
        Global.nextOffset = "--";  //下一条页面偏移量
        Global.nextLocation = "--";  //下一条指令的地址
        Global.needDispatch = "否"; //是否需要调度
        Global.inPage = "--"; //需要调进的页
        Global.outPage = "--"; //需要调出的页
        Global.finishedNumber = 0;  //已经完成的指令数
        Global.notFinishedNumber = 320; //未完成的指令数
        Global.currentOrder = -1;
        this.isContinuouslyRun = false;
      }
    },
    getOrder(){
      if(Global.currentOrder === -1){  //随机选择一条指令，这里还没有写
        Global.currentOrder = Math.floor(Math.random()*320);
        Global.isChecked[Global.currentOrder] = true;
        Global.finishedNumber ++;
        console.log(Global.currentOrder);
      }
      else if(Global.finishedNumber>=Global.Threshold){//大于阈值,强制顺序执行
        for(let i=0; i<Global.TotalOrdersNumber;i++){
          if(!Global.isChecked[i]){
            Global.currentOrder = i;
            Global.isChecked[i] = true;
            Global.finishedNumber ++;
            break;
          }
        }
        console.log(Global.currentOrder);
      }
      else if((Global.currentOrder === Global.TotalOrdersNumber-1)&&(Global.finishedNumber!==Global.TotalOrdersNumber)){  //到结尾但是没有执行完
        //随机生成一条
        let temp = Math.floor(Math.random()*320);
        while(Global.isChecked[temp]){
          temp = Math.floor(Math.random()*320);
        }
        Global.currentOrder = temp;
        Global.isChecked[temp] = true;
        Global.finishedNumber ++;
        console.log(Global.currentOrder);
      }
      else if((Global.currentOrder<=Global.SequenceOne)||(Global.currentOrder>=Global.SequenceTwo)){  //前后的顺序指令
        let tag = false;
        for(let i = Global.currentOrder+1;i<Global.TotalOrdersNumber;i++){
          if(!Global.isChecked[i]){
            Global.currentOrder = i;
            Global.isChecked[i] = true;
            Global.finishedNumber ++;
            tag = true;
            break;
          }
        }
        if(!tag){
          Global.currentOrder = Global.TotalOrdersNumber-1; //强行放到最后一个
        }
        console.log(Global.currentOrder);
      }
      else{   //中间的跳转指令
        let temp = Math.floor(Math.random()*320);
        while(Global.isChecked[temp]){
          temp = Math.floor(Math.random()*320);
        }
        Global.currentOrder = temp;
        Global.isChecked[temp] = true;
        Global.finishedNumber ++;
        console.log(Global.currentOrder);
      }
    },
    FIFO(){   //执行FIFO算法
      if(Global.finishedNumber === Global.TotalOrdersNumber){
        console.log(Global.finishedNumber);
        console.log("finished");
        Global.currentStatus =Global.Stop;
        return;
      }
      console.log(Global.finishedNumber);
      this.getOrder();
      this.FIFOMethod();
    },
    LRU(){  //执行LRU算法
      if(Global.finishedNumber === Global.TotalOrdersNumber){
        console.log("finished");
        Global.currentStatus =Global.Stop;
        return;
      }
      console.log(Global.finishedNumber);
      this.getOrder();
      this.LRUMethod();
    },
    FIFOMethod(){
    console.log("FIFO");
    },
    LRUMethod(){
    console.log("LRU");
    }
  },
  mounted(){
    this.timer = setInterval(this.continuouslyRun,100);
  },
  beforeDestroy() {
    clearInterval(this.timer)
  }
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
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
      this.runMethod();
    },
    setContinue(){
      this.isContinuouslyRun = true;
      Global.currentStatus = Global.ContinuouslyRun;
    },
    continuouslyRun(){
    if(this.isContinuouslyRun){
      this.runMethod();
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
        Global.succeedPageNumber = 0;  //请求页成功数
        Global.lackPageNumber = 0;   //缺页数
        Global.lackPagePercentage = "0%" ; //缺页率
        Global.pointerOne = -1;
        Global.pointerTwo = -1;
        Global.pointerThree = -1;
        Global.pointerFour = -1;
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
        Global.currentOrder = Math.floor(Math.random()*320);
        Global.nextOrder = -1;
        this.isContinuouslyRun = false;
      }
    },
    getOrder(){
      if(Global.nextOrder === -1){  //最开始的指令
        if((Global.currentOrder<=Global.SequenceOne)||(Global.currentOrder>=Global.SequenceTwo)){
          Global.nextOrder = Global.currentOrder+1;
        }
        else{
          Global.nextOrder = Math.floor(Math.random()*320);
        }
        Global.isChecked[Global.currentOrder] = true;
        Global.finishedNumber ++;
      }
      else if(Global.finishedNumber>=Global.Threshold){//大于阈值,强制顺序执行
        Global.currentOrder = Global.nextOrder;
        Global.isChecked[Global.currentOrder] = true;
        Global.finishedNumber ++;
        for(let i=0; i<Global.TotalOrdersNumber;i++){
          if(!Global.isChecked[i]){
            Global.nextOrder = i;
            break;
          }
        }
      }
      else if((Global.nextOrder === Global.TotalOrdersNumber-1)&&(Global.finishedNumber!==Global.TotalOrdersNumber)){  //到结尾但是没有执行完
        //随机生成一条
        let temp = Math.floor(Math.random()*320);
        while(Global.isChecked[temp]){
          temp = Math.floor(Math.random()*320);
        }
        Global.currentOrder =Global.nextOrder;
        Global.isChecked[Global.currentOrder] = true;
        Global.nextOrder = temp;
        Global.finishedNumber ++;
      }
      else if((Global.nextOrder<=Global.SequenceOne)||(Global.nextOrder>=Global.SequenceTwo)){  //前后的顺序指令
        let tag = false;
        for(let i = Global.nextOrder+1;i<Global.TotalOrdersNumber;i++){
          if(!Global.isChecked[i]){
            Global.currentOrder= Global.nextOrder;
            Global.isChecked[Global.currentOrder] = true;
            Global.nextOrder = i;
            Global.finishedNumber ++;
            tag = true;
            break;
          }
        }
        if(!tag){   //强行进行跳转
          let temp = Math.floor(Math.random()*320);
          while(Global.isChecked[temp]){
            temp = Math.floor(Math.random()*320);
          }
          Global.currentOrder = Global.nextOrder;
          Global.isChecked[Global.currentOrder] = true;
          Global.nextOrder = temp;
          Global.finishedNumber ++;
        }
      }
      else{   //中间的跳转指令
        let temp = Math.floor(Math.random()*320);
        while(Global.isChecked[temp]){
          temp = Math.floor(Math.random()*320);
        }
        Global.currentOrder = Global.nextOrder;
        Global.isChecked[Global.currentOrder] = true;
        Global.nextOrder = temp;
        Global.finishedNumber ++;
      }
    },
    runMethod(){
      if(Global.finishedNumber === Global.TotalOrdersNumber){
        Global.currentStatus =Global.Stop;
        return;
      }
      this.getOrder();
      Global.currentPageNumber = Math.floor(Global.currentOrder/10);
      Global.currentOffset = Global.currentOrder%10;
      Global.nextPageNumber = Math.floor(Global.nextOrder/10);
      Global.nextOffset = Global.nextOrder%10;
      this.runAlgorithm();
    },
    runAlgorithm(){
      let free = false;  //表示需要进入新的一个页
      let isIn = false;  //表示指令所在的页已经进入内存
      let freeTarget = -1;
      let isInTarget = -1;
      for(let i=0;i<Global.TotalMemoryBlocks;i++){
        if(Global.OrderQueue[i]===Global.currentPageNumber){
          isIn = true;
          isInTarget = i;
          break;
        }
      }
      if(isIn){ //已经进入页面不需要调度
        Global.needDispatch = "否";
        Global.inPage = "--";
        Global.outPage = "--";
        Global.succeedPageNumber++;
        Global.lackPagePercentage = ((Global.lackPageNumber/(Global.lackPageNumber+Global.succeedPageNumber))*100).toFixed(2) +"%";
        if(isInTarget ===Global.pointerTwo){
          Global.pointerTwo = Global.pointerOne;
          Global.pointerOne = isInTarget;
        }
        else if(isInTarget === Global.pointerThree){
          Global.pointerThree = Global.pointerTwo;
          Global.pointerTwo = Global.pointerOne;
          Global.pointerOne = isInTarget;
        }
        else if(isInTarget === Global.pointerFour){
          Global.pointerFour = Global.pointerThree;
          Global.pointerThree = Global.pointerTwo;
          Global.pointerTwo = Global.pointerOne;
          Global.pointerOne = isInTarget;
        }
      }
      if(!isIn){
        for(let i=0;i<Global.TotalMemoryBlocks;i++){
          if(Global.OrderQueue[i]===-1){
            free = true;
            Global.OrderQueue[i] = Global.currentPageNumber;
            freeTarget = i;
            break;
          }
        }
      }
      if(free){  //有空闲的位置，需要调度
        Global.needDispatch = "是";
        Global.inPage = Global.currentPageNumber;
        Global.outPage = "--";
        Global.lackPageNumber++;
        Global.lackPagePercentage = ((Global.lackPageNumber/(Global.lackPageNumber+Global.succeedPageNumber))*100).toFixed(2) +"%";
        switch (freeTarget){
          case 0:{
            Global.pageOne = Global.currentPageNumber;
            Global.pointerOne = 0;
            break;
          }
          case 1:{
            Global.pageTwo = Global.currentPageNumber;
            Global.pointerTwo = Global.pointerOne;
            Global.pointerOne = 1;
            break;
          }
          case 2:{
            Global.pageThree = Global.currentPageNumber;
            Global.pointerThree = Global.pointerTwo;
            Global.pointerTwo = Global.pointerOne;
            Global.pointerOne = 2;
            break;
          }
          case 3:{
            Global.pageFour = Global.currentPageNumber;
            Global.pointerFour = Global.pointerThree;
            Global.pointerThree = Global.pointerTwo;
            Global.pointerTwo = Global.pointerOne;
            Global.pointerOne = 3;
            break;
          }
        }
      }
      if((!isIn)&&(!free)){   //需要调度
        if(Global.currentAlgorithm === Global.LRU) {  //真正区分LRU和FIFO的地方
          Global.needDispatch = "是";
          Global.lackPageNumber++;
          Global.lackPagePercentage = ((Global.lackPageNumber / (Global.lackPageNumber + Global.succeedPageNumber)) * 100).toFixed(2) + "%";
          Global.outPage = Global.OrderQueue[Global.pointerFour];
          Global.inPage = Global.currentPageNumber;
          Global.OrderQueue[Global.pointerFour] = Global.currentPageNumber;
          switch (Global.outPage) {
            case Global.pageOne: {
              Global.pageOne = Global.inPage;
              break;
            }
            case Global.pageTwo: {
              Global.pageTwo = Global.inPage;
              break;
            }
            case Global.pageThree: {
              Global.pageThree = Global.inPage;
              break;
            }
            case Global.pageFour: {
              Global.pageFour = Global.inPage;
              break;
            }
          }
          let temp = Global.pointerFour;
          Global.pointerFour = Global.pointerThree;
          Global.pointerThree = Global.pointerTwo;
          Global.pointerTwo = Global.pointerOne;
          Global.pointerOne = temp;
        }
        else if(Global.currentAlgorithm === Global.FIFO){
          Global.needDispatch = "是";
          Global.lackPageNumber++;
          Global.lackPagePercentage = ((Global.lackPageNumber/(Global.lackPageNumber+Global.succeedPageNumber))*100).toFixed(2) +"%";
          Global.outPage = Global.OrderQueue.shift();
          Global.inPage = Global.currentPageNumber;
          Global.OrderQueue.push(Global.inPage);
          switch(Global.outPage){
            case Global.pageOne:{
              Global.pageOne = Global.OrderQueue[3];
              break;
            }
            case Global.pageTwo:{
              Global.pageTwo = Global.OrderQueue[3];
              break;
            }
            case Global.pageThree:{
              Global.pageThree = Global.OrderQueue[3];
              break;
            }
            case Global.pageFour:{
              Global.pageFour = Global.OrderQueue[3];
              break;
            }
          }
          if(Global.pointerOne === 3){
            Global.pointerOne = 3;
          }
          else if(Global.pointerTwo ===3){
            Global.pointerTwo = Global.pointerOne;
            Global.pointerOne = 3;
          }
          else if(Global.pointerThree ===3){
            Global.pointerThree = Global.pointerTwo;
            Global.pointerTwo = Global.pointerOne;
            Global.pointerOne = 3;
          }
          else if(Global.pointerFour ===3){
            Global.pointerFour = Global.pointerThree;
            Global.pointerThree = Global.pointerTwo;
            Global.pointerTwo = Global.pointerOne;
            Global.pointerOne = 3;
          }
        }
      }
    }
  },
  mounted(){
    this.timer = setInterval(this.continuouslyRun,200);
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
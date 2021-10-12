<script>
    export let data;
    export let mapper;
    let rowData = mapper(data);

    function up(check){     
      if(check != null && check != undefined)
      {
        var number = parseInt(check);
        return number > 0;
      }
      return false;
    }

    function down(check){
      if(check != null && check != undefined)
      {
        var number = parseInt(check);
        return number < 0;
      }
      return false;
    }

</script>

<div class="tr">
    <div class="td" style="">
      <span>{rowData[0]}</span>
    </div>
    <div class="td"
      style="justify-content: center;">
      <span>{rowData[1]}</span>
    </div>
    <div class="td"
      style="justify-content: flex-end;">
      <span>{rowData[2]} zł</span>
    </div>
    <div class="td"
      style="justify-content: center;">
      <span>{rowData[3]}</span>
    </div>
    <div class="td"
      style="justify-content: flex-end;">
      <span>{rowData[4]}</span>
    </div>   
    <div class="td"
      style="justify-content: flex-end;">
      <span>{rowData[5]} zł</span>
    </div>
    <div class="td"
      style="justify-content: flex-end;">
      <span>{rowData[6]} zł</span>
    </div>
    <div class="td"
      style="justify-content:  flex-end;">
      {#if up(rowData[7],0) }
        <i class="fas fa-arrow-up green"></i>
      {/if}
      {#if down(rowData[7])}
        <i class="fas fa-arrow-down red"></i>
      {/if}
      <span>{rowData[7]}</span> 
    </div>
    <div class="td"
      style="justify-content: flex-end;">
      <span>{rowData[8]} zł</span>
    </div>  
    <div class="td"
      style="justify-content: flex-end;">
      <span>{rowData[9]} zł</span>
    </div>   
  </div>   

<style>

.tr {
  width: 100%;
  display: flex;
  flex-flow: row nowrap;
  color: white;
}

.tr:nth-of-type(even) {
  background-color: rgb(29, 28, 28);
}

.tr:nth-of-type(odd) {
  background-color: rgb(51, 36, 36);
}

.td {
  display: flex;
  flex-flow: row nowrap;
  flex-grow: 1;
  flex-basis: 0;
  padding: 0.5em;
  word-break: break-word;
  overflow: hidden;
  text-overflow: ellipsis;
  min-width: 0px;
  white-space: nowrap;
  border-bottom: 1px solid #d0d0d0;
}

 .green {
  padding: 5px;
  color: green;
}

.red {
  padding: 5px;
  color: red;
}
</style>
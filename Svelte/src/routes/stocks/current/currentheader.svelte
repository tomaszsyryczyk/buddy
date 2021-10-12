<script>
    export let values;
</script>

<div class="tr th">
    <div class="td" style="">
      <span>{values[0]}</span>
    </div>
    <div class="td"
      style="justify-content: center;">
      <span>{values[1]}</span>
    </div>
    <div class="td"
      style="justify-content: center;">
      <span>{values[2]}</span>
    </div>
    <div class="td"
      style="justify-content: center;">
      <span>{values[3]}</span>
    </div>
    <div class="td"
      style="justify-content: center;">
      <span>{values[4]}</span>
    </div>    
    <div class="td"
        style="justify-content: center;">
        <span>{values[5]}</span>
    </div>
    <div class="td"
        style="justify-content: center;">
        <span>{values[6]}</span>
    </div>
    <div class="td"
        style="justify-content: center;">
        <span>{values[7]}</span>
    </div>
    <div class="td"
        style="justify-content: center;">
        <span>{values[8]}</span>
    </div>  
    <div class="td"
        style="justify-content: center;">
        <span>{values[9]}</span>
</div>       
  </div>   

<style>

.th {
  display: none;
  font-weight: 700;
  background-color: gray;  
  color: wheat; 
}

.th > .td {
  white-space: normal;
  justify-content: center;
}

.tr {
  width: 100%;
  display: flex;
  flex-flow: row nowrap;
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
</style>
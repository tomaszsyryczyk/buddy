<script>    
    import { onMount } from "svelte";
    import Header from "./currentheader.svelte";
    import Row from "./currentrow.svelte";
    import Stocks from "./../stocks.svelte";
    let currentStocks = [];

    let columnNames = ['Name', 'Ilość', 'zł/akcja', 'Marża', 'Data', 'na 0', 'Aktualna', '%', 'Sprzedaż', 'Zysk'];

    function mapper(data){
        return [data.name, data.count,data.price, data.fee, data.data, data.equal, data.current,data.delta, data.sell, data.income];
    };

    onMount(async () => {
    await fetch(`https://localhost:5001/api/stocks/current`)
      .then(r => r.json())
      .then(data => {
        currentStocks = data;
      });
  })
</script>

<Stocks>
    <div class="table">
        <Header values="{columnNames}"/>     
        {#each currentStocks as row}
            <Row data="{row}" mapper={mapper} />
        {/each}   
    </div>
</Stocks>


<style>
  .table {
  display: flex;
  flex-flow: column nowrap;
  font-size: .8rem;
  margin: 0.5rem;
  line-height: 1.5;
  border-bottom: 1px solid #d0d0d0;
  flex: 1 1 auto;
  }

</style>